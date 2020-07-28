using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
    }
}
