using Logic.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.ProductOrder
{
    public class ProductOrder
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public ProductOrder(Product product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public ProductOrder() { }
    }
}
