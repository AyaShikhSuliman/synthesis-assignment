using Data;
using Logic.Classes.Categories;
using Logic.Classes.Products;
using Logic.Interfaces.Logic.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_Application.Products
{
	public partial class EditProductForm : Form
	{
		private IDesktopAdministratorProductManager desktopAdministratorProductManager;
		private Product Product { get; set; }

		public EditProductForm(Product Product)
		{
			InitializeComponent();

			desktopAdministratorProductManager = new ProductManager(new DBProductManager());

			this.Product = Product;

			tbId.Text = Product.Id.ToString();
			cbCategory.Text = Product.Category.Name;
			tbName.Text = Product.Name.ToString();
			tbCurrentAmount.Text = Product.CurrentAmount.ToString();
			cbUnit.Text = Product.Unit.ToString();
			tbPrice.Text = Product.Price.ToString();
			tbImage.Text = Product.Image.ToString();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			string name = Product.Category.Name;
			name = cbCategory.Text;
			Product.Name = tbName.Text;
			Product.CurrentAmount = Convert.ToInt32(tbCurrentAmount.Text);
			Product.Unit = cbUnit.Text;
			Product.Price = Convert.ToDouble(tbPrice.Text);
			Product.Image = tbImage.Text;

			desktopAdministratorProductManager.EditProduct(Product);

			GeneralProductsForm generalProductsForm = new GeneralProductsForm();
			generalProductsForm.Show();
			this.Hide();

			tbName.Text = "";
			tbCurrentAmount.Text = "";
			cbUnit.Text = "";
			tbPrice.Text = "";
			tbImage.Text = "";
		}

		private void EditProductForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			GeneralProductsForm generalProductsForm = new GeneralProductsForm();
			generalProductsForm.Show();
			this.Hide();
		}
	}
}
