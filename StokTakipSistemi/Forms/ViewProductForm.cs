using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ViewProductForm : Form
    {
        internal Product product = new Product();
        public ViewProductForm()
        {
            InitializeComponent();
        }
        private void ViewProductForm_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";
            SQLiteCommand cmd = new SQLiteCommand(con);
            SQLiteCommand cmd2 = new SQLiteCommand(con);
            SQLiteDataReader dr;
            SQLiteDataReader dr2;
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM Product where Id = '" + product.Id + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    product.Id = Convert.ToInt32(dr["Id"] ?? 0);
                    product.Category = dr["Category"].ToString() ?? "";
                    product.Name = dr["Name"].ToString() ?? "";
                    product.Brand = dr["Brand"].ToString() ?? "";
                    product.Model = dr["Model"].ToString() ?? "";
                    product.Origin = dr["Origin"].ToString() ?? "";
                    product.Description = dr["Description"].ToString() ?? "";

                }

                textBoxProductCategory.Text = product.Category;
                textBoxProductName.Text = product.Name;
                textBoxProductBrand.Text = product.Brand;
                textBoxProductModel.Text = product.Model;
                textBoxProductOrigin.Text = product.Origin;
                textBoxProductDesc.Text = product.Description;

                cmd2.CommandText = "SELECT * FROM Product_Detail where Product_Id = '" + product.Id + "'";
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    product.Amount = Convert.ToInt32(dr2["Amount"] ?? 0);
                    product.Unit_Price = Convert.ToInt32(dr2["Unit_Price"] ?? 0);
                    product.Manufacturing_Year = Convert.ToInt32(dr2["Manufacturing_Year"] ?? 0);
                    product.Unit = dr2["Unit"].ToString() ?? "";

                    textBoxProductAmount.Text = product.Amount.ToString();
                    textBoxProductUnitPrice.Text = product.Unit_Price.ToString();
                    textBoxProductMadeYear.Text = product.Manufacturing_Year.ToString();
                    comboBoxProductUnit.Text = product.Unit.ToString();


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
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = $"update Product Set Category='{textBoxProductCategory.Text}', Name='{textBoxProductName.Text}',  Brand='{textBoxProductBrand.Text}',  Model='{textBoxProductModel.Text}',  Origin='{textBoxProductOrigin.Text}',  Description='{textBoxProductDesc.Text}' where Id = '" + product.Id + "'";
            cmd.ExecuteNonQuery();

            SQLiteCommand cmd2 = new SQLiteCommand(con);
            cmd2.CommandText = $"update Product_Detail Set Amount='{textBoxProductAmount.Text}', Unit='{comboBoxProductUnit.Text}',  Unit_Price='{textBoxProductUnitPrice.Text}',  Manufacturing_Year='{textBoxProductMadeYear.Text}' where Product_id = '" + product.Id + "'";
            cmd2.Parameters.AddWithValue("@amount", textBoxProductAmount.Text);
            cmd2.Parameters.AddWithValue("@unit", comboBoxProductUnit.Text);
            cmd2.Parameters.AddWithValue("@unit_Price", textBoxProductUnitPrice.Text);
            cmd2.Parameters.AddWithValue("@madeYear", textBoxProductMadeYear.Text);
            cmd2.ExecuteNonQuery();



            MessageBox.Show("Değişiklikler başarı ile kaydedildi!", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonEdit.Enabled = true;
            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;
            panelForm.Enabled = false;
            con.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonEdit.Enabled = true;
            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;
            panelForm.Enabled = false;

        }
    }
}
