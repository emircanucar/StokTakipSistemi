using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace StokTakipSistemi.Forms.Childs
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";
            con.Open();

            SQLiteDataAdapter adp = new SQLiteDataAdapter("select id, username KullanıcıAdı, Name Ad, Profession Görev, Email Eposta from users", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "users");
            dataGridView1.DataSource = ds.Tables["users"];
            con.Close();
        }

        int selectedId;
        private void buttonViewUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                selectedId = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);

                ViewUserForm viewUserForm = new ViewUserForm();
                viewUserForm.user.id = selectedId;
                viewUserForm.Show();
            }
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                selectedId = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);

                ViewUserForm viewUserForm = new ViewUserForm();
                viewUserForm.user.id = selectedId;
                viewUserForm.Show();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";
            con.Open();

            SQLiteDataAdapter adp = new SQLiteDataAdapter("select id, username KullanıcıAdı, Name Ad, Profession Görev, Email Eposta from users", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "users");
            dataGridView1.DataSource = ds.Tables["users"];
            con.Close();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult deleteUser = new DialogResult();
            deleteUser = MessageBox.Show("Kullanıcıyı silmek istediğinizden emin misiniz?", "Kulanıcıyı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteUser == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count >= 1)
                {
                    selectedId = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);


                    SQLiteConnection con = new SQLiteConnection();
                    con.ConnectionString = @"Data Source =StokTakipSistemi.db";
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "delete from users where id = '" + selectedId + "'";
                    cmd.ExecuteNonQuery();
                }
            }
            
        }
    }
}
