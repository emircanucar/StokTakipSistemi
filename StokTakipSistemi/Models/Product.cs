using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Models
{
    internal class Product
    {
        //From Product Table
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Profession { get; set; }
        public string Origin { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }

        //From Product_Detail Table
        public int Product_Id { get; set; }
        public int Amount { get; set; }
        public string Unit { get; set; }
        public double Unit_Price { get; set; }
        public int Manufacturing_Year { get; set; }

    }
}
