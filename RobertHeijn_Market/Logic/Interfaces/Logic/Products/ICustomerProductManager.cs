using Logic.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic.Products
{
    public interface ICustomerProductManager
    {
        List<Product> GetProducts();
        Product GetProductByID(int id);
    }
}
