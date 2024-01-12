using Logic.Classes.Accounts.WebsiteAdminstrator;
using Logic.Classes.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
	public interface IDBCategoryManager
	{
		List<Category> ReadAllCategories();
		List<Category> ReadSubCategories(string category);
		Category GetProductCategoryId(int id);

    }
}
