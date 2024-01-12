using Data;
using Logic.Classes.Categories;
using Logic.Classes.Products;
using Logic.Interfaces.Logic;
using Logic.Interfaces.Logic.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application.Products
{
	public partial class AddProductForm : Form
	{
		private IDesktopAdministratorProductManager desktopAdministratorProductManager;
		private ICategoryManager categoryManager;

		public AddProductForm()
		{
			InitializeComponent();

			desktopAdministratorProductManager = new ProductManager(new DBProductManager());
			categoryManager = new CategoryManager(new DBCategoryManager());

			InitializeComboboxes();
		}

		private void InitializeComboboxes()
		{
			foreach (Category category in categoryManager.GetCategories())
			{
				cbCategories.Items.Add(category.Name);
			}
		}

		private void AddProductForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			GeneralProductsForm generalProductsForm = new GeneralProductsForm();
			generalProductsForm.Show();
			this.Hide();
		}

		private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCategories.Text == "Fruit")
			{
				cbSubCategories.Items.Clear();

				foreach (Category category in categoryManager.GetSubCategories("Fruit"))
				{
					cbSubCategories.Items.Add(category);
				}
			}

			if (cbCategories.Text == "Vegetable")
			{
				cbSubCategories.Items.Clear();

				foreach (Category category in categoryManager.GetSubCategories("Vegetable"))
				{
					cbSubCategories.Items.Add(category);
				}
			}

			if (cbCategories.Text == "Meat")
			{
				cbSubCategories.Items.Clear();

				foreach (Category category in categoryManager.GetSubCategories("Meat"))
				{
					cbSubCategories.Items.Add(category);
				}
			}

			if (cbCategories.Text == "Household Goods")
			{
				cbSubCategories.Items.Clear();

				foreach (Category category in categoryManager.GetSubCategories("Household Goods"))
				{
					cbSubCategories.Items.Add(category);
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Category category = (Category)cbSubCategories.SelectedItem;
			string name = tbName.Text;
			int currentAmount = Convert.ToInt32(tbCurrentAmount.Text);
			string unit = cbUnit.Text;
			double price = Convert.ToDouble(tbPrice.Text);
			string image = tbImage.Text;

			Product product = new Product(0, category, name, currentAmount, unit, price, image);
			desktopAdministratorProductManager.AddProduct(product);

            GeneralProductsForm generalProductsForm = new GeneralProductsForm();
            generalProductsForm.Show();
            this.Hide();

            cbCategories.Text = "";
			cbSubCategories.Text = "";
			tbName.Text = "";
			tbCurrentAmount.Text = "";
			cbUnit.Text = "";
			tbPrice.Text = "";
			tbImage.Text = "";
		}
	}
}

