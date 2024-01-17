using StokTakipSistemi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
namespace StokTakipSistemi.Forms
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }
        string secureCode = "";
        private void FirstForm_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Today.ToLongDateString();
            secureCode = SecureCode.GetSecureCode();
            labelSecureCode.Text = secureCode;
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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            panelButton.Enabled = false;
            panelButton.Visible = false;
            tablePanelForm.Enabled = true;
            tablePanelForm.Visible = true;
            panelTitle.Enabled = true;
            panelTitle.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            LoginInfoForm loginInfoForm = new LoginInfoForm();
            loginInfoForm.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            secureCode = SecureCode.GetSecureCode();
            labelSecureCode.Text = secureCode;


        }

        private void buttonLogInto_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string passWord = textBoxPassword.Text;
            if (textBoxUserName.Text != "" && textBoxPassword.Text != "" && textBoxSecure.Text != "")
            {


                if (textBoxSecure.Text == secureCode)
                {

                    SQLiteConnection con = new SQLiteConnection();
                    con.ConnectionString = @"Data Source=StokTakipSistemi.db;Version=3;";
                    con.Open();

                    string firstQuery = "SELECT * FROM users where username = @userName and password = @password";
                    SQLiteCommand firstCMD = new SQLiteCommand(firstQuery, con);
                    firstCMD.Parameters.AddWithValue("@userName", userName);
                    firstCMD.Parameters.AddWithValue("@password", passWord);

                    SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(firstCMD);
                    DataTable dataTable = new DataTable();
                    sQLiteDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {

                        SQLiteDataAdapter sQLiteDataAdapter2 = new SQLiteDataAdapter("SELECT * FROM users where username ='" + userName + "' and role=1", con);
                        DataTable dataTable2 = new DataTable();
                        sQLiteDataAdapter2.Fill(dataTable2);
                        if (dataTable2.Rows.Count > 0)
                        {
                            MainForm1 mainForm1 = new MainForm1();
                            mainForm1.user.userName = userName;
                            mainForm1.Show();
                            this.Hide();

                        }
                        else
                        {
                            SQLiteDataAdapter sQLiteDataAdapter3 = new SQLiteDataAdapter("SELECT * FROM users where username ='" + userName + "' and role=2", con);
                            DataTable dataTable3 = new DataTable();
                            sQLiteDataAdapter3.Fill(dataTable3);
                            if (dataTable3.Rows.Count > 0)
                            {
                                MainForm2 mainForm2 = new MainForm2();
                                mainForm2.user.userName = userName;
                                mainForm2.Show();

                                this.Hide();

                            }
                            else
                            {
                                SQLiteDataAdapter sQLiteDataAdapter4 = new SQLiteDataAdapter("SELECT * FROM users where username ='" + userName + "' and role=3", con);
                                DataTable dataTable4 = new DataTable();
                                sQLiteDataAdapter4.Fill(dataTable4);
                                if (dataTable4.Rows.Count > 0)
                                {
                                    MainForm3 mainForm3 = new MainForm3();
                                    mainForm3.user.userName = userName;

                                    mainForm3.Show();
                                    this.Hide();

                                }
                            }
                        }
                        labelInfo.ForeColor = Color.Green;
                        labelInfo.Text = "Giriş başarılı. Lütfen bekleyiniz...";

                    }
                    else
                    {
                        labelInfo.ForeColor = Color.Red;
                        labelInfo.Text = "Kullanıcı adı veya şifre yanlış!";
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUserName.Text = "";
                        textBoxPassword.Text = "";
                    }

                    con.Close();
                }
                else
                {
                    labelInfo.ForeColor = Color.Red;
                    labelInfo.Text = "Güvenlik kodunu doğru giriniz!";
                    MessageBox.Show("Güvenlik kodu yanlış!", "Güvenlik Kodu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                labelInfo.ForeColor = Color.Red;
                labelInfo.Text = "Alanlar boş geçilemez!";
                MessageBox.Show("Kullanıcı adı , şifre veya güvenlik kodu boş geçilemez!", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
