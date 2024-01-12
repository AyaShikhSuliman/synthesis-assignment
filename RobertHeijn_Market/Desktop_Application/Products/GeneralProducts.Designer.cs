namespace Desktop_Application.Products
{
	partial class GeneralProductsForm
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
			this.lvProducts = new System.Windows.Forms.ListView();
			this.lblProducts = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvProducts
			// 
			this.lvProducts.FullRowSelect = true;
			this.lvProducts.Location = new System.Drawing.Point(57, 70);
			this.lvProducts.Name = "lvProducts";
			this.lvProducts.Size = new System.Drawing.Size(697, 311);
			this.lvProducts.TabIndex = 0;
			this.lvProducts.UseCompatibleStateImageBehavior = false;
			this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.lvProducts_SelectedIndexChanged);
			// 
			// lblProducts
			// 
			this.lblProducts.AutoSize = true;
			this.lblProducts.Location = new System.Drawing.Point(57, 32);
			this.lblProducts.Name = "lblProducts";
			this.lblProducts.Size = new System.Drawing.Size(69, 20);
			this.lblProducts.TabIndex = 1;
			this.lblProducts.Text = "Products:";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(708, 402);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(46, 29);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(641, 402);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(46, 29);
			this.btnRemove.TabIndex = 3;
			this.btnRemove.Text = "-";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(574, 402);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(46, 29);
			this.btnEdit.TabIndex = 4;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// GeneralProductsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblProducts);
			this.Controls.Add(this.lvProducts);
			this.Name = "GeneralProductsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "General Products";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralProductsForm_FormClosing);
			this.Load += new System.EventHandler(this.GeneralProductsForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ListView lvProducts;
		private Label lblProducts;
		private Button btnAdd;
		private Button btnRemove;
		private Button btnEdit;
	}
}