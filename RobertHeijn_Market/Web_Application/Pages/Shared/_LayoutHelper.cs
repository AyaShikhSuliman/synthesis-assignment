using Data;
using Logic.Classes.Accounts.Customer;
using Logic.Classes.Categories;
using Logic.Interfaces.Logic;
using Logic.Interfaces.Logic.Customers;
using Microsoft.AspNetCore.Authorization;

namespace Web_Application.Pages.Shared
{
	public class _LayoutHelper
	{
		public List<Category> Categories = new List<Category>();
		private ICategoryManager CategoryManager = new CategoryManager(new DBCategoryManager());
		public Category Category { get; set; }

		public static List<Category> DisplayMainCategories()
		{
			var Categories = new List<Category>();
			var CategoryManager = new CategoryManager(new DBCategoryManager());
			return Categories = CategoryManager.GetCategories();
		}

		public static List<Category> DisplaySubCategories(string category)
		{
			var Categories = new List<Category>();
			var CategoryManager = new CategoryManager(new DBCategoryManager());
			return Categories = CategoryManager.GetSubCategories(category);
		}

        public static bool NotLoggedIn(HttpContext httpContext)
        {
            return httpContext.Session.GetInt32("CustomerID") == null;
        }
    }
}
