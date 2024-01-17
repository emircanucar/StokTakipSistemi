namespace StokTakipSistemi.Forms.Childs
{
    partial class UsersForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelContent = new Panel();
            dataGridView1 = new DataGridView();
            panelBottom = new Panel();
            buttonRefresh = new Button();
            buttonDeleteUser = new Button();
            buttonViewUser = new Button();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(dataGridView1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1062, 638);
            panelContent.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(74, 76, 98);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(101, 108, 134);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(61, 68, 84);
            dataGridViewCellStyle5.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 40;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(84, 86, 108);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(101, 108, 134);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1062, 638);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(64, 66, 88);
            panelBottom.Controls.Add(buttonRefresh);
            panelBottom.Controls.Add(buttonDeleteUser);
            panelBottom.Controls.Add(buttonViewUser);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 588);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1062, 50);
            panelBottom.TabIndex = 8;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.FromArgb(101, 108, 144);
            buttonRefresh.Cursor = Cursors.Hand;
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Yu Gothic UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRefresh.ForeColor = Color.FromArgb(15, 255, 255, 255);
            buttonRefresh.Location = new Point(280, 5);
            buttonRefresh.Margin = new Padding(0);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(112, 40);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Yenile";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.BackColor = Color.FromArgb(101, 108, 144);
            buttonDeleteUser.Cursor = Cursors.Hand;
            buttonDeleteUser.FlatAppearance.BorderSize = 0;
            buttonDeleteUser.FlatStyle = FlatStyle.Flat;
            buttonDeleteUser.Font = new Font("Yu Gothic UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteUser.ForeColor = Color.FromArgb(15, 255, 255, 255);
            buttonDeleteUser.Location = new Point(158, 5);
            buttonDeleteUser.Margin = new Padding(0);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(112, 40);
            buttonDeleteUser.TabIndex = 6;
            buttonDeleteUser.Text = "Kullanıcı Sil";
            buttonDeleteUser.UseVisualStyleBackColor = false;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // buttonViewUser
            // 
            buttonViewUser.BackColor = Color.FromArgb(101, 108, 144);
            buttonViewUser.Cursor = Cursors.Hand;
            buttonViewUser.FlatAppearance.BorderSize = 0;
            buttonViewUser.FlatStyle = FlatStyle.Flat;
            buttonViewUser.Font = new Font("Yu Gothic UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonViewUser.ForeColor = Color.FromArgb(15, 255, 255, 255);
            buttonViewUser.Location = new Point(9, 5);
            buttonViewUser.Margin = new Padding(0);
            buttonViewUser.Name = "buttonViewUser";
            buttonViewUser.Size = new Size(139, 40);
            buttonViewUser.TabIndex = 6;
            buttonViewUser.Text = "Düzenle/Görüntüle";
            buttonViewUser.UseVisualStyleBackColor = false;
            buttonViewUser.Click += buttonViewUser_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1062, 638);
            Controls.Add(panelBottom);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += UsersForm_Load;
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContent;
        private Panel panelBottom;
        private Button buttonViewUser;
        private Button buttonDeleteUser;
        private DataGridView dataGridView1;
        private Button buttonRefresh;
    }
}