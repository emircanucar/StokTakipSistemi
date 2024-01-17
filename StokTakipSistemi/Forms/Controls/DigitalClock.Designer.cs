namespace StokTakipSistemi.Forms.Controls
{
    partial class DigitalClock
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            labelClock = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // labelClock
            // 
            labelClock.AutoSize = true;
            labelClock.Dock = DockStyle.Right;
            labelClock.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelClock.ForeColor = SystemColors.ControlDark;
            labelClock.Location = new Point(37, 0);
            labelClock.Margin = new Padding(0);
            labelClock.Name = "labelClock";
            labelClock.Size = new Size(109, 20);
            labelClock.TabIndex = 6;
            labelClock.Text = "Saat ve Dakika";
            labelClock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DigitalClock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(labelClock);
            Name = "DigitalClock";
            Size = new Size(146, 22);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label labelClock;
    }
}
