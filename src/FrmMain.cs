/*
 * Copyright (c) 2018 2024 coreizer
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace SystemProfiler
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Management;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using ByteSizeLib;

    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.InitializeComponent();

        }

        private void printScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                var SFD = new SaveFileDialog {
                    FileName = DateTime.Now.ToString("yyyy-MM-dd"),
                    Filter = "*.png|*.png"
                };

                if (SFD.ShowDialog(this) == DialogResult.OK) {
                    using (var bmp = new Bitmap(this.Width, this.Height)) {
                        this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
                        bmp.Save(SFD.FileName);
                        bmp.Dispose();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try {
                Task.WhenAll(this.OperatingSystem(),
                this.Processor(),
                this.BaseBoard(),
                this.VideoController()
                );
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task Processor()
        {
            await Task.Run(() => {
                using (var mc = new ManagementClass("Win32_Processor")) {
                    foreach (var value in mc.GetInstances()) {
                        this.Invoke((Action)(() => {
                            this.labelProcessorValue.Text = $"{value.GetPropertyValue("Name")}";
                        }));
                    }
                }

                Trace.WriteLine("Processor: OK");
            });
        }

        private async Task VideoController()
        {
            await Task.Run(() => {
                using (var mc = new ManagementClass("Win32_VideoController")) {
                    foreach (var value in mc.GetInstances()) {
                        this.Invoke((Action)(() => {
                            this.labelGraphicValue.Text = $"{value.GetPropertyValue("Name")}";
                        }));
                    }
                }

                Trace.WriteLine("VideoController: OK");
            });
        }

        private async Task BaseBoard()
        {
            await Task.Run(() => {
                using (var mc = new ManagementClass("Win32_BaseBoard")) {
                    foreach (var value in mc.GetInstances()) {
                        this.Invoke((Action)(() => {
                            this.label5.Text = $"{value.GetPropertyValue("Product")} ({value.GetPropertyValue("Manufacturer")})";
                        }));
                    }
                }

                Trace.WriteLine("BaseBoard: OK");
            });
        }

        private async Task OperatingSystem()
        {
            await Task.Run(() => {
                using (var mc = new ManagementClass("Win32_OperatingSystem")) {
                    foreach (var value in mc.GetInstances()) {
                        this.Invoke((Action)(() => {
                            this.labelOSNameValue.Text = $"{value.GetPropertyValue("Caption")}, {value.GetPropertyValue("Version")} ビルド {value.GetPropertyValue("BuildNumber")}";
                            this.labelMemoryValue.Text = $"{ByteSize.FromKiloBytes(double.Parse(value.GetPropertyValue("TotalVirtualMemorySize").ToString()))}";
                        }));
                    }
                }

                Trace.WriteLine("OperatingSystem: OK");
            });
        }
    }
}
