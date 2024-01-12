using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Categories
{
    public class Category
    {
		public int Id { get; }
        public string Name { get; }
        public List<Category> SubCategories { get; set;}

		public Category(int id, string name, List<Category> subCategory)
		{
			Id = id;
			Name = name;
			SubCategories = subCategory;
		}

		public Category(int id, string name)
		{
			Id = id;
			Name = name;
		}

		public Category(string name) 
		{ 
			Name = name;
		}

		public override string ToString()
		{
			string categoryName = $"{Name}";
			return categoryName;
		}
	}
}
