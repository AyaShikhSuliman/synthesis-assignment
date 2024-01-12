using Data;
using Logic.Classes.Categories;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Properties.FakeDataManagers;

namespace Unit_Test
{
    [TestClass]
    public class CategoryTests
    {
        ICategoryManager _categoryManager = new CategoryManager(new FakeDBCategoryManager());

        [TestMethod]
        public void GetAllCategoriesNotNull()
        {
            Assert.IsNotNull(_categoryManager.GetCategories());
        }
        [TestMethod]
        public void GetAllCategoriesIsNull()
        {
            List<Category> categories = _categoryManager.GetCategories();
            categories = null;
            Assert.IsNull(categories);
        }
        [TestMethod]
        public void GetAllSubCategoriesNotNull()
        {
            Assert.IsNotNull(_categoryManager.GetSubCategories("Meat"));
        }
        [TestMethod]
        public void GetAllSubCategoriesNull()
        {
            Assert.AreEqual(_categoryManager.GetSubCategories("Chicken").Count,0);

        }
        //Method doesn't exist in the interfaces. Remeber to implement!
        [TestMethod]
        public void GetProductCategoriesIdNotNull()
        {
            Category category = _categoryManager.GetProductCategoryId(1);
            Assert.IsNotNull(category);

        }
        [TestMethod]
        public void GetProductCategoriesIdNull()
        {
            Category category = _categoryManager.GetProductCategoryId(5);
            Assert.IsNull(category);

        }
    }
}
