namespace C868_Capstone
{
	partial class MainScreen1
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgvCust = new System.Windows.Forms.DataGridView();
			this.btnDelCust = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lblCustInfo = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbLast = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbFirst = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.lblTicket = new System.Windows.Forms.Label();
			this.dgvTicket = new System.Windows.Forms.DataGridView();
			this.btnReport = new System.Windows.Forms.Button();
			this.cbReportType = new System.Windows.Forms.ComboBox();
			this.cbSort = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.ticketSb = new System.Windows.Forms.VScrollBar();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.splitContainer1.Panel1.Controls.Add(this.panel2);
			this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
			this.splitContainer1.Panel1.Controls.Add(this.lblCustInfo);
			this.splitContainer1.Panel1.Controls.Add(this.tbSearch);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.btnSubmit);
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1207, 675);
			this.splitContainer1.SplitterDistance = 635;
			this.splitContainer1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgvCust);
			this.panel2.Controls.Add(this.btnDelCust);
			this.panel2.Location = new System.Drawing.Point(3, 74);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(577, 297);
			this.panel2.TabIndex = 14;
			// 
			// dgvCust
			// 
			this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCust.Location = new System.Drawing.Point(13, 15);
			this.dgvCust.Name = "dgvCust";
			this.dgvCust.RowHeadersWidth = 51;
			this.dgvCust.RowTemplate.Height = 24;
			this.dgvCust.Size = new System.Drawing.Size(548, 232);
			this.dgvCust.TabIndex = 3;
			this.dgvCust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCust_CellClick);
			// 
			// btnDelCust
			// 
			this.btnDelCust.Location = new System.Drawing.Point(225, 264);
			this.btnDelCust.Name = "btnDelCust";
			this.btnDelCust.Size = new System.Drawing.Size(125, 30);
			this.btnDelCust.TabIndex = 2;
			this.btnDelCust.Text = "Delete Customer ";
			this.btnDelCust.UseVisualStyleBackColor = true;
			this.btnDelCust.Click += new System.EventHandler(this.btnDelCust_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(490, 43);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(70, 27);
			this.btnSearch.TabIndex = 12;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lblCustInfo
			// 
			this.lblCustInfo.AutoSize = true;
			this.lblCustInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustInfo.Location = new System.Drawing.Point(9, 9);
			this.lblCustInfo.Name = "lblCustInfo";
			this.lblCustInfo.Size = new System.Drawing.Size(108, 17);
			this.lblCustInfo.TabIndex = 11;
			this.lblCustInfo.Text = "Customer Info";
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(83, 44);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(401, 22);
			this.tbSearch.TabIndex = 10;
			this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Search:";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(228, 573);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(125, 30);
			this.btnSubmit.TabIndex = 1;
			this.btnSubmit.Text = "Add Customer";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.tbPhone);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.tbLast);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tbFirst);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(84, 391);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(391, 157);
			this.panel1.TabIndex = 0;
			// 
			// tbPhone
			// 
			this.tbPhone.Location = new System.Drawing.Point(135, 112);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(218, 22);
			this.tbPhone.TabIndex = 8;
			this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
			this.tbPhone.Leave += new System.EventHandler(this.tbPhone_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Phone Number:";
			// 
			// tbLast
			// 
			this.tbLast.Location = new System.Drawing.Point(135, 62);
			this.tbLast.Name = "tbLast";
			this.tbLast.Size = new System.Drawing.Size(218, 22);
			this.tbLast.TabIndex = 4;
			this.tbLast.TextChanged += new System.EventHandler(this.tbLast_TextChanged);
			this.tbLast.Leave += new System.EventHandler(this.tbLast_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Last Name";
			// 
			// tbFirst
			// 
			this.tbFirst.Location = new System.Drawing.Point(135, 19);
			this.tbFirst.Name = "tbFirst";
			this.tbFirst.Size = new System.Drawing.Size(218, 22);
			this.tbFirst.TabIndex = 6;
			this.tbFirst.TextChanged += new System.EventHandler(this.tbFirst_TextChanged);
			this.tbFirst.Leave += new System.EventHandler(this.tbFirst_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "First Name:";
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.panel4);
			this.splitContainer2.Panel1.Controls.Add(this.panel3);
			this.splitContainer2.Panel1.Controls.Add(this.lblTicket);
			this.splitContainer2.Panel1.Controls.Add(this.dgvTicket);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.splitContainer2.Size = new System.Drawing.Size(568, 675);
			this.splitContainer2.SplitterDistance = 646;
			this.splitContainer2.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.cbSort);
			this.panel3.Controls.Add(this.cbReportType);
			this.panel3.Controls.Add(this.btnReport);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Location = new System.Drawing.Point(25, 391);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(501, 236);
			this.panel3.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label7.Location = new System.Drawing.Point(224, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 17);
			this.label7.TabIndex = 13;
			this.label7.Text = "Reports";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblTicket
			// 
			this.lblTicket.AutoSize = true;
			this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTicket.Location = new System.Drawing.Point(8, 9);
			this.lblTicket.Name = "lblTicket";
			this.lblTicket.Size = new System.Drawing.Size(145, 17);
			this.lblTicket.TabIndex = 12;
			this.lblTicket.Text = "Customer\'s Tickets";
			// 
			// dgvTicket
			// 
			this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTicket.Location = new System.Drawing.Point(11, 29);
			this.dgvTicket.Name = "dgvTicket";
			this.dgvTicket.RowHeadersWidth = 51;
			this.dgvTicket.RowTemplate.Height = 24;
			this.dgvTicket.Size = new System.Drawing.Size(502, 88);
			this.dgvTicket.TabIndex = 12;
			// 
			// btnReport
			// 
			this.btnReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnReport.Location = new System.Drawing.Point(190, 182);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(125, 30);
			this.btnReport.TabIndex = 16;
			this.btnReport.Text = "Create Report";
			this.btnReport.UseVisualStyleBackColor = true;
			// 
			// cbReportType
			// 
			this.cbReportType.FormattingEnabled = true;
			this.cbReportType.Location = new System.Drawing.Point(26, 55);
			this.cbReportType.Name = "cbReportType";
			this.cbReportType.Size = new System.Drawing.Size(121, 24);
			this.cbReportType.TabIndex = 17;
			// 
			// cbSort
			// 
			this.cbSort.FormattingEnabled = true;
			this.cbSort.Location = new System.Drawing.Point(377, 55);
			this.cbSort.Name = "cbSort";
			this.cbSort.Size = new System.Drawing.Size(121, 24);
			this.cbSort.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(167, 58);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(189, 17);
			this.label6.TabIndex = 20;
			this.label6.Text = "Have Date Range filter here ";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel4.Controls.Add(this.ticketSb);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Location = new System.Drawing.Point(11, 123);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(502, 265);
			this.panel4.TabIndex = 18;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel5.Location = new System.Drawing.Point(14, 14);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(460, 100);
			this.panel5.TabIndex = 0;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel6.Location = new System.Drawing.Point(14, 120);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(460, 100);
			this.panel6.TabIndex = 1;
			// 
			// ticketSb
			// 
			this.ticketSb.Location = new System.Drawing.Point(478, 13);
			this.ticketSb.Name = "ticketSb";
			this.ticketSb.Size = new System.Drawing.Size(21, 207);
			this.ticketSb.TabIndex = 2;
			this.ticketSb.ValueChanged += new System.EventHandler(this.ticketSb_ValueChanged);
			// 
			// MainScreen1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1207, 675);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MainScreen1";
			this.Text = "Main Screen ";
			this.Load += new System.EventHandler(this.MainScreen1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnDelCust;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Label lblCustInfo;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvCust;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbLast;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbFirst;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTicket;
		private System.Windows.Forms.DataGridView dgvTicket;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbSort;
		private System.Windows.Forms.ComboBox cbReportType;
		private System.Windows.Forms.Button btnReport;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.VScrollBar ticketSb;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel5;
	}
}