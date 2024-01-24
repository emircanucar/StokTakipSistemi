namespace StokTakipSistemi.Forms.Childs
{
    partial class AddUserForm
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
            panelBottomBar = new Panel();
            buttonClear = new Button();
            buttonAdd = new Button();
            tablePanelForm = new TableLayoutPanel();
            panelTextBoxUser = new Panel();
            textBoxUserName = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            textBoxName = new TextBox();
            panel4 = new Panel();
            textBoxMail = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel11 = new Panel();
            textBoxProf = new TextBox();
            panel12 = new Panel();
            comboBoxRole = new ComboBox();
            panel13 = new Panel();
            panel14 = new Panel();
            panelContent = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel7 = new Panel();
            textBoxPassword = new TextBox();
            panel8 = new Panel();
            panelBottomBar.SuspendLayout();
            tablePanelForm.SuspendLayout();
            panelTextBoxUser.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panelContent.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panelBottomBar
            // 
            panelBottomBar.BackColor = Color.FromArgb(64, 66, 88);
            panelBottomBar.Controls.Add(buttonClear);
            panelBottomBar.Controls.Add(buttonAdd);
            panelBottomBar.Dock = DockStyle.Bottom;
            panelBottomBar.Location = new Point(0, 564);
            panelBottomBar.Name = "panelBottomBar";
            panelBottomBar.Size = new Size(976, 50);
            panelBottomBar.TabIndex = 8;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(101, 108, 144);
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Yu Gothic UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(132, 5);
            buttonClear.Margin = new Padding(0);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(112, 40);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Temizle";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(101, 108, 144);
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Yu Gothic UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(8, 5);
            buttonAdd.Margin = new Padding(0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 40);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Kaydet/Ekle";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // tablePanelForm
            // 
            tablePanelForm.Anchor = AnchorStyles.None;
            tablePanelForm.BackColor = Color.Transparent;
            tablePanelForm.ColumnCount = 1;
            tablePanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePanelForm.Controls.Add(panelTextBoxUser, 0, 0);
            tablePanelForm.Controls.Add(panel1, 0, 1);
            tablePanelForm.Location = new Point(145, 64);
            tablePanelForm.Name = "tablePanelForm";
            tablePanelForm.RowCount = 2;
            tablePanelForm.RowStyles.Add(new RowStyle());
            tablePanelForm.RowStyles.Add(new RowStyle());
            tablePanelForm.Size = new Size(248, 48);
            tablePanelForm.TabIndex = 1;
            // 
            // panelTextBoxUser
            // 
            panelTextBoxUser.BackColor = SystemColors.Control;
            panelTextBoxUser.Controls.Add(textBoxUserName);
            panelTextBoxUser.Dock = DockStyle.Bottom;
            panelTextBoxUser.Location = new Point(0, 0);
            panelTextBoxUser.Margin = new Padding(0);
            panelTextBoxUser.Name = "panelTextBoxUser";
            panelTextBoxUser.Padding = new Padding(5);
            panelTextBoxUser.Size = new Size(248, 40);
            panelTextBoxUser.TabIndex = 0;
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = SystemColors.Control;
            textBoxUserName.BorderStyle = BorderStyle.None;
            textBoxUserName.Dock = DockStyle.Fill;
            textBoxUserName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserName.Location = new Point(5, 5);
            textBoxUserName.Margin = new Padding(0);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Kullanıcı adı*";
            textBoxUserName.Size = new Size(238, 27);
            textBoxUserName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 37, 60);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 3);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Controls.Add(panel6, 0, 4);
            tableLayoutPanel1.Location = new Point(7, 187);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(248, 106);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(textBoxName);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(248, 40);
            panel3.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.Control;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Dock = DockStyle.Fill;
            textBoxName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(5, 5);
            textBoxName.Margin = new Padding(0);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Ad Soyad";
            textBoxName.Size = new Size(238, 27);
            textBoxName.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(textBoxMail);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 58);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(248, 40);
            panel4.TabIndex = 0;
            // 
            // textBoxMail
            // 
            textBoxMail.BackColor = SystemColors.Control;
            textBoxMail.BorderStyle = BorderStyle.None;
            textBoxMail.Dock = DockStyle.Fill;
            textBoxMail.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMail.Location = new Point(5, 5);
            textBoxMail.Margin = new Padding(0);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.PlaceholderText = "E-posta";
            textBoxMail.Size = new Size(238, 27);
            textBoxMail.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(11, 37, 60);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 40);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(248, 3);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(11, 37, 60);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 98);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(248, 3);
            panel6.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel11, 0, 0);
            tableLayoutPanel3.Controls.Add(panel12, 0, 3);
            tableLayoutPanel3.Controls.Add(panel13, 0, 1);
            tableLayoutPanel3.Controls.Add(panel14, 0, 4);
            tableLayoutPanel3.Location = new Point(277, 187);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(248, 106);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.Control;
            panel11.Controls.Add(textBoxProf);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(0, 0);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(5);
            panel11.Size = new Size(248, 40);
            panel11.TabIndex = 0;
            // 
            // textBoxProf
            // 
            textBoxProf.BackColor = SystemColors.Control;
            textBoxProf.BorderStyle = BorderStyle.None;
            textBoxProf.Dock = DockStyle.Fill;
            textBoxProf.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProf.Location = new Point(5, 5);
            textBoxProf.Margin = new Padding(0);
            textBoxProf.Name = "textBoxProf";
            textBoxProf.PlaceholderText = "Ünvan/Görev";
            textBoxProf.Size = new Size(238, 27);
            textBoxProf.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.Control;
            panel12.Controls.Add(comboBoxRole);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 58);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(5);
            panel12.Size = new Size(248, 40);
            panel12.TabIndex = 0;
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = SystemColors.Control;
            comboBoxRole.Dock = DockStyle.Fill;
            comboBoxRole.FlatStyle = FlatStyle.Flat;
            comboBoxRole.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "1", "2", "3" });
            comboBoxRole.Location = new Point(5, 5);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(238, 31);
            comboBoxRole.TabIndex = 1;
            comboBoxRole.Text = "Yetki*";
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(11, 37, 60);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(0, 40);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(248, 3);
            panel13.TabIndex = 0;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(11, 37, 60);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 98);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(248, 3);
            panel14.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(panel2);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(976, 614);
            panelContent.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(tablePanelForm);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(217, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 471);
            panel2.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel7, 0, 0);
            tableLayoutPanel2.Controls.Add(panel8, 0, 1);
            tableLayoutPanel2.Location = new Point(145, 128);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(248, 48);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.Controls.Add(textBoxPassword);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(248, 40);
            panel7.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.Control;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Dock = DockStyle.Fill;
            textBoxPassword.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(5, 5);
            textBoxPassword.Margin = new Padding(0);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Şifre*";
            textBoxPassword.Size = new Size(238, 27);
            textBoxPassword.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(11, 37, 60);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 40);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(248, 3);
            panel8.TabIndex = 0;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(976, 614);
            Controls.Add(panelBottomBar);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = " ";
            panelBottomBar.ResumeLayout(false);
            tablePanelForm.ResumeLayout(false);
            panelTextBoxUser.ResumeLayout(false);
            panelTextBoxUser.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelBottomBar;
        private Button buttonClear;
        private Button buttonAdd;
        private TableLayoutPanel tablePanelForm;
        private Panel panelTextBoxUser;
        private TextBox textBoxUserName;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private TextBox textBoxName;
        private Panel panel4;
        private TextBox textBoxMail;
        private Panel panel5;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel11;
        private TextBox textBoxProf;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panelContent;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel7;
        private TextBox textBoxPassword;
        private Panel panel8;
        private ComboBox comboBoxRole;
    }
}