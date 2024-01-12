using Logic.Classes.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic
{
	public interface ICategoryManager
	{
		List<Category> GetCategories();
		List<Category> GetSubCategories(string category);
		Category GetProductCategoryId(int id);

    }
}
