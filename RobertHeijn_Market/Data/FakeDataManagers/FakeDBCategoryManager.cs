using Logic.Classes.Categories;
using Logic.Classes.Products;
using Logic.Interfaces.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Properties.FakeDataManagers
{
    public class FakeDBCategoryManager : IDBCategoryManager
    {
        List<Category> categories = new List<Category>();
        List<Category> subCategories = new List<Category>();
        public FakeDBCategoryManager()
        {
            Category category = new Category(1, "Meat");
            Category category2 = new Category(2, "Fruit");
            Category category3 = new Category(3, "Vegtable");
            categories.Add(category);
            categories.Add(category2);
            categories.Add(category3);
            subCategories.Add(category);
            subCategories.Add(category2);
            subCategories.Add(category3);

        }

        public List<Category> ReadAllCategories()
        {
            return categories;
        }

        public List<Category> ReadSubCategories(string category)
        {
            List<Category> cate = new List<Category>();
            foreach (Category category1 in categories)
            {
                if (category1.Name == category)
                {
                    cate.Add(category1);
                }
            }
            return cate;

        }

        public Category GetProductCategoryId(int id)
        {
            foreach (Category category1 in categories)
            {
                if (category1.Id == id)
                {
                    return category1;
                }
            }
            return null;
        }
    }
}
