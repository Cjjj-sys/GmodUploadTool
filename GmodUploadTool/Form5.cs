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
using MetroSet_UI;
using MetroSet_UI.Forms;

namespace GmodUploadTool
{
    public partial class Form5 : MetroSetForm
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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

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

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            textBox1.Text = fbd.SelectedPath;
        }

        private void metroSetScrollBar1_Scroll(object sender)
        {

        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            textBox6.Text = fbd.SelectedPath;
        }

        private void metroSetButton4_Click(object sender, EventArgs e)
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
                MessageBox.Show("生成 成功 ！！！", "！！！信息！！！", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("输出目录不能为空！！！", "！！！错误！！！", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void metroSetButton5_Click(object sender, EventArgs e)
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

        private void metroSetButton7_Click(object sender, EventArgs e)
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

        private void metroSetLabel8_Click(object sender, EventArgs e)
        {

        }

        private async void metroSetButton8_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            ThreadStart waitsteart = new ThreadStart(waitthread1);
            var waitthread = new Thread(waitthread1);
            waitthread.IsBackground = true;
            waitthread.Start();
            if (textBox2.Text != "" && textBox1.Text != "" && textBox4.Text != "")
            {
                await Task.Factory.StartNew(() =>
                {
                    startProgram("gmad.exe", "create -folder " + textBox2.Text + " -out " + textBox1.Text + "/" + textBox4.Text + ".gma");
                    TxtBoxOutput("执行完毕");
                });
                textBox3.Text = textBox3.Text.Replace("Microsoft Windows [版本 6.3.9600]", "GMA文件制作器[Cmd输出]：");
                textBox3.Text = textBox3.Text.Replace("(c) 2013 Microsoft Corporation。保留所有权利。", "程序根目录：");
                textBox3.Text = textBox3.Text.Replace(">@echo off", "");
                textBox3.Text = textBox3.Text.Replace("gmad.exe", "Cmd命令：");
                textBox3.Text = textBox3.Text.Replace("Garry's Mod Addon Creator 1.1", "GMA文件制作器1.1[Garry's Mod Addon Creator 1.1]");
                textBox3.Text = textBox3.Text.Replace("Looking in folder", "正在进入目录：");
                textBox3.Text = textBox3.Text.Replace("error: Couldn't find file", ">>>错误!不能找到这个文件");
                textBox3.Text = textBox3.Text.Replace("Not allowed by whitelist", ">不被允许的文件<");
                textBox3.Text = textBox3.Text.Replace("Filename contains captial letters", ">文件名包含大写字母<");
                textBox3.Text = textBox3.Text.Replace("File list verification failed", ">>>错误!文件列表验证失败");
                textBox3.Text = textBox3.Text.Replace("Writing file list...", "写入文件列表中...");
                textBox3.Text = textBox3.Text.Replace("Writing files...", "写入文件中...");
                textBox3.Text = textBox3.Text.Replace("Writing the .gma...", "写入GMA文件中...");
                textBox3.Text = textBox3.Text.Replace("Successfully saved to", ">>>制作成功！文件被保存在：");
                textBox3.Text = textBox3.Text.Replace("error: Couldn't parse json", ">>>错误!无法解析json文件！请检查文件内容，查看是否有语法错误。");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                textBox3.Text = textBox3.Text.Replace("exit", "程序退出");
            }
            else
            {
                MessageBox.Show("插件目录，输出目录 或 GMA文件名 不能为空！！！", "！！！错误！！！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            waitthread.Abort();
            /**

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
                textBox3.Text = textBox3.Text.Replace("Microsoft Windows [版本 6.3.9600]", "GMA文件制作器[Cmd输出]：");
                textBox3.Text = textBox3.Text.Replace("(c) 2013 Microsoft Corporation。保留所有权利。", "程序根目录：");
                textBox3.Text = textBox3.Text.Replace(">@echo off", "");
                textBox3.Text = textBox3.Text.Replace("gmad.exe", "Cmd命令：");
                textBox3.Text = textBox3.Text.Replace("Garry's Mod Addon Creator 1.1", "GMA文件制作器1.1[Garry's Mod Addon Creator 1.1]");
                textBox3.Text = textBox3.Text.Replace("Looking in folder", "正在进入目录：");
                textBox3.Text = textBox3.Text.Replace("error: Couldn't find file", ">>>错误!不能找到这个文件");
                textBox3.Text = textBox3.Text.Replace("Not allowed by whitelist", ">不被允许的文件<");
                textBox3.Text = textBox3.Text.Replace("Filename contains captial letters", ">文件名包含大写字母<");
                textBox3.Text = textBox3.Text.Replace("File list verification failed", ">>>错误!文件列表验证失败");
                textBox3.Text = textBox3.Text.Replace("Writing file list...", "写入文件列表中...");
                textBox3.Text = textBox3.Text.Replace("Writing files...", "写入文件中...");
                textBox3.Text = textBox3.Text.Replace("Writing the .gma...", "写入GMA文件中...");
                textBox3.Text = textBox3.Text.Replace("Successfully saved to", ">>>制作成功！文件被保存在：");
                textBox3.Text = textBox3.Text.Replace("error: Couldn't parse json", ">>>错误!无法解析json文件！请检查文件内容，查看是否有语法错误。");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                //textBox3.Text = textBox3.Text.Replace("","");
                textBox3.Text = textBox3.Text.Replace("exit", "程序退出");
            }
            else
            {
                MessageBox.Show("插件目录，输出目录 或 GMA文件名 不能为空！！！", "！！！错误！！！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            waitthread.Abort();
            **/

        }
        private void startProgram(string filename, string commandLine)
        {
            var fileName = filename;
            var arguments = commandLine;

            var info = new ProcessStartInfo();
            info.FileName = fileName;
            info.Arguments = arguments;

            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.CreateNoWindow = true;

            using (var p = new Process())
            {
                p.StartInfo = info;
                p.EnableRaisingEvents = true;

                p.OutputDataReceived += (s, o) =>
                {
                    TxtBoxOutput(o.Data);
                };
                p.ErrorDataReceived += (s, o) =>
                {
                    TxtBoxOutput(o.Data);
                };
                p.Start();
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                p.WaitForExit();
            }
        }

        public void TxtBoxOutput(string text)
        {
            BeginInvoke(new Action(delegate ()
            {
                textBox3.AppendText(text + Environment.NewLine);
                //textBox3.ScrollToCaret();
            }));
        }
    }
}
