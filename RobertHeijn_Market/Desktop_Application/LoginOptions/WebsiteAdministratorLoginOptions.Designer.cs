namespace Desktop_Application
{
	partial class WebsiteAdministratorLoginOptionsForm
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
			this.btnOrders = new System.Windows.Forms.Button();
			this.btnContactForms = new System.Windows.Forms.Button();
			this.btnCustomers = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOrders
			// 
			this.btnOrders.Location = new System.Drawing.Point(324, 211);
			this.btnOrders.Name = "btnOrders";
			this.btnOrders.Size = new System.Drawing.Size(153, 29);
			this.btnOrders.TabIndex = 3;
			this.btnOrders.Text = "Orders";
			this.btnOrders.UseVisualStyleBackColor = true;
			// 
			// btnContactForms
			// 
			this.btnContactForms.Location = new System.Drawing.Point(324, 246);
			this.btnContactForms.Name = "btnContactForms";
			this.btnContactForms.Size = new System.Drawing.Size(153, 29);
			this.btnContactForms.TabIndex = 5;
			this.btnContactForms.Text = "Contact Forms";
			this.btnContactForms.UseVisualStyleBackColor = true;
			// 
			// btnCustomers
			// 
			this.btnCustomers.Location = new System.Drawing.Point(324, 176);
			this.btnCustomers.Name = "btnCustomers";
			this.btnCustomers.Size = new System.Drawing.Size(153, 29);
			this.btnCustomers.TabIndex = 4;
			this.btnCustomers.Text = "Customers";
			this.btnCustomers.UseVisualStyleBackColor = true;
			// 
			// WebsiteAdministratorLoginOptionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnContactForms);
			this.Controls.Add(this.btnCustomers);
			this.Controls.Add(this.btnOrders);
			this.Name = "WebsiteAdministratorLoginOptionsForm";
			this.Text = "Website Administrator Login Options";
			this.Load += new System.EventHandler(this.WebsiteAdministratorLoginOptions_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private Button btnOrders;
		private Button btnContactForms;
		private Button btnCustomers;
	}
}