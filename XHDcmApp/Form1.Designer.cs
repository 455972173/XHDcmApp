namespace XHDcmApp
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LoglistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SetUpBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.LogFileNameLabel = new System.Windows.Forms.Label();
            this.LogOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // LoglistBox
            // 
            this.LoglistBox.FormattingEnabled = true;
            this.LoglistBox.ItemHeight = 12;
            this.LoglistBox.Location = new System.Drawing.Point(12, 12);
            this.LoglistBox.Name = "LoglistBox";
            this.LoglistBox.Size = new System.Drawing.Size(323, 436);
            this.LoglistBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "日志文件：";
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(360, 29);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(75, 23);
            this.ReadBtn.TabIndex = 2;
            this.ReadBtn.Text = "读取";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(360, 71);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // SetUpBtn
            // 
            this.SetUpBtn.Location = new System.Drawing.Point(360, 111);
            this.SetUpBtn.Name = "SetUpBtn";
            this.SetUpBtn.Size = new System.Drawing.Size(75, 23);
            this.SetUpBtn.TabIndex = 4;
            this.SetUpBtn.Text = "设置";
            this.SetUpBtn.UseVisualStyleBackColor = true;
            this.SetUpBtn.Click += new System.EventHandler(this.SetUpBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(360, 154);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "关闭";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LogFileNameLabel
            // 
            this.LogFileNameLabel.AutoSize = true;
            this.LogFileNameLabel.Location = new System.Drawing.Point(83, 451);
            this.LogFileNameLabel.Name = "LogFileNameLabel";
            this.LogFileNameLabel.Size = new System.Drawing.Size(0, 12);
            this.LogFileNameLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 472);
            this.Controls.Add(this.LogFileNameLabel);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SetUpBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoglistBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DICOM服务器应用程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LoglistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button SetUpBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label LogFileNameLabel;
        private System.Windows.Forms.OpenFileDialog LogOpenFileDialog;
    }
}

