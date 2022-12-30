using System;

namespace EntityCore.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public long Inventory { get; set; }
        public DateTime DateTime { get; set; }

        public Product(string name, string description, double price, long inventory)
        {
            Name = name;
            Description = description;
            Price = price;
            Inventory = inventory;
            DateTime = DateTime.Now;
        }
    }
}
