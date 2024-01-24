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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =StokTakipSistemi.db";
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "insert into Product (Category, Name, Brand, Model, Origin, Description) VALUES (@category, @name, @brand, @model, @origin, @description)";
            cmd.Parameters.AddWithValue("@category", textBoxProductCategory.Text ?? "");
            cmd.Parameters.AddWithValue("@name", textBoxProductName.Text ?? "");
            cmd.Parameters.AddWithValue("@brand", textBoxProductBrand.Text ?? "");
            cmd.Parameters.AddWithValue("@model", textBoxProductModel.Text ?? "");
            cmd.Parameters.AddWithValue("@origin", textBoxProductOrigin.Text ?? "");
            cmd.Parameters.AddWithValue("@description", textBoxProductDesc.Text ?? "");


            if (textBoxProductAmount.Text == null || textBoxProductAmount.Text == "")
            {
                textBoxProductAmount.Text = "0";
            }
            if (textBoxProductUnitPrice.Text == null || textBoxProductUnitPrice.Text == "")
            {
                textBoxProductUnitPrice.Text = "0";
            }
            if (textBoxProductMadeYear.Text == null || textBoxProductMadeYear.Text == "")
            {
                textBoxProductMadeYear.Text = "0";
            }

            SQLiteCommand cmd2 = new SQLiteCommand(con);
            cmd2.CommandText = "insert into Product_Detail (Product_Id, Amount, Unit, Unit_Price, Manufacturing_Year) VALUES ((SELECT max(id)FROM Product), @amount, @unit, @unit_price, @manufacturing_year)";
            cmd2.Parameters.AddWithValue("@amount", Convert.ToInt32(textBoxProductAmount.Text.Trim()));
            cmd2.Parameters.AddWithValue("@unit", comboBoxProductUnit.Text);
            cmd2.Parameters.AddWithValue("@unit_price", Convert.ToDouble(textBoxProductUnitPrice.Text.Trim()));
            cmd2.Parameters.AddWithValue("@manufacturing_year", Convert.ToInt32(textBoxProductMadeYear.Text.Trim()));


            try
            {
                if (textBoxProductName.Text != "" && comboBoxProductUnit.Text != "Cins (Adet/KG/Litre)*" && textBoxProductAmount.Text != "")
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Ürün başarı ile eklendi!", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    textBoxProductCategory.Text = "";
                    textBoxProductName.Text = "";
                    textBoxProductBrand.Text = "";
                    textBoxProductModel.Text = "";
                    textBoxProductOrigin.Text = "";
                    textBoxProductDesc.Text = "";
                    textBoxProductAmount.Text = "";
                    textBoxProductUnitPrice.Text = "";
                    textBoxProductMadeYear.Text = "";
                }
                else
                {
                    MessageBox.Show("Lütfen doldurulması zorunlu tüm alanları doldurunuz!", "Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
            textBoxProductCategory.Text = "";
            textBoxProductName.Text = "";
            textBoxProductBrand.Text = "";
            textBoxProductModel.Text = "";
            textBoxProductOrigin.Text = "";
            textBoxProductDesc.Text = "";
            textBoxProductAmount.Text = "";
            textBoxProductUnitPrice.Text = "";
            textBoxProductMadeYear.Text = "";
        }


    }
}
