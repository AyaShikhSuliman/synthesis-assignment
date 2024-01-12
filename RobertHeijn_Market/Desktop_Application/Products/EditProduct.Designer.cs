namespace Desktop_Application.Products
{
	partial class EditProductForm
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
			this.btnEdit = new System.Windows.Forms.Button();
			this.cbUnit = new System.Windows.Forms.ComboBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.lblUnit = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblProducts = new System.Windows.Forms.Label();
			this.tbId = new System.Windows.Forms.TextBox();
			this.lblId = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.lblCurrentAmount = new System.Windows.Forms.Label();
			this.tbCurrentAmount = new System.Windows.Forms.TextBox();
			this.tbImage = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(110, 394);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(581, 29);
			this.btnEdit.TabIndex = 34;
			this.btnEdit.Text = "Edit product";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// cbUnit
			// 
			this.cbUnit.FormattingEnabled = true;
			this.cbUnit.Items.AddRange(new object[] {
            "piece",
            "box",
            "kilo",
            "pack"});
			this.cbUnit.Location = new System.Drawing.Point(244, 249);
			this.cbUnit.Name = "cbUnit";
			this.cbUnit.Size = new System.Drawing.Size(445, 28);
			this.cbUnit.TabIndex = 33;
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(179, 305);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(44, 20);
			this.lblPrice.TabIndex = 30;
			this.lblPrice.Text = "Price:";
			// 
			// tbPrice
			// 
			this.tbPrice.Location = new System.Drawing.Point(244, 298);
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(376, 27);
			this.tbPrice.TabIndex = 29;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(244, 153);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(445, 27);
			this.tbName.TabIndex = 27;
			// 
			// lblUnit
			// 
			this.lblUnit.AutoSize = true;
			this.lblUnit.Location = new System.Drawing.Point(184, 252);
			this.lblUnit.Name = "lblUnit";
			this.lblUnit.Size = new System.Drawing.Size(39, 20);
			this.lblUnit.TabIndex = 26;
			this.lblUnit.Text = "Unit:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(171, 156);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(52, 20);
			this.lblName.TabIndex = 24;
			this.lblName.Text = "Name:";
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(151, 107);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(72, 20);
			this.lblCategory.TabIndex = 22;
			this.lblCategory.Text = "Category:";
			// 
			// lblProducts
			// 
			this.lblProducts.AutoSize = true;
			this.lblProducts.Location = new System.Drawing.Point(109, 29);
			this.lblProducts.Name = "lblProducts";
			this.lblProducts.Size = new System.Drawing.Size(106, 20);
			this.lblProducts.TabIndex = 21;
			this.lblProducts.Text = "Edit a product:";
			// 
			// tbId
			// 
			this.tbId.Enabled = false;
			this.tbId.Location = new System.Drawing.Point(244, 56);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(445, 27);
			this.tbId.TabIndex = 36;
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(188, 59);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(25, 20);
			this.lblId.TabIndex = 35;
			this.lblId.Text = "Id:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(625, 302);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 20);
			this.label1.TabIndex = 37;
			this.label1.Text = "euro/pp";
			// 
			// cbCategory
			// 
			this.cbCategory.Enabled = false;
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Items.AddRange(new object[] {
            "piece",
            "box",
            "kilo",
            "pack"});
			this.cbCategory.Location = new System.Drawing.Point(244, 104);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(445, 28);
			this.cbCategory.TabIndex = 39;
			// 
			// lblCurrentAmount
			// 
			this.lblCurrentAmount.AutoSize = true;
			this.lblCurrentAmount.Location = new System.Drawing.Point(108, 204);
			this.lblCurrentAmount.Name = "lblCurrentAmount";
			this.lblCurrentAmount.Size = new System.Drawing.Size(115, 20);
			this.lblCurrentAmount.TabIndex = 25;
			this.lblCurrentAmount.Text = "Current amount:";
			// 
			// tbCurrentAmount
			// 
			this.tbCurrentAmount.Location = new System.Drawing.Point(244, 201);
			this.tbCurrentAmount.Name = "tbCurrentAmount";
			this.tbCurrentAmount.Size = new System.Drawing.Size(445, 27);
			this.tbCurrentAmount.TabIndex = 28;
			// 
			// tbImage
			// 
			this.tbImage.Location = new System.Drawing.Point(244, 346);
			this.tbImage.Name = "tbImage";
			this.tbImage.Size = new System.Drawing.Size(445, 27);
			this.tbImage.TabIndex = 41;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(169, 349);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 20);
			this.label2.TabIndex = 40;
			this.label2.Text = "Image:";
			// 
			// EditProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tbImage);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbCategory);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.cbUnit);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.tbCurrentAmount);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.lblUnit);
			this.Controls.Add(this.lblCurrentAmount);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.lblProducts);
			this.Name = "EditProductForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EditProduct";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditProductForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnEdit;
		private ComboBox cbUnit;
		private Label lblPrice;
		private TextBox tbPrice;
		private TextBox tbName;
		private Label lblUnit;
		private Label lblName;
		private Label lblCategory;
		private Label lblProducts;
		private TextBox tbId;
		private Label lblId;
		private Label label1;
		private ComboBox cbCategory;
		private Label lblCurrentAmount;
		private TextBox tbCurrentAmount;
		private TextBox tbImage;
		private Label label2;
	}
}