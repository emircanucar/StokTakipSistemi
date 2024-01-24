using Microsoft.VisualBasic.ApplicationServices;
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
using User = StokTakipSistemi.Models.User;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakipSistemi.Forms.Childs
{
    public partial class ProfileForm : Form
    {
        public User user = new User();
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {


            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";
            SQLiteCommand cmd = new SQLiteCommand(con);
            SQLiteDataReader dr;
            try
            {
                con.Open();
                cmd.CommandText = "select * from Users where id = '" + user.id + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    user.userName = dr["username"].ToString() ?? "";
                    user.name = dr["Name"].ToString() ?? "";
                    user.profession = dr["Profession"].ToString() ?? "";
                    user.eMail = dr["Email"].ToString() ?? "";
                    user.role = Convert.ToByte(dr["role"]);
                }
                textBoxUserName.Text = user.userName;
                textBoxName.Text = user.name;
                textBoxProf.Text = user.profession;
                textBoxMail.Text = user.eMail;


                if (user.role == 1)
                {
                    comboBoxRole.Text = "Admin / Yetkili";
                }
                else if (user.role == 2)
                {
                    comboBoxRole.Text = "Orta Yetkili / Normal Kullanıcı ";
                }
                else
                {
                    comboBoxRole.Text = "Gözlemci / Yetkisiz";
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            panelForm.Enabled = true;
            buttonEdit.Enabled = false;
            buttonSave.Enabled = true;
            buttonCancel.Enabled = true;
            labelDontChangePW.Visible = true;


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "update Users Set name ='" + textBoxName.Text + "', Profession = '" + textBoxProf.Text + "', Email = '" + textBoxMail.Text + "'  where id = '" + user.id + "'";
            try
            {
                DialogResult askSave = new DialogResult();
                askSave = MessageBox.Show("Kaydetmek istediğinizden emin misiniz?", "Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (askSave == DialogResult.Yes)
                {
                    panelForm.Enabled = false;

                    buttonEdit.Enabled = true;
                    buttonSave.Enabled = false;
                    buttonCancel.Enabled = false;
                    labelDontChangePW.Visible = false;

                    con.Open();
                    cmd.ExecuteNonQuery();
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult askCancel = new DialogResult();
                askCancel = MessageBox.Show("İptal etmek istediğinizden emin misiniz?", "İptal Et", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (askCancel == DialogResult.Yes)
                {
                    panelForm.Enabled = false;
                    buttonEdit.Enabled = true;
                    buttonSave.Enabled = false;
                    buttonCancel.Enabled = false;
                    labelDontChangePW.Visible = false;


                    textBoxUserName.Text = user.userName;
                    textBoxName.Text = user.name;
                    textBoxProf.Text = user.profession;
                    textBoxMail.Text = user.eMail;

                    if (user.role == 1)
                    {
                        comboBoxRole.Text = "Admin / Yetkili";
                    }
                    else if (user.role == 2)
                    {
                        comboBoxRole.Text = "Orta Yetkili / Normal Kullanıcı ";
                    }
                    else
                    {
                        comboBoxRole.Text = "Gözlemci / Yetkisiz";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePasswordForm changePasswordForm = new ChangePasswordForm();
                changePasswordForm.userid = user.id;
                changePasswordForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
