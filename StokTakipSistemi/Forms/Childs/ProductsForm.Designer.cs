﻿namespace StokTakipSistemi.Forms.Childs
{
    partial class ProductsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelContent = new Panel();
            panelBottom = new Panel();
            buttonRefresh = new Button();
            buttonDeleteProduct = new Button();
            buttonViewProductDetail = new Button();
            tabPage1 = new TabPage();
            panelProductInfo = new Panel();
            labelProductTitle = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel16 = new Panel();
            panel9 = new Panel();
            numericUpDown1 = new NumericUpDown();
            buttonIncrease = new Button();
            buttonDecrease = new Button();
            buttonSave = new Button();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            panelContent.SuspendLayout();
            panelBottom.SuspendLayout();
            tabPage1.SuspendLayout();
            panelProductInfo.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(tabControl1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(964, 636);
            panelContent.TabIndex = 7;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(64, 66, 88);
            panelBottom.Controls.Add(buttonRefresh);
            panelBottom.Controls.Add(buttonDeleteProduct);
            panelBottom.Controls.Add(buttonViewProductDetail);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 586);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(964, 50);
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
            buttonRefresh.Location = new Point(283, 6);
            buttonRefresh.Margin = new Padding(0);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(112, 40);
            buttonRefresh.TabIndex = 8;
            buttonRefresh.Text = "Yenile";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.BackColor = Color.FromArgb(101, 108, 144);
            buttonDeleteProduct.Cursor = Cursors.Hand;
            buttonDeleteProduct.FlatAppearance.BorderSize = 0;
            buttonDeleteProduct.FlatStyle = FlatStyle.Flat;
            buttonDeleteProduct.Font = new Font("Yu Gothic UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteProduct.ForeColor = Color.FromArgb(15, 255, 255, 255);
            buttonDeleteProduct.Location = new Point(162, 5);
            buttonDeleteProduct.Margin = new Padding(0);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(112, 40);
            buttonDeleteProduct.TabIndex = 7;
            buttonDeleteProduct.Text = "Ürün Sil";
            buttonDeleteProduct.UseVisualStyleBackColor = false;
            buttonDeleteProduct.Click += buttonDeleteProduct_Click;
            // 
            // buttonViewProductDetail
            // 
            buttonViewProductDetail.BackColor = Color.FromArgb(101, 108, 144);
            buttonViewProductDetail.Cursor = Cursors.Hand;
            buttonViewProductDetail.FlatAppearance.BorderSize = 0;
            buttonViewProductDetail.FlatStyle = FlatStyle.Flat;
            buttonViewProductDetail.Font = new Font("Yu Gothic UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonViewProductDetail.ForeColor = Color.FromArgb(15, 255, 255, 255);
            buttonViewProductDetail.Location = new Point(9, 5);
            buttonViewProductDetail.Margin = new Padding(0);
            buttonViewProductDetail.Name = "buttonViewProductDetail";
            buttonViewProductDetail.Size = new Size(144, 40);
            buttonViewProductDetail.TabIndex = 6;
            buttonViewProductDetail.Text = "Düzenle/Görüntüle";
            buttonViewProductDetail.UseVisualStyleBackColor = false;
            buttonViewProductDetail.Click += buttonViewProductDetail_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(panelProductInfo);
            tabPage1.Location = new Point(4, 56);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(956, 576);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ürünler";
            // 
            // panelProductInfo
            // 
            panelProductInfo.BackColor = SystemColors.ControlLight;
            panelProductInfo.Controls.Add(buttonSave);
            panelProductInfo.Controls.Add(buttonDecrease);
            panelProductInfo.Controls.Add(buttonIncrease);
            panelProductInfo.Controls.Add(tableLayoutPanel4);
            panelProductInfo.Controls.Add(labelProductTitle);
            panelProductInfo.Dock = DockStyle.Bottom;
            panelProductInfo.Location = new Point(0, 348);
            panelProductInfo.Name = "panelProductInfo";
            panelProductInfo.Size = new Size(956, 228);
            panelProductInfo.TabIndex = 1;
            // 
            // labelProductTitle
            // 
            labelProductTitle.Anchor = AnchorStyles.None;
            labelProductTitle.AutoSize = true;
            labelProductTitle.Font = new Font("Yu Gothic UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductTitle.Location = new Point(417, 9);
            labelProductTitle.Name = "labelProductTitle";
            labelProductTitle.Size = new Size(118, 35);
            labelProductTitle.TabIndex = 0;
            labelProductTitle.Text = "Ürün Adı";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.None;
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel9, 0, 0);
            tableLayoutPanel4.Controls.Add(panel16, 0, 1);
            tableLayoutPanel4.Location = new Point(353, 60);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel4.Size = new Size(248, 46);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(11, 37, 60);
            panel16.Dock = DockStyle.Top;
            panel16.Location = new Point(0, 40);
            panel16.Margin = new Padding(0);
            panel16.Name = "panel16";
            panel16.Size = new Size(248, 3);
            panel16.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Control;
            panel9.Controls.Add(numericUpDown1);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(5);
            panel9.Size = new Size(248, 40);
            panel9.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.Control;
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(3, 10);
            numericUpDown1.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(270, 30);
            numericUpDown1.TabIndex = 0;
            // 
            // buttonIncrease
            // 
            buttonIncrease.Anchor = AnchorStyles.None;
            buttonIncrease.BackColor = Color.FromArgb(101, 108, 144);
            buttonIncrease.Cursor = Cursors.Hand;
            buttonIncrease.FlatAppearance.BorderSize = 0;
            buttonIncrease.FlatStyle = FlatStyle.Flat;
            buttonIncrease.Font = new Font("Lucida Sans Unicode", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIncrease.ForeColor = Color.FromArgb(15, 255, 255, 255);
            buttonIncrease.Location = new Point(614, 61);
            buttonIncrease.Margin = new Padding(0);
            buttonIncrease.Name = "buttonIncrease";
            buttonIncrease.Size = new Size(45, 45);
            buttonIncrease.TabIndex = 11;
            buttonIncrease.Text = "+";
            buttonIncrease.UseVisualStyleBackColor = false;
            buttonIncrease.Click += buttonIncrease_Click;
            // 
            // buttonDecrease
            // 
            buttonDecrease.Anchor = AnchorStyles.None;
            buttonDecrease.BackColor = Color.FromArgb(101, 108, 144);
            buttonDecrease.Cursor = Cursors.Hand;
            buttonDecrease.FlatAppearance.BorderSize = 0;
            buttonDecrease.FlatStyle = FlatStyle.Flat;
            buttonDecrease.Font = new Font("Lucida Sans Unicode", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDecrease.ForeColor = Color.FromArgb(15, 255, 255, 255);
            buttonDecrease.Location = new Point(296, 61);
            buttonDecrease.Margin = new Padding(0);
            buttonDecrease.Name = "buttonDecrease";
            buttonDecrease.Size = new Size(45, 45);
            buttonDecrease.TabIndex = 11;
            buttonDecrease.Text = "-";
            buttonDecrease.UseVisualStyleBackColor = false;
            buttonDecrease.Click += buttonDecrease_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.None;
            buttonSave.BackColor = Color.FromArgb(101, 108, 144);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Yu Gothic UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.FromArgb(15, 255, 255, 255);
            buttonSave.Location = new Point(417, 132);
            buttonSave.Margin = new Padding(0);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 40);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(74, 76, 98);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(101, 108, 134);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(61, 68, 84);
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 40;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(84, 86, 108);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(101, 108, 134);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(956, 348);
            dataGridView1.TabIndex = 2;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(20, 15);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(964, 636);
            tabControl1.TabIndex = 0;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(964, 636);
            Controls.Add(panelBottom);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += ProductsForm_Load;
            panelContent.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panelProductInfo.ResumeLayout(false);
            panelProductInfo.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContent;
        private Panel panelBottom;
        private Button buttonViewProductDetail;
        private Button buttonDeleteProduct;
        private Button buttonRefresh;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Panel panelProductInfo;
        private Button buttonSave;
        private Button buttonDecrease;
        private Button buttonIncrease;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel9;
        private NumericUpDown numericUpDown1;
        private Panel panel16;
        private Label labelProductTitle;
    }
}