using Logic.Interfaces.Data;
using Logic.Interfaces.Logic.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Products
{
    public class ProductManager : ICustomerProductManager, IDesktopAdministratorProductManager
	{
		private IDBProductManager dBProductManager;

		public ProductManager(IDBProductManager dBProductManager)
		{
			this.dBProductManager = dBProductManager;
		}

		public void AddProduct(Product product)
		{
			dBProductManager.CreateProduct(product);
		}

		public void EditProduct(Product product)
		{
			dBProductManager.UpdateProduct(product);
		}

		public List<Product> GetProducts()
		{
			return dBProductManager.ReadAllProducts();
		}

		public void RemoveProduct(Product product)
		{
			dBProductManager.DeleteProduct(product);
		}

		public Product GetProductByID(int id)
		{
			Product product = dBProductManager.GetProduct(id);

			if (product.Id != 0)
			{
				return product;
			}

			return null;
		}
	}
}
