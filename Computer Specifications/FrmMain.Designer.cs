namespace ComputerSpecifications
{
    partial class FrmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.labelProcName = new System.Windows.Forms.Label();
			this.textBoxProcessName = new System.Windows.Forms.TextBox();
			this.textBoxProcessCore = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxOSName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxRam = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxVideoName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxVideoRam = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ツールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBoxMonitor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelProcName
			// 
			this.labelProcName.AutoSize = true;
			this.labelProcName.Location = new System.Drawing.Point(12, 39);
			this.labelProcName.Name = "labelProcName";
			this.labelProcName.Size = new System.Drawing.Size(82, 12);
			this.labelProcName.TabIndex = 0;
			this.labelProcName.Text = "プロセッサー名 : ";
			// 
			// textBoxProcessName
			// 
			this.textBoxProcessName.Location = new System.Drawing.Point(144, 36);
			this.textBoxProcessName.Name = "textBoxProcessName";
			this.textBoxProcessName.ReadOnly = true;
			this.textBoxProcessName.Size = new System.Drawing.Size(296, 19);
			this.textBoxProcessName.TabIndex = 1;
			// 
			// textBoxProcessCore
			// 
			this.textBoxProcessCore.Location = new System.Drawing.Point(144, 61);
			this.textBoxProcessCore.Name = "textBoxProcessCore";
			this.textBoxProcessCore.ReadOnly = true;
			this.textBoxProcessCore.Size = new System.Drawing.Size(296, 19);
			this.textBoxProcessCore.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "プロセッサー数 : ";
			// 
			// textBoxOSName
			// 
			this.textBoxOSName.Location = new System.Drawing.Point(144, 86);
			this.textBoxOSName.Name = "textBoxOSName";
			this.textBoxOSName.ReadOnly = true;
			this.textBoxOSName.Size = new System.Drawing.Size(296, 19);
			this.textBoxOSName.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "OS : ";
			// 
			// textBoxRam
			// 
			this.textBoxRam.Location = new System.Drawing.Point(144, 111);
			this.textBoxRam.Name = "textBoxRam";
			this.textBoxRam.ReadOnly = true;
			this.textBoxRam.Size = new System.Drawing.Size(296, 19);
			this.textBoxRam.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 12);
			this.label4.TabIndex = 6;
			this.label4.Text = "メモリ : ";
			// 
			// textBoxVideoName
			// 
			this.textBoxVideoName.Location = new System.Drawing.Point(144, 136);
			this.textBoxVideoName.Name = "textBoxVideoName";
			this.textBoxVideoName.ReadOnly = true;
			this.textBoxVideoName.Size = new System.Drawing.Size(296, 19);
			this.textBoxVideoName.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 139);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 12);
			this.label5.TabIndex = 8;
			this.label5.Text = "グラフィックカード : ";
			// 
			// textBoxVideoRam
			// 
			this.textBoxVideoRam.Location = new System.Drawing.Point(144, 161);
			this.textBoxVideoRam.Name = "textBoxVideoRam";
			this.textBoxVideoRam.ReadOnly = true;
			this.textBoxVideoRam.Size = new System.Drawing.Size(296, 19);
			this.textBoxVideoRam.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(126, 12);
			this.label6.TabIndex = 10;
			this.label6.Text = "グラフィックカード (メモリ) : ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(314, 269);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 25);
			this.button1.TabIndex = 12;
			this.button1.Text = "取得";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ツールToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(452, 24);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ツールToolStripMenuItem
			// 
			this.ツールToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printScreenToolStripMenuItem});
			this.ツールToolStripMenuItem.Name = "ツールToolStripMenuItem";
			this.ツールToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.ツールToolStripMenuItem.Text = "ツール";
			// 
			// printScreenToolStripMenuItem
			// 
			this.printScreenToolStripMenuItem.Name = "printScreenToolStripMenuItem";
			this.printScreenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.printScreenToolStripMenuItem.Text = "スクリーンショット";
			this.printScreenToolStripMenuItem.Click += new System.EventHandler(this.printScreenToolStripMenuItem_Click);
			// 
			// textBoxMonitor
			// 
			this.textBoxMonitor.Location = new System.Drawing.Point(144, 211);
			this.textBoxMonitor.Name = "textBoxMonitor";
			this.textBoxMonitor.ReadOnly = true;
			this.textBoxMonitor.Size = new System.Drawing.Size(296, 19);
			this.textBoxMonitor.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 214);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 12);
			this.label1.TabIndex = 14;
			this.label1.Text = "モニター解析度 : ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(144, 186);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(296, 19);
			this.textBox1.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 189);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 12);
			this.label7.TabIndex = 16;
			this.label7.Text = "モニター名 (プライマー) : ";
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 306);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxMonitor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxVideoRam);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxVideoName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxRam);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxOSName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxProcessCore);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxProcessName);
			this.Controls.Add(this.labelProcName);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "簡易スペック表 (試作)";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProcName;
        private System.Windows.Forms.TextBox textBoxProcessName;
        private System.Windows.Forms.TextBox textBoxProcessCore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOSName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVideoName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxVideoRam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ツールToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printScreenToolStripMenuItem;
		private System.Windows.Forms.TextBox textBoxMonitor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
	}
}

