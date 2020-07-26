using EnglishGuidance.Data;
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
    public partial class Form2 : Form
    {
        DBCon db = new DBCon();
        int id;
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        int n = 1;
        public int result_mist = 0;
        public int result_corr = 0;
        public int mist_Elements = 0;
        public int corr_Elements = 0;
        public int mist_Wires = 0;
        public int corr_Wires = 0;
        public int mist_Numbers = 0;
        public int corr_Numbers = 0;
        public int mist_Actions = 0;
        public int corr_Actions = 0;
        public int mist_PT = 0;
        public int corr_PT = 0;
        public int mist_Tools = 0;
        public int corr_Tools = 0;
        public int mist_Safety = 0;
        public int corr_Safety = 0;
        public int mist_Materials = 0;
        public int corr_Materials = 0;
        public int mist_Measurements = 0;
        public int corr_Measurements = 0;
        public Form2(int id)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Numbers.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Measur.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.T.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.PT.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Materials.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Elem.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Actions.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Wires.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.Safe.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.id = id;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vids V = new Vids(id);
            Hide();
            V.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Numbers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Measur;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.WindowState = FormWindowState.Maximized;
            WMP.URL = @"Audios\Numbers.mp3";
            WMP.controls.stop();
            ToolTip t = new ToolTip();
            t.SetToolTip(button23, "Listen to the conversation");
            t.SetToolTip(button14, "Listen to the conversation");
            t.SetToolTip(button15, "Listen to the conversation");
            t.SetToolTip(button13, "Listen to the conversation");
            t.SetToolTip(button16, "Listen to the conversation");
            t.SetToolTip(button24, "Listen to the conversation");
            t.SetToolTip(button17, "Listen to the conversation");
            t.SetToolTip(button25, "Listen to the conversation");
            t.SetToolTip(button18, "Listen to the conversation");
            t.SetToolTip(button26, "Listen to the conversation");
            t.SetToolTip(button19, "Listen to the conversation");
            t.SetToolTip(button27, "Listen to the conversation");
            t.SetToolTip(button20, "Listen to the conversation");
            t.SetToolTip(button28, "Listen to the conversation");
            t.SetToolTip(button23, "Listen to the conversation");
            t.SetToolTip(button21, "Listen to the conversation");
            t.SetToolTip(button29, "Listen to the conversation");
            t.SetToolTip(button22, "Listen to the conversation");
            t.SetToolTip(button30, "Listen to the conversation");
            t.SetToolTip(button11, "Main Menu");
            t.SetToolTip(button12, "Interactive Tasks");
            t.SetToolTip(button5, "Videos");
            t.SetToolTip(Check_Numbers, "Check test");
            t.SetToolTip(Measur_Check, "Check test");
            t.SetToolTip(PT_Check, "Check test");
            t.SetToolTip(Tools_Check, "Check test");
            t.SetToolTip(Materials_Check, "Check test");
            t.SetToolTip(Elements_Check, "Check test");
            t.SetToolTip(Safety_Check, "Check test");
            t.SetToolTip(Wires_Check, "Check test");
            t.SetToolTip(Prev, "Previous test");
            t.SetToolTip(Next, "Next test");
            t.SetToolTip(Results, "Your tests results");
            t.SetToolTip(Actions_Check, "Check test");
            t.SetToolTip(pictureBox13, "Previous test");
            t.SetToolTip(pictureBox14, "Next test");
            t.SetToolTip(pictureBox15, "Your tests results");
            t.SetToolTip(pictureBox16, "Previous test");
            t.SetToolTip(pictureBox17, "Next test");
            t.SetToolTip(pictureBox18, "Your tests results");
            t.SetToolTip(pictureBox19, "Previous test");
            t.SetToolTip(pictureBox20, "Next test");
            t.SetToolTip(pictureBox21, "Your tests results");
            t.SetToolTip(pictureBox22, "Previous test");
            t.SetToolTip(pictureBox23, "Next test");
            t.SetToolTip(pictureBox24, "Your tests results");
            t.SetToolTip(pictureBox25, "Previous test");
            t.SetToolTip(pictureBox26, "Next test");
            t.SetToolTip(pictureBox27, "Your tests results");
            t.SetToolTip(pictureBox28, "Previous test");
            t.SetToolTip(pictureBox29, "Next test");
            t.SetToolTip(pictureBox30, "Your tests results");
            t.SetToolTip(pictureBox31, "Previous test");
            t.SetToolTip(pictureBox32, "Next test");
            t.SetToolTip(pictureBox33, "Your tests results");
            t.SetToolTip(pictureBox34, "Previous test");
            t.SetToolTip(pictureBox35, "Next test");
            t.SetToolTip(pictureBox36, "Your tests results");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            VidDrag VD = new VidDrag(corr_Numbers, mist_Numbers, corr_Measurements, mist_Measurements, corr_PT, mist_PT, corr_Tools, mist_Tools, corr_Materials, mist_Materials, corr_Elements, mist_Elements, corr_Safety, mist_Safety, corr_Wires, mist_Wires, corr_Actions, mist_Actions, id);
            Hide();
            VD.ShowDialog();
            this.Close();
            WMP.controls.stop();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Form1 MainMenu = new Form1();
            Hide();
            MainMenu.ShowDialog();
            this.Close();
            WMP.controls.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = PT;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = T;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Materials;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Elem;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Safe;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Wires;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Actions;
        }

        private void button15_Click(object sender, EventArgs e) //measurements audio
        {
            WMP.URL = @"Audios\Measurements.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void button16_Click(object sender, EventArgs e) // power tools audio 
        {
            WMP.URL = @"Audios\PowerTools.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void button17_Click(object sender, EventArgs e)  //tools audio
        {
            WMP.URL = @"Audios\Tools.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
            
        }

        private void button18_Click(object sender, EventArgs e) //materials audio
        {
            WMP.URL = @"Audios\Materials.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void button19_Click(object sender, EventArgs e) //elements audio
        {
            WMP.URL = @"Audios\Elements.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void button20_Click(object sender, EventArgs e) //safety audio
        {
            WMP.URL = @"Audios\Safety.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void button21_Click(object sender, EventArgs e) //wires audio
        {
            WMP.URL = @"Audios\Wires.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void button22_Click(object sender, EventArgs e) //actions audio
        {
            WMP.URL = @"Audios\Actions.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();  // пауза на повторное нажатие
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void Measur_Leave(object sender, EventArgs e)
        {
            WMP.controls.stop();
            n = 1;
        }

        private void Numbers_Leave(object sender, EventArgs e)
        {
            WMP.controls.stop();
            n = 1;
        }

        private void PT_Leave(object sender, EventArgs e)
        {
            WMP.controls.stop();
            n = 1;
        }

        private void T_Leave(object sender, EventArgs e)
        {
            WMP.controls.stop();
            n = 1;
        }

        private void Materials_Leave(object sender, EventArgs e)
        {
            WMP.controls.stop();
            n = 1;
        }

        private void Elem_Leave(object sender, EventArgs e)
        {
            WMP.controls.stop();
            n = 1;
        }

        private void Wires_Leave(object sender, EventArgs e)
        {
            WMP.controls.stop();
            n = 1;
        }

        private void Actions_Leave(object sender, EventArgs e)
        {
            WMP.controls.stop();
            n = 1;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            WMP.URL = @"Audios\Numbers.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void Check_Numbers_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "What's" || textBox9.Text == "Whats" || textBox9.Text == "what's" || textBox9.Text == "whats")
            {
                textBox9.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox9.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (textBox10.Text == "up" || textBox10.Text == "Up")
            {
                textBox10.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox10.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (textBox15.Text == "Add" || textBox15.Text == "add")
            {
                textBox15.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox15.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (textBox14.Text == "up" || textBox14.Text == "Up")
            {
                textBox14.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox14.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (textBox12.Text == "Let" || textBox12.Text == "let")
            {
                textBox12.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox12.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (textBox11.Text == "Me" || textBox11.Text == "me")
            {
                textBox11.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox11.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (textBox13.Text == "see" || textBox13.Text == "See")
            {
                textBox13.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox13.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (textBox2.Text == "thirteen" || textBox2.Text == "Thirteen")
            {
                textBox2.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox2.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (textBox3.Text == "hundred" || textBox3.Text == "Hundred")
            {
                textBox3.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox3.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (textBox6.Text == "There's" || textBox6.Text == "Theres" || textBox6.Text == "theres" || textBox6.Text == "there's")
            {
                textBox6.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox6.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (textBox7.Text == "your" || textBox7.Text == "Your")
            {
                textBox7.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox7.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (textBox8.Text == "problem" || textBox8.Text == "Problem")
            {
                textBox8.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox8.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (textBox4.Text == "multiplied" || textBox4.Text == "Multiplied")
            {
                textBox4.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox4.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (textBox5.Text == "By" || textBox5.Text == "by")
            {
                textBox5.ForeColor = Color.Green;
                corr_Numbers += 1;
            }
            else
            {
                textBox5.ForeColor = Color.Red;
                mist_Numbers += 1;
            }

            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true)
            {
                checkBox2.ForeColor = Color.Green;
                checkBox1.ForeColor = Color.Red;
                checkBox3.ForeColor = Color.Red;
                checkBox4.ForeColor = Color.Red;
                if (checkBox2.Checked == true)
                {
                    corr_Numbers += 1;
                }
                else
                {
                    mist_Numbers += 1;
                }
            }
            if (checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true || checkBox8.Checked == true)
            {
                checkBox5.ForeColor = Color.Green;
                checkBox7.ForeColor = Color.Red;
                checkBox6.ForeColor = Color.Red;
                checkBox8.ForeColor = Color.Red;
                if (checkBox5.Checked == true)
                {
                    corr_Numbers += 1;
                }
                else
                {
                    mist_Numbers += 1;
                }
            }
            MessageBox.Show("Your result for theme Numbers is " + corr_Numbers + " correct answers and " + mist_Numbers + " incorrect answers.", "Your «Numbers» test results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result_corr += corr_Numbers;
            result_mist += mist_Numbers;
            Check_Numbers.Enabled = false;
            Check_Numbers.BorderStyle = BorderStyle.Fixed3D;
            
            db.Answers.Add(new Data.Answers()
            {
                AnswerThemeId = 10,
                Result_Corr = corr_Numbers,
                Result_Incorr = mist_Numbers,
                ThemeId = 1,
                UserId = id

            });
            db.SaveChanges();
        }

        private void Measur_Check_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true || checkBox12.Checked == true || checkBox9.Checked == true || checkBox10.Checked == true)
            {
                checkBox11.ForeColor = Color.Green;
                checkBox9.ForeColor = Color.Red;
                checkBox10.ForeColor = Color.Red;
                checkBox12.ForeColor = Color.Red;
                if (checkBox11.Checked == true)
                {
                    corr_Measurements += 1;
                }
                else
                {
                    mist_Measurements += 1;
                }
            }
            if (checkBox15.Checked == true || checkBox16.Checked == true || checkBox13.Checked == true || checkBox14.Checked == true)
            {
                checkBox16.ForeColor = Color.Green;
                checkBox15.ForeColor = Color.Red;
                checkBox14.ForeColor = Color.Red;
                checkBox13.ForeColor = Color.Red;
                if (checkBox16.Checked == true)
                {
                    corr_Measurements += 1;
                }
                else
                {
                    mist_Measurements += 1;
                }
            }

            if (textBox17.Text == "having" || textBox17.Text == "Having")
            {
                textBox17.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox17.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox18.Text == "some" || textBox18.Text == "Some")
            {
                textBox18.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox18.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox19.Text == "trouble" || textBox19.Text == "Trouble")
            {
                textBox19.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox19.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox20.Text == "slipping" || textBox20.Text == "Slipping")
            {
                textBox20.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox20.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox21.Text == "off" || textBox21.Text == "Off")
            {
                textBox21.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox21.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox22.Text == "best" || textBox22.Text == "Best")
            {
                textBox22.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox22.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox23.Text == "fit" || textBox23.Text == "Fit")
            {
                textBox23.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox23.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox24.Text == "thats" || textBox24.Text == "Thats" || textBox24.Text == "that's" || textBox24.Text == "That's")
            {
                textBox24.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox24.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox25.Text == "not" || textBox25.Text == "Not")
            {
                textBox25.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox25.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox26.Text == "right" || textBox26.Text == "Right")
            {
                textBox26.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox26.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox27.Text == "the" || textBox27.Text == "The")
            {
                textBox27.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox27.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox28.Text == "wrong" || textBox28.Text == "Wrong")
            {
                textBox28.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox28.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox29.Text == "one" || textBox29.Text == "One")
            {
                textBox29.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox29.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox30.Text == "In" || textBox30.Text == "in")
            {
                textBox30.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox30.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox31.Text == "my" || textBox31.Text == "My")
            {
                textBox31.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox31.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox32.Text == "tool" || textBox32.Text == "Tool")
            {
                textBox32.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox32.ForeColor = Color.Red;
                mist_Measurements += 1;
            }

            if (textBox33.Text == "Kit" || textBox33.Text == "kit")
            {
                textBox33.ForeColor = Color.Green;
                corr_Measurements += 1;
            }
            else
            {
                textBox33.ForeColor = Color.Red;
                mist_Measurements += 1;
            }
            MessageBox.Show("Your result for theme Measurements is " + corr_Measurements + " correct answers and " + mist_Measurements + " incorrect answers.", "Your «Measurements» test results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result_corr += corr_Measurements;
            result_mist += mist_Measurements;
            Measur_Check.Enabled = false;
            db.Answers.Add(new Data.Answers()
            {
                AnswerThemeId = 10,
                Result_Corr = corr_Measurements,
                Result_Incorr = mist_Measurements,
                ThemeId = 2,
                UserId = id

            });
            db.SaveChanges();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            WMP.URL = @"Audios\Measurements.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void PT_Check_Click(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true || checkBox19.Checked == true || checkBox18.Checked == true || checkBox17.Checked == true)
            {
                checkBox20.ForeColor = Color.Green;
                checkBox19.ForeColor = Color.Red;
                checkBox18.ForeColor = Color.Red;
                checkBox17.ForeColor = Color.Red;
                if (checkBox20.Checked == true)
                {
                    corr_PT += 1;
                }
                else
                {
                    mist_PT += 1;
                }
            }
            if (checkBox21.Checked == true || checkBox22.Checked == true || checkBox23.Checked == true || checkBox24.Checked == true)
            {
                checkBox21.ForeColor = Color.Green;
                checkBox22.ForeColor = Color.Red;
                checkBox23.ForeColor = Color.Red;
                checkBox24.ForeColor = Color.Red;
                if (checkBox21.Checked == true)
                {
                    corr_PT += 1;
                }
                else
                {
                    mist_PT += 1;
                }
            }

            if (textBox50.Text == "make" || textBox50.Text == "Make")
            {
                textBox50.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox50.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox49.Text == "a" || textBox49.Text == "A")
            {
                textBox49.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox49.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox48.Text == "Hole" || textBox48.Text == "hole")
            {
                textBox48.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox48.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox47.Text == "drill" || textBox47.Text == "Drill")
            {
                textBox47.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox47.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox46.Text == "bit" || textBox46.Text == "Bit")
            {
                textBox46.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox46.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox45.Text == "spade" || textBox45.Text == "Spade")
            {
                textBox45.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox45.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox44.Text == "bit" || textBox44.Text == "Bit")
            {
                textBox44.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox44.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox43.Text == "In" || textBox43.Text == "in")
            {
                textBox43.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox43.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox42.Text == "My" || textBox42.Text == "my")
            {
                textBox42.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox42.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox41.Text == "Opinion" || textBox41.Text == "opinion")
            {
                textBox41.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox41.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox40.Text == "easier" || textBox40.Text == "Easier")
            {
                textBox40.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox40.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox39.Text == "To" || textBox39.Text == "to")
            {
                textBox39.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox39.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox38.Text == "run" || textBox38.Text == "Run")
            {
                textBox38.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox38.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox37.Text == "your" || textBox37.Text == "Your")
            {
                textBox37.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox37.ForeColor = Color.Red;
                mist_PT += 1;
            }

            if (textBox36.Text == "point" || textBox36.Text == "point")
            {
                textBox36.ForeColor = Color.Green;
                corr_PT += 1;
            }
            else
            {
                textBox36.ForeColor = Color.Red;
                mist_PT += 1;
            }
            MessageBox.Show("Your result for theme Power Tools is " + corr_PT + " correct answers and " + mist_PT + " incorrect answers.", "Your «Power Tools» test results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result_corr += corr_PT;
            result_mist += mist_PT;
            PT_Check.Enabled = false;
            db.Answers.Add(new Data.Answers()
            {
                AnswerThemeId = 10,
                Result_Corr = corr_PT,
                Result_Incorr = mist_PT,
                ThemeId = 3,
                UserId = id

            });
            db.SaveChanges();
        }

        private void Tools_Check_Click(object sender, EventArgs e)
        {
            if (checkBox25.Checked == true || checkBox26.Checked == true)
            {
                checkBox26.ForeColor = Color.Green;
                checkBox25.ForeColor = Color.Red;
                if (checkBox26.Checked == true)
                {
                    corr_Tools += 1;
                }
                else
                {
                    mist_Tools += 1;
                }
            }

            if (checkBox28.Checked == true || checkBox27.Checked == true)
            {
                checkBox27.ForeColor = Color.Green;
                checkBox28.ForeColor = Color.Red;
                if (checkBox27.Checked == true)
                {
                    corr_Tools += 1;
                }
                else
                {
                    mist_Tools += 1;
                }
            }

            if (checkBox29.Checked == true || checkBox30.Checked == true)
            {
                checkBox30.ForeColor = Color.Green;
                checkBox29.ForeColor = Color.Red;
                if (checkBox30.Checked == true)
                {
                    corr_Tools += 1;
                }
                else
                {
                    mist_Tools += 1;
                }
            }

            if (textBox64.Text == "first" || textBox64.Text == "First")
            {
                textBox64.ForeColor = Color.Green;
                corr_Tools += 1;
            }
            else
            {
                textBox64.ForeColor = Color.Red;
                mist_Tools += 1;
            }

            if (textBox63.Text == "day" || textBox63.Text == "Day")
            {
                textBox63.ForeColor = Color.Green;
                corr_Tools += 1;
            }
            else
            {
                textBox63.ForeColor = Color.Red;
                mist_Tools += 1;
            }

            if (textBox62.Text == "electrician's" || textBox62.Text == "electricians" || textBox62.Text == "Electrician's" || textBox62.Text == "Electricians")
            {
                textBox62.ForeColor = Color.Green;
                corr_Tools += 1;
            }
            else
            {
                textBox62.ForeColor = Color.Red;
                mist_Tools += 1;
            }

            if (textBox61.Text == "tools" || textBox61.Text == "Tools")
            {
                textBox61.ForeColor = Color.Green;
                corr_Tools += 1;
            }
            else
            {
                textBox61.ForeColor = Color.Red;
                mist_Tools += 1;
            }

            if (textBox60.Text == "side" || textBox60.Text == "Side")
            {
                textBox60.ForeColor = Color.Green;
                corr_Tools += 1;
            }
            else
            {
                textBox60.ForeColor = Color.Red;
                mist_Tools += 1;
            }

            if (textBox59.Text == "Cutters" || textBox59.Text == "cutters")
            {
                textBox59.ForeColor = Color.Green;
                corr_Tools += 1;
            }
            else
            {
                textBox59.ForeColor = Color.Red;
                mist_Tools += 1;
            }

            if (textBox58.Text == "made" || textBox58.Text == "Made")
            {
                textBox58.ForeColor = Color.Green;
                corr_Tools += 1;
            }
            else
            {
                textBox58.ForeColor = Color.Red;
                mist_Tools += 1;
            }

            if (textBox57.Text == "by" || textBox57.Text == "By")
            {
                textBox57.ForeColor = Color.Green;
                corr_Tools += 1;
            }
            else
            {
                textBox57.ForeColor = Color.Red;
                mist_Tools += 1;
            }

            if (textBox56.Text == "stopped" || textBox56.Text == "Stopped")
            {
                textBox56.ForeColor = Color.Green;
                corr_Tools += 1;
            }
            else
            {
                textBox56.ForeColor = Color.Red;
                mist_Tools += 1;
            }

            if (textBox55.Text == "buying" || textBox55.Text == "Buying")
            {
                textBox55.ForeColor = Color.Green;
                corr_Tools += 1;
            }
            else
            {
                textBox55.ForeColor = Color.Red;
                mist_Tools += 1;
            }

            if (textBox54.Text == "I'll go" || textBox54.Text == "I will go")
            {
                textBox54.ForeColor = Color.Green;
                corr_Tools += 1;
            }
            else
            {
                textBox54.ForeColor = Color.Red;
                mist_Tools += 1;
            }

            if (textBox53.Text == "with" || textBox53.Text == "With")
            {
                textBox53.ForeColor = Color.Green;
                corr_Tools += 1;
            }
            else
            {
                textBox53.ForeColor = Color.Red;
                mist_Tools += 1;
            }
            MessageBox.Show("Your result for theme Safety is " + corr_Tools + " correct answers and " + mist_Tools + " incorrect answers.", "Your «Tools» test results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result_corr += corr_Tools;
            result_mist += mist_Tools;
            Tools_Check.Enabled = false;
            db.Answers.Add(new Data.Answers()
            {
                AnswerThemeId = 10,
                Result_Corr = corr_Tools,
                Result_Incorr = mist_Tools,
                ThemeId = 4,
                UserId = id

            });
            db.SaveChanges();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            WMP.URL = @"Audios\PowerTools.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            WMP.URL = @"Audios\Tools.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void Materials_Check_Click(object sender, EventArgs e)
        {
            if ((radioButton7.Checked == true || radioButton8.Checked == true) && (radioButton9.Checked == true || radioButton10.Checked == true) && (radioButton11.Checked == true || radioButton12.Checked == true))
            {
                radioButton7.ForeColor = Color.Red;
                radioButton10.ForeColor = Color.Red;
                radioButton12.ForeColor = Color.Red;
                radioButton8.ForeColor = Color.Green;
                radioButton9.ForeColor = Color.Green;
                radioButton11.ForeColor = Color.Green;
                if (radioButton8.Checked == true && radioButton9.Checked == true && radioButton11.Checked == true)
                {
                    corr_Materials += 3;
                }
                else if ((radioButton8.Checked == true && radioButton9.Checked == true) || (radioButton8.Checked == true && radioButton11.Checked == true) || (radioButton9.Checked == true && radioButton11.Checked == true))
                {
                    corr_Materials += 2;
                    mist_Materials += 1;
                }
                else if (radioButton8.Checked == true || radioButton9.Checked == true || radioButton11.Checked == true)
                {
                    corr_Materials += 1;
                    mist_Materials += 2;
                }
                else
                {
                    mist_Materials += 3;
                }
            }

            if (textBox74.Text == "need" || textBox74.Text == "Need")
            {
                textBox74.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox74.ForeColor = Color.Red;
                mist_Materials += 1;
            }

            if (textBox73.Text == "to" || textBox73.Text == "To")
            {
                textBox73.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox73.ForeColor = Color.Red;
                mist_Materials += 1;
            }

            if (textBox72.Text == "Drill" || textBox72.Text == "drill")
            {
                textBox72.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox72.ForeColor = Color.Red;
                mist_Materials += 1;
            }

            if (textBox71.Text == "figure" || textBox53.Text == "Figure")
            {
                textBox71.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox71.ForeColor = Color.Red;
                mist_Materials += 1;
            }

            if (textBox70.Text == "it" || textBox70.Text == "It")
            {
                textBox70.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox70.ForeColor = Color.Red;
                mist_Materials += 1;
            }

            if (textBox69.Text == "out" || textBox69.Text == "Out")
            {
                textBox69.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox69.ForeColor = Color.Red;
                mist_Materials += 1;
            }

            if (textBox68.Text == "Rotary" || textBox68.Text == "rotary")
            {
                textBox68.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox68.ForeColor = Color.Red;
                mist_Materials += 1;
            }

            if (textBox67.Text == "Drill" || textBox67.Text == "drill")
            {
                textBox67.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox67.ForeColor = Color.Red;
                mist_Materials += 1;
            }

            if (textBox66.Text == "hummer" || textBox66.Text == "Hummer")
            {
                textBox66.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox66.ForeColor = Color.Red;
                mist_Materials += 1;
            }

            if (textBox52.Text == "drill" || textBox52.Text == "Drill")
            {
                textBox52.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox52.ForeColor = Color.Red;
                mist_Materials += 1;
            }

            if (textBox35.Text == "Blocks" || textBox35.Text == "blocks")
            {
                textBox35.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox35.ForeColor = Color.Red;
                mist_Materials += 1;
            }

            if (textBox34.Text == "and" || textBox34.Text == "And")
            {
                textBox34.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox34.ForeColor = Color.Red;
                mist_Materials += 1;
            }

            if (textBox76.Text == "Bricks" || textBox76.Text == "bricks")
            {
                textBox76.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox76.ForeColor = Color.Red;
                mist_Materials += 1;
            }

            if (textBox77.Text == "Tool" || textBox77.Text == "tool")
            {
                textBox77.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox77.ForeColor = Color.Red;
                mist_Materials += 1;
            }
            if (textBox78.Text == "kit" || textBox78.Text == "Kit")
            {
                textBox78.ForeColor = Color.Green;
                corr_Materials += 1;
            }
            else
            {
                textBox78.ForeColor = Color.Red;
                mist_Materials += 1;
            }
            MessageBox.Show("Your result for theme Materials is " + corr_Materials + " correct answers and " + mist_Materials + " incorrect answers.", "Your «Meterials» test results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result_corr += corr_Materials;
            result_mist += mist_Materials;
            Materials_Check.Enabled = false;
            db.Answers.Add(new Data.Answers()
            {
                AnswerThemeId = 10,
                Result_Corr = corr_Materials,
                Result_Incorr = mist_Materials,
                ThemeId = 5,
                UserId = id

            });
            db.SaveChanges();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            WMP.URL = @"Audios\Materials.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            WMP.URL = @"Audios\Elements.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            WMP.URL = @"Audios\Safety.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            WMP.URL = @"Audios\Wires.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            WMP.URL = @"Audios\Actions.mp3";
            if (n == 0)
            {
                n = 1;
                WMP.controls.stop();  // пауза на повторное нажатие
            }
            else
            {
                n = 0;
                WMP.controls.play();   //воспроизведение
            }
        }

        private void Safety_Check_Click(object sender, EventArgs e)
        {
            if (checkBox31.Checked == true || checkBox32.Checked == true || checkBox33.Checked == true || checkBox34.Checked == true)
            {
                checkBox33.ForeColor = Color.Green;
                checkBox34.ForeColor = Color.Red;
                checkBox32.ForeColor = Color.Red;
                checkBox31.ForeColor = Color.Red;
                if (checkBox33.Checked == true)
                {
                    corr_PT += 1;
                }
                else
                {
                    mist_PT += 1;
                }
            }

            if (checkBox35.Checked == true || checkBox36.Checked == true || checkBox37.Checked == true || checkBox38.Checked == true)
            {
                checkBox38.ForeColor = Color.Green;
                checkBox37.ForeColor = Color.Red;
                checkBox36.ForeColor = Color.Red;
                checkBox35.ForeColor = Color.Red;
                if (checkBox38.Checked == true)
                {
                    corr_Safety += 1;
                }
                else
                {
                    mist_Safety += 1;
                }
            }

            if (textBox94.Text == "Watch" || textBox94.Text == "watch")
            {
                textBox94.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox94.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox95.Text == "Out" || textBox95.Text == "out")
            {
                textBox95.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox95.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox92.Text == "cut" || textBox92.Text == "Cut")
            {
                textBox92.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox92.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox91.Text == "That" || textBox91.Text == "that")
            {
                textBox91.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox91.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox90.Text == "Wire" || textBox90.Text == "wire")
            {
                textBox90.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox90.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox89.Text == "live" || textBox89.Text == "Live")
            {
                textBox89.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox89.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox87.Text == "Wire" || textBox87.Text == "wire")
            {
                textBox87.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox87.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox83.Text == "Electric" || textBox83.Text == "electric")
            {
                textBox83.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox83.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox85.Text == "flash" || textBox85.Text == "Flash")
            {
                textBox85.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox85.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox88.Text == "think" || textBox88.Text == "Think")
            {
                textBox88.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox88.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox86.Text == "Of" || textBox86.Text == "of")
            {
                textBox86.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox86.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox84.Text == "that" || textBox84.Text == "That")
            {
                textBox84.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox84.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox82.Text == "Arc" || textBox82.Text == "Arc")
            {
                textBox82.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox82.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox79.Text == "Flash" || textBox79.Text == "flash")
            {
                textBox79.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox79.ForeColor = Color.Red;
                mist_Safety += 1;
            }

            if (textBox81.Text == "blanket" || textBox81.Text == "Blanket")
            {
                textBox81.ForeColor = Color.Green;
                corr_Safety += 1;
            }
            else
            {
                textBox81.ForeColor = Color.Red;
                mist_Safety += 1;
            }
            MessageBox.Show("Your result for theme Safety is " + corr_Safety + " correct answers and " + mist_Safety + " incorrect answers.", "Your «Safety» test results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result_corr += corr_Safety;
            result_mist += mist_Safety;
            Safety_Check.Enabled = false;
            db.Answers.Add(new Data.Answers()
            {
                AnswerThemeId = 10,
                Result_Corr = corr_Safety,
                Result_Incorr = mist_Safety,
                ThemeId = 7,
                UserId = id

            });
            db.SaveChanges();
        }

        private void Wires_Check_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true || radioButton2.Checked == true) && (radioButton3.Checked == true || radioButton4.Checked == true) && (radioButton5.Checked == true || radioButton6.Checked == true))
            {
                radioButton1.ForeColor = Color.Red;
                radioButton3.ForeColor = Color.Red;
                radioButton5.ForeColor = Color.Red;
                radioButton2.ForeColor = Color.Green;
                radioButton4.ForeColor = Color.Green;
                radioButton6.ForeColor = Color.Green;
                if (radioButton2.Checked == true && radioButton4.Checked == true && radioButton6.Checked == true)
                {
                    corr_Wires += 3;
                }
                else if ((radioButton2.Checked == true && radioButton4.Checked == true) || (radioButton4.Checked == true && radioButton6.Checked == true) || (radioButton2.Checked == true && radioButton6.Checked == true))
                {
                    corr_Wires += 2;
                    mist_Wires += 1;
                }
                else if (radioButton2.Checked == true || radioButton4.Checked == true || radioButton6.Checked == true)
                {
                    corr_Wires += 1;
                    mist_Wires += 2;
                }
                else
                {
                    mist_Wires += 3;
                }
            }

            if (textBox108.Text == "coming" || textBox108.Text == "Coming")
            {
                textBox108.ForeColor = Color.Green;
                corr_Wires += 1;
            }
            else
            {
                textBox108.ForeColor = Color.Red;
                mist_Wires += 1;
            }

            if (textBox109.Text == "out" || textBox109.Text == "Out")
            {
                textBox109.ForeColor = Color.Green;
                corr_Wires += 1;
            }
            else
            {
                textBox109.ForeColor = Color.Red;
                mist_Wires += 1;
            }

            if (textBox107.Text == "Great" || textBox107.Text == "great")
            {
                textBox107.ForeColor = Color.Green;
                corr_Wires += 1;
            }
            else
            {
                textBox107.ForeColor = Color.Red;
                mist_Wires += 1;
            }

            if (textBox106.Text == "condition" || textBox81.Text == "Condition")
            {
                textBox106.ForeColor = Color.Green;
                corr_Wires += 1;
            }
            else
            {
                textBox106.ForeColor = Color.Red;
                mist_Wires += 1;
            }

            if (textBox105.Text == "Let" || textBox105.Text == "let")
            {
                textBox105.ForeColor = Color.Green;
                corr_Wires += 1;
            }
            else
            {
                textBox105.ForeColor = Color.Red;
                mist_Wires += 1;
            }

            if (textBox104.Text == "me" || textBox104.Text == "Me")
            {
                textBox104.ForeColor = Color.Green;
                corr_Wires += 1;
            }
            else
            {
                textBox104.ForeColor = Color.Red;
                mist_Wires += 1;
            }

            if (textBox102.Text == "Look" || textBox102.Text == "look")
            {
                textBox102.ForeColor = Color.Green;
                corr_Wires += 1;
            }
            else
            {
                textBox102.ForeColor = Color.Red;
                mist_Wires += 1;
            }

            if (textBox98.Text == "insulation" || textBox98.Text == "Insulation")
            {
                textBox98.ForeColor = Color.Green;
                corr_Wires += 1;
            }
            else
            {
                textBox98.ForeColor = Color.Red;
                mist_Wires += 1;
            }

            if (textBox100.Text == "it" || textBox100.Text == "It")
            {
                textBox100.ForeColor = Color.Green;
                corr_Wires += 1;
            }
            else
            {
                textBox100.ForeColor = Color.Red;
                mist_Wires += 1;
            }

            if (textBox103.Text == "Look" || textBox103.Text == "look")
            {
                textBox103.ForeColor = Color.Green;
                corr_Wires += 1;
            }
            else
            {
                textBox103.ForeColor = Color.Red;
                mist_Wires += 1;
            }

            if (textBox101.Text == "Like" || textBox101.Text == "like")
            {
                textBox101.ForeColor = Color.Green;
                corr_Wires += 1;
            }
            else
            {
                textBox101.ForeColor = Color.Red;
                mist_Wires += 1;
            }

            if (textBox99.Text == "visible" || textBox99.Text == "Visible")
            {
                textBox99.ForeColor = Color.Green;
                corr_Wires += 1;
            }
            else
            {
                textBox99.ForeColor = Color.Red;
                mist_Wires += 1;
            }

            if (textBox97.Text == "wires" || textBox97.Text == "Wires")
            {
                textBox97.ForeColor = Color.Green;
                corr_Wires += 1;
            }
            else
            {
                textBox97.ForeColor = Color.Red;
                mist_Wires += 1;
            }
            MessageBox.Show("Your result for theme Wires if " + corr_Wires + " correct answers and " + mist_Wires + " incorrect answers.", "Your «Wires» test results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result_corr += corr_Wires;
            result_mist += mist_Wires;
            Wires_Check.Enabled = false;
            db.Answers.Add(new Data.Answers()
            {
                AnswerThemeId = 10,
                Result_Corr = corr_Wires,
                Result_Incorr = mist_Wires,
                ThemeId = 8,
                UserId = id
            });
            db.SaveChanges();
        }

        private void Elements_Check_Click(object sender, EventArgs e)
        {
            if ((radioButton13.Checked == true || radioButton14.Checked == true) && (radioButton15.Checked == true || radioButton16.Checked == true) && (radioButton17.Checked == true || radioButton18.Checked == true))
            {
                radioButton14.ForeColor = Color.Red;
                radioButton16.ForeColor = Color.Red;
                radioButton17.ForeColor = Color.Red;
                radioButton13.ForeColor = Color.Green;
                radioButton15.ForeColor = Color.Green;
                radioButton18.ForeColor = Color.Green;
                if (radioButton13.Checked == true && radioButton15.Checked == true && radioButton18.Checked == true)
                {
                    corr_Elements += 3;
                }
                else if ((radioButton13.Checked == true && radioButton15.Checked == true) || (radioButton13.Checked == true && radioButton18.Checked == true) || (radioButton15.Checked == true && radioButton18.Checked == true))
                {
                    corr_Elements += 2;
                    mist_Elements += 1;
                }
                else if (radioButton13.Checked == true || radioButton15.Checked == true || radioButton18.Checked == true)
                {
                    corr_Elements += 1;
                    mist_Elements += 2;
                }
                else
                {
                    mist_Elements += 3;
                }
            }

            if (textBox123.Text == "the" || textBox123.Text == "The")
            {
                textBox123.ForeColor = Color.Green;
                corr_Elements += 1;
            }
            else
            {
                textBox123.ForeColor = Color.Red;
                mist_Elements += 1;
            }

            if (textBox122.Text == "Difference" || textBox122.Text == "difference")
            {
                textBox122.ForeColor = Color.Green;
                corr_Elements += 1;
            }
            else
            {
                textBox122.ForeColor = Color.Red;
                mist_Elements += 1;
            }

            if (textBox121.Text == "between" || textBox121.Text == "Between")
            {
                textBox121.ForeColor = Color.Green;
                corr_Elements += 1;
            }
            else
            {
                textBox121.ForeColor = Color.Red;
                mist_Elements += 1;
            }

            if (textBox120.Text == "stand" || textBox120.Text == "Stand")
            {
                textBox120.ForeColor = Color.Green;
                corr_Elements += 1;
            }
            else
            {
                textBox120.ForeColor = Color.Red;
                mist_Elements += 1;
            }

            if (textBox119.Text == "for" || textBox119.Text == "For")
            {
                textBox119.ForeColor = Color.Green;
                corr_Elements += 1;
            }
            else
            {
                textBox119.ForeColor = Color.Red;
                mist_Elements += 1;
            }

            if (textBox118.Text == "current" || textBox118.Text == "Current")
            {
                textBox118.ForeColor = Color.Green;
                corr_Elements += 1;
            }
            else
            {
                textBox118.ForeColor = Color.Red;
                mist_Elements += 1;
            }

            if (textBox117.Text == "names" || textBox117.Text == "Names")
            {
                textBox117.ForeColor = Color.Green;
                corr_Elements += 1;
            }
            else
            {
                textBox117.ForeColor = Color.Red;
                mist_Elements += 1;
            }

            if (textBox116.Text == "Directions" || textBox116.Text == "directions")
            {
                textBox116.ForeColor = Color.Green;
                corr_Elements += 1;
            }
            else
            {
                textBox116.ForeColor = Color.Red;
                mist_Elements += 1;
            }

            if (textBox115.Text == "I")
            {
                textBox115.ForeColor = Color.Green;
                corr_Elements += 1;
            }
            else
            {
                textBox115.ForeColor = Color.Red;
                mist_Elements += 1;
            }

            if (textBox114.Text == "Understand" || textBox114.Text == "understand")
            {
                textBox114.ForeColor = Color.Green;
                corr_Elements += 1;
            }
            else
            {
                textBox114.ForeColor = Color.Red;
                mist_Elements += 1;
            }
            MessageBox.Show("Your result for theme Elements " + corr_Elements + " corrects answers and " + mist_Elements + " incorrect answers.", "Your «Elements» test results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result_corr += corr_Elements;
            result_mist += mist_Elements;
            Elements_Check.Enabled = false;
            db.Answers.Add(new Data.Answers()
            {
                AnswerThemeId = 10,
                Result_Corr = corr_Elements,
                Result_Incorr = mist_Elements,
                ThemeId = 6,
                UserId = id

            });
            db.SaveChanges();
        }

        private void Actions_Check_Click(object sender, EventArgs e)
        {
            if ((radioButton19.Checked == true || radioButton20.Checked == true) && (radioButton21.Checked == true || radioButton22.Checked == true) && (radioButton23.Checked == true || radioButton24.Checked == true))
            {
                radioButton22.ForeColor = Color.Red;
                radioButton23.ForeColor = Color.Red;
                radioButton19.ForeColor = Color.Red;
                radioButton20.ForeColor = Color.Green;
                radioButton21.ForeColor = Color.Green;
                radioButton24.ForeColor = Color.Green;
                if (radioButton20.Checked == true && radioButton21.Checked == true && radioButton24.Checked == true)
                {
                    corr_Actions += 3;

                }
                else if ((radioButton24.Checked == true && radioButton20.Checked == true) || (radioButton20.Checked == true && radioButton21.Checked == true) || (radioButton21.Checked == true && radioButton24.Checked == true))
                {
                    corr_Actions += 2;
                    mist_Actions += 1;
                }
                else if (radioButton24.Checked == true || radioButton21.Checked == true || radioButton20.Checked == true)
                {
                    corr_Actions += 1;
                    mist_Actions += 2;
                }
                else
                {
                    mist_Actions += 3;
                }
            }
            if (textBox131.Text == "damaged" || textBox131.Text == "Damaged")
            {
                textBox131.ForeColor = Color.Green;
                corr_Actions += 1;
            }
            else
            {
                textBox131.ForeColor = Color.Red;
                mist_Actions += 1;
            }

            if (textBox132.Text == "cable" || textBox132.Text == "Cable")
            {
                textBox132.ForeColor = Color.Green;
                corr_Actions += 1;
            }
            else
            {
                textBox132.ForeColor = Color.Red;
                mist_Actions += 1;
            }

            if (textBox130.Text == "turn" || textBox130.Text == "Turn")
            {
                textBox130.ForeColor = Color.Green;
                corr_Actions += 1;
            }
            else
            {
                textBox130.ForeColor = Color.Red;
                mist_Actions += 1;
            }

            if (textBox129.Text == "off" || textBox129.Text == "Off")
            {
                textBox129.ForeColor = Color.Green;
                corr_Actions += 1;
            }
            else
            {
                textBox129.ForeColor = Color.Red;
                mist_Actions += 1;
            }

            if (textBox128.Text == "strip" || textBox128.Text == "Strip")
            {
                textBox128.ForeColor = Color.Green;
                corr_Actions += 1;
            }
            else
            {
                textBox128.ForeColor = Color.Red;
                mist_Actions += 1;
            }

            if (textBox127.Text == "the" || textBox127.Text == "The")
            {
                textBox127.ForeColor = Color.Green;
                corr_Actions += 1;
            }
            else
            {
                textBox127.ForeColor = Color.Red;
                mist_Actions += 1;
            }

            if (textBox125.Text == "plastic" || textBox125.Text == "Plastic")
            {
                textBox125.ForeColor = Color.Green;
                corr_Actions += 1;
            }
            else
            {
                textBox125.ForeColor = Color.Red;
                mist_Actions += 1;
            }

            if (textBox93.Text == "burned" || textBox93.Text == "Burned")
            {
                textBox93.ForeColor = Color.Green;
                corr_Actions += 1;
            }
            else
            {
                textBox93.ForeColor = Color.Red;
                mist_Actions += 1;
            }

            if (textBox112.Text == "splice" || textBox112.Text == "Splice")
            {
                textBox112.ForeColor = Color.Green;
                corr_Actions += 1;
            }
            else
            {
                textBox112.ForeColor = Color.Red;
                mist_Actions += 1;
            }

            if (textBox126.Text == "the" || textBox126.Text == "The")
            {
                textBox126.ForeColor = Color.Green;
                corr_Actions += 1;
            }
            else
            {
                textBox126.ForeColor = Color.Red;
                mist_Actions += 1;
            }

            if (textBox113.Text == "wires" || textBox113.Text == "Wires")
            {
                textBox113.ForeColor = Color.Green;
                corr_Actions += 1;
            }
            else
            {
                textBox113.ForeColor = Color.Red;
                mist_Actions += 1;
            }

            if (textBox111.Text == "replace" || textBox111.Text == "Replace")
            {
                textBox111.ForeColor = Color.Green;
                corr_Actions += 1;
            }
            else
            {
                textBox111.ForeColor = Color.Red;
                mist_Actions += 1;
            }
            MessageBox.Show("Your result is " + corr_Actions + " correct answers and "+ mist_Actions + "incorrect answers.", "Your «Actions» test results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result_corr += corr_Actions;
            result_mist += mist_Actions;
            Actions_Check.Enabled = false;
            db.Answers.Add(new Data.Answers()
            {
                AnswerThemeId = 10,
                Result_Corr = corr_Actions,
                Result_Incorr = mist_Actions,
                ThemeId = 9,
                UserId = id

            });
            db.SaveChanges();
        }
        private void button32_Click(object sender, EventArgs e)
        {

            
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == Measur)
            {
                tabControl1.SelectedTab = Numbers;
            }
            else
            if (tabControl1.SelectedTab == PT)
            {
                tabControl1.SelectedTab = Measur;
            }
            else
            if (tabControl1.SelectedTab == T)
            {
                tabControl1.SelectedTab = PT;
            }
            else
            if (tabControl1.SelectedTab == Materials)
            {
                tabControl1.SelectedTab = T;
            }
            else
            if (tabControl1.SelectedTab == Elem)
            {
                tabControl1.SelectedTab = Materials;
            }
            else
            if (tabControl1.SelectedTab == Safe)
            {
                tabControl1.SelectedTab = Elem;
            }
            else
            if (tabControl1.SelectedTab == Wires)
            {
                tabControl1.SelectedTab = Safe;
            }
            else
            if (tabControl1.SelectedTab == Actions)
            {
                tabControl1.SelectedTab = Wires;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == Numbers)
            {
                tabControl1.SelectedTab = Measur;
            }
            else
            if (tabControl1.SelectedTab == Measur)
            {
                tabControl1.SelectedTab = PT;
            }
            else
            if (tabControl1.SelectedTab == PT)
            {
                tabControl1.SelectedTab = T;
            }
            else
            if (tabControl1.SelectedTab == T)
            {
                tabControl1.SelectedTab = Materials;
            }
            else
            if (tabControl1.SelectedTab == Materials)
            {
                tabControl1.SelectedTab = Elem;
            }
            else
            if (tabControl1.SelectedTab == Elem)
            {
                tabControl1.SelectedTab = Safe;
            }
            else
            if (tabControl1.SelectedTab == Safe)
            {
                tabControl1.SelectedTab = Wires;
            }
            else
            if (tabControl1.SelectedTab == Wires)
            {
                tabControl1.SelectedTab = Actions;
            }
        }

        private void Results_Click(object sender, EventArgs e)
        {
            ResultForm result = new ResultForm(corr_Numbers, mist_Numbers, corr_Measurements, mist_Measurements, corr_PT, mist_PT, corr_Tools, mist_Tools, corr_Materials, mist_Materials, corr_Elements, mist_Elements, corr_Safety, mist_Safety, corr_Wires, mist_Wires, corr_Actions, mist_Actions, id);
            Hide();
            result.ShowDialog();
            this.Close();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                System.Diagnostics.Process.Start("EnglishGuidance.chm");
            }
        }
    }
}
