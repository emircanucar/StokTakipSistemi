namespace StokTakipSistemi.Forms
{
    partial class AboutForm
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
            label1 = new Label();
            panelTopBar.SuspendLayout();
            panelRight.SuspendLayout();
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
            panelTopBar.Size = new Size(443, 40);
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
            btnMin.Location = new Point(363, 0);
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
            btnClose.Location = new Point(403, 0);
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
            panelRight.Controls.Add(label1);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(0, 40);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(443, 237);
            panelRight.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 51);
            label1.Name = "label1";
            label1.Size = new Size(305, 132);
            label1.TabIndex = 1;
            label1.Text = "Bu uygulama bir stok takip uygulamasıdır.\r\nEmircan UÇAR tarafından geliştirilmiştir.\r\n\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 277);
            ControlBox = false;
            Controls.Add(panelRight);
            Controls.Add(panelTopBar);
            MinimumSize = new Size(400, 250);
            Name = "AboutForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            panelTopBar.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Button btnMin;
        private Button btnClose;
        private Label lblTopTitle;
        private Panel panelRight;
        private Label label1;
    }
}