using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmodUploadTool
{
    public partial class SkinChange : Form
    {
        public SkinChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Skinname = comboBox1.Text;
            //Form1.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            Form1.skinEngine1.SkinFile = Application.StartupPath + "//" + Program.Skinname + ".ssk";
            //Form2.skinEngine1.SkinFile = Application.StartupPath + "//" + Program.Skinname + ".ssk";
            //Form3.skinEngine1.SkinFile = Application.StartupPath + "//" + Program.Skinname + ".ssk";
            //Form4.skinEngine1.SkinFile = Application.StartupPath + "//" + Program.Skinname + ".ssk";
            //Form5.skinEngine1.SkinFile = Application.StartupPath + "//" + Program.Skinname + ".ssk";
            //Form6.skinEngine1.SkinFile = Application.StartupPath + "//" + Program.Skinname + ".ssk";
            //Form7.skinEngine1.SkinFile = Application.StartupPath + "//" + Program.Skinname + ".ssk";
            //Form8.skinEngine1.SkinFile = Application.StartupPath + "//" + Program.Skinname + ".ssk";
            this.skinEngine1.SkinFile = Application.StartupPath + "//" + Program.Skinname + ".ssk";
        }

        private void SkinChange_Load(object sender, EventArgs e)
        {
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//" + Program.Skinname + ".ssk";
            if (Directory.Exists(Application.StartupPath + "//"))
            {
                string[] fileNames = Directory.GetFiles(Application.StartupPath + "//", "*.ssk");
                foreach (string s in fileNames)
                {
                    //comboBox1.Items.Add(Path.GetFileName(s));
                    string s1 = Path.GetFileName(s);
                    s1 = s1.Replace(".ssk", "").ToString();
                    comboBox1.Items.Remove(s1);
                    comboBox1.Items.Add(s1);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Application.StartupPath + "//"))
            {
                string[] fileNames = Directory.GetFiles(Application.StartupPath + "//", "*.ssk");
                foreach (string s in fileNames)
                {
                    //comboBox1.Items.Add(Path.GetFileName(s));
                    string s1 = Path.GetFileName(s);
                    s1 = s1.Replace(".ssk", "").ToString();
                    comboBox1.Items.Remove(s1);
                    comboBox1.Items.Add(s1);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
