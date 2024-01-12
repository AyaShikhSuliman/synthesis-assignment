using Azure.Core;
using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Categories
{
	public class CategoryManager : ICategoryManager
	{
		private IDBCategoryManager _dBCategoryManager;

		public CategoryManager(IDBCategoryManager dBCategoryManager) 
		{
			_dBCategoryManager = dBCategoryManager;
		}

		public List<Category> GetCategories()
		{
			return _dBCategoryManager.ReadAllCategories();
		}

		public Category GetProductCategoryId(int id)
		{
			return _dBCategoryManager.GetProductCategoryId(id);
		}

		public List<Category> GetSubCategories(string category)
		{
			return _dBCategoryManager.ReadSubCategories(category);
		}
	}
}
