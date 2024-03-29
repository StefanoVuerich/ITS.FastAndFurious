﻿namespace ITS.FastAndFurious.Models
{
    public class Product
    {
        public int Id { get; set; }     
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Origin { get; set; }

        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }
    }
}
