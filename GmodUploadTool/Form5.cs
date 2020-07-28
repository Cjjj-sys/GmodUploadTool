using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmodUploadTool
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

                private static void waitthread1()
        {
            wait openwait = new wait();
            openwait.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            textBox2.Text = fbd.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            textBox1.Text = fbd.SelectedPath;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";//要执行的程序名称 
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;//可能接受来自调用程序的输入信息 
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息 
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口 
            p.Start();//启动程序 

            //向CMD窗口发送输入信息： 
            ThreadStart waitsteart = new ThreadStart(waitthread1);
            var waitthread = new Thread(waitthread1);
            waitthread.IsBackground = true;
            waitthread.Start();
            if (textBox2.Text != "" && textBox1.Text != "" && textBox4.Text != "")
            {

                p.StandardInput.WriteLine("@echo off");
                p.StandardInput.WriteLine("gmad.exe create -folder " + textBox2.Text + " -out " + textBox1.Text + "/" + textBox4.Text + ".gma"); //10秒后重启（C#中可不好做哦） 
                                                                                                                       //获取CMD窗口的输出信息： 
                p.StandardInput.WriteLine("exit");
                string sOutput = p.StandardOutput.ReadToEnd();
                textBox3.Text = sOutput;
            }
            else
            {
                Form6 warn = new Form6();
                warn.ShowDialog();
            }
            waitthread.Abort();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";//要执行的程序名称 
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;//可能接受来自调用程序的输入信息 
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息 
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口 
            p.Start();//启动程序 

            //向CMD窗口发送输入信息： 
            ThreadStart waitsteart = new ThreadStart(waitthread1);
            var waitthread = new Thread(waitthread1);
            waitthread.IsBackground = true;
            waitthread.Start();

            p.StandardInput.WriteLine("@echo off");
            p.StandardInput.WriteLine("explorer " + '"' + textBox1.Text + '"');                                                                                                                                     //获取CMD窗口的输出信息： 
            p.StandardInput.WriteLine("exit");
            string sOutput = p.StandardOutput.ReadToEnd();
            waitthread.Abort();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                /* 生成文件名 */
                if (!Directory.Exists(textBox6.Text))
                {
                    /* 如果待保存的文件夹目录不存在就创建文件夹目录 */
                    Directory.CreateDirectory(textBox6.Text);
                }
                if (File.Exists(textBox6.Text + "/" + "addon.json"))
                {

                    //删除文件
                    File.Delete(textBox6.Text + "/" + "addon.json");
                }
                //{"title":"My Server Content","type":"ServerContent","tags":["roleplay","realism"],"ignore":["*.psd","*.vcproj","*.svn*"]}
                string filePath = textBox6.Text + "/" + "addon.json"; /* 拟保存的文件的全路径 */
                FileStream stream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(stream);
                sw.WriteLine("{" + '"' + "title" + '"' + ":" + '"' + textBox5.Text + '"' + "," + '"' + "type" + '"' + ":" + '"' + comboBox1.Text + '"' + "," + '"' + "tags" + '"' + ":" + "[" + textBox7.Text + "]" + "," + '"' + "ignore" + '"' + ":" + "[" + textBox8.Text + "]" + "}");
                sw.Close();
                Form8 form8 = new Form8();
                form8.ShowDialog();
            }
            else
            {
                Form7 form7 = new Form7();
                form7.ShowDialog();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            textBox6.Text = fbd.SelectedPath;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";//要执行的程序名称 
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;//可能接受来自调用程序的输入信息 
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息 
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口 
            p.Start();//启动程序 

            //向CMD窗口发送输入信息： 
            ThreadStart waitsteart = new ThreadStart(waitthread1);
            var waitthread = new Thread(waitthread1);
            waitthread.IsBackground = true;
            waitthread.Start();

            p.StandardInput.WriteLine("@echo off");
            p.StandardInput.WriteLine("explorer " + '"' + textBox6.Text + '"');                                                                                                                                     //获取CMD窗口的输出信息： 
            p.StandardInput.WriteLine("exit");
            string sOutput = p.StandardOutput.ReadToEnd();
            waitthread.Abort();

        }
    }
}
