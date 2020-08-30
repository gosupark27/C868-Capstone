namespace C868_Capstone
{
	partial class TicketTemplate
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
			this.tlMain = new System.Windows.Forms.TableLayoutPanel();
			this.lblCN = new System.Windows.Forms.Label();
			this.lblTN = new System.Windows.Forms.Label();
			this.lblSI = new System.Windows.Forms.Label();
			this.lblSIR = new System.Windows.Forms.Label();
			this.btnCT = new System.Windows.Forms.Button();
			this.tlSI = new System.Windows.Forms.TableLayoutPanel();
			this.tlSIR = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tlMain.SuspendLayout();
			this.tlSI.SuspendLayout();
			this.tlSIR.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlMain
			// 
			this.tlMain.ColumnCount = 2;
			this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlMain.Controls.Add(this.lblSI, 0, 1);
			this.tlMain.Controls.Add(this.lblTN, 1, 0);
			this.tlMain.Controls.Add(this.lblCN, 0, 0);
			this.tlMain.Controls.Add(this.lblSIR, 0, 3);
			this.tlMain.Controls.Add(this.btnCT, 0, 5);
			this.tlMain.Controls.Add(this.tlSI, 0, 2);
			this.tlMain.Controls.Add(this.tlSIR, 0, 4);
			this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlMain.Location = new System.Drawing.Point(0, 0);
			this.tlMain.Name = "tlMain";
			this.tlMain.RowCount = 6;
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlMain.Size = new System.Drawing.Size(800, 450);
			this.tlMain.TabIndex = 0;
			// 
			// lblCN
			// 
			this.lblCN.AutoSize = true;
			this.lblCN.Location = new System.Drawing.Point(3, 0);
			this.lblCN.Name = "lblCN";
			this.lblCN.Size = new System.Drawing.Size(66, 17);
			this.lblCN.TabIndex = 0;
			this.lblCN.Text = "First Last";
			// 
			// lblTN
			// 
			this.lblTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTN.AutoSize = true;
			this.lblTN.Location = new System.Drawing.Point(749, 0);
			this.lblTN.Name = "lblTN";
			this.lblTN.Size = new System.Drawing.Size(48, 17);
			this.lblTN.TabIndex = 1;
			this.lblTN.Text = "#1234";
			// 
			// lblSI
			// 
			this.lblSI.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblSI.AutoSize = true;
			this.tlMain.SetColumnSpan(this.lblSI, 2);
			this.lblSI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSI.Location = new System.Drawing.Point(343, 30);
			this.lblSI.Name = "lblSI";
			this.lblSI.Size = new System.Drawing.Size(114, 24);
			this.lblSI.TabIndex = 2;
			this.lblSI.Text = "Select Item";
			// 
			// lblSIR
			// 
			this.lblSIR.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblSIR.AutoSize = true;
			this.tlMain.SetColumnSpan(this.lblSIR, 2);
			this.lblSIR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSIR.Location = new System.Drawing.Point(297, 220);
			this.lblSIR.Name = "lblSIR";
			this.lblSIR.Size = new System.Drawing.Size(206, 24);
			this.lblSIR.TabIndex = 3;
			this.lblSIR.Text = "Select Item Repair(s)";
			// 
			// btnCT
			// 
			this.btnCT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.tlMain.SetColumnSpan(this.btnCT, 2);
			this.btnCT.Location = new System.Drawing.Point(332, 417);
			this.btnCT.Name = "btnCT";
			this.btnCT.Size = new System.Drawing.Size(136, 30);
			this.btnCT.TabIndex = 4;
			this.btnCT.Text = "Create Ticket";
			this.btnCT.UseVisualStyleBackColor = true;
			// 
			// tlSI
			// 
			this.tlSI.ColumnCount = 5;
			this.tlMain.SetColumnSpan(this.tlSI, 2);
			this.tlSI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlSI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlSI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlSI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlSI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlSI.Controls.Add(this.comboBox2, 1, 0);
			this.tlSI.Controls.Add(this.label1, 0, 0);
			this.tlSI.Controls.Add(this.label2, 2, 0);
			this.tlSI.Controls.Add(this.button1, 4, 0);
			this.tlSI.Controls.Add(this.comboBox1, 3, 0);
			this.tlSI.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlSI.Location = new System.Drawing.Point(3, 63);
			this.tlSI.Name = "tlSI";
			this.tlSI.RowCount = 1;
			this.tlSI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlSI.Size = new System.Drawing.Size(794, 154);
			this.tlSI.TabIndex = 5;
			// 
			// tlSIR
			// 
			this.tlSIR.ColumnCount = 5;
			this.tlMain.SetColumnSpan(this.tlSIR, 2);
			this.tlSIR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlSIR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlSIR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlSIR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlSIR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlSIR.Controls.Add(this.comboBox3, 1, 0);
			this.tlSIR.Controls.Add(this.button2, 4, 0);
			this.tlSIR.Controls.Add(this.label3, 0, 0);
			this.tlSIR.Controls.Add(this.label4, 2, 0);
			this.tlSIR.Controls.Add(this.textBox1, 3, 0);
			this.tlSIR.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlSIR.Location = new System.Drawing.Point(3, 253);
			this.tlSIR.Name = "tlSIR";
			this.tlSIR.RowCount = 1;
			this.tlSIR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlSIR.Size = new System.Drawing.Size(794, 154);
			this.tlSIR.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(319, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(319, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "label4";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(635, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(635, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(477, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 3;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(161, 3);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 24);
			this.comboBox2.TabIndex = 4;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(161, 3);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 24);
			this.comboBox3.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(477, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 5;
			// 
			// TicketTemplateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tlMain);
			this.Name = "TicketTemplateForm";
			this.Text = "NewTicketForm";
			this.tlMain.ResumeLayout(false);
			this.tlMain.PerformLayout();
			this.tlSI.ResumeLayout(false);
			this.tlSI.PerformLayout();
			this.tlSIR.ResumeLayout(false);
			this.tlSIR.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlMain;
		private System.Windows.Forms.Label lblSI;
		private System.Windows.Forms.Label lblTN;
		private System.Windows.Forms.Label lblCN;
		private System.Windows.Forms.Label lblSIR;
		private System.Windows.Forms.Button btnCT;
		private System.Windows.Forms.TableLayoutPanel tlSI;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TableLayoutPanel tlSIR;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
	}
}