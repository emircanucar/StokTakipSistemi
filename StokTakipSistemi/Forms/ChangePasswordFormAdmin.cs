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

namespace StokTakipSistemi.Forms
{
    public partial class ChangePasswordFormAdmin : Form
    {
        public ChangePasswordFormAdmin()
        {
            InitializeComponent();
        }
        internal int userid;
        string? password;
        private void ChangePasswordFormAdmin_Load(object sender, EventArgs e)
        {

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

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source=StokTakipSistemi.db;Version=3;";
            SQLiteCommand cmd = new SQLiteCommand(con);
            SQLiteDataReader dr;
            con.Open();
            cmd.CommandText = "select * from Users where id = '" + userid + "'";
            // cmd.Parameters.AddWithValue("@username", user.userName);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                password = dr["password"].ToString();
            }


            if (textBoxNewpassword.Text == textBoxRePassword.Text)
            {

                SQLiteCommand cmd2 = new SQLiteCommand(con);
                cmd2.CommandText = "update Users Set password = '" + textBoxNewpassword.Text + "' where id =" + Convert.ToInt32(userid);
                cmd2.Prepare();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Şifreniz başarılı bir şekilde değiştirildi!", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Yeni Şifreler Uyuşmuyor!", "Şifreler uyuşmuyor!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            con.Close();
        }

    }
}
