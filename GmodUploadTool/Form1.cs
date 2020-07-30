using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

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
                textBox2.Text = textBox2.Text.Replace("Microsoft Windows [版本 6.3.9600]", "Gmod创意工坊上传器[Cmd输出]：");
                textBox2.Text = textBox2.Text.Replace("(c) 2013 Microsoft Corporation。保留所有权利。", "程序根目录：");
                textBox2.Text = textBox2.Text.Replace(">@echo off", "");
                textBox2.Text = textBox2.Text.Replace("gmpublish.exe", "Cmd命令：");
                textBox2.Text = textBox2.Text.Replace("Garry's Mod Workshop Publisher 1.2", "Gmod创意工坊上传器1.2[Garry's Mod Workshop Publisher 1.2]");
                textBox2.Text = textBox2.Text.Replace("[Compiled May  8 2020 - 14:31:20]", "[编译时间：2020年8月8日14:31:20]");
                textBox2.Text = textBox2.Text.Replace("Beginning creation process...", "开始创建流程中...");
                textBox2.Text = textBox2.Text.Replace("Preparing Icon File...", "准备图标文件...");
                textBox2.Text = textBox2.Text.Replace("Couldn't open the icon!", ">>>错误：无法打开图标文件");
                textBox2.Text = textBox2.Text.Replace("Preparing Addon File...", "准备插件文件...");
                textBox2.Text = textBox2.Text.Replace("Requesting a new Workshop Item ID...", "获取一个新的创意工坊物品ID...");
                textBox2.Text = textBox2.Text.Replace("Success! Your new item ID is", ">>>获取成功！你的新物品ID为");
                textBox2.Text = textBox2.Text.Replace("Starting Update...", "开始上传物品中...");
                textBox2.Text = textBox2.Text.Replace("Updating title...", "上传标题中...");
                textBox2.Text = textBox2.Text.Replace("Updating icon...", "准备上传图标中...");
                textBox2.Text = textBox2.Text.Replace("Updating Tags...", "上传标签中...");
                textBox2.Text = textBox2.Text.Replace("Updating Addon File...", "准备上传插件文件中...");
                textBox2.Text = textBox2.Text.Replace("SetContentFile", ">>>已选中插件文件：");
                textBox2.Text = textBox2.Text.Replace("Submitting update.. (this can take a long time)", "提交更新中... (这可能需要数分钟)");
                textBox2.Text = textBox2.Text.Replace("Preparing config...", "准备配置文件中...");
                textBox2.Text = textBox2.Text.Replace("Preparing content...", "准备物品中...");
                textBox2.Text = textBox2.Text.Replace("Uploading content...", "上传物品中...");
                textBox2.Text = textBox2.Text.Replace("Uploading icon...", "上传图标中...");
                textBox2.Text = textBox2.Text.Replace("Success!", ">>>成功！！！");
                textBox2.Text = textBox2.Text.Replace("Addon creation finished.", ">>>插件成功创建！！！");
                textBox2.Text = textBox2.Text.Replace("Your new addon is currently marked as hidden, add some pictures and a description, then make it public!", "你的新物品当前被标记为隐藏，添加一些图片和说明，然后将其公开！");
                textBox2.Text = textBox2.Text.Replace("It is located at", "创意工坊地址：");
                //textBox2.Text = textBox2.Text.Replace("","");
                textBox2.Text = textBox2.Text.Replace("exit", "程序退出");
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
                textBox2.Text = textBox2.Text.Replace("Microsoft Windows [版本 6.3.9600]", "Gmod创意工坊上传器[Cmd输出]：");
                textBox2.Text = textBox2.Text.Replace("(c) 2013 Microsoft Corporation。保留所有权利。", "程序根目录：");
                textBox2.Text = textBox2.Text.Replace(">@echo off", "");
                textBox2.Text = textBox2.Text.Replace("gmpublish.exe", "Cmd命令：");
                textBox2.Text = textBox2.Text.Replace("Garry's Mod Workshop Publisher 1.2", "Gmod创意工坊上传器1.2[Garry's Mod Workshop Publisher 1.2]");
                textBox2.Text = textBox2.Text.Replace("[Compiled May  8 2020 - 14:31:20]", "[编译时间：2020年8月8日14:31:20]");
                textBox2.Text = textBox2.Text.Replace("Beginning creation process...", "开始创建流程中...");
                textBox2.Text = textBox2.Text.Replace("Preparing Icon File...", "准备图标文件...");
                textBox2.Text = textBox2.Text.Replace("Couldn't open the icon!", ">>>错误：无法打开图标文件");
                textBox2.Text = textBox2.Text.Replace("Preparing Addon File...", "准备插件文件...");
                textBox2.Text = textBox2.Text.Replace("Requesting a new Workshop Item ID...", "获取一个新的创意工坊物品ID...");
                textBox2.Text = textBox2.Text.Replace("Success! Your new item ID is", ">>>获取成功！你的新物品ID为");
                textBox2.Text = textBox2.Text.Replace("Starting Update...", "开始上传物品中...");
                textBox2.Text = textBox2.Text.Replace("Updating title...", "上传标题中...");
                textBox2.Text = textBox2.Text.Replace("Updating icon...", "准备上传图标中...");
                textBox2.Text = textBox2.Text.Replace("Updating Tags...", "上传标签中...");
                textBox2.Text = textBox2.Text.Replace("Updating Addon File...", "准备上传插件文件中...");
                textBox2.Text = textBox2.Text.Replace("SetContentFile", ">>>已选中插件文件：");
                textBox2.Text = textBox2.Text.Replace("Submitting update.. (this can take a long time)", "提交更新中... (这可能需要数分钟)");
                textBox2.Text = textBox2.Text.Replace("Preparing config...", "准备配置文件中...");
                textBox2.Text = textBox2.Text.Replace("Preparing content...", "准备物品中...");
                textBox2.Text = textBox2.Text.Replace("Uploading content...", "上传物品中...");
                textBox2.Text = textBox2.Text.Replace("Uploading icon...", "上传图标中...");
                textBox2.Text = textBox2.Text.Replace("Success!", ">>>成功！！！");
                textBox2.Text = textBox2.Text.Replace("Addon creation finished.", ">>>插件成功创建！！！");
                textBox2.Text = textBox2.Text.Replace("Your new addon is currently marked as hidden, add some pictures and a description, then make it public!", "你的新物品当前被标记为隐藏，添加一些图片和说明，然后将其公开！");
                textBox2.Text = textBox2.Text.Replace("It is located at", "创意工坊地址：");
                textBox2.Text = textBox2.Text.Replace("Beginning update process...", "开始创建更新线程...");
                textBox2.Text = textBox2.Text.Replace("Can't edit workshop id ", ">>>错误：不能编辑物品ID：");
                textBox2.Text = textBox2.Text.Replace("(are you the author?)", "(无法确认物品所有者)");
                //textBox2.Text = textBox2.Text.Replace("","");
                //textBox2.Text = textBox2.Text.Replace("","");
                //textBox2.Text = textBox2.Text.Replace("","");
                //textBox2.Text = textBox2.Text.Replace("","");
                //textBox2.Text = textBox2.Text.Replace("","");
                //textBox2.Text = textBox2.Text.Replace("","");
                //textBox2.Text = textBox2.Text.Replace("","");
                //textBox2.Text = textBox2.Text.Replace("","");
                textBox2.Text = textBox2.Text.Replace("exit", "程序退出");
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

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
