namespace StokTakipSistemi.Forms
{
    partial class MainForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm3));
            panelTopBar = new Panel();
            btnMin = new Button();
            btnClose = new Button();
            lblTopTitle = new Label();
            panelLeft = new Panel();
            panelNav = new Panel();
            buttonInfo = new Button();
            buttonProducts = new Button();
            panel2 = new Panel();
            buttonProfile = new Button();
            panel1 = new Panel();
            digitalClock1 = new Controls.DigitalClock();
            labelDate = new Label();
            pictureBox1 = new PictureBox();
            panelRight = new Panel();
            panelContent = new Panel();
            panelUser = new Panel();
            labelContentHead = new Label();
            labelUserName = new Label();
            buttonExit = new Button();
            panelTopBar.SuspendLayout();
            panelLeft.SuspendLayout();
            panelNav.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRight.SuspendLayout();
            panelUser.SuspendLayout();
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
            panelTopBar.Size = new Size(1262, 40);
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
            btnMin.Location = new Point(1182, 0);
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
            btnClose.Location = new Point(1222, 0);
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
            lblTopTitle.Size = new Size(181, 40);
            lblTopTitle.TabIndex = 0;
            lblTopTitle.Text = "Stok Takip Sistemi";
            lblTopTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(40, 42, 58);
            panelLeft.Controls.Add(panelNav);
            panelLeft.Controls.Add(panel1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 40);
            panelLeft.MinimumSize = new Size(250, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(280, 742);
            panelLeft.TabIndex = 0;
            // 
            // panelNav
            // 
            panelNav.AutoScroll = true;
            panelNav.Controls.Add(buttonInfo);
            panelNav.Controls.Add(buttonProducts);
            panelNav.Controls.Add(panel2);
            panelNav.Controls.Add(buttonProfile);
            panelNav.Dock = DockStyle.Fill;
            panelNav.Location = new Point(0, 205);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(280, 537);
            panelNav.TabIndex = 4;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonInfo.BackColor = Color.Transparent;
            buttonInfo.Cursor = Cursors.Hand;
            buttonInfo.FlatAppearance.BorderSize = 0;
            buttonInfo.FlatStyle = FlatStyle.Flat;
            buttonInfo.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInfo.ForeColor = Color.FromArgb(238, 244, 237);
            buttonInfo.Image = Properties.Resources.info30;
            buttonInfo.Location = new Point(9, 498);
            buttonInfo.Margin = new Padding(0);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(30, 29);
            buttonInfo.TabIndex = 16;
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click_1;
            // 
            // buttonProducts
            // 
            buttonProducts.BackColor = Color.FromArgb(71, 78, 104);
            buttonProducts.Cursor = Cursors.Hand;
            buttonProducts.Dock = DockStyle.Top;
            buttonProducts.FlatAppearance.BorderSize = 0;
            buttonProducts.FlatStyle = FlatStyle.Flat;
            buttonProducts.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProducts.ForeColor = Color.White;
            buttonProducts.Image = Properties.Resources.bar_chart_line_fill;
            buttonProducts.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProducts.Location = new Point(0, 62);
            buttonProducts.Margin = new Padding(0);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Padding = new Padding(10, 0, 0, 0);
            buttonProducts.Size = new Size(280, 51);
            buttonProducts.TabIndex = 8;
            buttonProducts.Text = "Ürünler/Stoklar";
            buttonProducts.UseVisualStyleBackColor = false;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 11);
            panel2.TabIndex = 7;
            // 
            // buttonProfile
            // 
            buttonProfile.BackColor = Color.FromArgb(71, 78, 104);
            buttonProfile.Cursor = Cursors.Hand;
            buttonProfile.Dock = DockStyle.Top;
            buttonProfile.FlatAppearance.BorderSize = 0;
            buttonProfile.FlatStyle = FlatStyle.Flat;
            buttonProfile.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProfile.ForeColor = Color.White;
            buttonProfile.Image = Properties.Resources.person_light;
            buttonProfile.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProfile.Location = new Point(0, 0);
            buttonProfile.Margin = new Padding(0);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Padding = new Padding(10, 0, 0, 0);
            buttonProfile.Size = new Size(280, 51);
            buttonProfile.TabIndex = 6;
            buttonProfile.Text = "Profil";
            buttonProfile.UseVisualStyleBackColor = false;
            buttonProfile.Click += buttonProfile_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(digitalClock1);
            panel1.Controls.Add(labelDate);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 205);
            panel1.TabIndex = 3;
            // 
            // digitalClock1
            // 
            digitalClock1.BackColor = Color.Transparent;
            digitalClock1.Location = new Point(215, 0);
            digitalClock1.Margin = new Padding(3, 4, 3, 4);
            digitalClock1.Name = "digitalClock1";
            digitalClock1.Size = new Size(65, 28);
            digitalClock1.TabIndex = 5;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.ForeColor = SystemColors.ControlDark;
            labelDate.Location = new Point(3, 3);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(42, 20);
            labelDate.TabIndex = 4;
            labelDate.Text = "Tarih";
            labelDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.monitor;
            pictureBox1.Location = new Point(21, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.BackColor = SystemColors.ControlLight;
            panelRight.Controls.Add(panelContent);
            panelRight.Controls.Add(panelUser);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(280, 40);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(982, 742);
            panelRight.TabIndex = 1;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.Transparent;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 51);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(982, 691);
            panelContent.TabIndex = 1;
            // 
            // panelUser
            // 
            panelUser.BackColor = Color.FromArgb(71, 78, 104);
            panelUser.Controls.Add(labelContentHead);
            panelUser.Controls.Add(labelUserName);
            panelUser.Controls.Add(buttonExit);
            panelUser.Dock = DockStyle.Top;
            panelUser.Location = new Point(0, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(982, 51);
            panelUser.TabIndex = 0;
            // 
            // labelContentHead
            // 
            labelContentHead.Dock = DockStyle.Left;
            labelContentHead.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelContentHead.ForeColor = Color.FromArgb(238, 244, 237);
            labelContentHead.Location = new Point(0, 0);
            labelContentHead.Name = "labelContentHead";
            labelContentHead.Padding = new Padding(10, 0, 0, 0);
            labelContentHead.Size = new Size(194, 51);
            labelContentHead.TabIndex = 1;
            labelContentHead.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelUserName
            // 
            labelUserName.Anchor = AnchorStyles.Right;
            labelUserName.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.ForeColor = Color.FromArgb(238, 244, 237);
            labelUserName.Location = new Point(753, 4);
            labelUserName.Name = "labelUserName";
            labelUserName.Padding = new Padding(10, 0, 0, 0);
            labelUserName.Size = new Size(181, 40);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "username";
            labelUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Right;
            buttonExit.BackColor = Color.Transparent;
            buttonExit.BackgroundImage = Properties.Resources.log_out;
            buttonExit.BackgroundImageLayout = ImageLayout.Zoom;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Location = new Point(942, 11);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(30, 29);
            buttonExit.TabIndex = 0;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // MainForm3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 782);
            ControlBox = false;
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTopBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MinimumSize = new Size(1024, 600);
            Name = "MainForm3";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm3_Load;
            panelTopBar.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelNav.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRight.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Label lblTopTitle;
        private Panel panelLeft;
        private Button btnClose;
        private Button btnMin;
        private Panel panelRight;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panelNav;
        private Button buttonProducts;
        private Panel panel2;
        private Button buttonProfile;
        private Label labelDate;
        private Panel panelUser;
        private Label labelUserName;
        private Button buttonExit;
        private Panel panelContent;
        private Button buttonInfo;
        private Label labelContentHead;
        private Controls.DigitalClock digitalClock1;
    }
}