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
			this.lblPIN = new System.Windows.Forms.Label();
			this.lblLoginTitle = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.tl2OptionsMain = new System.Windows.Forms.TableLayoutPanel();
			this.tlUserPwd = new System.Windows.Forms.TableLayoutPanel();
			this.tlPIN = new System.Windows.Forms.TableLayoutPanel();
			this.tlLoginMain = new System.Windows.Forms.TableLayoutPanel();
			this.tl2OptionsMain.SuspendLayout();
			this.tlUserPwd.SuspendLayout();
			this.tlPIN.SuspendLayout();
			this.tlLoginMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbUserName
			// 
			this.tbUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbUserName.Location = new System.Drawing.Point(245, 13);
			this.tbUserName.Name = "tbUserName";
			this.tbUserName.Size = new System.Drawing.Size(202, 22);
			this.tbUserName.TabIndex = 0;
			this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave);
			// 
			// tbPwd
			// 
			this.tbPwd.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbPwd.Location = new System.Drawing.Point(245, 61);
			this.tbPwd.Name = "tbPwd";
			this.tbPwd.Size = new System.Drawing.Size(202, 22);
			this.tbPwd.TabIndex = 1;
			this.tbPwd.Leave += new System.EventHandler(this.tbPwd_Leave);
			// 
			// tbPIN
			// 
			this.tbPIN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbPIN.Location = new System.Drawing.Point(245, 15);
			this.tbPIN.Name = "tbPIN";
			this.tbPIN.Size = new System.Drawing.Size(202, 22);
			this.tbPIN.TabIndex = 2;
			this.tbPIN.Leave += new System.EventHandler(this.tbPIN_Leave);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// lblPIN
			// 
			this.lblPIN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPIN.AutoSize = true;
			this.lblPIN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPIN.Location = new System.Drawing.Point(3, 17);
			this.lblPIN.Name = "lblPIN";
			this.lblPIN.Size = new System.Drawing.Size(36, 19);
			this.lblPIN.TabIndex = 5;
			this.lblPIN.Text = "PIN";
			// 
			// lblLoginTitle
			// 
			this.lblLoginTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblLoginTitle.AutoSize = true;
			this.lblLoginTitle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoginTitle.Location = new System.Drawing.Point(153, 0);
			this.lblLoginTitle.Name = "lblLoginTitle";
			this.lblLoginTitle.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.lblLoginTitle.Size = new System.Drawing.Size(195, 31);
			this.lblLoginTitle.TabIndex = 6;
			this.lblLoginTitle.Text = "Shoe Repair POS";
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnLogin.Location = new System.Drawing.Point(188, 211);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(125, 30);
			this.btnLogin.TabIndex = 10;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// tl2OptionsMain
			// 
			this.tl2OptionsMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
			this.tl2OptionsMain.ColumnCount = 1;
			this.tl2OptionsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tl2OptionsMain.Controls.Add(this.tlUserPwd, 0, 0);
			this.tl2OptionsMain.Controls.Add(this.tlPIN, 0, 1);
			this.tl2OptionsMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tl2OptionsMain.Location = new System.Drawing.Point(3, 34);
			this.tl2OptionsMain.Name = "tl2OptionsMain";
			this.tl2OptionsMain.RowCount = 2;
			this.tl2OptionsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.58382F));
			this.tl2OptionsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.41618F));
			this.tl2OptionsMain.Size = new System.Drawing.Size(496, 171);
			this.tl2OptionsMain.TabIndex = 12;
			// 
			// tlUserPwd
			// 
			this.tlUserPwd.ColumnCount = 2;
			this.tlUserPwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlUserPwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlUserPwd.Controls.Add(this.tbPwd, 1, 1);
			this.tlUserPwd.Controls.Add(this.tbUserName, 1, 0);
			this.tlUserPwd.Controls.Add(this.label2, 0, 1);
			this.tlUserPwd.Controls.Add(this.label1, 0, 0);
			this.tlUserPwd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlUserPwd.Location = new System.Drawing.Point(6, 6);
			this.tlUserPwd.Name = "tlUserPwd";
			this.tlUserPwd.RowCount = 2;
			this.tlUserPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlUserPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlUserPwd.Size = new System.Drawing.Size(484, 97);
			this.tlUserPwd.TabIndex = 0;
			// 
			// tlPIN
			// 
			this.tlPIN.ColumnCount = 2;
			this.tlPIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlPIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlPIN.Controls.Add(this.tbPIN, 1, 0);
			this.tlPIN.Controls.Add(this.lblPIN, 0, 0);
			this.tlPIN.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlPIN.Location = new System.Drawing.Point(6, 112);
			this.tlPIN.Name = "tlPIN";
			this.tlPIN.RowCount = 1;
			this.tlPIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlPIN.Size = new System.Drawing.Size(484, 53);
			this.tlPIN.TabIndex = 1;
			// 
			// tlLoginMain
			// 
			this.tlLoginMain.ColumnCount = 1;
			this.tlLoginMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlLoginMain.Controls.Add(this.btnLogin, 0, 2);
			this.tlLoginMain.Controls.Add(this.tl2OptionsMain, 0, 1);
			this.tlLoginMain.Controls.Add(this.lblLoginTitle, 0, 0);
			this.tlLoginMain.Location = new System.Drawing.Point(12, 12);
			this.tlLoginMain.Name = "tlLoginMain";
			this.tlLoginMain.RowCount = 3;
			this.tlLoginMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.378601F));
			this.tlLoginMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.41975F));
			this.tlLoginMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.99588F));
			this.tlLoginMain.Size = new System.Drawing.Size(502, 486);
			this.tlLoginMain.TabIndex = 13;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 610);
			this.Controls.Add(this.tlLoginMain);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Screen";
			this.Load += new System.EventHandler(this.Login_Load);
			this.tl2OptionsMain.ResumeLayout(false);
			this.tlUserPwd.ResumeLayout(false);
			this.tlUserPwd.PerformLayout();
			this.tlPIN.ResumeLayout(false);
			this.tlPIN.PerformLayout();
			this.tlLoginMain.ResumeLayout(false);
			this.tlLoginMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox tbUserName;
		private System.Windows.Forms.TextBox tbPwd;
		private System.Windows.Forms.TextBox tbPIN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblPIN;
		private System.Windows.Forms.Label lblLoginTitle;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TableLayoutPanel tl2OptionsMain;
		private System.Windows.Forms.TableLayoutPanel tlUserPwd;
		private System.Windows.Forms.TableLayoutPanel tlPIN;
		private System.Windows.Forms.TableLayoutPanel tlLoginMain;
	}
}

