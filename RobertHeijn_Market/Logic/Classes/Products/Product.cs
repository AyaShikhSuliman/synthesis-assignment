using Logic.Classes.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Enums;

namespace Logic.Classes.Products
{
	public class Product
	{
		public int Id { get; set; }
		public Category Category { get; set; }
		public string Name { get; set; }
		public int CurrentAmount { get; set; }
		public string Unit { get; set; }
		public double Price { get; set; }
		public string Image { get; set; }

		public Product() { }

		public Product(int id, Category category, string name, int currentAmount, string unit, double price, string image)
		{
			Id = id;
			Category = category;
			Name = name;
			CurrentAmount = currentAmount;
			Unit = unit;
			Price = price;
			Image = image;
		}
	}
}
