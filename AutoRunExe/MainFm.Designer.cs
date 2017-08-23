namespace AutoRunExe
{
    partial class MainFm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.bt_open = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.NumericUpDown();
            this.bt_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "扫描路径：";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(18, 43);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(487, 21);
            this.txtDir.TabIndex = 1;
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(511, 42);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(81, 23);
            this.bt_open.TabIndex = 2;
            this.bt_open.Text = "浏览...";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(399, 101);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(81, 23);
            this.bt_ok.TabIndex = 3;
            this.bt_ok.Text = "开始扫描";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "扫描间隔（单位:s )(范围;5~12000）：";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(18, 103);
            this.txtNum.Maximum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.txtNum.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(213, 21);
            this.txtNum.TabIndex = 6;
            this.txtNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(509, 101);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(81, 23);
            this.bt_cancel.TabIndex = 3;
            this.bt_cancel.Text = "停止扫描";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // MainFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 151);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFm";
            this.Text = "AutoRunExe";
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtNum;
        private System.Windows.Forms.Button bt_cancel;
    }
}

