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
            StreamReader SR = new StreamReader(m_ConfigFilePath, false);
            string CurFileContent = SR.ReadToEnd();
            SR.Close();
            string[] CurFileLines = Regex.Split(CurFileContent, "\r\n");
            if(CurFileLines.Length >= 3)
            {
                for(int Cnt = 0;Cnt <= 3;Cnt++)
                {
                    string[] CurElement = Regex.Split(CurFileLines[Cnt], "\t");
                    if(CurElement.Length == 4)
                    {
                        m_CurConfigHead.m_FileFlag = CurElement[0];
                        m_CurConfigHead.m_Version = CurElement[1];
                        m_CurConfigHead.m_EncryptKey = CurElement[2];
                        m_CurConfigHead.m_SaveDateTime = CurElement[3];
                    }

                    if (CurElement.Length == 19)
                    {
                        ServerTypecomboBox.SelectedIndex = Convert.ToInt32(CurElement[0]);
                        ServerIPtextBox.Text = CurElement[1];
                        SqlFilePathtextBox.Text = CurElement[2];
                        PortNumtextBox.Text = CurElement[6];
                        DICOMFilePathtextBox.Text = CurElement[7];
                        MaxPdutextBox.Text = CurElement[10];
                        DeviceNumtextBox.Text = CurElement[14];
                        MaxConnectNumcomboBox.SelectedIndex = Convert.ToInt32(CurElement[15]) - 1;
                        PicFilePathtextBox.Text = CurElement[17];
                    }
                }
            }
            else
            {
                ServerTypecomboBox.SelectedIndex = 0;
                ServerIPtextBox.Text = "127.0.0.1";
                SqlFilePathtextBox.Text = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                MaxConnectNumcomboBox.SelectedIndex = 0;
                PortNumtextBox.Text = "104";
                MaxPdutextBox.Text = "16384";
                //DICOMFilePathtextBox.Text = "d:\\DCMFiles";
                //PicFilePathtextBox.Text = "d:\\DCMFilesML";
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

            m_CurConfigHead.m_FileFlag = "XHDCMSET";
            m_CurConfigHead.m_Version = "1";
            m_CurConfigHead.m_EncryptKey = PubFunc.GetCurSeconds().ToString();
            m_CurConfigHead.m_SaveDateTime = DateTime.Now.ToLocalTime().ToString();
            string ConfigHeadStr = m_CurConfigHead.m_FileFlag + "\t" + m_CurConfigHead.m_Version + "\t" + m_CurConfigHead.m_EncryptKey + "\t" + m_CurConfigHead.m_SaveDateTime;

            m_CurConfig.m_DBServerType = ServerTypecomboBox.SelectedIndex;
            m_CurConfig.m_DBServerIp = ServerIPtextBox.Text.ToString();
            m_CurConfig.m_DBServerFileName = SqlFilePathtextBox.Text.ToString();
            //m_CurConfig.m_IbServerPath =;
            //m_CurConfig.m_DBBakeFileName =;
            m_CurConfig.m_DICOMAppEntity = DeviceNumtextBox.Text.ToString();
            m_CurConfig.m_DICOMServerPort = PortNumtextBox.Text.ToString();
            m_CurConfig.m_DICOMFileFolder = DICOMFilePathtextBox.Text.ToString();
            //m_CurConfig.m_IsAutoStartDICOMServer =;
            //m_CurConfig.m_IsAutoConnectDB =;
            m_CurConfig.m_MaxPduLength = MaxPdutextBox.Text.ToString();
            //m_CurConfig.m_IBServerStartDelay =;
            //m_CurConfig.m_IsSopInstanceUid =;
            if (checkBox2.CheckState == CheckState.Checked)
            {
                m_CurConfig.m_IsOverridePreDICOMFile = true;
            }
            else
            {
                m_CurConfig.m_IsOverridePreDICOMFile = false;
            }

            m_CurConfig.m_DeviceSN = DeviceNumtextBox.Text.ToString();
            m_CurConfig.m_MaxDBConnectTimes = MaxConnectNumcomboBox.SelectedIndex + 1;
            if (checkBox1.CheckState == CheckState.Checked)
            {
                m_CurConfig.m_IsUseSingleDICOMFolder = true;
            }
            else
            {
                m_CurConfig.m_IsUseSingleDICOMFolder = false;
            }
            m_CurConfig.m_DICOMmultilayerFileFolderName = PicFilePathtextBox.Text.ToString();
            //CurConfig.m_Reserved =;
            string ConfigFeildStr = m_CurConfig.m_DBServerType.ToString() + "\t" + m_CurConfig.m_DBServerIp + "\t" + m_CurConfig.m_DBServerFileName + "\t\t\t" + m_CurConfig.m_DICOMAppEntity + "\t" +
                                    m_CurConfig.m_DICOMServerPort + "\t" + m_CurConfig.m_DICOMFileFolder + "\t\t\t" + m_CurConfig.m_MaxPduLength + "\t\t\t" + m_CurConfig.m_IsOverridePreDICOMFile.ToString() + "\t" +
                                    m_CurConfig.m_DeviceSN + "\t" + m_CurConfig.m_MaxDBConnectTimes.ToString() + "\t" + m_CurConfig.m_IsUseSingleDICOMFolder.ToString() + "\t" + m_CurConfig.m_DICOMmultilayerFileFolderName + "\t";
            string ConfigTailStr = PubFunc.GetMD5WithString(ConfigFeildStr);
            StreamWriter Sw = new StreamWriter(m_ConfigFilePath,false);
            Sw.WriteLine(ConfigHeadStr);
            Sw.WriteLine(ConfigFeildStr);
            Sw.WriteLine(ConfigTailStr);
            Sw.Close();
            this.Close();
        }
    }
}
