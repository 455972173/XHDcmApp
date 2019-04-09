using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XHDcmApp
{
    public partial class Form1 : Form
    {
        string m_LogFilePath;//从注册表中读取的日志文件目录
        string m_SelectedLogFile;//选中的日志文件
        ConfigForm m_CfgForm;
        static public string m_XHDICOMRegistData;

        public Form1()
        {
            InitializeComponent();
        }
        private string GetRegistData(string name)
        {
            RegistryKey LocalMachine = Registry.LocalMachine;
            RegistryKey SOFTWARE = LocalMachine.OpenSubKey("SOFTWARE", true);
            RegistryKey SHINVA = SOFTWARE.OpenSubKey("SHINVA", true);
            RegistryKey XHDICOM = SHINVA.OpenSubKey("XHDICOM", true);
            //XHDICOM.SetValue("DcmFolderName", "E:\\ProjectTestFile");
            string RegistData = XHDICOM.GetValue(name).ToString();
            return RegistData;
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog LogFile = new OpenFileDialog();
            LogFile.InitialDirectory = m_LogFilePath;
            LogFile.ShowDialog();
            this.LogFileNameLabel.Text = LogFile.SafeFileName;

            m_SelectedLogFile = m_LogFilePath + "\\" + LogFile.SafeFileName;
            if(LogFile.SafeFileName == "")
            {
                return;
            }
            LogFileNameLabel.Text = m_SelectedLogFile;
            LoglistBox.Items.Clear();
            StreamReader File = new StreamReader(m_SelectedLogFile, Encoding.Default);
            string s = "";
            while (s != null)
            {
                s = File.ReadLine();
                if (!string.IsNullOrEmpty(s))
                {
                    LoglistBox.Items.Add(s);
                }
            }
            File.Close();
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            if(m_SelectedLogFile == null)
            {
                return;
            }
            LogFileNameLabel.Text = m_SelectedLogFile;
            LoglistBox.Items.Clear();
            StreamReader File = new StreamReader(m_SelectedLogFile, Encoding.Default);
            string s = "";
            while (s != null)
            {
                s = File.ReadLine();
                if (!string.IsNullOrEmpty(s))
                {
                    LoglistBox.Items.Add(s);
                }
            }
            File.Close();
        }

        private void SetUpBtn_Click(object sender, EventArgs e)
        {
            m_CfgForm = new ConfigForm();
            m_CfgForm.ShowDialog();
            m_CfgForm = null;
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_XHDICOMRegistData = GetRegistData("DcmFolderName");
            m_LogFilePath = m_XHDICOMRegistData + "\\LogFiles";
            m_CfgForm = null;
        }
    }
}
