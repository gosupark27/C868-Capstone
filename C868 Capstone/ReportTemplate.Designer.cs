namespace C868_Capstone
{
	partial class ReportTemplate
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
			this.btnBack = new System.Windows.Forms.Button();
			this.tlReportMain = new System.Windows.Forms.TableLayoutPanel();
			this.tlMain = new System.Windows.Forms.TableLayoutPanel();
			this.lblRN = new System.Windows.Forms.Label();
			this.dgvReport = new System.Windows.Forms.DataGridView();
			this.lblGT = new System.Windows.Forms.Label();
			this.tlReportMain.SuspendLayout();
			this.tlMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBack.Location = new System.Drawing.Point(703, 441);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(100, 39);
			this.btnBack.TabIndex = 1;
			this.btnBack.Text = "Go Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// tlReportMain
			// 
			this.tlReportMain.ColumnCount = 2;
			this.tlReportMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlReportMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tlReportMain.Controls.Add(this.tlMain, 0, 0);
			this.tlReportMain.Controls.Add(this.btnBack, 1, 1);
			this.tlReportMain.Controls.Add(this.lblGT, 0, 1);
			this.tlReportMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlReportMain.Location = new System.Drawing.Point(0, 0);
			this.tlReportMain.Name = "tlReportMain";
			this.tlReportMain.RowCount = 2;
			this.tlReportMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.89027F));
			this.tlReportMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.109731F));
			this.tlReportMain.Size = new System.Drawing.Size(806, 483);
			this.tlReportMain.TabIndex = 2;
			// 
			// tlMain
			// 
			this.tlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlMain.AutoSize = true;
			this.tlMain.ColumnCount = 1;
			this.tlReportMain.SetColumnSpan(this.tlMain, 2);
			this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlMain.Controls.Add(this.lblRN, 0, 0);
			this.tlMain.Controls.Add(this.dgvReport, 0, 1);
			this.tlMain.Location = new System.Drawing.Point(3, 3);
			this.tlMain.Name = "tlMain";
			this.tlMain.RowCount = 2;
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.270677F));
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.72932F));
			this.tlMain.Size = new System.Drawing.Size(800, 432);
			this.tlMain.TabIndex = 3;
			// 
			// lblRN
			// 
			this.lblRN.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblRN.AutoSize = true;
			this.lblRN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRN.Location = new System.Drawing.Point(333, 0);
			this.lblRN.Name = "lblRN";
			this.lblRN.Size = new System.Drawing.Size(133, 24);
			this.lblRN.TabIndex = 0;
			this.lblRN.Text = "Report Name";
			// 
			// dgvReport
			// 
			this.dgvReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReport.Location = new System.Drawing.Point(32, 38);
			this.dgvReport.Name = "dgvReport";
			this.dgvReport.RowHeadersWidth = 51;
			this.dgvReport.RowTemplate.Height = 24;
			this.dgvReport.Size = new System.Drawing.Size(735, 360);
			this.dgvReport.TabIndex = 1;
			// 
			// lblGT
			// 
			this.lblGT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblGT.AutoSize = true;
			this.lblGT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGT.Location = new System.Drawing.Point(3, 438);
			this.lblGT.Name = "lblGT";
			this.lblGT.Size = new System.Drawing.Size(680, 45);
			this.lblGT.TabIndex = 4;
			this.lblGT.Text = "Grand Total: ";
			this.lblGT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ReportTemplate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(806, 483);
			this.Controls.Add(this.tlReportMain);
			this.Name = "ReportTemplate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ReportTemplate";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportTemplate_FormClosing);
			this.tlReportMain.ResumeLayout(false);
			this.tlReportMain.PerformLayout();
			this.tlMain.ResumeLayout(false);
			this.tlMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.TableLayoutPanel tlReportMain;
		private System.Windows.Forms.TableLayoutPanel tlMain;
		private System.Windows.Forms.Label lblRN;
		private System.Windows.Forms.DataGridView dgvReport;
		private System.Windows.Forms.Label lblGT;
	}
}