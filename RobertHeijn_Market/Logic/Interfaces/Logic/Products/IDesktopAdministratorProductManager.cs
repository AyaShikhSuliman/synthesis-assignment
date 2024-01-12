using Logic.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic.Products
{
	public interface IDesktopAdministratorProductManager
	{
		void AddProduct(Product product);
		void EditProduct(Product product);
		List<Product> GetProducts();
		void RemoveProduct(Product product);
		Product GetProductByID(int id);
	}
}
