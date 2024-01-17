using StokTakipSistemi.Forms.Childs;
using StokTakipSistemi.Models;
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
    public partial class MainForm1 : Form
    {

        public MainForm1()
        {
            InitializeComponent();
        }

        internal User user = new User();
        private void MainForm1_Load(object sender, EventArgs e)
        {
            labelUserName.Text = user.userName;
            labelDate.Text = DateTime.Today.ToLongDateString();


            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";
            SQLiteCommand cmd = new SQLiteCommand(con);
            SQLiteDataReader dr;
            try
            {
                con.Open();
                cmd.CommandText = "select * from Users where username = '" + user.userName + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    user.id = Convert.ToInt32(dr["id"]);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            try
            {
                AboutForm aboutForm = new AboutForm();
                aboutForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            try
            {
                ProfileForm profileForm = new ProfileForm();
                profileForm.user.id = user.id;
                profileForm.TopLevel = false;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(profileForm);
                profileForm.Dock = DockStyle.Fill;
                profileForm.Show();

                labelContentHead.Text = buttonProfile.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsForm productsForm = new ProductsForm();
                productsForm.TopLevel = false;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(productsForm);
                productsForm.Dock = DockStyle.Fill;
                productsForm.Show();

                labelContentHead.Text = buttonProducts.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                AddProductForm addProductForm = new AddProductForm();
                addProductForm.TopLevel = false;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(addProductForm);
                addProductForm.Dock = DockStyle.Fill;
                addProductForm.Show();

                labelContentHead.Text = buttonAddProduct.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            try
            {
                UsersForm usersForm = new UsersForm();
                usersForm.TopLevel = false;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(usersForm);
                usersForm.Dock = DockStyle.Fill;
                usersForm.Show();

                labelContentHead.Text = buttonUsers.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                AddUserForm addUserForm = new AddUserForm();
                addUserForm.TopLevel = false;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(addUserForm);
                addUserForm.Dock = DockStyle.Fill;
                addUserForm.Show();

                labelContentHead.Text = buttonAddUser.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonInfo_Click_1(object sender, EventArgs e)
        {
            try
            {
                AboutForm aboutForm = new AboutForm();
                aboutForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            try
            {
                FirstForm firstForm = new FirstForm();
                firstForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
