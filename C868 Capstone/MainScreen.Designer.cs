namespace C868_Capstone
{
	partial class MainScreen
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
			this.tlCTVMain = new System.Windows.Forms.TableLayoutPanel();
			this.lblTicket = new System.Windows.Forms.Label();
			this.tlCTV = new System.Windows.Forms.TableLayoutPanel();
			this.tlCTVTemp = new System.Windows.Forms.TableLayoutPanel();
			this.lblTS = new System.Windows.Forms.Label();
			this.lblTN = new System.Windows.Forms.Label();
			this.btnStatus = new System.Windows.Forms.Button();
			this.tLRep = new System.Windows.Forms.TableLayoutPanel();
			this.btnReport = new System.Windows.Forms.Button();
			this.lblRT = new System.Windows.Forms.Label();
			this.cbReportType = new System.Windows.Forms.ComboBox();
			this.lblSort = new System.Windows.Forms.Label();
			this.cbSort = new System.Windows.Forms.ComboBox();
			this.rbWk = new System.Windows.Forms.RadioButton();
			this.monthCal = new System.Windows.Forms.MonthCalendar();
			this.rbMo = new System.Windows.Forms.RadioButton();
			this.lblReport = new System.Windows.Forms.Label();
			this.tLCI = new System.Windows.Forms.TableLayoutPanel();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.tlCIDetail = new System.Windows.Forms.TableLayoutPanel();
			this.tbFirst = new System.Windows.Forms.TextBox();
			this.lblFN = new System.Windows.Forms.Label();
			this.tbLast = new System.Windows.Forms.TextBox();
			this.lblLN = new System.Windows.Forms.Label();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.lblPN = new System.Windows.Forms.Label();
			this.lblCI = new System.Windows.Forms.Label();
			this.tLCS = new System.Windows.Forms.TableLayoutPanel();
			this.btnSearch = new System.Windows.Forms.Button();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.lblCS = new System.Windows.Forms.Label();
			this.btnDelCust = new System.Windows.Forms.Button();
			this.dgvCust = new System.Windows.Forms.DataGridView();
			this.tLMain = new System.Windows.Forms.TableLayoutPanel();
			this.btnDelTicket = new System.Windows.Forms.Button();
			this.btnAddTicket = new System.Windows.Forms.Button();
			this.tlCTVMain.SuspendLayout();
			this.tlCTV.SuspendLayout();
			this.tlCTVTemp.SuspendLayout();
			this.tLRep.SuspendLayout();
			this.tLCI.SuspendLayout();
			this.tlCIDetail.SuspendLayout();
			this.tLCS.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
			this.tLMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlCTVMain
			// 
			this.tlCTVMain.ColumnCount = 2;
			this.tlCTVMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlCTVMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
			this.tlCTVMain.Controls.Add(this.tlCTV, 0, 1);
			this.tlCTVMain.Controls.Add(this.btnAddTicket, 1, 0);
			this.tlCTVMain.Controls.Add(this.lblTicket, 0, 0);
			this.tlCTVMain.Location = new System.Drawing.Point(604, 6);
			this.tlCTVMain.Name = "tlCTVMain";
			this.tlCTVMain.RowCount = 2;
			this.tlCTVMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.511568F));
			this.tlCTVMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.48843F));
			this.tlCTVMain.Size = new System.Drawing.Size(590, 389);
			this.tlCTVMain.TabIndex = 12;
			// 
			// lblTicket
			// 
			this.lblTicket.AutoSize = true;
			this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTicket.Location = new System.Drawing.Point(3, 7);
			this.lblTicket.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
			this.lblTicket.Name = "lblTicket";
			this.lblTicket.Size = new System.Drawing.Size(193, 17);
			this.lblTicket.TabIndex = 14;
			this.lblTicket.Text = "Customer\'s Ticket History";
			this.lblTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tlCTV
			// 
			this.tlCTV.AutoScroll = true;
			this.tlCTV.BackColor = System.Drawing.Color.Transparent;
			this.tlCTV.ColumnCount = 2;
			this.tlCTVMain.SetColumnSpan(this.tlCTV, 2);
			this.tlCTV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlCTV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlCTV.Controls.Add(this.tlCTVTemp, 0, 0);
			this.tlCTV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlCTV.Location = new System.Drawing.Point(3, 40);
			this.tlCTV.Name = "tlCTV";
			this.tlCTV.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.tlCTV.RowCount = 1;
			this.tlCTV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.77228F));
			this.tlCTV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.77228F));
			this.tlCTV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.77228F));
			this.tlCTV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.77228F));
			this.tlCTV.Size = new System.Drawing.Size(584, 346);
			this.tlCTV.TabIndex = 20;
			// 
			// tlCTVTemp
			// 
			this.tlCTVTemp.BackColor = System.Drawing.SystemColors.Control;
			this.tlCTVTemp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlCTVTemp.ColumnCount = 2;
			this.tlCTV.SetColumnSpan(this.tlCTVTemp, 2);
			this.tlCTVTemp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlCTVTemp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlCTVTemp.Controls.Add(this.btnStatus, 1, 1);
			this.tlCTVTemp.Controls.Add(this.lblTN, 0, 0);
			this.tlCTVTemp.Controls.Add(this.lblTS, 0, 1);
			this.tlCTVTemp.Controls.Add(this.btnDelTicket, 1, 0);
			this.tlCTVTemp.Location = new System.Drawing.Point(3, 3);
			this.tlCTVTemp.Name = "tlCTVTemp";
			this.tlCTVTemp.RowCount = 2;
			this.tlCTVTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.32099F));
			this.tlCTVTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.67901F));
			this.tlCTVTemp.Size = new System.Drawing.Size(564, 77);
			this.tlCTVTemp.TabIndex = 16;
			this.tlCTVTemp.Click += new System.EventHandler(this.Panel_Click);
			this.tlCTVTemp.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
			this.tlCTVTemp.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
			// 
			// lblTS
			// 
			this.lblTS.AutoSize = true;
			this.lblTS.Location = new System.Drawing.Point(4, 42);
			this.lblTS.Name = "lblTS";
			this.lblTS.Size = new System.Drawing.Size(114, 17);
			this.lblTS.TabIndex = 1;
			this.lblTS.Text = "OPEN | CLOSED";
			// 
			// lblTN
			// 
			this.lblTN.AutoSize = true;
			this.lblTN.Location = new System.Drawing.Point(4, 1);
			this.lblTN.Name = "lblTN";
			this.lblTN.Size = new System.Drawing.Size(48, 17);
			this.lblTN.TabIndex = 0;
			this.lblTN.Text = "#1234";
			// 
			// btnStatus
			// 
			this.btnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStatus.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnStatus.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnStatus.Location = new System.Drawing.Point(285, 45);
			this.btnStatus.Name = "btnStatus";
			this.btnStatus.Size = new System.Drawing.Size(275, 28);
			this.btnStatus.TabIndex = 3;
			this.btnStatus.Text = "Close Ticket";
			this.btnStatus.UseVisualStyleBackColor = false;
			this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
			// 
			// tLRep
			// 
			this.tLRep.ColumnCount = 2;
			this.tLRep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.49153F));
			this.tLRep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.50848F));
			this.tLRep.Controls.Add(this.lblReport, 0, 0);
			this.tLRep.Controls.Add(this.rbMo, 0, 6);
			this.tLRep.Controls.Add(this.monthCal, 1, 1);
			this.tLRep.Controls.Add(this.rbWk, 0, 5);
			this.tLRep.Controls.Add(this.cbSort, 0, 4);
			this.tLRep.Controls.Add(this.lblSort, 0, 3);
			this.tLRep.Controls.Add(this.cbReportType, 0, 2);
			this.tLRep.Controls.Add(this.lblRT, 0, 1);
			this.tLRep.Controls.Add(this.btnReport, 0, 7);
			this.tLRep.Location = new System.Drawing.Point(604, 404);
			this.tLRep.Name = "tLRep";
			this.tLRep.RowCount = 8;
			this.tLRep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tLRep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tLRep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tLRep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
			this.tLRep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tLRep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.tLRep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
			this.tLRep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
			this.tLRep.Size = new System.Drawing.Size(590, 390);
			this.tLRep.TabIndex = 11;
			// 
			// btnReport
			// 
			this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tLRep.SetColumnSpan(this.btnReport, 2);
			this.btnReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnReport.Location = new System.Drawing.Point(202, 349);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(185, 31);
			this.btnReport.TabIndex = 30;
			this.btnReport.Text = "Create Report";
			this.btnReport.UseVisualStyleBackColor = true;
			this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
			// 
			// lblRT
			// 
			this.lblRT.AutoSize = true;
			this.lblRT.Location = new System.Drawing.Point(3, 45);
			this.lblRT.Name = "lblRT";
			this.lblRT.Size = new System.Drawing.Size(87, 17);
			this.lblRT.TabIndex = 32;
			this.lblRT.Text = "Report Type";
			// 
			// cbReportType
			// 
			this.cbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbReportType.FormattingEnabled = true;
			this.cbReportType.Location = new System.Drawing.Point(3, 72);
			this.cbReportType.Name = "cbReportType";
			this.cbReportType.Size = new System.Drawing.Size(144, 24);
			this.cbReportType.TabIndex = 24;
			this.cbReportType.SelectedIndexChanged += new System.EventHandler(this.cbReportType_SelectedIndexChanged);
			// 
			// lblSort
			// 
			this.lblSort.AutoSize = true;
			this.lblSort.Location = new System.Drawing.Point(3, 105);
			this.lblSort.Name = "lblSort";
			this.lblSort.Size = new System.Drawing.Size(54, 17);
			this.lblSort.TabIndex = 25;
			this.lblSort.Text = "Sort By";
			// 
			// cbSort
			// 
			this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSort.DropDownWidth = 144;
			this.cbSort.FormattingEnabled = true;
			this.cbSort.Location = new System.Drawing.Point(3, 127);
			this.cbSort.Name = "cbSort";
			this.cbSort.Size = new System.Drawing.Size(144, 24);
			this.cbSort.TabIndex = 26;
			// 
			// rbWk
			// 
			this.rbWk.AutoSize = true;
			this.rbWk.Location = new System.Drawing.Point(3, 164);
			this.rbWk.Name = "rbWk";
			this.rbWk.Size = new System.Drawing.Size(75, 21);
			this.rbWk.TabIndex = 28;
			this.rbWk.TabStop = true;
			this.rbWk.Text = "Weekly";
			this.rbWk.UseVisualStyleBackColor = true;
			this.rbWk.CheckedChanged += new System.EventHandler(this.rbWk_CheckedChanged);
			// 
			// monthCal
			// 
			this.monthCal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.monthCal.Location = new System.Drawing.Point(319, 54);
			this.monthCal.Name = "monthCal";
			this.tLRep.SetRowSpan(this.monthCal, 6);
			this.monthCal.ShowToday = false;
			this.monthCal.ShowTodayCircle = false;
			this.monthCal.TabIndex = 12;
			this.monthCal.TrailingForeColor = System.Drawing.Color.Gray;
			this.monthCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCal_DateChanged);
			this.monthCal.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCal_DateSelected);
			// 
			// rbMo
			// 
			this.rbMo.AutoSize = true;
			this.rbMo.Location = new System.Drawing.Point(3, 195);
			this.rbMo.Name = "rbMo";
			this.rbMo.Size = new System.Drawing.Size(78, 21);
			this.rbMo.TabIndex = 31;
			this.rbMo.TabStop = true;
			this.rbMo.Text = "Monthly";
			this.rbMo.UseVisualStyleBackColor = true;
			this.rbMo.CheckedChanged += new System.EventHandler(this.rbMo_CheckedChanged);
			// 
			// lblReport
			// 
			this.lblReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblReport.AutoSize = true;
			this.tLRep.SetColumnSpan(this.lblReport, 2);
			this.lblReport.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReport.Location = new System.Drawing.Point(250, 7);
			this.lblReport.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
			this.lblReport.Name = "lblReport";
			this.lblReport.Size = new System.Drawing.Size(90, 29);
			this.lblReport.TabIndex = 13;
			this.lblReport.Text = "Report";
			this.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tLCI
			// 
			this.tLCI.ColumnCount = 1;
			this.tLCI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tLCI.Controls.Add(this.tlCIDetail, 0, 0);
			this.tLCI.Controls.Add(this.btnSubmit, 0, 1);
			this.tLCI.Location = new System.Drawing.Point(6, 404);
			this.tLCI.Name = "tLCI";
			this.tLCI.RowCount = 2;
			this.tLCI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.19289F));
			this.tLCI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.80711F));
			this.tLCI.Size = new System.Drawing.Size(589, 390);
			this.tLCI.TabIndex = 10;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSubmit.Location = new System.Drawing.Point(202, 352);
			this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(185, 31);
			this.btnSubmit.TabIndex = 9;
			this.btnSubmit.Text = "Add Customer";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// tlCIDetail
			// 
			this.tlCIDetail.ColumnCount = 2;
			this.tlCIDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlCIDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tlCIDetail.Controls.Add(this.lblCI, 0, 0);
			this.tlCIDetail.Controls.Add(this.lblPN, 0, 3);
			this.tlCIDetail.Controls.Add(this.tbPhone, 1, 3);
			this.tlCIDetail.Controls.Add(this.lblLN, 0, 2);
			this.tlCIDetail.Controls.Add(this.tbLast, 1, 2);
			this.tlCIDetail.Controls.Add(this.lblFN, 0, 1);
			this.tlCIDetail.Controls.Add(this.tbFirst, 1, 1);
			this.tlCIDetail.Location = new System.Drawing.Point(3, 10);
			this.tlCIDetail.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
			this.tlCIDetail.Name = "tlCIDetail";
			this.tlCIDetail.RowCount = 4;
			this.tlCIDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlCIDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tlCIDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tlCIDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tlCIDetail.Size = new System.Drawing.Size(582, 170);
			this.tlCIDetail.TabIndex = 11;
			// 
			// tbFirst
			// 
			this.tbFirst.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbFirst.Location = new System.Drawing.Point(119, 46);
			this.tbFirst.Name = "tbFirst";
			this.tbFirst.Size = new System.Drawing.Size(320, 22);
			this.tbFirst.TabIndex = 11;
			this.tbFirst.Leave += new System.EventHandler(this.tbFirst_Leave);
			// 
			// lblFN
			// 
			this.lblFN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFN.AutoSize = true;
			this.lblFN.Location = new System.Drawing.Point(3, 49);
			this.lblFN.Name = "lblFN";
			this.lblFN.Size = new System.Drawing.Size(80, 17);
			this.lblFN.TabIndex = 7;
			this.lblFN.Text = "First Name:";
			// 
			// tbLast
			// 
			this.tbLast.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbLast.Location = new System.Drawing.Point(119, 91);
			this.tbLast.Name = "tbLast";
			this.tbLast.Size = new System.Drawing.Size(320, 22);
			this.tbLast.TabIndex = 13;
			this.tbLast.Leave += new System.EventHandler(this.tbLast_Leave);
			// 
			// lblLN
			// 
			this.lblLN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblLN.AutoSize = true;
			this.lblLN.Location = new System.Drawing.Point(3, 94);
			this.lblLN.Name = "lblLN";
			this.lblLN.Size = new System.Drawing.Size(76, 17);
			this.lblLN.TabIndex = 12;
			this.lblLN.Text = "Last Name";
			// 
			// tbPhone
			// 
			this.tbPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbPhone.Location = new System.Drawing.Point(119, 136);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(320, 22);
			this.tbPhone.TabIndex = 15;
			this.tbPhone.Leave += new System.EventHandler(this.tbPhone_Leave);
			// 
			// lblPN
			// 
			this.lblPN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPN.AutoSize = true;
			this.lblPN.Location = new System.Drawing.Point(3, 139);
			this.lblPN.Name = "lblPN";
			this.lblPN.Size = new System.Drawing.Size(107, 17);
			this.lblPN.TabIndex = 14;
			this.lblPN.Text = "Phone Number:";
			// 
			// lblCI
			// 
			this.lblCI.AutoSize = true;
			this.tlCIDetail.SetColumnSpan(this.lblCI, 3);
			this.lblCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCI.Location = new System.Drawing.Point(3, 0);
			this.lblCI.Name = "lblCI";
			this.lblCI.Size = new System.Drawing.Size(108, 17);
			this.lblCI.TabIndex = 16;
			this.lblCI.Text = "Customer Info";
			this.lblCI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tLCS
			// 
			this.tLCS.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tLCS.ColumnCount = 3;
			this.tLCS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.33981F));
			this.tLCS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.66019F));
			this.tLCS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
			this.tLCS.Controls.Add(this.dgvCust, 2, 1);
			this.tLCS.Controls.Add(this.btnDelCust, 1, 3);
			this.tLCS.Controls.Add(this.lblCS, 0, 0);
			this.tLCS.Controls.Add(this.tbSearch, 0, 1);
			this.tLCS.Controls.Add(this.btnSearch, 2, 1);
			this.tLCS.Location = new System.Drawing.Point(6, 3);
			this.tLCS.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.tLCS.Name = "tLCS";
			this.tLCS.RowCount = 4;
			this.tLCS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
			this.tLCS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.84615F));
			this.tLCS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
			this.tLCS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tLCS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
			this.tLCS.Size = new System.Drawing.Size(589, 392);
			this.tLCS.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnSearch.Location = new System.Drawing.Point(516, 34);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(70, 27);
			this.btnSearch.TabIndex = 15;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// tbSearch
			// 
			this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tLCS.SetColumnSpan(this.tbSearch, 2);
			this.tbSearch.Location = new System.Drawing.Point(3, 36);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(484, 22);
			this.tbSearch.TabIndex = 14;
			this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			// 
			// lblCS
			// 
			this.lblCS.AutoSize = true;
			this.tLCS.SetColumnSpan(this.lblCS, 3);
			this.lblCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCS.Location = new System.Drawing.Point(3, 7);
			this.lblCS.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
			this.lblCS.Name = "lblCS";
			this.lblCS.Size = new System.Drawing.Size(132, 17);
			this.lblCS.TabIndex = 12;
			this.lblCS.Text = "Customer Search";
			this.lblCS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnDelCust
			// 
			this.btnDelCust.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnDelCust.Location = new System.Drawing.Point(190, 351);
			this.btnDelCust.Margin = new System.Windows.Forms.Padding(4, 6, 3, 3);
			this.btnDelCust.Name = "btnDelCust";
			this.btnDelCust.Size = new System.Drawing.Size(185, 31);
			this.btnDelCust.TabIndex = 17;
			this.btnDelCust.Text = "Delete Customer ";
			this.btnDelCust.UseVisualStyleBackColor = true;
			this.btnDelCust.Click += new System.EventHandler(this.btnDelCust_Click);
			// 
			// dgvCust
			// 
			this.dgvCust.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tLCS.SetColumnSpan(this.dgvCust, 3);
			this.dgvCust.Location = new System.Drawing.Point(3, 75);
			this.dgvCust.Name = "dgvCust";
			this.dgvCust.RowHeadersWidth = 51;
			this.dgvCust.RowTemplate.Height = 24;
			this.dgvCust.Size = new System.Drawing.Size(583, 260);
			this.dgvCust.TabIndex = 4;
			this.dgvCust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCust_CellClick);
			this.dgvCust.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCust_CellFormatting);
			// 
			// tLMain
			// 
			this.tLMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
			this.tLMain.ColumnCount = 2;
			this.tLMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tLMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tLMain.Controls.Add(this.tLCS, 0, 0);
			this.tLMain.Controls.Add(this.tLCI, 0, 1);
			this.tLMain.Controls.Add(this.tLRep, 1, 1);
			this.tLMain.Controls.Add(this.tlCTVMain, 1, 0);
			this.tLMain.Location = new System.Drawing.Point(44, 12);
			this.tLMain.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
			this.tLMain.Name = "tLMain";
			this.tLMain.RowCount = 2;
			this.tLMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tLMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tLMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tLMain.Size = new System.Drawing.Size(1200, 800);
			this.tLMain.TabIndex = 0;
			// 
			// btnDelTicket
			// 
			this.btnDelTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelTicket.BackColor = System.Drawing.Color.Transparent;
			this.btnDelTicket.FlatAppearance.BorderSize = 0;
			this.btnDelTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnDelTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnDelTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelTicket.Image = global::C868_Capstone.Properties.Resources.icons8_trash_18;
			this.btnDelTicket.Location = new System.Drawing.Point(285, 4);
			this.btnDelTicket.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.btnDelTicket.Name = "btnDelTicket";
			this.btnDelTicket.Size = new System.Drawing.Size(278, 34);
			this.btnDelTicket.TabIndex = 2;
			this.btnDelTicket.UseVisualStyleBackColor = false;
			this.btnDelTicket.Click += new System.EventHandler(this.btnDelTicket_Click);
			// 
			// btnAddTicket
			// 
			this.btnAddTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddTicket.BackColor = System.Drawing.Color.Transparent;
			this.btnAddTicket.FlatAppearance.BorderSize = 0;
			this.btnAddTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnAddTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnAddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddTicket.Image = global::C868_Capstone.Properties.Resources.icons8_plus_20;
			this.btnAddTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddTicket.Location = new System.Drawing.Point(284, 3);
			this.btnAddTicket.Name = "btnAddTicket";
			this.btnAddTicket.Size = new System.Drawing.Size(303, 31);
			this.btnAddTicket.TabIndex = 19;
			this.btnAddTicket.UseVisualStyleBackColor = false;
			this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1306, 864);
			this.Controls.Add(this.tLMain);
			this.Name = "MainScreen";
			this.Text = "MainScreen";
			//this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.tlCTVMain.ResumeLayout(false);
			this.tlCTVMain.PerformLayout();
			this.tlCTV.ResumeLayout(false);
			this.tlCTVTemp.ResumeLayout(false);
			this.tlCTVTemp.PerformLayout();
			this.tLRep.ResumeLayout(false);
			this.tLRep.PerformLayout();
			this.tLCI.ResumeLayout(false);
			this.tlCIDetail.ResumeLayout(false);
			this.tlCIDetail.PerformLayout();
			this.tLCS.ResumeLayout(false);
			this.tLCS.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
			this.tLMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlCTVMain;
		private System.Windows.Forms.TableLayoutPanel tlCTV;
		private System.Windows.Forms.TableLayoutPanel tlCTVTemp;
		private System.Windows.Forms.Button btnStatus;
		private System.Windows.Forms.Label lblTN;
		private System.Windows.Forms.Label lblTS;
		private System.Windows.Forms.Button btnDelTicket;
		private System.Windows.Forms.Button btnAddTicket;
		private System.Windows.Forms.Label lblTicket;
		private System.Windows.Forms.TableLayoutPanel tLRep;
		private System.Windows.Forms.Label lblReport;
		private System.Windows.Forms.RadioButton rbMo;
		private System.Windows.Forms.MonthCalendar monthCal;
		private System.Windows.Forms.RadioButton rbWk;
		private System.Windows.Forms.ComboBox cbSort;
		private System.Windows.Forms.Label lblSort;
		private System.Windows.Forms.ComboBox cbReportType;
		private System.Windows.Forms.Label lblRT;
		private System.Windows.Forms.Button btnReport;
		private System.Windows.Forms.TableLayoutPanel tLCI;
		private System.Windows.Forms.TableLayoutPanel tlCIDetail;
		private System.Windows.Forms.Label lblCI;
		private System.Windows.Forms.Label lblPN;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.Label lblLN;
		private System.Windows.Forms.TextBox tbLast;
		private System.Windows.Forms.Label lblFN;
		private System.Windows.Forms.TextBox tbFirst;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.TableLayoutPanel tLCS;
		private System.Windows.Forms.DataGridView dgvCust;
		private System.Windows.Forms.Button btnDelCust;
		private System.Windows.Forms.Label lblCS;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TableLayoutPanel tLMain;
	}
}