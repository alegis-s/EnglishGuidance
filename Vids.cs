using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishGuidance
{
    public partial class Vids : Form
    {
        int id;
        public Vids(int id)
        {
            InitializeComponent();
            this.id = id;
            this.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.tableLayoutPanel2.BackColor = ColorTranslator.FromHtml("#ffc685");
        }
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        private void WiresVideo_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"Videos\Wires.mp4";
            WMP.controls.stop();
        }

        private void MathForKids_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"Videos\Maths for Kids.mp4";
            WMP.controls.stop();
        }

        private void Electr_Engin_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"Videos\Electrical Engineering.mp4";
            WMP.controls.stop();
        }

        private void VideoPB_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"Videos\VideoPB.mp4";
            WMP.controls.stop();
        }

        private void Eng_Words_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"Videos\EngWords_WorkshopTools.mp4";
            WMP.controls.stop();
        }

        private void Vids_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.WindowState = FormWindowState.Normal;
            axWindowsMediaPlayer1.URL = @"Videos\Wires.mp4";
            WMP.controls.stop();
            ToolTip t = new ToolTip();
            t.SetToolTip(WiresVideo, "Wires");
            t.SetToolTip(VideoPB, "Video Playback");
            t.SetToolTip(Eng_Words, "English Words");
            t.SetToolTip(Electr_Engin, "Electrical Engineering");
            t.SetToolTip(MathForKids, "Math For Kids");
            t.SetToolTip(button11, "Home");
            t.SetToolTip(Results, "Themes");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("You will lose your result's. Are your sure?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.OK)
            {
                Form1 f = new Form1();
                Hide();
                f.ShowDialog();
                this.Close();
            }
            if (d == DialogResult.Cancel)
            {
                
            }
        }

        private void Results_Click(object sender, EventArgs e)
        {
            WMP.controls.stop();
            Form2 f2 = new Form2(id);
            Hide();
            f2.ShowDialog();
            this.Close();
            
        }

        private void Vids_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                System.Diagnostics.Process.Start("EnglishGuidance.chm");
            }
        }
    }
}
