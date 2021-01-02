using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GmodUploadTool
{
    class IniFileGMA
    {
        /* 
        * 声明API函数 
        */
        public string iniPath;
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        /// <summary> 
        /// 构造函数 
        /// </summary> 
        /// <param name="iniPath">ini文件路径，默认为当前路径下default.ini</param> 
        public IniFileGMA(string iniPath = "./savegma.ini")
        {
            this.iniPath = iniPath;
        }

        /// <summary> 
        /// 写入ini文件 
        /// </summary> 
        /// <param name="Section">Section</param> 
        /// <param name="Key">键</param> 
        /// <param name="Value">值</param> 
        public void writeIni(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.iniPath);
        }

        /// <summary> 
        /// 写入ini文件，不管section，默认放在default里 
        /// </summary> 
        /// <param name="Key">键</param> 
        /// <param name="Value">值</param> 
        public void writeIni(string Key, string Value)
        {
            WritePrivateProfileString("default", Key, Value, this.iniPath);
        }

        /// <summary> 
        /// 读取ini文件 
        /// </summary> 
        /// <param name="Section">Section</param> 
        /// <param name="Key">键</param> 
        /// <returns>返回的值</returns> 
        public string readIni(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(256);
            int i = GetPrivateProfileString(Section, Key, "", temp, 256, this.iniPath);
            return temp.ToString();
        }

        /// <summary> 
        /// 读取section，不管section，默认从default里读取 
        /// </summary> 
        /// <param name="Key">键</param> 
        /// <returns>返回值</returns> 
        public string readIni(string Key)
        {
            return readIni("default", Key);
        }

        /// <summary> 
        /// 查询ini文件是否存在 
        /// </summary> 
        /// <returns>是否存在</returns> 
        public bool existINIFile()
        {
            return File.Exists(iniPath);
        }
        public void EraseSection(string Section)
        {
            WritePrivateProfileString(Section, null, null, iniPath);
        }


    }

}
