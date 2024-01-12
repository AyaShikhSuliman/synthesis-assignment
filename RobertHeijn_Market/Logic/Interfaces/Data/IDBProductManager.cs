using Logic.Classes.Accounts.WebsiteAdminstrator;
using Logic.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
	public interface IDBProductManager
	{
		void CreateProduct(Product product);
		List<Product> ReadAllProducts();
		void UpdateProduct(Product product);
		void DeleteProduct(Product product);
		Product GetProduct(int id);
	}
}
