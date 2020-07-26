namespace EnglishGuidance
{
    partial class Reg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.change_button = new System.Windows.Forms.Button();
            this.quit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 284);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "№";
            this.Column3.Name = "Column3";
            this.Column3.Width = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Group";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "It\'s me!";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 75;
            // 
            // change_button
            // 
            this.change_button.BackgroundImage = global::EnglishGuidance.Properties.Resources.Reg1;
            this.change_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.change_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.change_button.Location = new System.Drawing.Point(12, 302);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(120, 117);
            this.change_button.TabIndex = 8;
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // quit_button
            // 
            this.quit_button.BackgroundImage = global::EnglishGuidance.Properties.Resources.Рисунок10;
            this.quit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.quit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quit_button.Location = new System.Drawing.Point(298, 302);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(120, 117);
            this.quit_button.TabIndex = 2;
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 429);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quit_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 468);
            this.MinimumSize = new System.Drawing.Size(450, 468);
            this.Name = "Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reg_FormClosing);
            this.Load += new System.EventHandler(this.Reg_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Reg_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button change_button;
    }
}