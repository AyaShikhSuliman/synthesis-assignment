using Data;
using Logic.Classes.Products;
using Logic.Enums;
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

namespace Desktop_Application.Products
{
    public partial class GeneralProductsForm : Form
	{
		private DataTable dataTable;
		private DataView dataView;
		private Product _selectedProductFromLV;
		private IDesktopAdministratorProductManager desktopAdministratorProductManager;

		public GeneralProductsForm()
		{
			InitializeComponent();

			desktopAdministratorProductManager = new ProductManager(new DBProductManager());

			//Listview properties
			lvProducts.View = View.Details;
			lvProducts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

			//Add columns
			lvProducts.Columns.Add("ID", 50);
			lvProducts.Columns.Add("Category", 100);
			lvProducts.Columns.Add("Name", 150);
			lvProducts.Columns.Add("Current Amount", 150);
			lvProducts.Columns.Add("Unit", 100);
			lvProducts.Columns.Add("Price (euro/pp)", 150);

			//Initialize dataTable and add columns
			dataTable = new DataTable();
			dataTable.Columns.Add("ID");
			dataTable.Columns.Add("Category");
			dataTable.Columns.Add("Name");
			dataTable.Columns.Add("Current Amount");
			dataTable.Columns.Add("Unit");
			dataTable.Columns.Add("Price (euro)");
		}

		private void PopulateListView(DataView dataView)
		{
			lvProducts.Items.Clear();

			foreach (DataRow row in dataView.ToTable().Rows)
			{
				lvProducts.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString()}));
			}
		}

		private void GeneralProductsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			DesktopAdministratorLoginOptionsForm loginOptionsForm = new DesktopAdministratorLoginOptionsForm();
			loginOptionsForm.Show();
			this.Hide();
		}

		private void GeneralProductsForm_Load(object sender, EventArgs e)
		{
			dataTable.Clear();

			if (desktopAdministratorProductManager != null)
			{
				foreach (Product product in desktopAdministratorProductManager.GetProducts())
				{
					dataTable.Rows.Add(product.Id, product.Category.Name, product.Name, product.CurrentAmount, product.Unit, product.Price);
				}

				dataView = new DataView(dataTable);
				PopulateListView(dataView);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddProductForm addProductForm = new AddProductForm();
			addProductForm.Show();
			this.Hide();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (lvProducts.SelectedItems.Count > 0)
			{
				var confirmation = MessageBox.Show($"Are you sure you want to delete this workout?",
					"Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (confirmation == DialogResult.Yes)
				{
					if (lvProducts.SelectedItems.Count == 0)
					{
						return;
					}

					int id = int.Parse(lvProducts.SelectedItems[0].SubItems[0].Text);

					Product product = desktopAdministratorProductManager.GetProductByID(id);
					desktopAdministratorProductManager.RemoveProduct(product);

					for (int i = lvProducts.SelectedItems.Count - 1; i >= 0; i--)
					{
						ListViewItem listViewItem = lvProducts.SelectedItems[i];
						lvProducts.Items[listViewItem.Index].Remove();
					}
				}
			}
			else
			{
				MessageBox.Show("Select a product first!", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (this._selectedProductFromLV != null)
			{
				Product product = this._selectedProductFromLV;

				EditProductForm editProductForm = new EditProductForm(product);
				editProductForm.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Select a product first!");
			}
		}

		private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvProducts.SelectedItems.Count == 0)
			{
				return;
			}

			int id = int.Parse(lvProducts.SelectedItems[0].SubItems[0].Text);
			Product product = desktopAdministratorProductManager.GetProductByID(id);

			_selectedProductFromLV = product;
		}
	}
}
