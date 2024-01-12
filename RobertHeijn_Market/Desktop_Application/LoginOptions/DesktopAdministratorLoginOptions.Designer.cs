namespace Desktop_Application
{
	partial class DesktopAdministratorLoginOptionsForm
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
			this.btnAdministrators = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnProducts = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAdministrators
			// 
			this.btnAdministrators.Location = new System.Drawing.Point(231, 197);
			this.btnAdministrators.Name = "btnAdministrators";
			this.btnAdministrators.Size = new System.Drawing.Size(251, 29);
			this.btnAdministrators.TabIndex = 4;
			this.btnAdministrators.Text = "Desktop Administrators";
			this.btnAdministrators.UseVisualStyleBackColor = true;
			this.btnAdministrators.Click += new System.EventHandler(this.btnAdministrators_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(231, 232);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(251, 29);
			this.button1.TabIndex = 5;
			this.button1.Text = "Website Administrators";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnProducts
			// 
			this.btnProducts.Location = new System.Drawing.Point(231, 162);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Size = new System.Drawing.Size(251, 29);
			this.btnProducts.TabIndex = 6;
			this.btnProducts.Text = "Products";
			this.btnProducts.UseVisualStyleBackColor = true;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// DesktopAdministratorLoginOptionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnProducts);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnAdministrators);
			this.Name = "DesktopAdministratorLoginOptionsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Desktop Administrator Login Options";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginOptionsForm_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion
		private Button btnAdministrators;
		private Button button1;
		private Button btnProducts;
	}
}