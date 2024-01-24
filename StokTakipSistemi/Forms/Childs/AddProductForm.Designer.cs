namespace StokTakipSistemi.Forms.Childs
{
    partial class AddProductForm
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
            panel10 = new Panel();
            buttonClear = new Button();
            buttonAdd = new Button();
            panelContent = new Panel();
            panel27 = new Panel();
            label3 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            panel26 = new Panel();
            comboBoxProductUnit = new ComboBox();
            panel28 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel18 = new Panel();
            textBoxProductDesc = new TextBox();
            panel20 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            textBoxProductBrand = new TextBox();
            panel4 = new Panel();
            textBoxProductCategory = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            textBoxProductOrigin = new TextBox();
            panel2 = new Panel();
            textBoxProductMadeYear = new MaskedTextBox();
            panel7 = new Panel();
            panel8 = new Panel();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel11 = new Panel();
            textBoxProductName = new TextBox();
            panel12 = new Panel();
            textBoxProductModel = new TextBox();
            panel13 = new Panel();
            panel14 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            panel9 = new Panel();
            textBoxProductAmount = new MaskedTextBox();
            panel15 = new Panel();
            textBoxProductUnitPrice = new MaskedTextBox();
            panel16 = new Panel();
            panel17 = new Panel();
            panel10.SuspendLayout();
            panelContent.SuspendLayout();
            panel27.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel26.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel18.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel9.SuspendLayout();
            panel15.SuspendLayout();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(64, 66, 88);
            panel10.Controls.Add(buttonClear);
            panel10.Controls.Add(buttonAdd);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 1052);
            panel10.Name = "panel10";
            panel10.Size = new Size(890, 50);
            panel10.TabIndex = 8;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(101, 108, 144);
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Yu Gothic UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.ForeColor = Color.FromArgb(15, 255, 255, 255);
            buttonClear.Location = new Point(131, 5);
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
            buttonAdd.ForeColor = Color.FromArgb(15, 255, 255, 255);
            buttonAdd.Location = new Point(9, 5);
            buttonAdd.Margin = new Padding(0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 40);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Ekle/Kaydet";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(panel27);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(890, 1102);
            panelContent.TabIndex = 7;
            // 
            // panel27
            // 
            panel27.Anchor = AnchorStyles.Top;
            panel27.Controls.Add(label3);
            panel27.Controls.Add(tableLayoutPanel7);
            panel27.Controls.Add(tableLayoutPanel5);
            panel27.Controls.Add(tableLayoutPanel1);
            panel27.Controls.Add(tableLayoutPanel2);
            panel27.Controls.Add(tableLayoutPanel3);
            panel27.Controls.Add(tableLayoutPanel4);
            panel27.Location = new Point(191, 3);
            panel27.Name = "panel27";
            panel27.Size = new Size(514, 736);
            panel27.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Yu Gothic UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(265, 286);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 14;
            label3.Text = "Miktar *:";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.None;
            tableLayoutPanel7.BackColor = Color.Transparent;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(panel26, 0, 0);
            tableLayoutPanel7.Controls.Add(panel28, 0, 1);
            tableLayoutPanel7.Location = new Point(-1, 236);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel7.Size = new Size(248, 45);
            tableLayoutPanel7.TabIndex = 13;
            // 
            // panel26
            // 
            panel26.BackColor = SystemColors.Control;
            panel26.Controls.Add(comboBoxProductUnit);
            panel26.Dock = DockStyle.Bottom;
            panel26.Location = new Point(0, 0);
            panel26.Margin = new Padding(0);
            panel26.Name = "panel26";
            panel26.Padding = new Padding(5);
            panel26.Size = new Size(248, 40);
            panel26.TabIndex = 0;
            // 
            // comboBoxProductUnit
            // 
            comboBoxProductUnit.BackColor = SystemColors.Control;
            comboBoxProductUnit.Dock = DockStyle.Fill;
            comboBoxProductUnit.FlatStyle = FlatStyle.Flat;
            comboBoxProductUnit.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxProductUnit.FormattingEnabled = true;
            comboBoxProductUnit.Items.AddRange(new object[] { "Adet", "KG (Kilogram)", "G (Gram)", "MG (Miligram)", "L (Litre)", "ML (Mililitre)", "Ton", "KM (Kilometre)", "M (Metre)", "CM (Santimetre)", "Diğer" });
            comboBoxProductUnit.Location = new Point(5, 5);
            comboBoxProductUnit.Name = "comboBoxProductUnit";
            comboBoxProductUnit.Size = new Size(238, 31);
            comboBoxProductUnit.TabIndex = 0;
            comboBoxProductUnit.Text = "Cins (Adet/KG/Litre)*";
            // 
            // panel28
            // 
            panel28.BackColor = Color.FromArgb(11, 37, 60);
            panel28.Dock = DockStyle.Top;
            panel28.Location = new Point(0, 40);
            panel28.Margin = new Padding(0);
            panel28.Name = "panel28";
            panel28.Size = new Size(248, 3);
            panel28.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.None;
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(panel18, 0, 0);
            tableLayoutPanel5.Controls.Add(panel20, 0, 1);
            tableLayoutPanel5.Location = new Point(-1, 497);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel5.Size = new Size(515, 134);
            tableLayoutPanel5.TabIndex = 12;
            // 
            // panel18
            // 
            panel18.BackColor = SystemColors.Control;
            panel18.Controls.Add(textBoxProductDesc);
            panel18.Dock = DockStyle.Bottom;
            panel18.Location = new Point(0, 0);
            panel18.Margin = new Padding(0);
            panel18.Name = "panel18";
            panel18.Padding = new Padding(5);
            panel18.Size = new Size(515, 96);
            panel18.TabIndex = 0;
            // 
            // textBoxProductDesc
            // 
            textBoxProductDesc.BackColor = SystemColors.Control;
            textBoxProductDesc.BorderStyle = BorderStyle.None;
            textBoxProductDesc.Dock = DockStyle.Fill;
            textBoxProductDesc.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductDesc.Location = new Point(5, 5);
            textBoxProductDesc.Margin = new Padding(0);
            textBoxProductDesc.Multiline = true;
            textBoxProductDesc.Name = "textBoxProductDesc";
            textBoxProductDesc.PlaceholderText = "Ürün ile ilgili açıklama";
            textBoxProductDesc.Size = new Size(505, 86);
            textBoxProductDesc.TabIndex = 0;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(11, 37, 60);
            panel20.Dock = DockStyle.Top;
            panel20.Location = new Point(0, 96);
            panel20.Margin = new Padding(0);
            panel20.Name = "panel20";
            panel20.Size = new Size(515, 3);
            panel20.TabIndex = 0;
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
            tableLayoutPanel1.Location = new Point(265, 105);
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
            panel3.Controls.Add(textBoxProductBrand);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(248, 40);
            panel3.TabIndex = 0;
            // 
            // textBoxProductBrand
            // 
            textBoxProductBrand.BackColor = SystemColors.Control;
            textBoxProductBrand.BorderStyle = BorderStyle.None;
            textBoxProductBrand.Dock = DockStyle.Fill;
            textBoxProductBrand.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductBrand.Location = new Point(5, 5);
            textBoxProductBrand.Margin = new Padding(0);
            textBoxProductBrand.Name = "textBoxProductBrand";
            textBoxProductBrand.PlaceholderText = "Ürün Markası";
            textBoxProductBrand.Size = new Size(238, 27);
            textBoxProductBrand.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(textBoxProductCategory);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 58);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(248, 40);
            panel4.TabIndex = 0;
            // 
            // textBoxProductCategory
            // 
            textBoxProductCategory.BackColor = SystemColors.Control;
            textBoxProductCategory.BorderStyle = BorderStyle.None;
            textBoxProductCategory.Dock = DockStyle.Fill;
            textBoxProductCategory.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductCategory.Location = new Point(5, 5);
            textBoxProductCategory.Margin = new Padding(0);
            textBoxProductCategory.Name = "textBoxProductCategory";
            textBoxProductCategory.PlaceholderText = "Kategori";
            textBoxProductCategory.Size = new Size(238, 27);
            textBoxProductCategory.TabIndex = 0;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 3);
            tableLayoutPanel2.Controls.Add(panel7, 0, 1);
            tableLayoutPanel2.Controls.Add(panel8, 0, 4);
            tableLayoutPanel2.Controls.Add(label1, 0, 2);
            tableLayoutPanel2.Location = new Point(-1, 312);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(248, 133);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(textBoxProductOrigin);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(248, 40);
            panel1.TabIndex = 0;
            // 
            // textBoxProductOrigin
            // 
            textBoxProductOrigin.BackColor = SystemColors.Control;
            textBoxProductOrigin.BorderStyle = BorderStyle.None;
            textBoxProductOrigin.Dock = DockStyle.Fill;
            textBoxProductOrigin.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductOrigin.Location = new Point(5, 5);
            textBoxProductOrigin.Margin = new Padding(0);
            textBoxProductOrigin.Name = "textBoxProductOrigin";
            textBoxProductOrigin.PlaceholderText = "Menşei";
            textBoxProductOrigin.Size = new Size(238, 27);
            textBoxProductOrigin.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(textBoxProductMadeYear);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 83);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(248, 40);
            panel2.TabIndex = 0;
            // 
            // textBoxProductMadeYear
            // 
            textBoxProductMadeYear.BackColor = SystemColors.Control;
            textBoxProductMadeYear.BorderStyle = BorderStyle.None;
            textBoxProductMadeYear.Dock = DockStyle.Fill;
            textBoxProductMadeYear.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductMadeYear.Location = new Point(5, 5);
            textBoxProductMadeYear.Mask = "0000";
            textBoxProductMadeYear.Name = "textBoxProductMadeYear";
            textBoxProductMadeYear.Size = new Size(238, 27);
            textBoxProductMadeYear.TabIndex = 0;
            textBoxProductMadeYear.ValidatingType = typeof(int);
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(11, 37, 60);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 40);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(248, 3);
            panel7.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(11, 37, 60);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 123);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(248, 3);
            panel8.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Yu Gothic UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 60);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(248, 23);
            label1.TabIndex = 1;
            label1.Text = "Üretim Yılı :";
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
            tableLayoutPanel3.Location = new Point(-1, 105);
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
            panel11.Controls.Add(textBoxProductName);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(0, 0);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(5);
            panel11.Size = new Size(248, 40);
            panel11.TabIndex = 0;
            // 
            // textBoxProductName
            // 
            textBoxProductName.BackColor = SystemColors.Control;
            textBoxProductName.BorderStyle = BorderStyle.None;
            textBoxProductName.Dock = DockStyle.Fill;
            textBoxProductName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductName.Location = new Point(5, 5);
            textBoxProductName.Margin = new Padding(0);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.PlaceholderText = "Ürün adı*";
            textBoxProductName.Size = new Size(238, 27);
            textBoxProductName.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.Control;
            panel12.Controls.Add(textBoxProductModel);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 58);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(5);
            panel12.Size = new Size(248, 40);
            panel12.TabIndex = 0;
            // 
            // textBoxProductModel
            // 
            textBoxProductModel.BackColor = SystemColors.Control;
            textBoxProductModel.BorderStyle = BorderStyle.None;
            textBoxProductModel.Dock = DockStyle.Fill;
            textBoxProductModel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductModel.Location = new Point(5, 5);
            textBoxProductModel.Margin = new Padding(0);
            textBoxProductModel.Name = "textBoxProductModel";
            textBoxProductModel.PlaceholderText = "Ürün Modeli";
            textBoxProductModel.Size = new Size(238, 27);
            textBoxProductModel.TabIndex = 0;
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.None;
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label2, 0, 2);
            tableLayoutPanel4.Controls.Add(panel9, 0, 0);
            tableLayoutPanel4.Controls.Add(panel15, 0, 3);
            tableLayoutPanel4.Controls.Add(panel16, 0, 1);
            tableLayoutPanel4.Controls.Add(panel17, 0, 4);
            tableLayoutPanel4.Location = new Point(265, 312);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(248, 133);
            tableLayoutPanel4.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Yu Gothic UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 60);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(248, 23);
            label2.TabIndex = 2;
            label2.Text = "Birim Fiyat :";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Control;
            panel9.Controls.Add(textBoxProductAmount);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(5);
            panel9.Size = new Size(248, 40);
            panel9.TabIndex = 0;
            // 
            // textBoxProductAmount
            // 
            textBoxProductAmount.BackColor = SystemColors.Control;
            textBoxProductAmount.BorderStyle = BorderStyle.None;
            textBoxProductAmount.Dock = DockStyle.Fill;
            textBoxProductAmount.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductAmount.Location = new Point(5, 5);
            textBoxProductAmount.Mask = "000000000000000000000000000000";
            textBoxProductAmount.Name = "textBoxProductAmount";
            textBoxProductAmount.Size = new Size(238, 27);
            textBoxProductAmount.TabIndex = 1;
            textBoxProductAmount.ValidatingType = typeof(int);
            // 
            // panel15
            // 
            panel15.BackColor = SystemColors.Control;
            panel15.Controls.Add(textBoxProductUnitPrice);
            panel15.Dock = DockStyle.Bottom;
            panel15.Location = new Point(0, 83);
            panel15.Margin = new Padding(0);
            panel15.Name = "panel15";
            panel15.Padding = new Padding(5);
            panel15.Size = new Size(248, 40);
            panel15.TabIndex = 0;
            // 
            // textBoxProductUnitPrice
            // 
            textBoxProductUnitPrice.BackColor = SystemColors.Control;
            textBoxProductUnitPrice.BorderStyle = BorderStyle.None;
            textBoxProductUnitPrice.Dock = DockStyle.Fill;
            textBoxProductUnitPrice.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductUnitPrice.Location = new Point(5, 5);
            textBoxProductUnitPrice.Mask = "000000000000000000000000000000";
            textBoxProductUnitPrice.Name = "textBoxProductUnitPrice";
            textBoxProductUnitPrice.Size = new Size(238, 27);
            textBoxProductUnitPrice.TabIndex = 2;
            textBoxProductUnitPrice.ValidatingType = typeof(int);
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
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(11, 37, 60);
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(0, 123);
            panel17.Margin = new Padding(0);
            panel17.Name = "panel17";
            panel17.Size = new Size(248, 3);
            panel17.TabIndex = 0;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(890, 1102);
            Controls.Add(panel10);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = " ";
            panel10.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            panel26.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel10;
        private Button buttonAdd;
        private Panel panelContent;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel18;
        private TextBox textBoxProductDesc;
        private Panel panel20;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TextBox textBoxProductOrigin;
        private Panel panel2;
        private Panel panel7;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel9;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel11;
        private TextBox textBoxProductName;
        private Panel panel12;
        private TextBox textBoxProductModel;
        private Panel panel13;
        private Panel panel14;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private TextBox textBoxProductBrand;
        private Panel panel4;
        private TextBox textBoxProductCategory;
        private Panel panel5;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel26;
        private ComboBox comboBoxProductUnit;
        private Panel panel28;
        private Panel panel27;
        private Button buttonClear;
        private MaskedTextBox textBoxProductMadeYear;
        private MaskedTextBox textBoxProductAmount;
        private MaskedTextBox textBoxProductUnitPrice;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}