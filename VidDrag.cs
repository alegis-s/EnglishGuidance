using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EnglishGuidance
{
    public partial class VidDrag : Form
    {
        //Variables
        #region
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        bool status = false;
        public int corr_Numbers = 0;
        public int mist_Numbers = 0;
        public int corr_Measurements = 0;
        public int mist_Measurements = 0;
        public int corr_PT = 0;
        public int mist_PT = 0;
        public int corr_Tools = 0;
        public int mist_Tools = 0;
        public int corr_Materials = 0;
        public int mist_Materials = 0;
        public int corr_Elements = 0;
        public int mist_Elements = 0;
        public int corr_Safety = 0;
        public int mist_Safety = 0;
        public int corr_Wires = 0;
        public int mist_Wires = 0;
        public int corr_Actions = 0;
        public int mist_Actions = 0;
        public int result_corr = 0;
        public int result_mist = 0;
        public int id;

        PictureBox IMG1;
        PictureBox IMG2;

        PictureBox PB1;
        PictureBox PB2;
        #endregion

        //Switching Themes
        #region
        public void NextTask()
        {
            if (tabControl1.SelectedTab == Meas_Def)
            {
                tabControl1.SelectedTab = Tools_Def;
            }
            else
            if (tabControl1.SelectedTab == Tools_Def)
            {
                tabControl1.SelectedTab = Tools_Def2;
            }
            else
            if (tabControl1.SelectedTab == Tools_Def2)
            {
                tabControl1.SelectedTab = PT_FP;
            }
            else
            if (tabControl1.SelectedTab == PT_FP)
            {
                tabControl1.SelectedTab = Materials_Categ;
            }
            else
            if (tabControl1.SelectedTab == Materials_Categ)
            {
                tabControl1.SelectedTab = Materials_Def;
            }
            else
            if (tabControl1.SelectedTab == Materials_Def)
            {
                tabControl1.SelectedTab = Materials_Words;
            }
            else
            if (tabControl1.SelectedTab == Materials_Words)
            {
                tabControl1.SelectedTab = Safety_Def;
            }
            else
            if (tabControl1.SelectedTab == Safety_Def)
            {
                tabControl1.SelectedTab = Safety_FP;
            }
            else
            if (tabControl1.SelectedTab == Safety_FP)
            {
                tabControl1.SelectedTab = Voc_Words;
            }
        }
        public void PreviousTask()
        {
            if (tabControl1.SelectedTab == Tools_Def)
            {
                tabControl1.SelectedTab = Meas_Def;
            }
            else
            if (tabControl1.SelectedTab == Tools_Def2)
            {
                tabControl1.SelectedTab = Tools_Def;
            }
            else
            if (tabControl1.SelectedTab == PT_FP)
            {
                tabControl1.SelectedTab = Tools_Def2;
            }
            else
            if (tabControl1.SelectedTab == Materials_Categ)
            {
                tabControl1.SelectedTab = PT_FP;
            }
            else
            if (tabControl1.SelectedTab == Materials_Def)
            {
                tabControl1.SelectedTab = Materials_Categ;
            }
            else
            if (tabControl1.SelectedTab == Materials_Words)
            {
                tabControl1.SelectedTab = Materials_Def;
            }
            else
            if (tabControl1.SelectedTab == Safety_Def)
            {
                tabControl1.SelectedTab = Materials_Words;
            }
            else
            if (tabControl1.SelectedTab == Safety_FP)
            {
                tabControl1.SelectedTab = Safety_Def;
            }
            else
            if (tabControl1.SelectedTab == Voc_Words)
            {
                tabControl1.SelectedTab = Safety_FP;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Voc_Words;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Meas_Def;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Tools_Def;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Tools_Def2;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = PT_FP;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Materials_Categ;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Materials_Def;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Materials_Words;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Safety_Def;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Safety_FP;
        }
        private void Prev_Click(object sender, EventArgs e)
        {
            PreviousTask();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            NextTask();
        }
        private void tabPage1_Leave(object sender, EventArgs e)
        {
            WMP.controls.stop();
        }
        #endregion

        //Form
        #region
        public VidDrag(int corr_Numbers, int mist_Numbers, int corr_Measurements, int mist_Measurements, int corr_PT, int mist_PT, int corr_Tools, int mist_Tools, int corr_Materials, int mist_Materials, int corr_Elements, int mist_Elements, int corr_Safety, int mist_Safety, int corr_Wires, int mist_Wires, int corr_Actions, int mist_Actions, int id)
        {
            InitializeComponent();
            this.mist_Numbers = corr_Numbers;
            this.corr_Elements = mist_Numbers;
            this.corr_Measurements = corr_Measurements;
            this.mist_Measurements = mist_Measurements;
            this.corr_PT = corr_PT;
            this.mist_PT = mist_PT;
            this.mist_Tools = mist_Tools;
            this.corr_Tools = corr_Tools;
            this.corr_Materials = corr_Materials;
            this.mist_Materials = mist_Materials;
            this.mist_Elements = mist_Elements;
            this.corr_Elements = corr_Elements;
            this.mist_Safety = mist_Safety;
            this.corr_Safety = corr_Safety;
            this.mist_Wires = mist_Wires;
            this.corr_Wires = corr_Wires;
            this.mist_Actions = mist_Actions;
            this.corr_Actions = corr_Actions;
            this.id = id;

            this.pictureBox20.BringToFront();
            this.pictureBox21.BringToFront();
            this.pictureBox22.BringToFront();
            this.pictureBox23.BringToFront();
            this.pictureBox24.BringToFront();
            this.pictureBox25.BringToFront();
            this.pictureBox26.BringToFront();
            this.pictureBox62.BringToFront();
            this.pictureBox65.BringToFront();
            this.pictureBox66.BringToFront();
            this.pictureBox67.BringToFront();
            this.pictureBox63.BringToFront();
            this.pictureBox75.BringToFront();
            this.pictureBox74.BringToFront();
            this.pictureBox127.BringToFront();
            this.pictureBox130.BringToFront();
            this.pictureBox131.BringToFront();
            this.pictureBox132.BringToFront();
            this.pictureBox128.BringToFront();
            this.pictureBox140.BringToFront();
            this.pictureBox139.BringToFront();
            this.pictureBox100.BringToFront();
            this.pictureBox103.BringToFront();
            this.pictureBox104.BringToFront();
            this.pictureBox105.BringToFront();
            this.pictureBox101.BringToFront();
            this.pictureBox111.BringToFront();
            this.pictureBox114.BringToFront();
            this.pictureBox117.BringToFront();
            this.pictureBox153.BringToFront();
            this.pictureBox154.BringToFront();
            this.pictureBox155.BringToFront();
            this.pictureBox156.BringToFront();
            this.pictureBox157.BringToFront();
            this.pictureBox158.BringToFront();
            this.pictureBox159.BringToFront();
            this.pictureBox160.BringToFront();
            this.pictureBox162.BringToFront();
            this.pictureBox163.BringToFront();
            this.pictureBox164.BringToFront();
            this.pictureBox165.BringToFront();
            this.Voc_Words.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Meas_Def.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Safety_Def.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Safety_FP.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Materials_Words.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Materials_Categ.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Materials_Def.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Tools_Def.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Tools_Def2.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.PT_FP.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.BackColor = ColorTranslator.FromHtml("#ffc685");
        }
        private void VidDrag_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.WindowState = FormWindowState.Maximized;
            ToolTip t = new ToolTip();
            t.SetToolTip(button2, "Measurements: Definitions");
            t.SetToolTip(button5, "Tools: Definitions");
            t.SetToolTip(button18, "Tools: Definitions #2");
            t.SetToolTip(button13, "Power Tools: Match Pairs");
            t.SetToolTip(button17, "Materials: Categories");
            t.SetToolTip(button21, "Materials: Definitions");
            t.SetToolTip(button22, "Materials: Words");
            t.SetToolTip(button19, "Safety: Definitions");
            t.SetToolTip(button20, "Safety: Match Pairs");
            t.SetToolTip(button3, "Vocabulary");
            t.SetToolTip(button11, "Main Menu");
            t.SetToolTip(button16, "Videos");
            t.SetToolTip(Results, "Your tests results");
            t.SetToolTip(button1, "Check task");
            t.SetToolTip(Tools_Def_Check, "Check task");
            t.SetToolTip(MoreTools_Check, "Check task");
            t.SetToolTip(button7, "Check task");
            t.SetToolTip(button4, "Check task");
            t.SetToolTip(button10, "Check task");
            t.SetToolTip(pictureBox35, "Previous task");
            t.SetToolTip(pictureBox34, "Next task");
            t.SetToolTip(pictureBox37, "Previous task");
            t.SetToolTip(pictureBox36, "Next task");
            t.SetToolTip(pictureBox39, "Previous task");
            t.SetToolTip(pictureBox38, "Next task");
            t.SetToolTip(pictureBox41, "Previous task");
            t.SetToolTip(pictureBox40, "Next task");
            t.SetToolTip(pictureBox43, "Previous task");
            t.SetToolTip(pictureBox42, "Next task");
            t.SetToolTip(Prev, "Previous task");
            t.SetToolTip(Next, "Next task");
            t.SetToolTip(pictureBox45, "Previous task");
            t.SetToolTip(pictureBox44, "Next task");
            t.SetToolTip(pictureBox49, "Previous task");
            t.SetToolTip(pictureBox48, "Next task");
            t.SetToolTip(pictureBox47, "Previous task");
            t.SetToolTip(pictureBox46, "Next task");
            t.SetToolTip(pictureBox51, "Previous task");
            t.SetToolTip(pictureBox50, "Next task");
            t.SetToolTip(button12, "Refresh");
            t.SetToolTip(pictureBox146, "Word Meaning");
            t.SetToolTip(pictureBox149, "What to do?");
            t.SetToolTip(pictureBox148, "What to do?");
            t.SetToolTip(pictureBox147, "What to do?");
            t.SetToolTip(pictureBox145, "What to do?");
            t.SetToolTip(pictureBox144, "What to do?");
            t.SetToolTip(pictureBox143, "What to do?");
            t.SetToolTip(pictureBox142, "What to do?");
            t.SetToolTip(pictureBox141, "What to do?");
            t.SetToolTip(pictureBox14, "Word meaning");
        }
        private void button16_Click(object sender, EventArgs e)
        {
            Vids v = new Vids(id);
            Hide();
            v.ShowDialog();
            this.Close();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Hide();
            Home.ShowDialog();
            this.Close();
            WMP.controls.stop();
        }
        private void pictureBox142_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task Rule: Drag words to the definition, when you're done check the result.", "Definitions task", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void pictureBox144_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task Rule: Click on the tile, then click on the second. So, find a match for the picture and it's denitinion. If all tiles dissapear, then you win.", "Match pairs task", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void pictureBox145_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task Rule: Drag words to the area of the category, that you think belongs to the word.", "Categories task", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Results_Click(object sender, EventArgs e)
        {
            ResultForm RS = new ResultForm(corr_Numbers, mist_Numbers, corr_Measurements, mist_Measurements, corr_PT, mist_PT, corr_Tools, mist_Tools, corr_Materials, mist_Materials, corr_Elements, mist_Elements, corr_Safety, mist_Safety, corr_Wires, mist_Wires, corr_Actions, mist_Actions, id);
            Hide();
            RS.ShowDialog();
            this.Close();
        }
        private void VidDrag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                Process.Start("EnglishGuidance.chm");
            }
        }
        #endregion

        //Safety:Find_Pairs
        #region
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"Pictures\State_0\Glasses_txt.gif", true);
            timer1.Start();
            if (IMG1 == null)
            {
                IMG1 = pictureBox1;
            }
            else if (IMG1 != null && IMG2 == null)
            {
                IMG2 = pictureBox1;
            }
            if (IMG1 != null && IMG2 != null)
            {
                Сhecking();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"Pictures\State_0\Mask_txt.gif", true);
            timer1.Start();
            if (IMG1 == null)
            {
                IMG1 = pictureBox2;
            }
            else if (IMG1 != null && IMG2 == null)
            {
                IMG2 = pictureBox2;
            }
            if (IMG1 != null && IMG2 != null)
            {
                Сhecking();
            }
        }
        public void Сhecking()
        {
            if (IMG1.Tag == IMG2.Tag)
            {
                IMG1.Image = null;
                IMG2.Image = null;
                IMG1.Enabled = false;
                IMG2.Enabled = false;
                IMG1 = null;
                IMG2 = null;
            }
            else
            {
                if (IMG1 == pictureBox1 || IMG2 == pictureBox1)
                {
                    pictureBox1.Image = Image.FromFile(@"Pictures\State_1\Glasses_txt.gif", true);
                }
                if (IMG1 == pictureBox2 || IMG2 == pictureBox2)
                {
                    pictureBox2.Image = Image.FromFile(@"Pictures\State_1\Mask_txt.gif", true);
                }
                if (IMG1 == pictureBox3 || IMG2 == pictureBox3)
                {
                    pictureBox3.Image = Image.FromFile(@"Pictures\State_1\Boots_pic.gif", true);
                }
                if (IMG1 == pictureBox4 || IMG2 == pictureBox4)
                {
                    pictureBox4.Image = Image.FromFile(@"Pictures\State_1\Mask_txt.gif", true);
                }
                if (IMG1 == pictureBox5 || IMG2 == pictureBox5)
                {
                    pictureBox5.Image = Image.FromFile(@"Pictures\State_1\Glasses_txt.gif", true);
                }
                if (IMG1 == pictureBox6 || IMG2 == pictureBox6)
                {
                    pictureBox6.Image = Image.FromFile(@"Pictures\State_1\Mask_txt.gif", true);
                }
                if (IMG1 == pictureBox7 || IMG2 == pictureBox7)
                {
                    pictureBox7.Image = Image.FromFile(@"Pictures\State_1\Glasses_pic.gif", true);
                }
                if (IMG1 == pictureBox8 || IMG2 == pictureBox8)
                {
                    pictureBox8.Image = Image.FromFile(@"Pictures\State_1\Mask_pic.gif", true);
                }
                if (IMG1 == pictureBox9 || IMG2 == pictureBox9)
                {
                    pictureBox9.Image = Image.FromFile(@"Pictures\State_1\Glasses_txt.gif", true);
                }
                if (IMG1 == pictureBox10 || IMG2 == pictureBox10)
                {
                    pictureBox10.Image = Image.FromFile(@"Pictures\State_1\Mask_txt.gif", true);
                }
                if (IMG1 == pictureBox11 || IMG2 == pictureBox11)
                {
                    pictureBox11.Image = Image.FromFile(@"Pictures\State_1\Mask_txt.gif", true);
                }
                if (IMG1 == pictureBox12 || IMG2 == pictureBox12)
                {
                    pictureBox12.Image = Image.FromFile(@"Pictures\State_1\Mask_txt.gif", true);
                }
                timer2.Start();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"Pictures\State_0\Boots_pic.gif", true);
            timer1.Start();
            if (IMG1 == null)
            {
                IMG1 = pictureBox3;
            }
            else if (IMG1 != null && IMG2 == null)
            {
                IMG2 = pictureBox3;
            }
            if (IMG1 != null && IMG2 != null)
            {
                Сhecking();
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile(@"Pictures\State_0\Costume_pic.gif", true);
            timer1.Start();
            if (IMG1 == null)
            {
                IMG1 = pictureBox4;
            }
            else if (IMG1 != null && IMG2 == null)
            {
                IMG2 = pictureBox4;
            }
            if (IMG1 != null && IMG2 != null)
            {
                Сhecking();
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"Pictures\State_0\Stick_txt.gif", true);
            timer1.Start();
            if (IMG1 == null)
            {
                IMG1 = pictureBox5;
            }
            else if (IMG1 != null && IMG2 == null)
            {
                IMG2 = pictureBox5;
            }
            if (IMG1 != null && IMG2 != null)
            {
                Сhecking();
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"Pictures\State_0\Stick_pic.gif", true);
            timer1.Start();
            if (IMG1 == null)
            {
                IMG1 = pictureBox6;
            }
            else if (IMG1 != null && IMG2 == null)
            {
                IMG2 = pictureBox6;
            }
            if (IMG1 != null && IMG2 != null)
            {
                Сhecking();
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile(@"Pictures\State_0\Glasses_pic.gif", true);
            timer1.Start();
            if (IMG1 == null)
            {
                IMG1 = pictureBox7;
            }
            else if (IMG1 != null && IMG2 == null)
            {
                IMG2 = pictureBox7;
            }
            if (IMG1 != null && IMG2 != null)
            {
                Сhecking();
            }
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile(@"Pictures\State_0\Mask_pic.gif", true);
            timer1.Start();
            if (IMG1 == null)
            {
                IMG1 = pictureBox8;
            }
            else if (IMG1 != null && IMG2 == null)
            {
                IMG2 = pictureBox8;
            }
            if (IMG1 != null && IMG2 != null)
            {
                Сhecking();
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Image.FromFile(@"Pictures\State_0\Gloves_txt.gif", true);
            timer1.Start();
            if (IMG1 == null)
            {
                IMG1 = pictureBox9;
            }
            else if (IMG1 != null && IMG2 == null)
            {
                IMG2 = pictureBox9;
            }
            if (IMG1 != null && IMG2 != null)
            {
                Сhecking();
            }
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Image.FromFile(@"Pictures\State_0\Costume_txt.gif", true);
            timer1.Start();
            if (IMG1 == null)
            {
                IMG1 = pictureBox10;
            }
            else if (IMG1 != null && IMG2 == null)
            {
                IMG2 = pictureBox10;
            }
            if (IMG1 != null && IMG2 != null)
            {
                Сhecking();
            }
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Image.FromFile(@"Pictures\State_0\Boots_txt.gif", true);
            timer1.Start();
            if (IMG1 == null)
            {
                IMG1 = pictureBox11;
            }
            else if (IMG1 != null && IMG2 == null)
            {
                IMG2 = pictureBox11;
            }
            if (IMG1 != null && IMG2 != null)
            {
                Сhecking();
            }
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Image.FromFile(@"Pictures\State_0\Gloves_pic.gif", true);
            timer1.Start();
            if (IMG1 == null)
            {
                IMG1 = pictureBox12;
            }
            else if (IMG1 != null && IMG2 == null)
            {
                IMG2 = pictureBox12;
            }
            if (IMG1 != null && IMG2 != null)
            {
                Сhecking();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (IMG1 != null)
            {
                if (IMG1 == pictureBox1)
                {
                    pictureBox1.Image = Image.FromFile(@"Pictures\png\Glasses_txt.png");
                }
                if (IMG1 == pictureBox2)
                {
                    pictureBox2.Image = Image.FromFile(@"Pictures\png\Mask_txt.png");
                }
                if (IMG1 == pictureBox3)
                {
                    pictureBox3.Image = Image.FromFile(@"Pictures\png\Boots_pic.png");
                }
                if (IMG1 == pictureBox4)
                {
                    pictureBox4.Image = Image.FromFile(@"Pictures\png\Costume_pic.png");
                }
                if (IMG1 == pictureBox5)
                {
                    pictureBox5.Image = Image.FromFile(@"Pictures\png\Stick_txt.png");
                }
                if (IMG1 == pictureBox6)
                {
                    pictureBox6.Image = Image.FromFile(@"Pictures\png\Stick_pic.png");
                }
                if (IMG1 == pictureBox7)
                {
                    pictureBox7.Image = Image.FromFile(@"Pictures\png\Glasses_pic.png");
                }
                if (IMG1 == pictureBox8)
                {
                    pictureBox8.Image = Image.FromFile(@"Pictures\png\Mask_pic.png");
                }
                if (IMG1 == pictureBox9)
                {
                    pictureBox9.Image = Image.FromFile(@"Pictures\png\Gloves_txt.png");
                }
                if (IMG1 == pictureBox10)
                {
                    pictureBox10.Image = Image.FromFile(@"Pictures\png\Costume_txt.png");
                }
                if (IMG1 == pictureBox11)
                {
                    pictureBox11.Image = Image.FromFile(@"Pictures\png\Boots_txt.png");
                }
                if (IMG1 == pictureBox12)
                {
                    pictureBox12.Image = Image.FromFile(@"Pictures\png\Gloves_pic.png");
                }
            }
            if (IMG2 != null)
            {
                if (IMG2 == pictureBox1)
                {
                    pictureBox1.Image = Image.FromFile(@"Pictures\png\Glasses_txt.png");
                }

                if (IMG2 == pictureBox2)
                {
                    pictureBox2.Image = Image.FromFile(@"Pictures\png\Mask_txt.png");
                }

                if (IMG2 == pictureBox3)
                {
                    pictureBox3.Image = Image.FromFile(@"Pictures\png\Boots_pic.png");
                }

                if (IMG2 == pictureBox4)
                {
                    pictureBox4.Image = Image.FromFile(@"Pictures\png\Costume_pic.png");
                }

                if (IMG2 == pictureBox5)
                {
                    pictureBox5.Image = Image.FromFile(@"Pictures\png\Stick_txt.png");
                }

                if (IMG2 == pictureBox6)
                {
                    pictureBox6.Image = Image.FromFile(@"Pictures\png\Stick_pic.png");
                }

                if (IMG2 == pictureBox7)
                {
                    pictureBox7.Image = Image.FromFile(@"Pictures\png\Glasses_pic.png");
                }

                if (IMG2 == pictureBox8)
                {
                    pictureBox8.Image = Image.FromFile(@"Pictures\png\Mask_pic.png");
                }

                if (IMG2 == pictureBox9)
                {
                    pictureBox9.Image = Image.FromFile(@"Pictures\png\Gloves_txt.png");
                }

                if (IMG2 == pictureBox10)
                {
                    pictureBox10.Image = Image.FromFile(@"Pictures\png\Costume_txt.png");
                }

                if (IMG2 == pictureBox11)
                {
                    pictureBox11.Image = Image.FromFile(@"Pictures\png\Boots_txt.png");
                }

                if (IMG2 == pictureBox12)
                {
                    pictureBox12.Image = Image.FromFile(@"Pictures\png\Gloves_pic.png");
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            if (IMG1 == pictureBox1 || IMG2 == pictureBox1)
            {
                pictureBox1.Image = Image.FromFile(@"Pictures\png\glasses_txt_1.png");
            }
            if (IMG1 == pictureBox2 || IMG2 == pictureBox2)
            {
                pictureBox2.Image = Image.FromFile(@"Pictures\png\shield_txt_1.png");
            }
            if (IMG1 == pictureBox3 || IMG2 == pictureBox3)
            {
                pictureBox3.Image = Image.FromFile(@"Pictures\png\boots_pic_1.png");
            }
            if (IMG1 == pictureBox4 || IMG2 == pictureBox4)
            {
                pictureBox4.Image = Image.FromFile(@"Pictures\png\costume_pic_1.png");
            }
            if (IMG1 == pictureBox5 || IMG2 == pictureBox5)
            {
                pictureBox5.Image = Image.FromFile(@"Pictures\png\stick_txt_1.png");
            }
            if (IMG1 == pictureBox6 || IMG2 == pictureBox6)
            {
                pictureBox6.Image = Image.FromFile(@"Pictures\png\stick_pic_1.png");
            }
            if (IMG1 == pictureBox7 || IMG2 == pictureBox7)
            {
                pictureBox7.Image = Image.FromFile(@"Pictures\png\glasses_pic_1.png");
            }
            if (IMG1 == pictureBox8 || IMG2 == pictureBox8)
            {
                pictureBox8.Image = Image.FromFile(@"Pictures\png\shield_pic_1.png");
            }
            if (IMG1 == pictureBox9 || IMG2 == pictureBox9)
            {
                pictureBox9.Image = Image.FromFile(@"Pictures\png\gloves_txt_1.png");
            }
            if (IMG1 == pictureBox10 || IMG2 == pictureBox10)
            {
                pictureBox10.Image = Image.FromFile(@"Pictures\png\costume_txt_1.png");
            }
            if (IMG1 == pictureBox11 || IMG2 == pictureBox11)
            {
                pictureBox11.Image = Image.FromFile(@"Pictures\png\boots_txt_1.png");
            }
            if (IMG1 == pictureBox12 || IMG2 == pictureBox12)
            {
                pictureBox12.Image = Image.FromFile(@"Pictures\png\gloves_pic_1.png");
            }
            IMG1 = null;
            IMG2 = null;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"Pictures\png\glasses_txt_1.png");
            pictureBox1.Enabled = true;
            pictureBox2.Image = Image.FromFile(@"Pictures\png\shield_txt_1.png");
            pictureBox2.Enabled = true;
            pictureBox3.Image = Image.FromFile(@"Pictures\png\boots_pic_1.png");
            pictureBox3.Enabled = true;
            pictureBox4.Image = Image.FromFile(@"Pictures\png\costume_pic_1.png");
            pictureBox4.Enabled = true;
            pictureBox5.Image = Image.FromFile(@"Pictures\png\stick_txt_1.png");
            pictureBox5.Enabled = true;
            pictureBox6.Image = Image.FromFile(@"Pictures\png\stick_pic_1.png");
            pictureBox6.Enabled = true;
            pictureBox7.Image = Image.FromFile(@"Pictures\png\glasses_pic_1.png");
            pictureBox7.Enabled = true;
            pictureBox8.Image = Image.FromFile(@"Pictures\png\shield_pic_1.png");
            pictureBox8.Enabled = true;
            pictureBox9.Image = Image.FromFile(@"Pictures\png\gloves_txt_1.png");
            pictureBox9.Enabled = true;
            pictureBox10.Image = Image.FromFile(@"Pictures\png\Costume_txt_1.png");
            pictureBox10.Enabled = true;
            pictureBox11.Image = Image.FromFile(@"Pictures\png\boots_txt_1.png");
            pictureBox11.Enabled = true;
            pictureBox12.Image = Image.FromFile(@"Pictures\png\gloves_pic_1.png");
            pictureBox12.Enabled = true;
        }
        #endregion

        //Materials:Definitions
        #region
        private void pictureBox20_MouseUp(object sender, MouseEventArgs e)
        {
            status = false;
        }
        private void pictureBox20_MouseDown(object sender, MouseEventArgs e)
        {
            status = true;
        }
        private void pictureBox20_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true)
            {
                pictureBox20.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        private void pictureBox25_MouseUp(object sender, MouseEventArgs e)
        {
            status = false;
        }
        private void pictureBox25_MouseDown(object sender, MouseEventArgs e)
        {
            status = true;
        }
        private void pictureBox25_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox25.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if ((pictureBox23.Location.Y > 65 && pictureBox23.Location.Y < 100) && (pictureBox23.Location.X > 40 && pictureBox23.Location.X < 200))
            {
                pictureBox27.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox27.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox26.Location.Y > 108 && pictureBox26.Location.Y < 200) && (pictureBox26.Location.X > 40 && pictureBox26.Location.X < 200))
            {

                pictureBox28.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox28.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox24.Location.Y > 180 && pictureBox24.Location.Y < 278) && (pictureBox24.Location.X > 40 && pictureBox24.Location.X < 200))
            {
                pictureBox29.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox29.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox22.Location.Y > 250 && pictureBox22.Location.Y < 350) && (pictureBox22.Location.X > 40 && pictureBox22.Location.X < 200))
            {
                pictureBox30.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox30.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox21.Location.Y > 310 && pictureBox21.Location.Y < 410) && (pictureBox21.Location.X > 40 && pictureBox21.Location.X < 200))
            {
                pictureBox31.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox31.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox20.Location.Y > 440 && pictureBox20.Location.Y < 550) && (pictureBox20.Location.X > 30 && pictureBox20.Location.X < 120))
            {
                pictureBox33.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox33.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox25.Location.Y > 380 && pictureBox25.Location.Y < 480) && (pictureBox25.Location.X > 30 && pictureBox25.Location.X < 120))
            {
                pictureBox32.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox32.Image = Image.FromFile(@"Checks\222.png");
            }
        }
        private void pictureBox23_MouseUp(object sender, MouseEventArgs e)
        {
            status = false;
        }
        private void pictureBox23_MouseDown(object sender, MouseEventArgs e)
        {
            status = true;
        }
        private void pictureBox23_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox23.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));

            }
        }
        private void pictureBox24_MouseDown(object sender, MouseEventArgs e)
        {
            status = true;
        }
        private void pictureBox24_MouseUp(object sender, MouseEventArgs e)
        {
            status = false;
        }
        private void pictureBox24_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox24.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));

            }
        }
        private void pictureBox22_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox22.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));

            }
        }
        private void pictureBox22_MouseDown(object sender, MouseEventArgs e)
        {
            status = true;
        }
        private void pictureBox22_MouseUp(object sender, MouseEventArgs e)
        {
            status = false;
        }
        private void pictureBox21_MouseUp(object sender, MouseEventArgs e)
        {
            status = false;
        }
        private void pictureBox21_MouseDown(object sender, MouseEventArgs e)
        {
            status = true;
        }
        private void pictureBox21_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox21.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));

            }
        }
        private void pictureBox26_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox26.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));

            }
        }
        private void pictureBox26_MouseDown(object sender, MouseEventArgs e)
        {
            status = true;
        }
        private void pictureBox26_MouseUp(object sender, MouseEventArgs e)
        {
            status = false;
        }
        #endregion

        //Vocabulary
        #region
        int i = 0;
        private void pictureBox54_Click(object sender, EventArgs e)
        {
            pictureBox54.Visible = false;
            timer3.Enabled = true;
            pictureBox53.Enabled = true;
            if (i < 17)
            {
                i++;
            }
            if (i == 1)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book1.gif");
            }
            else
            if (i == 2)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book2.gif");
            }
            else
            if (i == 3)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book3.gif");
            }
            else
            if (i == 4)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book4.gif");
            }
            else
            if (i == 5)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book5.gif");
            }
            else
            if (i == 6)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book6.gif");
            }
            else
            if (i == 7)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book7.gif");
            }
            else
            if (i == 8)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book8.gif");
            }
            else
            if (i == 9)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book9.gif");
            }
            else
            if (i == 10)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book10.gif");
            }
            else
            if (i == 11)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book11.gif");
            }
            else
            if (i == 12)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book12.gif");
            }
            else
            if (i == 13)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book13.gif");
            }
            else
            if (i == 14)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book14.gif");
            }
            else
            if (i == 15)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book15.gif");
            }
            else if (i >= 16) { pictureBox53.Enabled = false; }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox54.Visible = true;
            pictureBox53.Enabled = false;
            if (i == 1)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book2.gif");
            }
            else
            if (i == 2)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book3.gif");
            }
            else
            if (i == 3)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book4.gif");
            }
            else
            if (i == 4)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book5.gif");
            }
            else
            if (i == 5)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book6.gif");
            }
            else
            if (i == 6)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book7.gif");
            }
            else
            if (i == 7)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book8.gif");
            }
            else
            if (i == 8)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book9.gif");
            }
            else
            if (i == 9)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book10.gif");
            }
            else
            if (i == 10)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book11.gif");
            }
            else
            if (i == 11)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book12.gif");
            }
            else
            if (i == 12)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book13.gif");
            }
            else
            if (i == 13)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book14.gif");
            }
            else
            if (i == 14)
            {
                pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book15.gif");
            }
        }
        private void pictureBox146_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                MessageBox.Show("Flashlight — small light source for individual use","Flashlight meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 2)
            {
                MessageBox.Show("Side Cutters — pliers intended for the cutting of wire", "Side Cutter meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 3)
            {
                MessageBox.Show("Allen wrench — a tool with a six-sided head used for tightening screw or bolts", "Allen wrench meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 4)
            {
                MessageBox.Show("Crimper — a tool used for pushing connectors around bare wires", "Crimper meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 5)
            {
                MessageBox.Show("Screwdriver — a tool used to tighten or loosen screws", "Screwdriver meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 6)
            {
                MessageBox.Show("Long nose pliers — a tool with especially narrowed pyramidal lips", "Long nose pliers meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 7)
            {
                MessageBox.Show("Nut driver — tool to tightening nuts", "Nut driver meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 8)
            {
                MessageBox.Show("Hacksaw — a tool with a thin blade that cuts through metal", "Hacksaw meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 9)
            {
                MessageBox.Show("Tool kit — a bag or box used to hold a set of tools", "Tool kit meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 10)
            {
                MessageBox.Show("Measuring tape — a tape used for finding the lenghts of an object", "Measuring tape meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 11)
            {
                MessageBox.Show("Duct tape — kind of tape made of mesh used on air ducts", "Duct tape meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 12)
            {
                MessageBox.Show("Utility knife — a fixed blade knife with cutting edge suitable for general work", "Utility knife meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 13)
            {
                MessageBox.Show("Torque wrench — a tool with integrated dynamometer", "Torque wrench meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 14)
            {
                MessageBox.Show("Socket wrench — a tool that inserts into a socket to turn a fastener, typically in the form of a nut or bolt", "Socket wrench meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i == 15 || i > 15)
            {
                MessageBox.Show("Wire stripper — a tool used to pull the covering off wires", "Wire stripper meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox53.Enabled = true;
            pictureBox53.Image = Image.FromFile(@"Pictures\Vocabulary\Book1.gif");
            pictureBox53.Enabled = false;
            i = 0;
        }
        #endregion

        //Measurements: Definitions
        #region
        private void button1_Click(object sender, EventArgs e)
        {
            if ((pictureBox66.Location.Y > 65 && pictureBox66.Location.Y < 100) && (pictureBox66.Location.X > 40 && pictureBox66.Location.X < 200))
            {
                pictureBox61.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox61.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox74.Location.Y > 108 && pictureBox74.Location.Y < 200) && (pictureBox74.Location.X > 40 && pictureBox74.Location.X < 200))
            {

                pictureBox60.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox60.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox67.Location.Y > 180 && pictureBox67.Location.Y < 278) && (pictureBox67.Location.X > 40 && pictureBox67.Location.X < 200))
            {
                pictureBox59.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox59.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox63.Location.Y > 250 && pictureBox63.Location.Y < 350) && (pictureBox63.Location.X > 40 && pictureBox63.Location.X < 200))
            {
                pictureBox58.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox58.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox75.Location.Y > 310 && pictureBox75.Location.Y < 410) && (pictureBox75.Location.X > 40 && pictureBox75.Location.X < 200))
            {
                pictureBox57.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox57.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox62.Location.Y > 440 && pictureBox62.Location.Y < 550) && (pictureBox62.Location.X > 30 && pictureBox62.Location.X < 120))
            {
                pictureBox55.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox55.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox65.Location.Y > 380 && pictureBox65.Location.Y < 480) && (pictureBox65.Location.X > 30 && pictureBox65.Location.X < 120))
            {
                pictureBox56.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox56.Image = Image.FromFile(@"Checks\222.png");
            }
        }

        private void pictureBox62_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox62.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox65_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox65.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox66_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox66.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox67_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox67.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox63_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox63.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox75_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox75.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox74_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox74.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        #endregion

        //Tools:Definitions
        #region
        private void pictureBox93_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox93.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox83_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox83.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox87_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox87.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox86_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox86.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox85_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox85.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox82_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox82.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void Tools_Def_Check_Click(object sender, EventArgs e)
        {
            if ((pictureBox86.Location.Y > 65 && pictureBox86.Location.Y < 100) && (pictureBox86.Location.X > 40 && pictureBox86.Location.X < 200))
            {
                pictureBox81.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox81.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox82.Location.Y > 108 && pictureBox82.Location.Y < 200) && (pictureBox82.Location.X > 40 && pictureBox82.Location.X < 200))
            {

                pictureBox80.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox80.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox87.Location.Y > 180 && pictureBox87.Location.Y < 278) && (pictureBox87.Location.X > 40 && pictureBox87.Location.X < 200))
            {
                pictureBox79.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox79.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox83.Location.Y > 250 && pictureBox83.Location.Y < 350) && (pictureBox83.Location.X > 40 && pictureBox83.Location.X < 200))
            {
                pictureBox78.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox78.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox93.Location.Y > 310 && pictureBox93.Location.Y < 410) && (pictureBox93.Location.X > 40 && pictureBox93.Location.X < 200))
            {
                pictureBox77.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox77.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox85.Location.Y > 380 && pictureBox85.Location.Y < 480) && (pictureBox85.Location.X > 30 && pictureBox85.Location.X < 120))
            {
                pictureBox76.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox76.Image = Image.FromFile(@"Checks\222.png");
            }
        }
        #endregion

        //Tools2:Definitions
        #region
        private void MoreTools_Check_Click(object sender, EventArgs e)
        {
            if ((pictureBox104.Location.Y > 65 && pictureBox104.Location.Y < 100) && (pictureBox104.Location.X > 40 && pictureBox104.Location.X < 200))
            {
                pictureBox99.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox99.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox100.Location.Y > 108 && pictureBox100.Location.Y < 200) && (pictureBox100.Location.X > 40 && pictureBox100.Location.X < 200))
            {

                pictureBox98.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox98.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox105.Location.Y > 180 && pictureBox105.Location.Y < 278) && (pictureBox105.Location.X > 40 && pictureBox105.Location.X < 200))
            {
                pictureBox97.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox97.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox101.Location.Y > 250 && pictureBox101.Location.Y < 350) && (pictureBox101.Location.X > 40 && pictureBox101.Location.X < 200))
            {
                pictureBox96.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox96.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox111.Location.Y > 310 && pictureBox111.Location.Y < 410) && (pictureBox111.Location.X > 40 && pictureBox111.Location.X < 200))
            {
                pictureBox95.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox95.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox117.Location.Y > 380 && pictureBox117.Location.Y < 450) && (pictureBox117.Location.X > 30 && pictureBox117.Location.X < 120))
            {
                pictureBox94.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox94.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox103.Location.Y > 430 && pictureBox103.Location.Y < 480) && (pictureBox103.Location.X > 30 && pictureBox103.Location.X < 120))
            {
                pictureBox113.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox113.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox114.Location.Y > 500 && pictureBox114.Location.Y < 600) && (pictureBox114.Location.X > 30 && pictureBox114.Location.X < 120))
            {
                pictureBox112.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox112.Image = Image.FromFile(@"Checks\222.png");
            }
        }

        private void pictureBox100_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox100.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox103_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox103.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox104_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox104.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox105_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox105.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox101_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox101.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox111_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox111.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox114_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox114.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox117_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox117.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        #endregion

        //Materials: Words
        #region
        int i1 = 0;
        private void pictureBox119_Click(object sender, EventArgs e)
        {

            pictureBox119.Visible = false;
            timer4.Enabled = true;
            pictureBox118.Enabled = true;
            if (i1 < 17)
            {
                i1++;
            }
            if (i1 == 1)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book1.gif");
            }
            else
            if (i1 == 2)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book2.gif");
            }
            else
            if (i1 == 3)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book3.gif");
            }
            else
            if (i1 == 4)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book4.gif");
            }
            else
            if (i1 == 5)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book5.gif");
            }
            else
            if (i1 == 6)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book6.gif");
            }
            else
            if (i1 == 7)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book7.gif");
            }
            else
            if (i1 == 8)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book8.gif");
            }
            else
            if (i1 == 9)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book9.gif");
            }
            else
            if (i1 == 10)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book10.gif");
            }
            else
            if (i1 == 11)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book11.gif");
            }
            else
            if (i1 == 12)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book12.gif");
            }
            else
            if (i1 == 13)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book13.gif");
            }
            else
            if (i1 == 14)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book14.gif");
            }
            else
            if (i1 == 15)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book15.gif");
            }
            else if (i1 >= 16) { pictureBox53.Enabled = false; }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox119.Visible = true;
            pictureBox118.Enabled = false;
            if (i1 == 1)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book2.gif");
            }
            else
            if (i1 == 2)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book3.gif");
            }
            else
            if (i1 == 3)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book4.gif");
            }
            else
            if (i1 == 4)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book5.gif");
            }
            else
            if (i1 == 5)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book6.gif");
            }
            else
            if (i1 == 6)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book7.gif");
            }
            else
            if (i1 == 7)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book8.gif");
            }
            else
            if (i1 == 8)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book9.gif");
            }
            else
            if (i1 == 9)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book10.gif");
            }
            else
            if (i1 == 10)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book11.gif");
            }
            else
            if (i1 == 11)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book12.gif");
            }
            else
            if (i1 == 12)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book13.gif");
            }
            else
            if (i1 == 13)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book14.gif");
            }
            else
            if (i1 == 14)
            {
                pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book15.gif");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox118.Enabled = true;
            pictureBox118.Image = Image.FromFile(@"Pictures\Materials_Words\Book1.gif");
            pictureBox118.Enabled = false;
            i1 = 0;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (i1 == 1)
            {
                MessageBox.Show("Steel — a metal that is made from combining iron and carbon", "Steel meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 2)
            {
                MessageBox.Show("Rotary drill — similar to a hammer drill, but rotary drills use a piston mechanism instead of a special clutch.", "Rotary drill meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 3)
            {
                MessageBox.Show("Concrete — a hard material made with cement, small stones, sand and water", "Concrete meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 4)
            {
                MessageBox.Show("Hammer drill — a power tool used chiefly for drilling in hard materials.", "Hammer drill meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 5)
            {
                MessageBox.Show("Copper — a one of the few metals that can occur in nature in a directly usable metallic form (native metals). This metal is used in wires.", "Copper meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 6)
            {
                MessageBox.Show("Rotary hammer — a power tool that can perform heavy-duty tasks such as drilling and chiseling hard materials.", "Rotaty hammer meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 7)
            {
                MessageBox.Show("Plywood — a board made of thin layers of wood glued together", "Plywood meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 8)
            {
                MessageBox.Show("Plaster — a building material used for the protective or decorative coating of walls and ceilings and for moulding and casting decorative elements.", "Plaster meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 9)
            {
                MessageBox.Show("Drywall — a board made of plaster and covered in paper", "Drywall meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 10)
            {
                MessageBox.Show("Lime — calcium-containing inorganic mineral composed primarily of oxides, and hydroxide, usually calcium oxide. The rocks and minerals from which these materials are derived, typically limestone or chalk, are composed primarily of calcium carbonate.", "Lime meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 11)
            {
                MessageBox.Show("Brick — a block of clay that is baked until it is hard", "Brick meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 12)
            {
                MessageBox.Show("Cement — small light source for individual use", "Cement meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 13)
            {
                MessageBox.Show("Mortar — an artificial inorganic hydraulic binder. One of the main building materials.", "Mortar meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 14)
            {
                MessageBox.Show("Stone — the hard solid non-metallic mineral matter of which rock is made, especially as a building material.", "Stone meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (i1 == 15 || i1 > 15)
            {
                MessageBox.Show("Wood — a porous and fibrous structural tissue found in the stems and roots of trees. Used as building material.", "Wood meaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        //Safety: Definitions
        #region
        private void button10_Click(object sender, EventArgs e)
        {
            if ((pictureBox131.Location.Y > 65 && pictureBox131.Location.Y < 100) && (pictureBox131.Location.X > 40 && pictureBox131.Location.X < 200))
            {
                pictureBox126.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox126.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox139.Location.Y > 108 && pictureBox139.Location.Y < 200) && (pictureBox139.Location.X > 40 && pictureBox139.Location.X < 200))
            {
                pictureBox125.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox125.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox132.Location.Y > 180 && pictureBox132.Location.Y < 278) && (pictureBox132.Location.X > 40 && pictureBox132.Location.X < 200))
            {
                pictureBox124.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox124.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox128.Location.Y > 250 && pictureBox128.Location.Y < 350) && (pictureBox128.Location.X > 40 && pictureBox128.Location.X < 200))
            {
                pictureBox123.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox123.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox140.Location.Y > 310 && pictureBox140.Location.Y < 410) && (pictureBox140.Location.X > 40 && pictureBox140.Location.X < 200))
            {
                pictureBox122.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox122.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox127.Location.Y > 440 && pictureBox127.Location.Y < 550) && (pictureBox127.Location.X > 30 && pictureBox127.Location.X < 120))
            {
                pictureBox120.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox120.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox130.Location.Y > 380 && pictureBox130.Location.Y < 480) && (pictureBox130.Location.X > 30 && pictureBox130.Location.X < 120))
            {
                pictureBox121.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox121.Image = Image.FromFile(@"Checks\222.png");
            }
        }
        private void pictureBox127_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox127.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));

            }
        }
        private void pictureBox130_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox130.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));

            }
        }
        private void pictureBox131_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox131.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));

            }
        }
        private void pictureBox132_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox132.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));

            }
        }
        private void pictureBox128_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox128.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));

            }
        }
        private void pictureBox140_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox140.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));

            }
        }
        private void pictureBox139_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox139.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));

            }
        }
        #endregion

        //Materials: Categories
        #region
        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox166.Location = pictureBox153.Location; pictureBox166.BringToFront(); pictureBox166.Visible = true;
            pictureBox167.Location = pictureBox154.Location; pictureBox167.BringToFront(); pictureBox167.Visible = true;
            pictureBox168.Location = pictureBox155.Location; pictureBox168.BringToFront(); pictureBox168.Visible = true;
            pictureBox169.Location = pictureBox156.Location; pictureBox169.BringToFront(); pictureBox169.Visible = true;
            pictureBox170.Location = pictureBox157.Location; pictureBox170.BringToFront(); pictureBox170.Visible = true;
            pictureBox171.Location = pictureBox158.Location; pictureBox171.BringToFront(); pictureBox171.Visible = true;
            pictureBox172.Location = pictureBox159.Location; pictureBox172.BringToFront(); pictureBox172.Visible = true;
            pictureBox173.Location = pictureBox160.Location; pictureBox173.BringToFront(); pictureBox173.Visible = true;
            pictureBox174.Location = pictureBox162.Location; pictureBox174.BringToFront(); pictureBox174.Visible = true;
            pictureBox175.Location = pictureBox163.Location; pictureBox175.BringToFront(); pictureBox175.Visible = true;
            pictureBox176.Location = pictureBox164.Location; pictureBox176.BringToFront(); pictureBox176.Visible = true;
            pictureBox177.Location = pictureBox165.Location; pictureBox177.BringToFront(); pictureBox177.Visible = true;
            if ((pictureBox154.Location.Y > 64 && pictureBox154.Location.Y < 365) && (pictureBox154.Location.X > 5 && pictureBox154.Location.X < 260))
            {
                pictureBox166.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox166.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox153.Location.Y > 64 && pictureBox153.Location.Y < 365) && (pictureBox153.Location.X > 268 && pictureBox153.Location.X < 537))
            {
                pictureBox167.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox167.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox155.Location.Y > 64 && pictureBox155.Location.Y < 365) && (pictureBox155.Location.X > 545 && pictureBox155.Location.X < 800))
            {
                pictureBox168.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox168.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox156.Location.Y > 64 && pictureBox156.Location.Y < 365) && (pictureBox156.Location.X > 268 && pictureBox156.Location.X < 537))
            {
                pictureBox169.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox169.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox157.Location.Y > 64 && pictureBox157.Location.Y < 365) && (pictureBox157.Location.X > 545 && pictureBox157.Location.X < 800))
            {
                pictureBox170.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox170.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox158.Location.Y > 64 && pictureBox158.Location.Y < 365) && (pictureBox158.Location.X > 5 && pictureBox158.Location.X < 260))
            {
                pictureBox171.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox171.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox159.Location.Y > 64 && pictureBox159.Location.Y < 365) && (pictureBox159.Location.X > 5 && pictureBox159.Location.X < 260))
            {
                pictureBox172.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox172.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox160.Location.Y > 64 && pictureBox160.Location.Y < 365) && (pictureBox160.Location.X > 5 && pictureBox160.Location.X < 260))
            {
                pictureBox173.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox173.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox162.Location.Y > 64 && pictureBox162.Location.Y < 365) && (pictureBox162.Location.X > 268 && pictureBox162.Location.X < 537))
            {
                pictureBox174.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox174.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox163.Location.Y > 64 && pictureBox163.Location.Y < 365) && (pictureBox160.Location.X > 5 && pictureBox160.Location.X < 260))
            {
                pictureBox175.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox175.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox164.Location.Y > 64 && pictureBox163.Location.Y < 365) && (pictureBox160.Location.X > 5 && pictureBox160.Location.X < 260))
            {
                pictureBox176.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox176.Image = Image.FromFile(@"Checks\222.png");
            }
            if ((pictureBox165.Location.Y > 64 && pictureBox165.Location.Y < 365) && (pictureBox162.Location.X > 268 && pictureBox162.Location.X < 537))
            {
                pictureBox177.Image = Image.FromFile(@"Checks\333.png");
            }
            else
            {
                pictureBox177.Image = Image.FromFile(@"Checks\222.png");
            }
        }
        private void pictureBox153_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox153.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox154_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox154.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        private void pictureBox155_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox155.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        private void pictureBox156_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox156.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        private void pictureBox157_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox157.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        private void pictureBox158_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox158.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        private void pictureBox159_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox159.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        private void pictureBox160_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox160.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        private void pictureBox162_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox162.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }

        private void pictureBox163_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox163.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        private void pictureBox164_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox164.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        private void pictureBox165_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true) //Если "перемещение включено"
            {
                pictureBox165.Location = new Point((Cursor.Position.X - this.Location.X - 600), (Cursor.Position.Y - this.Location.Y - 70));
            }
        }
        #endregion

        //PT:Match_Pairs
        #region 
        public void Сhecking_PT()
        {
            if (PB1.Tag == PB2.Tag)
            {
                PB1.Image = null;
                PB2.Image = null;
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB1 = null;
                PB2 = null;
            }
            else
            {
                if (PB1 == plate1 || PB2 == plate1)
                {
                    plate1.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_1\CircularSaw_pic.gif", true);
                }
                if (PB1 == plate2 || PB2 == plate2)
                {
                    plate2.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_1\WoodAugers_txt.gif", true);
                }
                if (PB1 == plate3 || PB2 == plate3)
                {
                    plate3.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_1\HammerDrill_pic.gif", true);
                }
                if (PB1 == plate4 || PB2 == plate4)
                {
                    plate4.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_1\Jigsaw_txt.gif", true);
                }
                if (PB1 == plate5 || PB2 == plate5)
                {
                    plate5.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_1\Hacksaw_txt.gif", true);
                }
                if (PB1 == dup_plate5 || PB2 == dup_plate5)
                {
                    dup_plate5.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_1\Hacksaw_pic.gif", true);
                }
                if (PB1 == dup_plate1 || PB2 == dup_plate1)
                {
                    dup_plate1.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_1\CircularSaw_txt.gif", true);
                }
                if (PB1 == dup_plate2 || PB2 == dup_plate2)
                {
                    dup_plate2.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_1\WoodAugers_pic.gif", true);
                }
                if (PB1 == plate6 || PB2 == plate6)
                {
                    plate6.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_1\SpadeBits_txt.gif", true);
                }
                if (PB1 == dup_plate4 || PB2 == dup_plate4)
                {
                    dup_plate4.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_1\Jigsaw_pic.gif", true);
                }
                if (PB1 == dup_plate3 || PB2 == dup_plate3)
                {
                    dup_plate3.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_1\HammerDrill_txt.gif", true);
                }
                if (PB1 == dup_plate6 || PB2 == dup_plate6)
                {
                    dup_plate6.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_1\SpadeBits_pic.gif", true);
                }
                PT_Timer2.Start();
            }
        }
        private void PT_Timer1_Tick(object sender, EventArgs e)
        {
            PT_Timer1.Stop();
            if (PB1 != null)
            {
                if (PB1 == plate1)
                {
                    plate1.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\CircularSaw_pic.png");
                }
                if (PB1 == plate2)
                {
                    plate2.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\WoodAugers_txt.png");
                }
                if (PB1 == plate3)
                {
                    plate3.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\HammerDrill_pic.png");
                }
                if (PB1 == plate4)
                {
                    plate4.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Jigsaw_txt.png");
                }
                if (PB1 == plate5)
                {
                    plate5.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Hacksaw_txt.png");
                }
                if (PB1 == dup_plate5)
                {
                    dup_plate5.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Hacksaw_pic.png");
                }
                if (PB1 == dup_plate1)
                {
                    dup_plate1.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\CircularSaw_txt.png");
                }
                if (IMG1 == dup_plate2)
                {
                    dup_plate2.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\WoodAugers_pic.png");
                }
                if (PB1 == plate6)
                {
                    plate6.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\SpadeBits_txt.png");
                }
                if (PB1 == dup_plate4)
                {
                    dup_plate4.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Jigsaw_pic.png");
                }
                if (PB1 == dup_plate3)
                {
                    dup_plate3.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\HammerDrill_txt.png");
                }
                if (PB1 == dup_plate6)
                {
                    dup_plate6.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\SpadeBits_pic.png");
                }
            }
            if (PB2 != null)
            {
                if (PB2 == plate1)
                {
                    plate1.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\CircularSaw_pic.png");
                }
                if (PB2 == plate2)
                {
                    plate2.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\WoodAugers_txt.png");
                }
                if (PB2 == plate3)
                {
                    plate3.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\HammerDrill_pic.png");
                }
                if (PB2 == plate4)
                {
                    plate4.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Jigsaw_txt.png");
                }
                if (PB2 == plate5)
                {
                    plate5.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Hacksaw_txt.png");
                }
                if (PB2 == dup_plate5)
                {
                    dup_plate5.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Hacksaw_pic.png");
                }
                if (PB2 == dup_plate1)
                {
                    dup_plate1.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\CircularSaw_txt.png");
                }
                if (PB2 == dup_plate2)
                {
                    dup_plate2.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\WoodAugers_pic.png");
                }
                if (PB2 == plate6)
                {
                    plate6.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\SpadeBits_txt.png");
                }
                if (PB2 == dup_plate4)
                {
                    dup_plate4.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Jigsaw_pic.png");
                }
                if (PB2 == dup_plate3)
                {
                    dup_plate3.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\HammerDrill_txt.png");
                }
                if (PB2 == dup_plate6)
                {
                    dup_plate6.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\SpadeBits_pic.png");
                }
            }
        }
        private void PT_Timer2_Tick(object sender, EventArgs e)
        {
            PT_Timer2.Stop();
            if (PB1 == plate1 || PB2 == plate1)
            {
                plate1.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            }
            if (PB1 == plate2 || PB2 == plate2)
            {
                plate2.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            }
            if (PB1 == plate3 || PB2 == plate3)
            {
                plate3.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            }
            if (PB1 == plate4 || PB2 == plate4)
            {
                plate4.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            }
            if (PB1 == plate5 || PB2 == plate5)
            {
                plate5.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            }
            if (PB1 == dup_plate5 || PB2 == dup_plate5)
            {
                dup_plate5.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            }
            if (PB1 == dup_plate1 || PB2 == dup_plate1)
            {
                dup_plate1.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            }
            if (PB1 == dup_plate2 || PB2 == dup_plate2)
            {
                dup_plate2.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            }
            if (PB1 == plate6 || PB2 == plate6)
            {
                plate6.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            }
            if (PB1 == dup_plate4 || PB2 == dup_plate4)
            {
                dup_plate4.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            }
            if (PB1 == dup_plate3 || PB2 == dup_plate3)
            {
                dup_plate3.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            }
            if (PB1 == dup_plate6 || PB2 == dup_plate6)
            {
                dup_plate6.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            }
            PB1 = null;
            PB2 = null;
        }
        private void plate1_Click(object sender, EventArgs e)
        {
            plate1.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_0\CircularSaw_pic.gif", true);
            PT_Timer1.Start();
            if (PB1 == null)
            {
                PB1 = plate1;
            }
            else if (PB1 != null && PB2 == null)
            {
                PB2 = plate1;
            }
            if (PB1 != null && PB2 != null)
            {
                Сhecking_PT();
            }
        }
        private void plate2_Click(object sender, EventArgs e)
        {
            plate2.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_0\WoodAugers_txt.gif", true);
            PT_Timer1.Start();
            if (PB1 == null)
            {
                PB1 = plate2;
            }
            else if (PB1 != null && PB2 == null)
            {
                PB2 = plate2;
            }
            if (PB1 != null && PB2 != null)
            {
                Сhecking_PT();
            }
        }
        private void dup_plate1_Click(object sender, EventArgs e)
        {
            dup_plate1.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_0\CircularSaw_txt.gif", true);
            PT_Timer1.Start();
            if (PB1 == null)
            {
                PB1 = dup_plate1;
            }
            else if (PB1 != null && PB2 == null)
            {
                PB2 = dup_plate1;
            }
            if (PB1 != null && PB2 != null)
            {
                Сhecking_PT();
            }
        }
        private void dup_plate2_Click(object sender, EventArgs e)
        {
            dup_plate2.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_0\WoodAugers_pic.gif", true);
            PT_Timer1.Start();
            if (PB1 == null)
            {
                PB1 = dup_plate2;
            }
            else if (PB1 != null && PB2 == null)
            {
                PB2 = dup_plate2;
            }
            if (PB1 != null && PB2 != null)
            {
                Сhecking_PT();
            }
        }
        private void plate3_Click(object sender, EventArgs e)
        {
            plate3.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_0\HammerDrill_pic.gif", true);
            PT_Timer1.Start();
            if (PB1 == null)
            {
                PB1 = plate3;
            }
            else if (PB1 != null && PB2 == null)
            {
                PB2 = plate3;
            }
            if (PB1 != null && PB2 != null)
            {
                Сhecking_PT();
            }
        }
        private void plate4_Click(object sender, EventArgs e)
        {
            plate4.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_0\Jigsaw_txt.gif", true);
            PT_Timer1.Start();
            if (PB1 == null)
            {
                PB1 = plate4;
            }
            else if (PB1 != null && PB2 == null)
            {
                PB2 = plate4;
            }
            if (PB1 != null && PB2 != null)
            {
                Сhecking_PT();
            }
        }
        private void plate5_Click(object sender, EventArgs e)
        {
            plate5.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_0\Hacksaw_txt.gif", true);
            PT_Timer1.Start();
            if (PB1 == null)
            {
                PB1 = plate5;
            }
            else if (PB1 != null && PB2 == null)
            {
                PB2 = plate5;
            }
            if (PB1 != null && PB2 != null)
            {
                Сhecking_PT();
            }
        }
        private void dup_plate5_Click(object sender, EventArgs e)
        {
            dup_plate5.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_0\Hacksaw_pic.gif", true);
            PT_Timer1.Start();
            if (PB1 == null)
            {
                PB1 = dup_plate5;
            }
            else if (PB1 != null && PB2 == null)
            {
                PB2 = dup_plate5;
            }
            if (PB1 != null && PB2 != null)
            {
                Сhecking_PT();
            }
        }
        private void plate6_Click(object sender, EventArgs e)
        {
            plate6.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_0\SpadeBits_txt.gif", true);
            PT_Timer1.Start();
            if (PB1 == null)
            {
                PB1 = plate6;
            }
            else if (PB1 != null && PB2 == null)
            {
                PB2 = plate6;
            }
            if (PB1 != null && PB2 != null)
            {
                Сhecking_PT();
            }
        }
        private void dup_plate4_Click(object sender, EventArgs e)
        {
            dup_plate4.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_0\Jigsaw_pic.gif", true);
            PT_Timer1.Start();
            if (PB1 == null)
            {
                PB1 = dup_plate4;
            }
            else if (PB1 != null && PB2 == null)
            {
                PB2 = dup_plate4;
            }
            if (PB1 != null && PB2 != null)
            {
                Сhecking_PT();
            }
        }
        private void dup_plate3_Click(object sender, EventArgs e)
        {
            dup_plate3.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_0\HammerDrill_txt.gif", true);
            PT_Timer1.Start();
            if (PB1 == null)
            {
                PB1 = dup_plate3;
            }
            else if (PB1 != null && PB2 == null)
            {
                PB2 = dup_plate3;
            }
            if (PB1 != null && PB2 != null)
            {
                Сhecking_PT();
            }
        }
        private void dup_plate6_Click(object sender, EventArgs e)
        {
            dup_plate6.Image = Image.FromFile(@"Pictures\PowerTools_Files\State_0\SpadeBits_pic.gif", true);
            PT_Timer1.Start();
            if (PB1 == null)
            {
                PB1 = dup_plate6;
            }
            else if (PB1 != null && PB2 == null)
            {
                PB2 = dup_plate4;
            }
            if (PB1 != null && PB2 != null)
            {
                Сhecking_PT();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            plate1.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            plate1.Enabled = true;
            plate2.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            plate2.Enabled = true;
            plate3.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            plate3.Enabled = true;
            plate4.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            plate4.Enabled = true;
            plate5.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            plate5.Enabled = true;
            plate6.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            plate6.Enabled = true;
            dup_plate1.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            dup_plate1.Enabled = true;
            dup_plate2.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            dup_plate2.Enabled = true;
            dup_plate3.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            dup_plate3.Enabled = true;
            dup_plate4.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            dup_plate4.Enabled = true;
            dup_plate5.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            dup_plate5.Enabled = true;
            dup_plate6.Image = Image.FromFile(@"Pictures\PowerTools_Files\png\Close_Plate.png");
            dup_plate6.Enabled = true;
        }
        #endregion
    }
}
