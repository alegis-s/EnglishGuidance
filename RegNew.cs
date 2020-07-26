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
    public partial class RegNew : Form
    {
        public int id;
        DBCon db = new DBCon();
        
        public RegNew(int id)
        {
            InitializeComponent();
            this.id = id;
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            button1.ForeColor = ColorTranslator.FromHtml("#006600");
            button1.BackColor = ColorTranslator.FromHtml("#ffc685");
            button2.ForeColor = ColorTranslator.FromHtml("#006600");
            button2.BackColor = ColorTranslator.FromHtml("#ffc685");
            this.BackColor = ColorTranslator.FromHtml("#ffc685");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reg r = new Reg();
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty)
            {
                db.Users.Add(new Data.Users()
                {
                    UserId = id,
                    UserName = textBox1.Text,
                    UserGroup = textBox2.Text
                }) ;
                db.SaveChanges();
                r.Updating();
                Loading();
                Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        public void Loading()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in db.Users.Where(w => w.UserId == id).ToList())
            {
                dataGridView1.Rows.Add(item.UserId, item.UserName, item.UserGroup);
            }
        }
        public void Updating()
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                Data.Users u = db.Users.Find(int.Parse(item.Cells[0].Value.ToString()));
                u.UserName = item.Cells[1].Value.ToString();
                u.UserGroup = item.Cells[2].Value.ToString();
            }
            db.SaveChanges();
        }

        private void RegNew_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Loading();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Name";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Group";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

        private void RegNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reg r = new Reg();
            r.Updating();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter (e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Group")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void RegNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                System.Diagnostics.Process.Start("EnglishGuidance.chm");
            }
        }
    }
}
