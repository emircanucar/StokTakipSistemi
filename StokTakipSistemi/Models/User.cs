﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Models
{
    public class User
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string name { get; set; }
        public string profession{ get; set; }
        public string eMail { get; set; }
        public byte role { get; set; }  
        public string imgUrl { get; set; }
    }
}
