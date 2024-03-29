﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstYaklisimi.DAL
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int Barcode { get; set; }
        public int Category_Id { get; set; }
        //Navigation Property
        public Category Category { get; set; }
    }
}
