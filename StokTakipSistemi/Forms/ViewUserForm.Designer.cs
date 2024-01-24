namespace StokTakipSistemi.Forms
{
    partial class ViewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUserForm));
            panelTopBar = new Panel();
            btnMin = new Button();
            btnClose = new Button();
            lblTopTitle = new Label();
            panel10 = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            buttonEdit = new Button();
            panelContent = new Panel();
            panel = new Panel();
            panelForm = new Panel();
            labelDontChangePW = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel11 = new Panel();
            textBoxProf = new TextBox();
            panel12 = new Panel();
            comboBoxRole = new ComboBox();
            panel13 = new Panel();
            panel14 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelTextBoxUser = new Panel();
            textBoxUserName = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            textBoxName = new TextBox();
            panel4 = new Panel();
            textBoxMail = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            buttonChangePassword = new Button();
            pictureBoxUser = new PictureBox();
            panelTopBar.SuspendLayout();
            panel10.SuspendLayout();
            panelContent.SuspendLayout();
            panel.SuspendLayout();
            panelForm.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelTextBoxUser.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(64, 66, 88);
            panelTopBar.Controls.Add(btnMin);
            panelTopBar.Controls.Add(btnClose);
            panelTopBar.Controls.Add(lblTopTitle);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Margin = new Padding(0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1048, 40);
            panelTopBar.TabIndex = 2;
            panelTopBar.MouseDown += panelTopBar_MouseDown;
            panelTopBar.MouseMove += panelTopBar_MouseMove;
            // 
            // btnMin
            // 
            btnMin.Dock = DockStyle.Right;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.ForeColor = Color.FromArgb(238, 244, 237);
            btnMin.Location = new Point(968, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(40, 40);
            btnMin.TabIndex = 10;
            btnMin.TabStop = false;
            btnMin.Text = "ꟷ\r\n";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(238, 244, 237);
            btnClose.Location = new Point(1008, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 9;
            btnClose.TabStop = false;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTopTitle
            // 
            lblTopTitle.Dock = DockStyle.Left;
            lblTopTitle.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopTitle.ForeColor = Color.FromArgb(238, 244, 237);
            lblTopTitle.Location = new Point(0, 0);
            lblTopTitle.Name = "lblTopTitle";
            lblTopTitle.Padding = new Padding(10, 0, 0, 0);
            lblTopTitle.Size = new Size(180, 40);
            lblTopTitle.TabIndex = 0;
            lblTopTitle.Text = "Stok Takip Sistemi";
            lblTopTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(64, 66, 88);
            panel10.Controls.Add(buttonCancel);
            panel10.Controls.Add(buttonSave);
            panel10.Controls.Add(buttonEdit);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 601);
            panel10.Name = "panel10";
            panel10.Size = new Size(1048, 50);
            panel10.TabIndex = 10;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(101, 108, 144);
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.Enabled = false;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Yu Gothic UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(257, 5);
            buttonCancel.Margin = new Padding(0);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 40);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "İptal";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(101, 108, 144);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Enabled = false;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Yu Gothic UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(133, 5);
            buttonSave.Margin = new Padding(0);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 40);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(101, 108, 144);
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Yu Gothic UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.FromArgb(15, 255, 255, 255);
            buttonEdit.Location = new Point(9, 5);
            buttonEdit.Margin = new Padding(0);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(112, 40);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Düzenle";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(panel);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 40);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1048, 611);
            panelContent.TabIndex = 9;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top;
            panel.Controls.Add(panelForm);
            panel.Controls.Add(buttonChangePassword);
            panel.Controls.Add(pictureBoxUser);
            panel.Location = new Point(257, 3);
            panel.Name = "panel";
            panel.Size = new Size(540, 582);
            panel.TabIndex = 11;
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top;
            panelForm.Controls.Add(labelDontChangePW);
            panelForm.Controls.Add(tableLayoutPanel3);
            panelForm.Controls.Add(tableLayoutPanel1);
            panelForm.Controls.Add(tableLayoutPanel2);
            panelForm.Enabled = false;
            panelForm.Location = new Point(0, 265);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(540, 228);
            panelForm.TabIndex = 12;
            // 
            // labelDontChangePW
            // 
            labelDontChangePW.Anchor = AnchorStyles.Bottom;
            labelDontChangePW.AutoSize = true;
            labelDontChangePW.Font = new Font("Yu Gothic UI Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDontChangePW.Location = new Point(146, 1);
            labelDontChangePW.Name = "labelDontChangePW";
            labelDontChangePW.Size = new Size(170, 19);
            labelDontChangePW.TabIndex = 10;
            labelDontChangePW.Text = "Kullanıcı adı değiştirilemez!";
            labelDontChangePW.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel11, 0, 0);
            tableLayoutPanel3.Controls.Add(panel12, 0, 3);
            tableLayoutPanel3.Controls.Add(panel13, 0, 1);
            tableLayoutPanel3.Controls.Add(panel14, 0, 4);
            tableLayoutPanel3.Controls.Add(label1, 0, 5);
            tableLayoutPanel3.Location = new Point(278, 90);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(248, 130);
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
            comboBoxRole.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxRole.ForeColor = Color.DimGray;
            comboBoxRole.FormatString = "N2";
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.ItemHeight = 20;
            comboBoxRole.Items.AddRange(new object[] { "1", "2", "3" });
            comboBoxRole.Location = new Point(5, 5);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(238, 28);
            comboBoxRole.TabIndex = 0;
            comboBoxRole.Tag = "";
            comboBoxRole.Text = "Yetki";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 101);
            label1.Name = "label1";
            label1.Size = new Size(171, 19);
            label1.TabIndex = 1;
            label1.Text = "Yetki: 1-Admin 2-Orta 3-Az";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelTextBoxUser, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Location = new Point(146, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(248, 48);
            tableLayoutPanel1.TabIndex = 1;
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
            textBoxUserName.Enabled = false;
            textBoxUserName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserName.Location = new Point(5, 5);
            textBoxUserName.Margin = new Padding(0);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Kullanıcı adı";
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel4, 0, 3);
            tableLayoutPanel2.Controls.Add(panel5, 0, 1);
            tableLayoutPanel2.Controls.Add(panel6, 0, 4);
            tableLayoutPanel2.Location = new Point(14, 90);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(248, 106);
            tableLayoutPanel2.TabIndex = 7;
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
            // buttonChangePassword
            // 
            buttonChangePassword.Anchor = AnchorStyles.None;
            buttonChangePassword.BackColor = Color.FromArgb(44, 46, 68);
            buttonChangePassword.Cursor = Cursors.Hand;
            buttonChangePassword.FlatAppearance.BorderSize = 0;
            buttonChangePassword.FlatStyle = FlatStyle.Flat;
            buttonChangePassword.Font = new Font("Yu Gothic UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChangePassword.ForeColor = Color.FromArgb(238, 244, 237);
            buttonChangePassword.Location = new Point(188, 496);
            buttonChangePassword.Margin = new Padding(0);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(150, 40);
            buttonChangePassword.TabIndex = 9;
            buttonChangePassword.Text = "Şifre Değiştir";
            buttonChangePassword.UseVisualStyleBackColor = false;
            buttonChangePassword.Click += buttonChangePassword_Click;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Anchor = AnchorStyles.None;
            pictureBoxUser.Image = Properties.Resources.personprofile;
            pictureBoxUser.Location = new Point(173, 11);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(183, 182);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUser.TabIndex = 4;
            pictureBoxUser.TabStop = false;
            // 
            // ViewUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1048, 651);
            ControlBox = false;
            Controls.Add(panel10);
            Controls.Add(panelContent);
            Controls.Add(panelTopBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewUserForm";
            Load += ViewUserForm_Load;
            panelTopBar.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panel.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelTextBoxUser.ResumeLayout(false);
            panelTextBoxUser.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Button btnMin;
        private Button btnClose;
        private Label lblTopTitle;
        private Panel panel10;
        private Button buttonCancel;
        private Button buttonSave;
        private Button buttonEdit;
        private Panel panelContent;
        private Panel panel;
        private Button buttonChangePassword;
        private PictureBox pictureBoxUser;
        private Panel panelForm;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel11;
        private TextBox textBoxProf;
        private Panel panel12;
        private ComboBox comboBoxRole;
        private Panel panel13;
        private Panel panel14;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelTextBoxUser;
        private TextBox textBoxUserName;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private TextBox textBoxName;
        private Panel panel4;
        private TextBox textBoxMail;
        private Panel panel5;
        private Panel panel6;
        private Label labelDontChangePW;
    }
}