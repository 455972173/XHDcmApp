using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XHDcmApp
{
    public partial class ConfigForm : Form
    {
        string m_ConfigFilePath;
        IniFile XHDcmGateSetFile;
        ConfigHead m_CurConfigHead;
        ConfigField m_CurConfig;
        /// <summary>
        /// 配置文件头
        /// </summary>
        struct ConfigHead
        {
            public string m_FileFlag;//XHDCMSET
            public string m_Version;//版本号
            public string m_EncryptKey;//key是当前的绝对秒数
            public string m_SaveDateTime;//当前日期
        }
        /// <summary>
        /// 配置文件字段内容
        /// </summary>
        struct ConfigField
        {
            //数据库参数
            public int    m_DBServerType;//数据库服务器类型0:本地 1:远程
            public string m_DBServerIp;//数据库服务器IP
            public string m_DBServerFileName;//数据库文件名
            public string m_IbServerPath;//ibserver.exe完全路径名
            public string m_DBBakeFileName;//数据库备份文件名
            //DICOM服务器参数
            public string m_DICOMAppEntity;//DICOM服务器AE
            public string m_DICOMServerPort;//DICOM服务器端口号
            public string m_DICOMFileFolder;//保存DICOM文件的文件夹名
            public bool   m_IsAutoStartDICOMServer;//是否自动启动DICOM服务器
            public bool   m_IsAutoConnectDB;//是否自动连接数据库
            public string m_MaxPduLength;//Pdu最大长度
            //其他
            public int    m_IBServerStartDelay;//ibserver.exe启动需要的时间（不用）
            public bool   m_IsSopInstanceUid;//用 SOP Instance UID 命名患者文件夹中的DICOM文件（不用）
            public bool   m_IsOverridePreDICOMFile;//是否在患者文件夹中 SOP Instance UID 对应的DICOM文件存在时，用后收到的文件将其覆盖
            public string m_DeviceSN;//设备出厂编号
            public int    m_MaxDBConnectTimes;//数据库连接最多允许重试的次数
            public bool   m_IsUseSingleDICOMFolder;//是否用单独的文件夹保存多层面图像文件（CT等）
            public string m_DICOMmultilayerFileFolderName;//保存多层面图像文件的文件夹名
            public string m_Reserved;//保留

        }
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            m_CurConfigHead = new ConfigHead();
            m_CurConfig = new ConfigField();

            m_ConfigFilePath = Form1.m_XHDICOMRegistData + "\\XHDcmGate.set";
            XHDcmGateSetFile = new IniFile(m_ConfigFilePath);

            m_CurConfigHead.m_FileFlag = XHDcmGateSetFile.ReadString("ConfigHead", "FileFlag", "");
            m_CurConfigHead.m_Version = XHDcmGateSetFile.ReadString("ConfigHead", "Version", "");
            m_CurConfigHead.m_EncryptKey = XHDcmGateSetFile.ReadString("ConfigHead", "EncryptKey", "");
            m_CurConfigHead.m_SaveDateTime = XHDcmGateSetFile.ReadString("ConfigHead", "SaveDateTime", "");

            ServerTypecomboBox.SelectedIndex = Convert.ToInt32(XHDcmGateSetFile.ReadString("ConfigInfo", "ServerType", "0"));
            ServerIPtextBox.Text = XHDcmGateSetFile.ReadString("ConfigInfo", "ServerIp", "127.0.0.1");
            SqlFilePathtextBox.Text = XHDcmGateSetFile.ReadString("ConfigInfo", "SqlFilePath", System.AppDomain.CurrentDomain.BaseDirectory.ToString());
            PortNumtextBox.Text = XHDcmGateSetFile.ReadString("ConfigInfo", "ServerPort", "104");
            DICOMFilePathtextBox.Text = XHDcmGateSetFile.ReadString("ConfigInfo", "DICOMFilePath", "");
            MaxPdutextBox.Text = XHDcmGateSetFile.ReadString("ConfigInfo", "MaxPdu", "16384");
            DeviceNumtextBox.Text = XHDcmGateSetFile.ReadString("ConfigInfo", "DeviceSN", "");
            MaxConnectNumcomboBox.SelectedIndex = Convert.ToInt32(XHDcmGateSetFile.ReadString("ConfigInfo", "MaxDBConnectNum", "1")) - 1;
            PicFilePathtextBox.Text = XHDcmGateSetFile.ReadString("ConfigInfo", "PicFilePath", "");
            if (String.Compare(XHDcmGateSetFile.ReadString("ConfigInfo", "IsUseSingleDICOMFolder", ""), "True", true) == 0)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            if (String.Compare(XHDcmGateSetFile.ReadString("ConfigInfo", "IsOverridePreDICOMFile", ""), "true", true) == 0)
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
        }

        private void SqlFilePathbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog SqlFile = new OpenFileDialog();
            SqlFile.InitialDirectory = SqlFilePathtextBox.Text;
            SqlFile.Filter = "数据库文件|*.ib|所有文件|*.*";
            SqlFile.ShowDialog();
            if (SqlFile.SafeFileName == "")
            {
                return;
            }
            SqlFilePathtextBox.Text = System.IO.Path.GetFullPath(SqlFile.SafeFileName);
        }

        private void DICOMFilePathbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DICOMFilePath = new FolderBrowserDialog();
            DICOMFilePath.ShowDialog();
            if (DICOMFilePath.SelectedPath == "")
            {
                return;
            }
            DICOMFilePathtextBox.Text = DICOMFilePath.SelectedPath;
        }

        private void PicFilePathbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog PicFilePath = new FolderBrowserDialog();
            PicFilePath.ShowDialog();
            if(PicFilePath.SelectedPath == "")
            {
                return;
            }
            PicFilePathtextBox.Text = PicFilePath.SelectedPath;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            XHDcmGateSetFile.WriteString("ConfigHead", "FileFlag", "XHDCMSET");
            XHDcmGateSetFile.WriteString("ConfigHead", "Version", "1");
            XHDcmGateSetFile.WriteString("ConfigHead", "EncryptKey", PubFunc.GetCurSeconds().ToString());
            XHDcmGateSetFile.WriteString("ConfigHead", "SaveDateTime", DateTime.Now.ToLocalTime().ToString());


            XHDcmGateSetFile.WriteInt("ConfigInfo", "ServerType", ServerTypecomboBox.SelectedIndex);
            XHDcmGateSetFile.WriteString("ConfigInfo", "ServerIp", ServerIPtextBox.Text.ToString());
            XHDcmGateSetFile.WriteString("ConfigInfo", "SqlFilePath", SqlFilePathtextBox.Text.ToString());
            XHDcmGateSetFile.WriteString("ConfigInfo", "DICOMAppEntity", DeviceNumtextBox.Text.ToString());
            XHDcmGateSetFile.WriteString("ConfigInfo", "ServerPort", PortNumtextBox.Text.ToString());
            XHDcmGateSetFile.WriteString("ConfigInfo", "DICOMFilePath", DICOMFilePathtextBox.Text.ToString());
            XHDcmGateSetFile.WriteString("ConfigInfo", "MaxPdu", MaxPdutextBox.Text.ToString());
            if (checkBox2.CheckState == CheckState.Checked)
            {
                XHDcmGateSetFile.WriteString("ConfigInfo", "IsOverridePreDICOMFile", "True");
            }
            else
            {
                XHDcmGateSetFile.WriteString("ConfigInfo", "IsOverridePreDICOMFile", "False");
            }
            XHDcmGateSetFile.WriteString("ConfigInfo", "DeviceSN", DeviceNumtextBox.Text.ToString());
            XHDcmGateSetFile.WriteInt("ConfigInfo", "MaxDBConnectNum", MaxConnectNumcomboBox.SelectedIndex + 1);
            if (checkBox1.CheckState == CheckState.Checked)
            {
                XHDcmGateSetFile.WriteString("ConfigInfo", "IsUseSingleDICOMFolder", "True");
            }
            else
            {
                XHDcmGateSetFile.WriteString("ConfigInfo", "IsUseSingleDICOMFolder", "False");
            }
            XHDcmGateSetFile.WriteString("ConfigInfo", "PicFilePath", PicFilePathtextBox.Text.ToString());

            XHDcmGateSetFile.WriteString("FileMd5", "Value", "");
            this.Close();
        }
    }
}
