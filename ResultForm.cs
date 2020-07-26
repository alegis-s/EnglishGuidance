using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EnglishGuidance.Data;
using System.Data.Entity;

namespace EnglishGuidance
{
    public partial class ResultForm : Form
    {
        DBCon db = new DBCon();
        public int mist_Numbers = 0;
        public int corr_Numbers = 0;
        public int mist_Measurements = 0;
        public int corr_Measurements = 0;
        public int mist_PT = 0;
        public int corr_PT = 0;
        public int mist_Tools = 0;
        public int corr_Tools = 0;
        public int mist_Materials = 0;
        public int corr_Materials = 0;
        public int mist_Elements = 0;
        public int corr_Elements = 0;
        public int mist_Safety = 0;
        public int corr_Safety = 0;
        public int mist_Wires = 0;
        public int corr_Wires = 0;
        public int mist_Actions = 0;
        public int corr_Actions = 0;
        public int id;
        public ResultForm(int corr_Numbers, int mist_Numbers, int corr_Measurements, int mist_Measurements, int corr_PT, int mist_PT, int corr_Tools, int mist_Tools, int corr_Materials, int mist_Materials, int corr_Elements, int mist_Elements, int corr_Safety, int mist_Safety, int corr_Wires, int mist_Wires, int corr_Actions, int mist_Actions, int id)
        {
            InitializeComponent();
            this.mist_Numbers = mist_Numbers;
            this.corr_Numbers = corr_Numbers;
            this.mist_Measurements = mist_Measurements;
            this.corr_Measurements = corr_Measurements;
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
            this.BackColor = ColorTranslator.FromHtml("#ffc685");
            label19.ForeColor = ColorTranslator.FromHtml("#006600");
            label20.ForeColor = ColorTranslator.FromHtml("#006600");
            label21.ForeColor = ColorTranslator.FromHtml("#006600");
            label22.ForeColor = ColorTranslator.FromHtml("#006600");
            label23.ForeColor = ColorTranslator.FromHtml("#006600");
            label24.ForeColor = ColorTranslator.FromHtml("#006600");
            label25.ForeColor = ColorTranslator.FromHtml("#006600");
            label26.ForeColor = ColorTranslator.FromHtml("#006600");
            label27.ForeColor = ColorTranslator.FromHtml("#006600");
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            label1.Text = "Number of correct answers:" + corr_Numbers;
            label2.Text = "Number of incorrect answers:" + mist_Numbers;
            chart1.Series.Add(new Series("Ser")
            {
                ChartType = SeriesChartType.Pie
            });
            chart1.Series[0].Color = Color.Green;
            chart1.Series[0].Points.AddXY("Correct", corr_Numbers);
            chart1.Series[0].Color = Color.Red;
            chart1.Series[0].Points.AddXY("Incorrect", mist_Numbers);

            label4.Text = "Number of correct answers:" + corr_Measurements;
            label3.Text = "Number of incorrect answers:" + mist_Measurements;
            chart2.Series.Add(new Series("Ser")
            {
                ChartType = SeriesChartType.Pie
            });
            chart2.Series[0].Color = Color.Green;
            chart2.Series[0].Points.AddXY("Correct", corr_Measurements);
            chart2.Series[0].Color = Color.Red;
            chart2.Series[0].Points.AddXY("Incorrect", mist_Measurements);

            label5.Text = "Number of correct answers:" + corr_PT;
            label6.Text = "Number of incorrect answers:" + mist_PT;
            chart7.Series.Add(new Series("Ser")
            {
                ChartType = SeriesChartType.Pie
            });
            chart7.Series[0].Color = Color.Green;
            chart7.Series[0].Points.AddXY("Correct", corr_PT);
            chart7.Series[0].Color = Color.Red;
            chart7.Series[0].Points.AddXY("Incorrect", mist_PT);

            label8.Text = "Number of correct answers:" + corr_Tools;
            label7.Text = "Number of incorrect answers:" + mist_Tools;
            chart3.Series.Add(new Series("Ser")
            {
                ChartType = SeriesChartType.Pie
            });
            chart3.Series[0].Color = Color.Green;
            chart3.Series[0].Points.AddXY("Correct", corr_Tools);
            chart3.Series[0].Color = Color.Red;
            chart3.Series[0].Points.AddXY("Incorrect", mist_Tools);

            label10.Text = "Number of correct answers:" + corr_Materials;
            label9.Text = "Number of incorrect answers:" + mist_Materials;
            chart4.Series.Add(new Series("Ser")
            {
                ChartType = SeriesChartType.Pie
            });
            chart4.Series[0].Color = Color.Green;
            chart4.Series[0].Points.AddXY("Correct", corr_Materials);
            chart4.Series[0].Color = Color.Red;
            chart4.Series[0].Points.AddXY("Incorrect", mist_Materials);

            label12.Text = "Number of correct answers:" + corr_Elements;
            label11.Text = "Number of incorrect answers:" + mist_Elements;
            chart8.Series.Add(new Series("Ser")
            {
                ChartType = SeriesChartType.Pie
            });
            chart8.Series[0].Color = Color.Green;
            chart8.Series[0].Points.AddXY("Correct", corr_Elements);
            chart8.Series[0].Color = Color.Red;
            chart8.Series[0].Points.AddXY("Incorrect", mist_Elements);

            label14.Text = "Number of correct answers:" + corr_Safety;
            label13.Text = "Number of incorrect answers:" + mist_Safety;
            chart5.Series.Add(new Series("Ser")
            {
                ChartType = SeriesChartType.Pie
            });
            chart5.Series[0].Color = Color.Green;
            chart5.Series[0].Points.AddXY("Correct", corr_Safety);
            chart5.Series[0].Color = Color.Red;
            chart5.Series[0].Points.AddXY("Incorrect", mist_Safety);

            label16.Text = "Number of correct answers:" + corr_Wires;
            label15.Text = "Number of incorrect answers:" + mist_Wires;
            chart6.Series.Add(new Series("Ser")
            {
                ChartType = SeriesChartType.Pie
            });
            chart6.Series[0].Color = Color.Green;
            chart6.Series[0].Points.AddXY("Correct", corr_Wires);
            chart6.Series[0].Color = Color.Red;
            chart6.Series[0].Points.AddXY("Incorrect", mist_Wires);

            label18.Text = "Number of correct answers:" + corr_Actions;
            label17.Text = "Number of incorrect answers:" + mist_Actions;
            chart9.Series.Add(new Series("Ser")
            {
                ChartType = SeriesChartType.Pie
            });
            chart9.Series[0].Color = Color.Green;
            chart9.Series[0].Points.AddXY("Correct", corr_Actions);
            chart9.Series[0].Color = Color.Red;
            chart9.Series[0].Points.AddXY("Incorrect", mist_Actions);
            Loading();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Hide();
            f1.ShowDialog();
            this.Close();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Login";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.PasswordChar = '\0';
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Login")
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '\u25CF';
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if ((textBox1.Text == "teacher" || textBox1.Text == "Teacher") || (textBox2.Text == "teacher_123"))
            {
                dataGridView1.Visible = true;
                checkBox1.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button2.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                chart1.Visible = false;
                chart2.Visible = false;
                chart3.Visible = false;
                chart4.Visible = false;
                chart5.Visible = false;
                chart6.Visible = false;
                chart7.Visible = false;
                chart8.Visible = false;
                chart9.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button2.Visible = true;
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                chart1.Visible = true;
                chart2.Visible = true;
                chart3.Visible = true;
                chart4.Visible = true;
                chart5.Visible = true;
                chart6.Visible = true;
                chart7.Visible = true;
                chart8.Visible = true;
                chart9.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button2.Visible = false;
            } 
        }
        public void Loading()
        {
            dataGridView1.Rows.Clear();
            using (DBCon db = new DBCon())
            {
                var answ = db.Answers
                    .Include(a => a.User)
                    .Include(a => a.Theme)
                    .ToList();
                foreach (var a in answ)
                {
                    dataGridView1.Rows.Add(a.User?.UserName, a.User?.UserGroup, a.Theme?.ThemeName, a.Result_Corr, a.Result_Incorr);
                }
            }  
        }

        private void ResultForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
               System.Diagnostics.Process.Start("EnglishGuidance.chm");
            }
        }
    }
}
