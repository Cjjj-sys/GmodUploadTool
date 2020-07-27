using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GmodUploadTool
{
    public partial class Form1 : Form
    {

        public Form1()
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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Gma文件|*.gma";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    this.textBox1.Text = openFileDialog1.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            if (textBox1.Text != "" && textBox3.Text != "")
            {

                p.StandardInput.WriteLine("@echo off");
                p.StandardInput.WriteLine("gmpublish.exe create -addon " + textBox1.Text + " -icon " + textBox3.Text); //10秒后重启（C#中可不好做哦） 
                                                                                                                       //获取CMD窗口的输出信息： 
                p.StandardInput.WriteLine("exit");
                string sOutput = p.StandardOutput.ReadToEnd();
                textBox2.Text = sOutput;
            }
            else
            {
                Form3 warn = new Form3();
                warn.ShowDialog();
            }
            waitthread.Abort();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "jpg文件|*.jpg";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog2.FileName != "")
                {
                    this.textBox3.Text = openFileDialog2.FileName;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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
            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                p.StandardInput.WriteLine("@echo off");
                p.StandardInput.WriteLine("gmpublish.exe update -addon " + textBox1.Text + " -icon " + textBox3.Text + " -id " + textBox4.Text); //10秒后重启（C#中可不好做哦） 
                                                                                                                                                 //获取CMD窗口的输出信息： 
                p.StandardInput.WriteLine("exit");
                string sOutput = p.StandardOutput.ReadToEnd();
                textBox2.Text = sOutput;
            }
            else
            {
                Form4 warn = new Form4();
                warn.ShowDialog();
            }

            
            waitthread.Abort();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            about.ShowDialog();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

    }
}
