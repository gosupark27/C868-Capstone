namespace C868_Capstone
{
	partial class MainScreenDos
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
			this.tlTicketOV = new System.Windows.Forms.TableLayoutPanel();
			this.lblCustName = new System.Windows.Forms.Label();
			this.lblTO = new System.Windows.Forms.Label();
			this.tlDates = new System.Windows.Forms.TableLayoutPanel();
			this.tbDD = new System.Windows.Forms.TextBox();
			this.dtpPD = new System.Windows.Forms.DateTimePicker();
			this.lblPD = new System.Windows.Forms.Label();
			this.lblDD = new System.Windows.Forms.Label();
			this.tlPayInfo = new System.Windows.Forms.TableLayoutPanel();
			this.tbBal = new System.Windows.Forms.TextBox();
			this.tbDep = new System.Windows.Forms.TextBox();
			this.lblBal = new System.Windows.Forms.Label();
			this.lblGT = new System.Windows.Forms.Label();
			this.lblDep = new System.Windows.Forms.Label();
			this.tbGT = new System.Windows.Forms.TextBox();
			this.tlTILMain = new System.Windows.Forms.TableLayoutPanel();
			this.tlTIL = new System.Windows.Forms.TableLayoutPanel();
			this.tlTILTemp = new System.Windows.Forms.TableLayoutPanel();
			this.lblCI = new System.Windows.Forms.Label();
			this.lblSubT = new System.Windows.Forms.Label();
			this.btnDelItem = new System.Windows.Forms.Button();
			this.lblCat = new System.Windows.Forms.Label();
			this.tlTILHeader = new System.Windows.Forms.TableLayoutPanel();
			this.lblTIL = new System.Windows.Forms.Label();
			this.btnAddTI = new System.Windows.Forms.Button();
			this.tlIRLMain = new System.Windows.Forms.TableLayoutPanel();
			this.tlIRL = new System.Windows.Forms.TableLayoutPanel();
			this.tlIRLTemp = new System.Windows.Forms.TableLayoutPanel();
			this.lblTN = new System.Windows.Forms.Label();
			this.lblTS = new System.Windows.Forms.Label();
			this.btnDelRepair = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.tlIRLHeader = new System.Windows.Forms.TableLayoutPanel();
			this.btnAddIR = new System.Windows.Forms.Button();
			this.lblIRL = new System.Windows.Forms.Label();
			this.btnExt = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.tlMain.SuspendLayout();
			this.tlTicketOV.SuspendLayout();
			this.tlDates.SuspendLayout();
			this.tlPayInfo.SuspendLayout();
			this.tlTILMain.SuspendLayout();
			this.tlTIL.SuspendLayout();
			this.tlTILTemp.SuspendLayout();
			this.tlTILHeader.SuspendLayout();
			this.tlIRLMain.SuspendLayout();
			this.tlIRL.SuspendLayout();
			this.tlIRLTemp.SuspendLayout();
			this.tlIRLHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlMain
			// 
			this.tlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
			this.tlMain.ColumnCount = 2;
			this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlMain.Controls.Add(this.tlTicketOV, 1, 1);
			this.tlMain.Controls.Add(this.tlTILMain, 0, 0);
			this.tlMain.Controls.Add(this.tlIRLMain, 1, 0);
			this.tlMain.Location = new System.Drawing.Point(43, 21);
			this.tlMain.Name = "tlMain";
			this.tlMain.RowCount = 2;
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.40778F));
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.59222F));
			this.tlMain.Size = new System.Drawing.Size(1200, 800);
			this.tlMain.TabIndex = 0;
			// 
			// tlTicketOV
			// 
			this.tlTicketOV.ColumnCount = 2;
			this.tlTicketOV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlTicketOV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlTicketOV.Controls.Add(this.lblCustName, 1, 0);
			this.tlTicketOV.Controls.Add(this.lblTO, 0, 0);
			this.tlTicketOV.Controls.Add(this.tlDates, 0, 1);
			this.tlTicketOV.Controls.Add(this.tlPayInfo, 1, 1);
			this.tlTicketOV.Location = new System.Drawing.Point(604, 605);
			this.tlTicketOV.Name = "tlTicketOV";
			this.tlTicketOV.RowCount = 2;
			this.tlTicketOV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.629441F));
			this.tlTicketOV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.37056F));
			this.tlTicketOV.Size = new System.Drawing.Size(590, 189);
			this.tlTicketOV.TabIndex = 2;
			// 
			// lblCustName
			// 
			this.lblCustName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCustName.AutoSize = true;
			this.lblCustName.Location = new System.Drawing.Point(298, 0);
			this.lblCustName.Name = "lblCustName";
			this.lblCustName.Size = new System.Drawing.Size(289, 16);
			this.lblCustName.TabIndex = 1;
			this.lblCustName.Text = "First Last";
			this.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTO
			// 
			this.lblTO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTO.AutoSize = true;
			this.lblTO.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTO.Location = new System.Drawing.Point(3, 0);
			this.lblTO.Name = "lblTO";
			this.lblTO.Size = new System.Drawing.Size(289, 16);
			this.lblTO.TabIndex = 0;
			this.lblTO.Text = "Ticket Overview";
			this.lblTO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tlDates
			// 
			this.tlDates.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
			this.tlDates.ColumnCount = 2;
			this.tlDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlDates.Controls.Add(this.tbDD, 1, 0);
			this.tlDates.Controls.Add(this.dtpPD, 1, 0);
			this.tlDates.Controls.Add(this.lblPD, 1, 0);
			this.tlDates.Controls.Add(this.lblDD, 0, 0);
			this.tlDates.Location = new System.Drawing.Point(3, 19);
			this.tlDates.Name = "tlDates";
			this.tlDates.RowCount = 2;
			this.tlDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlDates.Size = new System.Drawing.Size(289, 167);
			this.tlDates.TabIndex = 2;
			// 
			// tbDD
			// 
			this.tbDD.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tbDD.Location = new System.Drawing.Point(149, 31);
			this.tbDD.Name = "tbDD";
			this.tbDD.ReadOnly = true;
			this.tbDD.Size = new System.Drawing.Size(134, 22);
			this.tbDD.TabIndex = 7;
			// 
			// dtpPD
			// 
			this.dtpPD.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtpPD.CustomFormat = "MM-dd-yyyy";
			this.dtpPD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPD.Location = new System.Drawing.Point(149, 113);
			this.dtpPD.Name = "dtpPD";
			this.dtpPD.Size = new System.Drawing.Size(134, 22);
			this.dtpPD.TabIndex = 4;
			this.dtpPD.ValueChanged += new System.EventHandler(this.dtPD_ValueChanged);
			// 
			// lblPD
			// 
			this.lblPD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPD.AutoSize = true;
			this.lblPD.Location = new System.Drawing.Point(6, 85);
			this.lblPD.Name = "lblPD";
			this.lblPD.Size = new System.Drawing.Size(134, 79);
			this.lblPD.TabIndex = 2;
			this.lblPD.Text = "Pickup Date";
			this.lblPD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDD
			// 
			this.lblDD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDD.AutoSize = true;
			this.lblDD.Location = new System.Drawing.Point(6, 3);
			this.lblDD.Name = "lblDD";
			this.lblDD.Size = new System.Drawing.Size(134, 79);
			this.lblDD.TabIndex = 1;
			this.lblDD.Text = "Drop Date";
			this.lblDD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tlPayInfo
			// 
			this.tlPayInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
			this.tlPayInfo.ColumnCount = 2;
			this.tlPayInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlPayInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlPayInfo.Controls.Add(this.tbBal, 1, 2);
			this.tlPayInfo.Controls.Add(this.tbDep, 1, 1);
			this.tlPayInfo.Controls.Add(this.lblBal, 0, 2);
			this.tlPayInfo.Controls.Add(this.lblGT, 0, 0);
			this.tlPayInfo.Controls.Add(this.lblDep, 0, 1);
			this.tlPayInfo.Controls.Add(this.tbGT, 1, 0);
			this.tlPayInfo.Location = new System.Drawing.Point(298, 19);
			this.tlPayInfo.Name = "tlPayInfo";
			this.tlPayInfo.RowCount = 3;
			this.tlPayInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlPayInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlPayInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlPayInfo.Size = new System.Drawing.Size(289, 167);
			this.tlPayInfo.TabIndex = 3;
			// 
			// tbBal
			// 
			this.tbBal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tbBal.Location = new System.Drawing.Point(149, 126);
			this.tbBal.Name = "tbBal";
			this.tbBal.ReadOnly = true;
			this.tbBal.Size = new System.Drawing.Size(134, 22);
			this.tbBal.TabIndex = 7;
			// 
			// tbDep
			// 
			this.tbDep.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tbDep.Location = new System.Drawing.Point(149, 71);
			this.tbDep.Name = "tbDep";
			this.tbDep.Size = new System.Drawing.Size(134, 22);
			this.tbDep.TabIndex = 6;
			this.tbDep.TextChanged += new System.EventHandler(this.tbDep_TextChanged);
			// 
			// lblBal
			// 
			this.lblBal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBal.AutoSize = true;
			this.lblBal.Location = new System.Drawing.Point(6, 111);
			this.lblBal.Name = "lblBal";
			this.lblBal.Size = new System.Drawing.Size(134, 53);
			this.lblBal.TabIndex = 4;
			this.lblBal.Text = "Balance ";
			this.lblBal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGT
			// 
			this.lblGT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblGT.AutoSize = true;
			this.lblGT.Location = new System.Drawing.Point(6, 3);
			this.lblGT.Name = "lblGT";
			this.lblGT.Size = new System.Drawing.Size(134, 51);
			this.lblGT.TabIndex = 2;
			this.lblGT.Text = "Grand Total";
			this.lblGT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDep
			// 
			this.lblDep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDep.AutoSize = true;
			this.lblDep.Location = new System.Drawing.Point(6, 57);
			this.lblDep.Name = "lblDep";
			this.lblDep.Size = new System.Drawing.Size(134, 51);
			this.lblDep.TabIndex = 3;
			this.lblDep.Text = "Deposit";
			this.lblDep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbGT
			// 
			this.tbGT.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tbGT.Location = new System.Drawing.Point(149, 17);
			this.tbGT.Name = "tbGT";
			this.tbGT.ReadOnly = true;
			this.tbGT.Size = new System.Drawing.Size(134, 22);
			this.tbGT.TabIndex = 5;
			this.tbGT.TextChanged += new System.EventHandler(this.tbGT_TextChanged);
			// 
			// tlTILMain
			// 
			this.tlTILMain.ColumnCount = 1;
			this.tlTILMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlTILMain.Controls.Add(this.tlTIL, 0, 1);
			this.tlTILMain.Controls.Add(this.tlTILHeader, 0, 0);
			this.tlTILMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlTILMain.Location = new System.Drawing.Point(6, 6);
			this.tlTILMain.Name = "tlTILMain";
			this.tlTILMain.RowCount = 1;
			this.tlMain.SetRowSpan(this.tlTILMain, 2);
			this.tlTILMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.329949F));
			this.tlTILMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.67005F));
			this.tlTILMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlTILMain.Size = new System.Drawing.Size(589, 788);
			this.tlTILMain.TabIndex = 3;
			// 
			// tlTIL
			// 
			this.tlTIL.AutoScroll = true;
			this.tlTIL.ColumnCount = 2;
			this.tlTIL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlTIL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlTIL.Controls.Add(this.tlTILTemp, 0, 0);
			this.tlTIL.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlTIL.Location = new System.Drawing.Point(3, 44);
			this.tlTIL.Name = "tlTIL";
			this.tlTIL.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.tlTIL.RowCount = 9;
			this.tlTIL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8381F));
			this.tlTIL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.07594F));
			this.tlTIL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.17303F));
			this.tlTIL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04002F));
			this.tlTIL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04002F));
			this.tlTIL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.64099F));
			this.tlTIL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04002F));
			this.tlTIL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.07594F));
			this.tlTIL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.07594F));
			this.tlTIL.Size = new System.Drawing.Size(583, 741);
			this.tlTIL.TabIndex = 1;
			// 
			// tlTILTemp
			// 
			this.tlTILTemp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlTILTemp.ColumnCount = 2;
			this.tlTIL.SetColumnSpan(this.tlTILTemp, 2);
			this.tlTILTemp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlTILTemp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlTILTemp.Controls.Add(this.lblCI, 0, 0);
			this.tlTILTemp.Controls.Add(this.lblSubT, 0, 1);
			this.tlTILTemp.Controls.Add(this.btnDelItem, 1, 1);
			this.tlTILTemp.Controls.Add(this.lblCat, 1, 0);
			this.tlTILTemp.Location = new System.Drawing.Point(3, 3);
			this.tlTILTemp.Name = "tlTILTemp";
			this.tlTILTemp.RowCount = 2;
			this.tlTILTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.32099F));
			this.tlTILTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.67901F));
			this.tlTILTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlTILTemp.Size = new System.Drawing.Size(569, 81);
			this.tlTILTemp.TabIndex = 21;
			// 
			// lblCI
			// 
			this.lblCI.AutoSize = true;
			this.lblCI.Location = new System.Drawing.Point(4, 1);
			this.lblCI.Name = "lblCI";
			this.lblCI.Size = new System.Drawing.Size(85, 17);
			this.lblCI.TabIndex = 0;
			this.lblCI.Text = "Item\'s Name";
			// 
			// lblSubT
			// 
			this.lblSubT.AutoSize = true;
			this.lblSubT.Location = new System.Drawing.Point(4, 44);
			this.lblSubT.Name = "lblSubT";
			this.lblSubT.Size = new System.Drawing.Size(68, 17);
			this.lblSubT.TabIndex = 1;
			this.lblSubT.Text = "Subtotal: ";
			this.lblSubT.TextChanged += new System.EventHandler(this.lblSubT_TextChanged);
			// 
			// btnDelItem
			// 
			this.btnDelItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelItem.FlatAppearance.BorderSize = 0;
			this.btnDelItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnDelItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnDelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelItem.Image = global::C868_Capstone.Properties.Resources.icons8_trash_18;
			this.btnDelItem.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnDelItem.Location = new System.Drawing.Point(288, 47);
			this.btnDelItem.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.btnDelItem.Name = "btnDelItem";
			this.btnDelItem.Size = new System.Drawing.Size(280, 30);
			this.btnDelItem.TabIndex = 2;
			this.btnDelItem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnDelItem.UseVisualStyleBackColor = true;
			this.btnDelItem.Click += new System.EventHandler(this.btnDelItem_Click);
			// 
			// lblCat
			// 
			this.lblCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCat.AutoSize = true;
			this.lblCat.Location = new System.Drawing.Point(460, 1);
			this.lblCat.Name = "lblCat";
			this.lblCat.Size = new System.Drawing.Size(105, 17);
			this.lblCat.TabIndex = 3;
			this.lblCat.Text = "Item\'s Category";
			this.lblCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tlTILHeader
			// 
			this.tlTILHeader.ColumnCount = 2;
			this.tlTILHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlTILHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlTILHeader.Controls.Add(this.lblTIL, 0, 0);
			this.tlTILHeader.Controls.Add(this.btnAddTI, 1, 0);
			this.tlTILHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlTILHeader.Location = new System.Drawing.Point(3, 3);
			this.tlTILHeader.Name = "tlTILHeader";
			this.tlTILHeader.RowCount = 1;
			this.tlTILHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlTILHeader.Size = new System.Drawing.Size(583, 35);
			this.tlTILHeader.TabIndex = 2;
			// 
			// lblTIL
			// 
			this.lblTIL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTIL.AutoSize = true;
			this.lblTIL.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTIL.Location = new System.Drawing.Point(3, 0);
			this.lblTIL.Name = "lblTIL";
			this.lblTIL.Size = new System.Drawing.Size(285, 35);
			this.lblTIL.TabIndex = 0;
			this.lblTIL.Text = "Ticket Item List";
			this.lblTIL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAddTI
			// 
			this.btnAddTI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddTI.BackColor = System.Drawing.Color.Transparent;
			this.btnAddTI.FlatAppearance.BorderSize = 0;
			this.btnAddTI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnAddTI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnAddTI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddTI.Image = global::C868_Capstone.Properties.Resources.icons8_plus_20;
			this.btnAddTI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddTI.Location = new System.Drawing.Point(294, 3);
			this.btnAddTI.Name = "btnAddTI";
			this.btnAddTI.Size = new System.Drawing.Size(286, 29);
			this.btnAddTI.TabIndex = 20;
			this.btnAddTI.UseVisualStyleBackColor = false;
			this.btnAddTI.Click += new System.EventHandler(this.btnAddTI_Click);
			// 
			// tlIRLMain
			// 
			this.tlIRLMain.ColumnCount = 1;
			this.tlIRLMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlIRLMain.Controls.Add(this.tlIRL, 0, 1);
			this.tlIRLMain.Controls.Add(this.tlIRLHeader, 0, 0);
			this.tlIRLMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlIRLMain.Location = new System.Drawing.Point(604, 6);
			this.tlIRLMain.Name = "tlIRLMain";
			this.tlIRLMain.RowCount = 2;
			this.tlIRLMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.610169F));
			this.tlIRLMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.38983F));
			this.tlIRLMain.Size = new System.Drawing.Size(590, 590);
			this.tlIRLMain.TabIndex = 4;
			// 
			// tlIRL
			// 
			this.tlIRL.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tlIRL.AutoScroll = true;
			this.tlIRL.ColumnCount = 2;
			this.tlIRL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlIRL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlIRL.Controls.Add(this.tlIRLTemp, 0, 0);
			this.tlIRL.Location = new System.Drawing.Point(3, 41);
			this.tlIRL.Name = "tlIRL";
			this.tlIRL.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.tlIRL.RowCount = 6;
			this.tlIRL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.30037F));
			this.tlIRL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.49817F));
			this.tlIRL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.30037F));
			this.tlIRL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.75092F));
			this.tlIRL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.48352F));
			this.tlIRL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.30037F));
			this.tlIRL.Size = new System.Drawing.Size(584, 546);
			this.tlIRL.TabIndex = 2;
			// 
			// tlIRLTemp
			// 
			this.tlIRLTemp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlIRLTemp.ColumnCount = 2;
			this.tlIRL.SetColumnSpan(this.tlIRLTemp, 2);
			this.tlIRLTemp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlIRLTemp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlIRLTemp.Controls.Add(this.lblTN, 0, 0);
			this.tlIRLTemp.Controls.Add(this.lblTS, 0, 1);
			this.tlIRLTemp.Controls.Add(this.btnDelRepair, 1, 1);
			this.tlIRLTemp.Controls.Add(this.button8, 1, 0);
			this.tlIRLTemp.Location = new System.Drawing.Point(3, 3);
			this.tlIRLTemp.Name = "tlIRLTemp";
			this.tlIRLTemp.RowCount = 2;
			this.tlIRLTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.32099F));
			this.tlIRLTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.67901F));
			this.tlIRLTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlIRLTemp.Size = new System.Drawing.Size(570, 83);
			this.tlIRLTemp.TabIndex = 23;
			// 
			// lblTN
			// 
			this.lblTN.AutoSize = true;
			this.lblTN.Location = new System.Drawing.Point(4, 1);
			this.lblTN.Name = "lblTN";
			this.lblTN.Size = new System.Drawing.Size(91, 17);
			this.lblTN.TabIndex = 0;
			this.lblTN.Text = "Repair Name";
			// 
			// lblTS
			// 
			this.lblTS.AutoSize = true;
			this.lblTS.Location = new System.Drawing.Point(4, 45);
			this.lblTS.Name = "lblTS";
			this.lblTS.Size = new System.Drawing.Size(82, 17);
			this.lblTS.TabIndex = 1;
			this.lblTS.Text = "Repair Cost";
			// 
			// btnDelRepair
			// 
			this.btnDelRepair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelRepair.FlatAppearance.BorderSize = 0;
			this.btnDelRepair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnDelRepair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnDelRepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelRepair.Image = global::C868_Capstone.Properties.Resources.icons8_trash_18;
			this.btnDelRepair.Location = new System.Drawing.Point(494, 48);
			this.btnDelRepair.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.btnDelRepair.Name = "btnDelRepair";
			this.btnDelRepair.Size = new System.Drawing.Size(75, 31);
			this.btnDelRepair.TabIndex = 2;
			this.btnDelRepair.UseVisualStyleBackColor = true;
			this.btnDelRepair.Click += new System.EventHandler(this.btnDelRepair_Click);
			// 
			// button8
			// 
			this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button8.Location = new System.Drawing.Point(491, 4);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 3;
			this.button8.Text = "Edit";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// tlIRLHeader
			// 
			this.tlIRLHeader.ColumnCount = 2;
			this.tlIRLHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlIRLHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlIRLHeader.Controls.Add(this.btnAddIR, 1, 0);
			this.tlIRLHeader.Controls.Add(this.lblIRL, 0, 0);
			this.tlIRLHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlIRLHeader.Location = new System.Drawing.Point(3, 3);
			this.tlIRLHeader.Name = "tlIRLHeader";
			this.tlIRLHeader.RowCount = 1;
			this.tlIRLHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlIRLHeader.Size = new System.Drawing.Size(584, 32);
			this.tlIRLHeader.TabIndex = 3;
			// 
			// btnAddIR
			// 
			this.btnAddIR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddIR.BackColor = System.Drawing.Color.Transparent;
			this.btnAddIR.FlatAppearance.BorderSize = 0;
			this.btnAddIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnAddIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnAddIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddIR.Image = global::C868_Capstone.Properties.Resources.icons8_plus_20;
			this.btnAddIR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddIR.Location = new System.Drawing.Point(295, 3);
			this.btnAddIR.Name = "btnAddIR";
			this.btnAddIR.Size = new System.Drawing.Size(286, 26);
			this.btnAddIR.TabIndex = 21;
			this.btnAddIR.UseVisualStyleBackColor = false;
			this.btnAddIR.Click += new System.EventHandler(this.btnAddIR_Click);
			// 
			// lblIRL
			// 
			this.lblIRL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblIRL.AutoSize = true;
			this.lblIRL.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIRL.Location = new System.Drawing.Point(3, 0);
			this.lblIRL.Name = "lblIRL";
			this.lblIRL.Size = new System.Drawing.Size(286, 32);
			this.lblIRL.TabIndex = 1;
			this.lblIRL.Text = "Item Repair List";
			this.lblIRL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnExt
			// 
			this.btnExt.Location = new System.Drawing.Point(1163, 827);
			this.btnExt.Name = "btnExt";
			this.btnExt.Size = new System.Drawing.Size(80, 35);
			this.btnExt.TabIndex = 1;
			this.btnExt.Text = "Exit";
			this.btnExt.UseVisualStyleBackColor = true;
			this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(1066, 827);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(80, 35);
			this.btnBack.TabIndex = 2;
			this.btnBack.Text = "Go Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// MainScreenDos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1306, 864);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnExt);
			this.Controls.Add(this.tlMain);
			this.Name = "MainScreenDos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainScreenDos";
			this.Load += new System.EventHandler(this.MainScreenDos_Load);
			this.tlMain.ResumeLayout(false);
			this.tlTicketOV.ResumeLayout(false);
			this.tlTicketOV.PerformLayout();
			this.tlDates.ResumeLayout(false);
			this.tlDates.PerformLayout();
			this.tlPayInfo.ResumeLayout(false);
			this.tlPayInfo.PerformLayout();
			this.tlTILMain.ResumeLayout(false);
			this.tlTIL.ResumeLayout(false);
			this.tlTILTemp.ResumeLayout(false);
			this.tlTILTemp.PerformLayout();
			this.tlTILHeader.ResumeLayout(false);
			this.tlTILHeader.PerformLayout();
			this.tlIRLMain.ResumeLayout(false);
			this.tlIRL.ResumeLayout(false);
			this.tlIRLTemp.ResumeLayout(false);
			this.tlIRLTemp.PerformLayout();
			this.tlIRLHeader.ResumeLayout(false);
			this.tlIRLHeader.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlMain;
		private System.Windows.Forms.TableLayoutPanel tlTicketOV;
		private System.Windows.Forms.Label lblCustName;
		private System.Windows.Forms.Label lblTO;
		private System.Windows.Forms.TableLayoutPanel tlDates;
		private System.Windows.Forms.DateTimePicker dtpPD;
		private System.Windows.Forms.Label lblPD;
		private System.Windows.Forms.Label lblDD;
		private System.Windows.Forms.TableLayoutPanel tlPayInfo;
		private System.Windows.Forms.TextBox tbBal;
		private System.Windows.Forms.TextBox tbDep;
		private System.Windows.Forms.Label lblBal;
		private System.Windows.Forms.Label lblGT;
		private System.Windows.Forms.Label lblDep;
		private System.Windows.Forms.TextBox tbGT;
		private System.Windows.Forms.TableLayoutPanel tlTILMain;
		private System.Windows.Forms.TableLayoutPanel tlTIL;
		private System.Windows.Forms.TableLayoutPanel tlTILTemp;
		private System.Windows.Forms.Label lblCI;
		private System.Windows.Forms.Label lblSubT;
		private System.Windows.Forms.Button btnDelItem;
		private System.Windows.Forms.Label lblCat;
		private System.Windows.Forms.TableLayoutPanel tlTILHeader;
		private System.Windows.Forms.Label lblTIL;
		private System.Windows.Forms.Button btnAddTI;
		private System.Windows.Forms.TableLayoutPanel tlIRLMain;
		private System.Windows.Forms.TableLayoutPanel tlIRL;
		private System.Windows.Forms.TableLayoutPanel tlIRLHeader;
		private System.Windows.Forms.Button btnAddIR;
		private System.Windows.Forms.Label lblIRL;
		private System.Windows.Forms.TableLayoutPanel tlIRLTemp;
		private System.Windows.Forms.Label lblTN;
		private System.Windows.Forms.Label lblTS;
		private System.Windows.Forms.Button btnDelRepair;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button btnExt;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.TextBox tbDD;
	}
}