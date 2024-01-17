using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemi.Forms.Childs
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "insert into users (Username, Password, Name, Profession, Email, Role, ImageURL) VALUES (@username, @password, @name, @prof, @email, @role, @image)";
            cmd.Parameters.AddWithValue("@username", textBoxUserName.Text);
            cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@prof", textBoxProf.Text);
            cmd.Parameters.AddWithValue("@email", textBoxMail.Text);
            cmd.Parameters.AddWithValue("@role", comboBoxRole.Text);
            cmd.Parameters.AddWithValue("@image", pictureBoxUser.ImageLocation);
            try
            {
                if (comboBoxRole.Text != "Yetki*" && textBoxUserName.Text != "" && textBoxPassword.Text != "")
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı başarı ile eklendi!", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxUserName.Text = string.Empty;
                    textBoxPassword.Text = string.Empty;
                    textBoxMail.Text = string.Empty;
                    textBoxProf.Text = string.Empty;
                    textBoxName.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Lütfen doldurulması zorunlu tüm alanları doldurunuz!", "Eksil Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUserName.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxMail.Text = string.Empty;
            textBoxProf.Text = string.Empty;
            textBoxName.Text = string.Empty;
        }
        string? sourcePath;
        string destPath = Application.StartupPath + @"..\..\..\Assets\UserImages\";
        string? destFile;
        Random rnd = new Random();
        private void buttonLoadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog choosePhoto = new OpenFileDialog();
                choosePhoto.Filter = "Resim Dosyası |*.jpg; *.jpeg; *.png";
                choosePhoto.Title = "Resim Seç";
                if (choosePhoto.ShowDialog() == DialogResult.OK)
                {
                    sourcePath = choosePhoto.FileName;
                    destFile = destPath + "new" + "-" + textBoxUserName.Text + "-" + rnd.Next(999999).ToString() + Path.GetExtension(choosePhoto.FileName);
                    File.Copy(sourcePath, destFile);
                    pictureBoxUser.ImageLocation = destFile;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
