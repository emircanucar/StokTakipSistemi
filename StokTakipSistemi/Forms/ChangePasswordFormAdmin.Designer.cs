namespace StokTakipSistemi.Forms
{
    partial class ChangePasswordFormAdmin
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
            panelRight = new Panel();
            buttonChangePassword = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            textBoxNewpassword = new TextBox();
            panel4 = new Panel();
            textBoxRePassword = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            panelTopBar.SuspendLayout();
            panelRight.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panelTopBar.Size = new Size(653, 40);
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
            btnMin.Location = new Point(573, 0);
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
            btnClose.Location = new Point(613, 0);
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
            // panelRight
            // 
            panelRight.BackColor = SystemColors.ControlLight;
            panelRight.BackgroundImage = Properties.Resources.bricks;
            panelRight.Controls.Add(buttonChangePassword);
            panelRight.Controls.Add(tableLayoutPanel2);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(0, 40);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(653, 383);
            panelRight.TabIndex = 3;
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
            buttonChangePassword.Location = new Point(247, 230);
            buttonChangePassword.Margin = new Padding(0);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(150, 55);
            buttonChangePassword.TabIndex = 10;
            buttonChangePassword.Text = "Şifre Değiştir";
            buttonChangePassword.UseVisualStyleBackColor = false;
            buttonChangePassword.Click += buttonChangePassword_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel4, 0, 3);
            tableLayoutPanel2.Controls.Add(panel5, 0, 1);
            tableLayoutPanel2.Controls.Add(panel6, 0, 4);
            tableLayoutPanel2.Location = new Point(203, 104);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(248, 106);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(textBoxNewpassword);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(248, 40);
            panel3.TabIndex = 0;
            // 
            // textBoxNewpassword
            // 
            textBoxNewpassword.BackColor = SystemColors.Control;
            textBoxNewpassword.BorderStyle = BorderStyle.None;
            textBoxNewpassword.Dock = DockStyle.Fill;
            textBoxNewpassword.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNewpassword.Location = new Point(5, 5);
            textBoxNewpassword.Margin = new Padding(0);
            textBoxNewpassword.Name = "textBoxNewpassword";
            textBoxNewpassword.PlaceholderText = "Yeni Şifre";
            textBoxNewpassword.Size = new Size(238, 27);
            textBoxNewpassword.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(textBoxRePassword);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 58);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(248, 40);
            panel4.TabIndex = 0;
            // 
            // textBoxRePassword
            // 
            textBoxRePassword.BackColor = SystemColors.Control;
            textBoxRePassword.BorderStyle = BorderStyle.None;
            textBoxRePassword.Dock = DockStyle.Fill;
            textBoxRePassword.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRePassword.Location = new Point(5, 5);
            textBoxRePassword.Margin = new Padding(0);
            textBoxRePassword.Name = "textBoxRePassword";
            textBoxRePassword.PlaceholderText = "Yeni Şifre Tekrar";
            textBoxRePassword.Size = new Size(238, 27);
            textBoxRePassword.TabIndex = 0;
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
            // ChangePasswordFormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(653, 423);
            ControlBox = false;
            Controls.Add(panelRight);
            Controls.Add(panelTopBar);
            MinimumSize = new Size(400, 250);
            Name = "ChangePasswordFormAdmin";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Load += ChangePasswordFormAdmin_Load;
            panelTopBar.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Button btnMin;
        private Button btnClose;
        private Label lblTopTitle;
        private Panel panelRight;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private TextBox textBoxNewpassword;
        private Panel panel4;
        private TextBox textBoxRePassword;
        private Panel panel5;
        private Panel panel6;
        private Button buttonChangePassword;
    }
}