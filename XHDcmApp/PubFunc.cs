using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 公共函数
/// </summary>
namespace XHDcmApp
{
    class PubFunc
    {
        /// <summary>
        /// 获取字符串MD5
        /// </summary>
        /// <param name="SrcStr">需要加密的字符串</param>
        /// <returns></returns>
        static public string GetMD5WithString(string SrcStr)
        {
            string DstStr = "";
            byte[] data = Encoding.GetEncoding("utf-8").GetBytes(SrcStr);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(data);
            for (int i = 0; i < bytes.Length; i++)
            {
                DstStr += bytes[i].ToString("x2");
            }
            return DstStr;
        }
        /// <summary>
        /// 获取当前绝对秒数
        /// </summary>
        /// <returns></returns>
        static public int GetCurSeconds()
        {
            TimeSpan t = (DateTime.UtcNow - new DateTime(1970, 1, 1));
            int timestamp = (int)t.TotalSeconds;
            return timestamp;
        }
    }
}
