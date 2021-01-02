using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI;
using MetroSet_UI.Forms;
using GUT_E;

namespace GmodUploadTool
{
    public partial class SRE : Form
    {
        public SRE()
        {
            InitializeComponent();
        }

        private void SRE_Load(object sender, EventArgs e)
        {
            //ExtractResFile("GmodUploadTool.Resources.MetroSet UI.dll", Application.StartupPath + "/MetroSet UI.dll");
            ExtractResFile("GmodUploadTool.Resources.gmpublish.exe", Application.StartupPath + "/gmpublish.exe");
            ExtractResFile("GmodUploadTool.Resources.gmad.exe", Application.StartupPath + "/gmad.exe");
            ExtractResFile("GmodUploadTool.Resources.steam_api.dll", Application.StartupPath + "/steam_api.dll");
            
            

            //MessageBox.Show("初始化成功！！！");
            //MessageBox.Show("初始化成功！");
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        public static bool ExtractResFile(string resFileName, string outputFile)
        {
            BufferedStream inStream = null;
            FileStream outStream = null;
            try
            {
                Assembly asm = Assembly.GetExecutingAssembly(); //读取嵌入式资源
                inStream = new BufferedStream(asm.GetManifestResourceStream(resFileName));
                outStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write);

                byte[] buffer = new byte[65565];
                int length;

                while ((length = inStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outStream.Write(buffer, 0, length);
                }
                outStream.Flush();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (outStream != null) outStream.Close();
                if (inStream != null) inStream.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete("gmpublish.exe");
            File.Delete("gmad.exe");
            File.Delete("steam_api.dll");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUT_E.MainWindow mainWindow = new GUT_E.MainWindow();
            mainWindow.Show();
        }
    }
}
/**
            
**/