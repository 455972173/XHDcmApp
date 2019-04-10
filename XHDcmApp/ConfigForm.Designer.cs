namespace XHDcmApp
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServerIPtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerTypecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DICOMFilePathtextBox = new System.Windows.Forms.TextBox();
            this.DICOMFilePathbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MaxConnectNumcomboBox = new System.Windows.Forms.ComboBox();
            this.DeviceNumtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.PicFilePathbutton = new System.Windows.Forms.Button();
            this.PicFilePathtextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MaxPdutextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PortNumtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AETitletextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SqlFilePathbutton = new System.Windows.Forms.Button();
            this.SqlFilePathtextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Confirmbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ServerIPtextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ServerTypecomboBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库服务器";
            // 
            // ServerIPtextBox
            // 
            this.ServerIPtextBox.Location = new System.Drawing.Point(252, 13);
            this.ServerIPtextBox.Name = "ServerIPtextBox";
            this.ServerIPtextBox.Size = new System.Drawing.Size(103, 21);
            this.ServerIPtextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "类型：";
            // 
            // ServerTypecomboBox
            // 
            this.ServerTypecomboBox.FormattingEnabled = true;
            this.ServerTypecomboBox.Items.AddRange(new object[] {
            "本地",
            "远程"});
            this.ServerTypecomboBox.Location = new System.Drawing.Point(53, 14);
            this.ServerTypecomboBox.Name = "ServerTypecomboBox";
            this.ServerTypecomboBox.Size = new System.Drawing.Size(120, 20);
            this.ServerTypecomboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "DICOM文件的保存位置：";
            // 
            // DICOMFilePathtextBox
            // 
            this.DICOMFilePathtextBox.Location = new System.Drawing.Point(9, 130);
            this.DICOMFilePathtextBox.Name = "DICOMFilePathtextBox";
            this.DICOMFilePathtextBox.Size = new System.Drawing.Size(282, 21);
            this.DICOMFilePathtextBox.TabIndex = 1;
            // 
            // DICOMFilePathbutton
            // 
            this.DICOMFilePathbutton.Location = new System.Drawing.Point(309, 128);
            this.DICOMFilePathbutton.Name = "DICOMFilePathbutton";
            this.DICOMFilePathbutton.Size = new System.Drawing.Size(32, 23);
            this.DICOMFilePathbutton.TabIndex = 2;
            this.DICOMFilePathbutton.Text = "...";
            this.DICOMFilePathbutton.UseVisualStyleBackColor = true;
            this.DICOMFilePathbutton.Click += new System.EventHandler(this.DICOMFilePathbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "最大连接次数：";
            // 
            // MaxConnectNumcomboBox
            // 
            this.MaxConnectNumcomboBox.FormattingEnabled = true;
            this.MaxConnectNumcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.MaxConnectNumcomboBox.Location = new System.Drawing.Point(14, 117);
            this.MaxConnectNumcomboBox.Name = "MaxConnectNumcomboBox";
            this.MaxConnectNumcomboBox.Size = new System.Drawing.Size(122, 20);
            this.MaxConnectNumcomboBox.TabIndex = 4;
            // 
            // DeviceNumtextBox
            // 
            this.DeviceNumtextBox.Location = new System.Drawing.Point(153, 151);
            this.DeviceNumtextBox.Name = "DeviceNumtextBox";
            this.DeviceNumtextBox.Size = new System.Drawing.Size(103, 21);
            this.DeviceNumtextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "设备编号(.opt文件名)：";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(380, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 434);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.PicFilePathbutton);
            this.groupBox2.Controls.Add(this.PicFilePathtextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.MaxPdutextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.PortNumtextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.AETitletextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DICOMFilePathbutton);
            this.groupBox2.Controls.Add(this.DICOMFilePathtextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 255);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DICOM服务器";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 224);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(318, 16);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "患者文件夹中DICOM文件存在时用后收到的文件将其覆盖";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // PicFilePathbutton
            // 
            this.PicFilePathbutton.Location = new System.Drawing.Point(309, 195);
            this.PicFilePathbutton.Name = "PicFilePathbutton";
            this.PicFilePathbutton.Size = new System.Drawing.Size(32, 23);
            this.PicFilePathbutton.TabIndex = 16;
            this.PicFilePathbutton.Text = "...";
            this.PicFilePathbutton.UseVisualStyleBackColor = true;
            this.PicFilePathbutton.Click += new System.EventHandler(this.PicFilePathbutton_Click);
            // 
            // PicFilePathtextBox
            // 
            this.PicFilePathtextBox.Location = new System.Drawing.Point(9, 197);
            this.PicFilePathtextBox.Name = "PicFilePathtextBox";
            this.PicFilePathtextBox.Size = new System.Drawing.Size(282, 21);
            this.PicFilePathtextBox.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "多层面图像文件的保存位置：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(264, 16);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "用单独的文件夹保存多层面图像文件（CT等）";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MaxPdutextBox
            // 
            this.MaxPdutextBox.Location = new System.Drawing.Point(66, 86);
            this.MaxPdutextBox.Name = "MaxPdutextBox";
            this.MaxPdutextBox.Size = new System.Drawing.Size(103, 21);
            this.MaxPdutextBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "最大PDU：";
            // 
            // PortNumtextBox
            // 
            this.PortNumtextBox.Location = new System.Drawing.Point(66, 50);
            this.PortNumtextBox.Name = "PortNumtextBox";
            this.PortNumtextBox.Size = new System.Drawing.Size(103, 21);
            this.PortNumtextBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "端口号：";
            // 
            // AETitletextBox
            // 
            this.AETitletextBox.Location = new System.Drawing.Point(66, 14);
            this.AETitletextBox.Name = "AETitletextBox";
            this.AETitletextBox.ReadOnly = true;
            this.AETitletextBox.Size = new System.Drawing.Size(187, 21);
            this.AETitletextBox.TabIndex = 8;
            this.AETitletextBox.Text = "XHDICOM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "AE标题：";
            // 
            // SqlFilePathbutton
            // 
            this.SqlFilePathbutton.Location = new System.Drawing.Point(319, 76);
            this.SqlFilePathbutton.Name = "SqlFilePathbutton";
            this.SqlFilePathbutton.Size = new System.Drawing.Size(32, 23);
            this.SqlFilePathbutton.TabIndex = 15;
            this.SqlFilePathbutton.Text = "...";
            this.SqlFilePathbutton.UseVisualStyleBackColor = true;
            this.SqlFilePathbutton.Click += new System.EventHandler(this.SqlFilePathbutton_Click);
            // 
            // SqlFilePathtextBox
            // 
            this.SqlFilePathtextBox.Location = new System.Drawing.Point(16, 78);
            this.SqlFilePathtextBox.Name = "SqlFilePathtextBox";
            this.SqlFilePathtextBox.Size = new System.Drawing.Size(285, 21);
            this.SqlFilePathtextBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "数据库文件路径：";
            // 
            // Confirmbutton
            // 
            this.Confirmbutton.Location = new System.Drawing.Point(394, 27);
            this.Confirmbutton.Name = "Confirmbutton";
            this.Confirmbutton.Size = new System.Drawing.Size(75, 23);
            this.Confirmbutton.TabIndex = 16;
            this.Confirmbutton.Text = "确定";
            this.Confirmbutton.UseVisualStyleBackColor = true;
            this.Confirmbutton.Click += new System.EventHandler(this.Confirmbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(394, 58);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 17;
            this.Cancelbutton.Text = "取消";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 446);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Confirmbutton);
            this.Controls.Add(this.SqlFilePathbutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SqlFilePathtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DeviceNumtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MaxConnectNumcomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统设置";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ServerIPtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ServerTypecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DICOMFilePathtextBox;
        private System.Windows.Forms.Button DICOMFilePathbutton;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox MaxConnectNumcomboBox;
        private System.Windows.Forms.TextBox DeviceNumtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button PicFilePathbutton;
        private System.Windows.Forms.TextBox PicFilePathtextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox MaxPdutextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PortNumtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AETitletextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SqlFilePathbutton;
        private System.Windows.Forms.TextBox SqlFilePathtextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Confirmbutton;
        private System.Windows.Forms.Button Cancelbutton;
    }
}