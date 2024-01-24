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
            cmd.CommandText = "insert into users (Username, Password, Name, Profession, Email, Role) VALUES (@username, @password, @name, @prof, @email, @role)";
            cmd.Parameters.AddWithValue("@username", textBoxUserName.Text);
            cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@prof", textBoxProf.Text);
            cmd.Parameters.AddWithValue("@email", textBoxMail.Text);
            cmd.Parameters.AddWithValue("@role", comboBoxRole.Text);
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

    }
}
