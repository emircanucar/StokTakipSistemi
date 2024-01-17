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


namespace StokTakipSistemi.Forms
{
    public partial class ViewUserForm : Form
    {

        internal User user = new User();
        public ViewUserForm()
        {
            InitializeComponent();
        }
        private void ViewUserForm_Load(object sender, EventArgs e)
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
                    user.imgUrl = dr["ImageURL"].ToString() ?? "";
                    user.role = Convert.ToByte(dr["role"]);
                }
                textBoxUserName.Text = user.userName;
                textBoxName.Text = user.name;
                textBoxProf.Text = user.profession;
                textBoxMail.Text = user.eMail;
                pictureBoxUser.ImageLocation = user.imgUrl;


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
                MessageBox.Show("Hata:" + ex.Message);
            }
            finally
            {
                con.Close();

            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        Point mouseLocation;
        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonEdit.Enabled = false;
            buttonSave.Enabled = true;
            buttonCancel.Enabled = true;
            panelForm.Enabled = true;
            labelDontChangePW.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            panelForm.Enabled = false;

            buttonEdit.Enabled = true;
            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;
            labelDontChangePW.Visible = false;



             
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "update Users Set name ='" + textBoxName.Text + "', Profession = '" + textBoxProf.Text + "', Email = '" + textBoxMail.Text + "', Role='" + comboBoxRole.Text + "'  where id = '" + user.id + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Değişiklikler başarı ile kaydedildi!", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonEdit.Enabled = true;
            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;
            panelForm.Enabled = false;
            labelDontChangePW.Visible = false;



        }
        string? sourcePath;
        string destPath = Application.StartupPath + @"..\..\..\Assets\UserImages\";
        string? destFile;
        Random rnd = new Random();
        private void buttonLoadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog choosePhoto = new OpenFileDialog();
            choosePhoto.Filter = "Resim Dosyası |*.jpg; *.jpeg; *.png";
            choosePhoto.Title = "Resim Seç";
            if (choosePhoto.ShowDialog() == DialogResult.OK)
            {
                sourcePath = choosePhoto.FileName;
                destFile = destPath + user.id + "-" + user.name + "-" + rnd.Next(999999).ToString() + Path.GetExtension(choosePhoto.FileName);
                File.Copy(sourcePath, destFile);
                pictureBoxUser.ImageLocation = destFile;


                SQLiteConnection con = new SQLiteConnection();
                con.ConnectionString = @"Data Source =StokTakipSistemi.db";
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = "update users set ImageURL = '" + destFile + "' where id = " + user.id;
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordFormAdmin changePasswordFormAdmin = new ChangePasswordFormAdmin();
            changePasswordFormAdmin.userid = user.id;
            changePasswordFormAdmin.Show();
        }
    }
}
