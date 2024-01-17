namespace StokTakipSistemi.Forms
{
    partial class FirstForm
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
            panelTopBar = new Panel();
            btnMin = new Button();
            btnClose = new Button();
            lblTopTitle = new Label();
            panelLeft = new Panel();
            labelDate = new Label();
            lblProjectName = new Label();
            pictureBox1 = new PictureBox();
            panelButton = new Panel();
            btnLogOut = new Button();
            btnLogin = new Button();
            panelRight = new Panel();
            buttonInfo = new Button();
            panelTitle = new Panel();
            panel3 = new Panel();
            lblPageTitle = new Label();
            tablePanelForm = new TableLayoutPanel();
            labelInfo = new Label();
            panelTextBoxUser = new Panel();
            pictureBox2 = new PictureBox();
            textBoxUserName = new TextBox();
            buttonLogInto = new Button();
            panelSecureField = new Panel();
            buttonRefresh = new Button();
            panelSecure = new Panel();
            panel4 = new Panel();
            textBoxSecure = new TextBox();
            labelSecureCode = new Label();
            label2 = new Label();
            panelTextBoxPassword = new Panel();
            pictureBox3 = new PictureBox();
            textBoxPassword = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panelTopBar.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelButton.SuspendLayout();
            panelRight.SuspendLayout();
            panelTitle.SuspendLayout();
            tablePanelForm.SuspendLayout();
            panelTextBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelSecureField.SuspendLayout();
            panelSecure.SuspendLayout();
            panelTextBoxPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            panelTopBar.Size = new Size(1126, 40);
            panelTopBar.TabIndex = 1;
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
            btnMin.Location = new Point(1046, 0);
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
            btnClose.Location = new Point(1086, 0);
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
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(44, 46, 68);
            panelLeft.Controls.Add(labelDate);
            panelLeft.Controls.Add(lblProjectName);
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 40);
            panelLeft.MinimumSize = new Size(460, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(535, 662);
            panelLeft.TabIndex = 0;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.ForeColor = SystemColors.ControlDark;
            labelDate.Location = new Point(3, 3);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(42, 20);
            labelDate.TabIndex = 5;
            labelDate.Text = "Tarih";
            labelDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProjectName
            // 
            lblProjectName.Anchor = AnchorStyles.None;
            lblProjectName.AutoSize = true;
            lblProjectName.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjectName.ForeColor = Color.FromArgb(238, 244, 237);
            lblProjectName.Location = new Point(146, 109);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(247, 38);
            lblProjectName.TabIndex = 1;
            lblProjectName.Text = "Stok Takip Sistemi";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.ui;
            pictureBox1.Location = new Point(60, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelButton
            // 
            panelButton.Anchor = AnchorStyles.None;
            panelButton.Controls.Add(btnLogOut);
            panelButton.Controls.Add(btnLogin);
            panelButton.Location = new Point(144, 266);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(304, 125);
            panelButton.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(44, 46, 68);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.FromArgb(238, 244, 237);
            btnLogOut.Location = new Point(0, 68);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(304, 57);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Çıkış";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(44, 46, 68);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Dock = DockStyle.Top;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(238, 244, 237);
            btnLogin.Location = new Point(0, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(304, 57);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panelRight
            // 
            panelRight.BackColor = SystemColors.ControlLight;
            panelRight.Controls.Add(buttonInfo);
            panelRight.Controls.Add(panelTitle);
            panelRight.Controls.Add(panelButton);
            panelRight.Controls.Add(tablePanelForm);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(535, 40);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(591, 662);
            panelRight.TabIndex = 1;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInfo.BackColor = Color.Transparent;
            buttonInfo.Cursor = Cursors.Hand;
            buttonInfo.FlatAppearance.BorderSize = 0;
            buttonInfo.FlatStyle = FlatStyle.Flat;
            buttonInfo.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInfo.ForeColor = Color.FromArgb(238, 244, 237);
            buttonInfo.Image = Properties.Resources.info;
            buttonInfo.Location = new Point(546, 617);
            buttonInfo.Margin = new Padding(0);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(36, 36);
            buttonInfo.TabIndex = 8;
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // panelTitle
            // 
            panelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTitle.BackColor = Color.Transparent;
            panelTitle.Controls.Add(panel3);
            panelTitle.Controls.Add(lblPageTitle);
            panelTitle.Enabled = false;
            panelTitle.Location = new Point(17, 17);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(549, 45);
            panelTitle.TabIndex = 0;
            panelTitle.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 46, 68);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 42);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(549, 3);
            panel3.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.BackColor = Color.Transparent;
            lblPageTitle.Dock = DockStyle.Top;
            lblPageTitle.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPageTitle.ForeColor = Color.FromArgb(44, 46, 68);
            lblPageTitle.Location = new Point(0, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(549, 42);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Giriş Yap";
            // 
            // tablePanelForm
            // 
            tablePanelForm.Anchor = AnchorStyles.None;
            tablePanelForm.BackColor = Color.Transparent;
            tablePanelForm.ColumnCount = 1;
            tablePanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePanelForm.Controls.Add(labelInfo, 0, 8);
            tablePanelForm.Controls.Add(panelTextBoxUser, 0, 0);
            tablePanelForm.Controls.Add(buttonLogInto, 0, 9);
            tablePanelForm.Controls.Add(panelSecureField, 0, 6);
            tablePanelForm.Controls.Add(panelTextBoxPassword, 0, 3);
            tablePanelForm.Controls.Add(panel1, 0, 1);
            tablePanelForm.Controls.Add(panel2, 0, 4);
            tablePanelForm.Enabled = false;
            tablePanelForm.Location = new Point(121, 224);
            tablePanelForm.Name = "tablePanelForm";
            tablePanelForm.RowCount = 10;
            tablePanelForm.RowStyles.Add(new RowStyle());
            tablePanelForm.RowStyles.Add(new RowStyle());
            tablePanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tablePanelForm.RowStyles.Add(new RowStyle());
            tablePanelForm.RowStyles.Add(new RowStyle());
            tablePanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tablePanelForm.RowStyles.Add(new RowStyle());
            tablePanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tablePanelForm.RowStyles.Add(new RowStyle());
            tablePanelForm.RowStyles.Add(new RowStyle());
            tablePanelForm.Size = new Size(350, 274);
            tablePanelForm.TabIndex = 0;
            tablePanelForm.Visible = false;
            // 
            // labelInfo
            // 
            labelInfo.Dock = DockStyle.Fill;
            labelInfo.FlatStyle = FlatStyle.Flat;
            labelInfo.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelInfo.ForeColor = SystemColors.ControlDarkDark;
            labelInfo.Location = new Point(0, 164);
            labelInfo.Margin = new Padding(0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(350, 30);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "Güvenlik kodunu ilgili kutucuğa giriniz.\r\n";
            labelInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTextBoxUser
            // 
            panelTextBoxUser.BackColor = Color.Transparent;
            panelTextBoxUser.Controls.Add(pictureBox2);
            panelTextBoxUser.Controls.Add(textBoxUserName);
            panelTextBoxUser.Dock = DockStyle.Bottom;
            panelTextBoxUser.Location = new Point(0, 0);
            panelTextBoxUser.Margin = new Padding(0);
            panelTextBoxUser.Name = "panelTextBoxUser";
            panelTextBoxUser.Padding = new Padding(5);
            panelTextBoxUser.Size = new Size(350, 40);
            panelTextBoxUser.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.person;
            pictureBox2.Location = new Point(5, 5);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 30);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = SystemColors.ControlLight;
            textBoxUserName.BorderStyle = BorderStyle.None;
            textBoxUserName.Dock = DockStyle.Right;
            textBoxUserName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserName.Location = new Point(45, 5);
            textBoxUserName.Margin = new Padding(0);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Kullanıcı adı:";
            textBoxUserName.Size = new Size(300, 27);
            textBoxUserName.TabIndex = 0;
            // 
            // buttonLogInto
            // 
            buttonLogInto.BackColor = Color.FromArgb(44, 46, 68);
            buttonLogInto.Cursor = Cursors.Hand;
            buttonLogInto.Dock = DockStyle.Bottom;
            buttonLogInto.FlatAppearance.BorderSize = 0;
            buttonLogInto.FlatStyle = FlatStyle.Flat;
            buttonLogInto.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogInto.ForeColor = Color.FromArgb(238, 244, 237);
            buttonLogInto.Location = new Point(0, 214);
            buttonLogInto.Margin = new Padding(0);
            buttonLogInto.Name = "buttonLogInto";
            buttonLogInto.Size = new Size(350, 60);
            buttonLogInto.TabIndex = 0;
            buttonLogInto.Text = "Giriş Yap";
            buttonLogInto.UseVisualStyleBackColor = false;
            buttonLogInto.Click += buttonLogInto_Click;
            // 
            // panelSecureField
            // 
            panelSecureField.BackColor = SystemColors.ScrollBar;
            panelSecureField.Controls.Add(buttonRefresh);
            panelSecureField.Controls.Add(panelSecure);
            panelSecureField.Controls.Add(labelSecureCode);
            panelSecureField.Controls.Add(label2);
            panelSecureField.Dock = DockStyle.Bottom;
            panelSecureField.Location = new Point(0, 116);
            panelSecureField.Margin = new Padding(0);
            panelSecureField.Name = "panelSecureField";
            panelSecureField.Size = new Size(350, 43);
            panelSecureField.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = SystemColors.ScrollBar;
            buttonRefresh.Cursor = Cursors.Hand;
            buttonRefresh.Dock = DockStyle.Left;
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRefresh.ForeColor = Color.FromArgb(238, 244, 237);
            buttonRefresh.Image = Properties.Resources.refresh;
            buttonRefresh.Location = new Point(184, 0);
            buttonRefresh.Margin = new Padding(0);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(40, 43);
            buttonRefresh.TabIndex = 0;
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // panelSecure
            // 
            panelSecure.BackColor = Color.Transparent;
            panelSecure.Controls.Add(panel4);
            panelSecure.Controls.Add(textBoxSecure);
            panelSecure.Location = new Point(250, 7);
            panelSecure.Margin = new Padding(0);
            panelSecure.Name = "panelSecure";
            panelSecure.Size = new Size(95, 36);
            panelSecure.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(11, 37, 60);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 27);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(95, 3);
            panel4.TabIndex = 0;
            // 
            // textBoxSecure
            // 
            textBoxSecure.BackColor = SystemColors.ControlLight;
            textBoxSecure.BorderStyle = BorderStyle.None;
            textBoxSecure.Dock = DockStyle.Top;
            textBoxSecure.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSecure.Location = new Point(0, 0);
            textBoxSecure.Margin = new Padding(0, 0, 0, 5);
            textBoxSecure.Name = "textBoxSecure";
            textBoxSecure.Size = new Size(95, 27);
            textBoxSecure.TabIndex = 0;
            // 
            // labelSecureCode
            // 
            labelSecureCode.Dock = DockStyle.Left;
            labelSecureCode.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelSecureCode.Location = new Point(109, 0);
            labelSecureCode.Margin = new Padding(0);
            labelSecureCode.Name = "labelSecureCode";
            labelSecureCode.Size = new Size(75, 43);
            labelSecureCode.TabIndex = 0;
            labelSecureCode.Text = "secure";
            labelSecureCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(109, 43);
            label2.TabIndex = 0;
            label2.Text = "Güvenlik Kodu:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTextBoxPassword
            // 
            panelTextBoxPassword.BackColor = Color.Transparent;
            panelTextBoxPassword.Controls.Add(pictureBox3);
            panelTextBoxPassword.Controls.Add(textBoxPassword);
            panelTextBoxPassword.Dock = DockStyle.Bottom;
            panelTextBoxPassword.Location = new Point(0, 58);
            panelTextBoxPassword.Margin = new Padding(0);
            panelTextBoxPassword.Name = "panelTextBoxPassword";
            panelTextBoxPassword.Padding = new Padding(5);
            panelTextBoxPassword.Size = new Size(350, 40);
            panelTextBoxPassword.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = Properties.Resources.key;
            pictureBox3.Location = new Point(5, 5);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.ControlLight;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Dock = DockStyle.Right;
            textBoxPassword.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(45, 5);
            textBoxPassword.Margin = new Padding(0);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Şifre:";
            textBoxPassword.Size = new Size(300, 27);
            textBoxPassword.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 37, 60);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 3);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 37, 60);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 98);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 3);
            panel2.TabIndex = 0;
            // 
            // FirstForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 702);
            ControlBox = false;
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTopBar);
            IsMdiContainer = true;
            MinimumSize = new Size(1024, 576);
            Name = "FirstForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FirstForm_Load;
            panelTopBar.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelButton.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            tablePanelForm.ResumeLayout(false);
            panelTextBoxUser.ResumeLayout(false);
            panelTextBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelSecureField.ResumeLayout(false);
            panelSecure.ResumeLayout(false);
            panelSecure.PerformLayout();
            panelTextBoxPassword.ResumeLayout(false);
            panelTextBoxPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Label lblTopTitle;
        private Panel panelLeft;
        private PictureBox pictureBox1;
        private Label lblProjectName;
        private Button btnClose;
        private Button btnMin;
        private Panel panelButton;
        private Button btnLogOut;
        private Button btnLogin;
        private Panel panelRight;
        private TableLayoutPanel tablePanelForm;
        private Label labelInfo;
        private Panel panelTextBoxUser;
        private PictureBox pictureBox2;
        private TextBox textBoxUserName;
        private Button buttonLogInto;
        private Panel panelSecureField;
        private Button buttonRefresh;
        private Panel panelSecure;
        private Panel panel4;
        private TextBox textBoxSecure;
        private Label labelSecureCode;
        private Label label2;
        private Panel panelTextBoxPassword;
        private PictureBox pictureBox3;
        private TextBox textBoxPassword;
        private Panel panel1;
        private Panel panel2;
        private Panel panelTitle;
        private Panel panel3;
        private Label lblPageTitle;
        private Button buttonInfo;
        private Label labelDate;
    }
}