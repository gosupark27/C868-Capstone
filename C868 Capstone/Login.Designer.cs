namespace C868_Capstone
{
	partial class Login
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
			this.tbUserName = new System.Windows.Forms.TextBox();
			this.tbPwd = new System.Windows.Forms.TextBox();
			this.tbPIN = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblLoginTitle = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnLogin = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbUserName
			// 
			this.tbUserName.Location = new System.Drawing.Point(97, 14);
			this.tbUserName.Name = "tbUserName";
			this.tbUserName.Size = new System.Drawing.Size(150, 22);
			this.tbUserName.TabIndex = 0;
			// 
			// tbPwd
			// 
			this.tbPwd.Location = new System.Drawing.Point(97, 58);
			this.tbPwd.Name = "tbPwd";
			this.tbPwd.Size = new System.Drawing.Size(150, 22);
			this.tbPwd.TabIndex = 1;
			// 
			// tbPIN
			// 
			this.tbPIN.Location = new System.Drawing.Point(97, 14);
			this.tbPIN.Name = "tbPIN";
			this.tbPIN.Size = new System.Drawing.Size(150, 22);
			this.tbPIN.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "PIN";
			// 
			// lblLoginTitle
			// 
			this.lblLoginTitle.AutoSize = true;
			this.lblLoginTitle.Location = new System.Drawing.Point(135, 9);
			this.lblLoginTitle.Name = "lblLoginTitle";
			this.lblLoginTitle.Size = new System.Drawing.Size(120, 17);
			this.lblLoginTitle.TabIndex = 6;
			this.lblLoginTitle.Text = "Shoe Repair POS";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tbUserName);
			this.panel1.Controls.Add(this.tbPwd);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(57, 43);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(266, 99);
			this.panel1.TabIndex = 8;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tbPIN);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(57, 166);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(266, 51);
			this.panel2.TabIndex = 9;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(130, 228);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(125, 30);
			this.btnLogin.TabIndex = 10;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(57, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "OR";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 270);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblLoginTitle);
			this.Name = "Login";
			this.Text = "Login Screen";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbUserName;
		private System.Windows.Forms.TextBox tbPwd;
		private System.Windows.Forms.TextBox tbPIN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblLoginTitle;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label label4;
	}
}

