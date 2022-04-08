using System;

namespace Course.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name , double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
            + " R$ " 
            + Price.ToString("F2");
        }
    }
}
    