namespace Desktop_Application.Products
{
	partial class AddProductForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblProducts = new System.Windows.Forms.Label();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblSubCategory = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblCurrentAmount = new System.Windows.Forms.Label();
			this.lblUnit = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbCurrentAmount = new System.Windows.Forms.TextBox();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.cbCategories = new System.Windows.Forms.ComboBox();
			this.cbSubCategories = new System.Windows.Forms.ComboBox();
			this.cbUnit = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tbImage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblProducts
			// 
			this.lblProducts.AutoSize = true;
			this.lblProducts.Location = new System.Drawing.Point(109, 29);
			this.lblProducts.Name = "lblProducts";
			this.lblProducts.Size = new System.Drawing.Size(108, 20);
			this.lblProducts.TabIndex = 2;
			this.lblProducts.Text = "Add a product:";
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(152, 58);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(72, 20);
			this.lblCategory.TabIndex = 4;
			this.lblCategory.Text = "Category:";
			// 
			// lblSubCategory
			// 
			this.lblSubCategory.AutoSize = true;
			this.lblSubCategory.Location = new System.Drawing.Point(125, 107);
			this.lblSubCategory.Name = "lblSubCategory";
			this.lblSubCategory.Size = new System.Drawing.Size(101, 20);
			this.lblSubCategory.TabIndex = 5;
			this.lblSubCategory.Text = "Sub-category:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(172, 156);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(52, 20);
			this.lblName.TabIndex = 6;
			this.lblName.Text = "Name:";
			// 
			// lblCurrentAmount
			// 
			this.lblCurrentAmount.AutoSize = true;
			this.lblCurrentAmount.Location = new System.Drawing.Point(109, 204);
			this.lblCurrentAmount.Name = "lblCurrentAmount";
			this.lblCurrentAmount.Size = new System.Drawing.Size(115, 20);
			this.lblCurrentAmount.TabIndex = 7;
			this.lblCurrentAmount.Text = "Current amount:";
			// 
			// lblUnit
			// 
			this.lblUnit.AutoSize = true;
			this.lblUnit.Location = new System.Drawing.Point(185, 252);
			this.lblUnit.Name = "lblUnit";
			this.lblUnit.Size = new System.Drawing.Size(39, 20);
			this.lblUnit.TabIndex = 8;
			this.lblUnit.Text = "Unit:";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(245, 153);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(445, 27);
			this.tbName.TabIndex = 12;
			// 
			// tbCurrentAmount
			// 
			this.tbCurrentAmount.Location = new System.Drawing.Point(245, 201);
			this.tbCurrentAmount.Name = "tbCurrentAmount";
			this.tbCurrentAmount.Size = new System.Drawing.Size(445, 27);
			this.tbCurrentAmount.TabIndex = 13;
			// 
			// tbPrice
			// 
			this.tbPrice.Location = new System.Drawing.Point(245, 298);
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(376, 27);
			this.tbPrice.TabIndex = 14;
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(180, 305);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(44, 20);
			this.lblPrice.TabIndex = 15;
			this.lblPrice.Text = "Price:";
			// 
			// cbCategories
			// 
			this.cbCategories.FormattingEnabled = true;
			this.cbCategories.Location = new System.Drawing.Point(245, 55);
			this.cbCategories.Name = "cbCategories";
			this.cbCategories.Size = new System.Drawing.Size(445, 28);
			this.cbCategories.TabIndex = 17;
			this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
			// 
			// cbSubCategories
			// 
			this.cbSubCategories.FormattingEnabled = true;
			this.cbSubCategories.Location = new System.Drawing.Point(245, 104);
			this.cbSubCategories.Name = "cbSubCategories";
			this.cbSubCategories.Size = new System.Drawing.Size(445, 28);
			this.cbSubCategories.TabIndex = 18;
			// 
			// cbUnit
			// 
			this.cbUnit.FormattingEnabled = true;
			this.cbUnit.Items.AddRange(new object[] {
            "piece",
            "box",
            "kilo",
            "pack"});
			this.cbUnit.Location = new System.Drawing.Point(245, 249);
			this.cbUnit.Name = "cbUnit";
			this.cbUnit.Size = new System.Drawing.Size(445, 28);
			this.cbUnit.TabIndex = 19;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(109, 394);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(581, 29);
			this.btnAdd.TabIndex = 20;
			this.btnAdd.Text = "Add product";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(627, 301);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 20);
			this.label1.TabIndex = 21;
			this.label1.Text = "euro/pp";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(245, 346);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(445, 27);
			this.textBox1.TabIndex = 23;
			// 
			// tbImage
			// 
			this.tbImage.AutoSize = true;
			this.tbImage.Location = new System.Drawing.Point(170, 349);
			this.tbImage.Name = "tbImage";
			this.tbImage.Size = new System.Drawing.Size(54, 20);
			this.tbImage.TabIndex = 22;
			this.tbImage.Text = "Image:";
			// 
			// AddProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.tbImage);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cbUnit);
			this.Controls.Add(this.cbSubCategories);
			this.Controls.Add(this.cbCategories);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.tbCurrentAmount);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.lblUnit);
			this.Controls.Add(this.lblCurrentAmount);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblSubCategory);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.lblProducts);
			this.Name = "AddProductForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddProduct";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProductForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblProducts;
		private Label lblCategory;
		private Label lblSubCategory;
		private Label lblName;
		private Label lblCurrentAmount;
		private Label lblUnit;
		private TextBox tbName;
		private TextBox tbCurrentAmount;
		private TextBox tbPrice;
		private Label lblPrice;
		private ComboBox cbCategories;
		private ComboBox cbSubCategories;
		private ComboBox cbUnit;
		private Button btnAdd;
		private Label label1;
		private TextBox textBox1;
		private Label tbImage;
	}
}