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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";

            try
            {
                con.Open();
                SQLiteDataAdapter adp = new SQLiteDataAdapter("SELECT p.Id, p.Category Kategori, p.Name İsim, p.Brand Marka, p.Model, pd.Amount Miktar, pd.Unit Tür, pd.Unit_Price Fiyat FROM Product p FULL OUTER JOIN Product_Detail pd ON p.Id = pd.Product_Id;", con);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Product");
                dataGridView1.DataSource = ds.Tables["Product"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                labelProductTitle.Text = Convert.ToString(dataGridView1.SelectedCells[2].Value);
                numericUpDown1.Value = Convert.ToInt32(dataGridView1.SelectedCells[5].Value);
            }
        }

        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value++;
        }

        private void buttonDecrease_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value--;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";

            try
            {
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = "update Product_Detail Set Amount =" + numericUpDown1.Value + " where Product_Id =" + Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                cmd.ExecuteNonQuery();
                dataGridView1.SelectedCells[5].Value = numericUpDown1.Value;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            { con.Close(); }
        }
        int selectedId;
        private void buttonViewProductDetail_Click(object sender, EventArgs e)

        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedId = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);

                ViewProductForm viewProductForm = new ViewProductForm();
                viewProductForm.product.Id = selectedId;
                viewProductForm.Show();
            }
        }
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";
            con.Open();
            try
            {
                DialogResult deleteUser = new DialogResult();
                deleteUser = MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteUser == DialogResult.Yes)
                {
                    if (dataGridView1.SelectedRows.Count >= 1)
                    {
                        SQLiteCommand cmd = new SQLiteCommand(con);
                        cmd.CommandText = "Delete from product_detail where Product_Id=" + Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                        cmd.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();

                        SQLiteCommand cmd2 = new SQLiteCommand(con);
                        cmd2.CommandText = "Delete from product where Id=" + Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                        cmd2.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";
            con.Open();

            SQLiteDataAdapter adp = new SQLiteDataAdapter("SELECT p.Id, p.Category Kategori, p.Name İsim, p.Brand Marka, p.Model, pd.Amount Miktar, pd.Unit Tür, pd.Unit_Price Fiyat FROM Product p FULL OUTER JOIN Product_Detail pd ON p.Id = pd.Product_Id;", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Product");
            dataGridView1.DataSource = ds.Tables["Product"];
            con.Close();
        }


    }
}
