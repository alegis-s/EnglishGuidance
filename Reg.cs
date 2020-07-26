using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EnglishGuidance
{
    public partial class Reg : Form
    {
        DBCon db = new DBCon();
        public Reg()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#ffc685");
        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            Form1 MainMenu = new Form1();
            Hide();
            MainMenu.ShowDialog();
            this.Close();
        }
        private void Reg_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Loading();
        }

        private void registrate_button_Click(object sender, EventArgs e)
        {
            change_button.Visible = true;
            dataGridView1.Visible = true;
        }

        public void Loading()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in db.Users.ToList())
            {
                dataGridView1.Rows.Add(item.UserId, item.UserName, item.UserGroup);
            }
        }
        public void Updating()
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                int id = Convert.ToInt32(item.Cells[0].Value);
                Data.Users u = db.Users.FirstOrDefault(f => f.UserId == id);
                u.UserName = item.Cells[1].Value.ToString();
                u.UserGroup = item.Cells[2].Value.ToString();
            }
            db.SaveChanges();
        }

        private void Reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            //    sqlConnection.Close();
            
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            RegNew form = new RegNew(id);
            form.ShowDialog();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Form2 form = new Form2(id);   //TestForm form = new TestForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                Hide();
                form.ShowDialog();

            }
        }

        private void Reg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                System.Diagnostics.Process.Start("EnglishGuidance.chm");
            }
        }
    }
}
