namespace Desktop_Application
{
	partial class LoginForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblEmailAddress = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.tbEmailAddress = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.rbDesktopAdministrator = new System.Windows.Forms.RadioButton();
			this.rbWebsiteAdministrator = new System.Windows.Forms.RadioButton();
			this.rbCutsomer = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(207, 300);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(363, 29);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblEmailAddress
			// 
			this.lblEmailAddress.AutoSize = true;
			this.lblEmailAddress.Location = new System.Drawing.Point(207, 151);
			this.lblEmailAddress.Name = "lblEmailAddress";
			this.lblEmailAddress.Size = new System.Drawing.Size(104, 20);
			this.lblEmailAddress.TabIndex = 1;
			this.lblEmailAddress.Text = "Email address:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(238, 180);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(73, 20);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password:";
			// 
			// tbEmailAddress
			// 
			this.tbEmailAddress.Location = new System.Drawing.Point(336, 144);
			this.tbEmailAddress.Name = "tbEmailAddress";
			this.tbEmailAddress.Size = new System.Drawing.Size(234, 27);
			this.tbEmailAddress.TabIndex = 3;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(336, 177);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(234, 27);
			this.tbPassword.TabIndex = 4;
			// 
			// rbDesktopAdministrator
			// 
			this.rbDesktopAdministrator.AutoSize = true;
			this.rbDesktopAdministrator.Location = new System.Drawing.Point(336, 210);
			this.rbDesktopAdministrator.Name = "rbDesktopAdministrator";
			this.rbDesktopAdministrator.Size = new System.Drawing.Size(180, 24);
			this.rbDesktopAdministrator.TabIndex = 5;
			this.rbDesktopAdministrator.TabStop = true;
			this.rbDesktopAdministrator.Text = "Desktop Administrator";
			this.rbDesktopAdministrator.UseVisualStyleBackColor = true;
			// 
			// rbWebsiteAdministrator
			// 
			this.rbWebsiteAdministrator.AutoSize = true;
			this.rbWebsiteAdministrator.Location = new System.Drawing.Point(336, 240);
			this.rbWebsiteAdministrator.Name = "rbWebsiteAdministrator";
			this.rbWebsiteAdministrator.Size = new System.Drawing.Size(178, 24);
			this.rbWebsiteAdministrator.TabIndex = 6;
			this.rbWebsiteAdministrator.TabStop = true;
			this.rbWebsiteAdministrator.Text = "Website Administrator";
			this.rbWebsiteAdministrator.UseVisualStyleBackColor = true;
			// 
			// rbCutsomer
			// 
			this.rbCutsomer.AutoSize = true;
			this.rbCutsomer.Location = new System.Drawing.Point(336, 270);
			this.rbCutsomer.Name = "rbCutsomer";
			this.rbCutsomer.Size = new System.Drawing.Size(93, 24);
			this.rbCutsomer.TabIndex = 7;
			this.rbCutsomer.TabStop = true;
			this.rbCutsomer.Text = "Customer";
			this.rbCutsomer.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(212, 212);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Account type:";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rbCutsomer);
			this.Controls.Add(this.rbWebsiteAdministrator);
			this.Controls.Add(this.rbDesktopAdministrator);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbEmailAddress);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblEmailAddress);
			this.Controls.Add(this.btnLogin);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnLogin;
		private Label lblEmailAddress;
		private Label lblPassword;
		private TextBox tbEmailAddress;
		private TextBox tbPassword;
		private RadioButton rbDesktopAdministrator;
		private RadioButton rbWebsiteAdministrator;
		private RadioButton rbCutsomer;
		private Label label1;
	}
}