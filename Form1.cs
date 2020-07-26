using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishGuidance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox1, "Start");
            t.SetToolTip(pictureBox3, "Info");
            t.SetToolTip(pictureBox2, "Exit");
            t.SetToolTip(label1, "Start");
            t.SetToolTip(label2, "Info");
            t.SetToolTip(label3, "Exit");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            Hide();
            reg.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("EnglishGuidance.chm");
        }
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Process.Start("EnglishGuidance.chm");
            }
        }
    }
}
