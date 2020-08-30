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
			this.tlBtns = new System.Windows.Forms.TableLayoutPanel();
			this.btnCnl = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.tlDate = new System.Windows.Forms.TableLayoutPanel();
			this.tlDateMain = new System.Windows.Forms.TableLayoutPanel();
			this.tlDatePD = new System.Windows.Forms.TableLayoutPanel();
			this.dtpPD = new System.Windows.Forms.DateTimePicker();
			this.lblPD = new System.Windows.Forms.Label();
			this.tlDateDD = new System.Windows.Forms.TableLayoutPanel();
			this.tbDD = new System.Windows.Forms.TextBox();
			this.lblDD = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.tlSIR = new System.Windows.Forms.TableLayoutPanel();
			this.tlSIRMain = new System.Windows.Forms.TableLayoutPanel();
			this.tlSIRCost = new System.Windows.Forms.TableLayoutPanel();
			this.tbCost = new System.Windows.Forms.TextBox();
			this.lblCost = new System.Windows.Forms.Label();
			this.tlSIRRepSer = new System.Windows.Forms.TableLayoutPanel();
			this.cbRS = new System.Windows.Forms.ComboBox();
			this.lblRS = new System.Windows.Forms.Label();
			this.lblSIR = new System.Windows.Forms.Label();
			this.tlMainHeader = new System.Windows.Forms.TableLayoutPanel();
			this.lblTN = new System.Windows.Forms.Label();
			this.lblCN = new System.Windows.Forms.Label();
			this.tlSI = new System.Windows.Forms.TableLayoutPanel();
			this.lblSI = new System.Windows.Forms.Label();
			this.tlSIMain = new System.Windows.Forms.TableLayoutPanel();
			this.tlSICatItem = new System.Windows.Forms.TableLayoutPanel();
			this.cbCI = new System.Windows.Forms.ComboBox();
			this.lblCI = new System.Windows.Forms.Label();
			this.tlSICategory = new System.Windows.Forms.TableLayoutPanel();
			this.cbCat = new System.Windows.Forms.ComboBox();
			this.lblCat = new System.Windows.Forms.Label();
			this.tlMain.SuspendLayout();
			this.tlBtns.SuspendLayout();
			this.tlDate.SuspendLayout();
			this.tlDateMain.SuspendLayout();
			this.tlDatePD.SuspendLayout();
			this.tlDateDD.SuspendLayout();
			this.tlSIR.SuspendLayout();
			this.tlSIRMain.SuspendLayout();
			this.tlSIRCost.SuspendLayout();
			this.tlSIRRepSer.SuspendLayout();
			this.tlMainHeader.SuspendLayout();
			this.tlSI.SuspendLayout();
			this.tlSIMain.SuspendLayout();
			this.tlSICatItem.SuspendLayout();
			this.tlSICategory.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlMain
			// 
			this.tlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlMain.ColumnCount = 1;
			this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlMain.Controls.Add(this.tlBtns, 0, 4);
			this.tlMain.Controls.Add(this.tlDate, 0, 3);
			this.tlMain.Controls.Add(this.tlSIR, 0, 2);
			this.tlMain.Controls.Add(this.tlMainHeader, 0, 0);
			this.tlMain.Controls.Add(this.tlSI, 0, 1);
			this.tlMain.Location = new System.Drawing.Point(49, 12);
			this.tlMain.Name = "tlMain";
			this.tlMain.RowCount = 5;
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
			this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 253F));
			this.tlMain.Size = new System.Drawing.Size(777, 340);
			this.tlMain.TabIndex = 0;
			// 
			// tlBtns
			// 
			this.tlBtns.ColumnCount = 2;
			this.tlBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 387F));
			this.tlBtns.Controls.Add(this.btnCnl, 1, 0);
			this.tlBtns.Controls.Add(this.btnCreate, 0, 0);
			this.tlBtns.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlBtns.Location = new System.Drawing.Point(4, 300);
			this.tlBtns.Name = "tlBtns";
			this.tlBtns.RowCount = 1;
			this.tlBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlBtns.Size = new System.Drawing.Size(769, 38);
			this.tlBtns.TabIndex = 4;
			// 
			// btnCnl
			// 
			this.btnCnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCnl.Location = new System.Drawing.Point(385, 3);
			this.btnCnl.Name = "btnCnl";
			this.btnCnl.Size = new System.Drawing.Size(381, 32);
			this.btnCnl.TabIndex = 1;
			this.btnCnl.Text = "Cancel";
			this.btnCnl.UseVisualStyleBackColor = true;
			this.btnCnl.Click += new System.EventHandler(this.btnCnl_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreate.Location = new System.Drawing.Point(3, 3);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(376, 32);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Create Ticket";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// tlDate
			// 
			this.tlDate.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlDate.ColumnCount = 1;
			this.tlDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlDate.Controls.Add(this.tlDateMain, 0, 1);
			this.tlDate.Controls.Add(this.lblDate, 0, 0);
			this.tlDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlDate.Location = new System.Drawing.Point(4, 214);
			this.tlDate.Name = "tlDate";
			this.tlDate.RowCount = 2;
			this.tlDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tlDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
			this.tlDate.Size = new System.Drawing.Size(769, 79);
			this.tlDate.TabIndex = 3;
			// 
			// tlDateMain
			// 
			this.tlDateMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlDateMain.ColumnCount = 2;
			this.tlDateMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlDateMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlDateMain.Controls.Add(this.tlDatePD, 0, 0);
			this.tlDateMain.Controls.Add(this.tlDateDD, 0, 0);
			this.tlDateMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlDateMain.Location = new System.Drawing.Point(4, 38);
			this.tlDateMain.Name = "tlDateMain";
			this.tlDateMain.RowCount = 1;
			this.tlDateMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlDateMain.Size = new System.Drawing.Size(761, 149);
			this.tlDateMain.TabIndex = 2;
			// 
			// tlDatePD
			// 
			this.tlDatePD.ColumnCount = 2;
			this.tlDatePD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.51064F));
			this.tlDatePD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.48936F));
			this.tlDatePD.Controls.Add(this.dtpPD, 0, 0);
			this.tlDatePD.Controls.Add(this.lblPD, 0, 0);
			this.tlDatePD.Location = new System.Drawing.Point(384, 4);
			this.tlDatePD.Name = "tlDatePD";
			this.tlDatePD.RowCount = 1;
			this.tlDatePD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlDatePD.Size = new System.Drawing.Size(373, 38);
			this.tlDatePD.TabIndex = 2;
			// 
			// dtpPD
			// 
			this.dtpPD.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.dtpPD.CustomFormat = "MM-dd-yyyy";
			this.dtpPD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPD.Location = new System.Drawing.Point(221, 8);
			this.dtpPD.Name = "dtpPD";
			this.dtpPD.Size = new System.Drawing.Size(149, 22);
			this.dtpPD.TabIndex = 4;
			this.dtpPD.ValueChanged += new System.EventHandler(this.dtpPD_ValueChanged);
			// 
			// lblPD
			// 
			this.lblPD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPD.AutoSize = true;
			this.lblPD.Location = new System.Drawing.Point(3, 0);
			this.lblPD.Name = "lblPD";
			this.lblPD.Size = new System.Drawing.Size(212, 38);
			this.lblPD.TabIndex = 3;
			this.lblPD.Text = "Pickup Date";
			this.lblPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tlDateDD
			// 
			this.tlDateDD.ColumnCount = 2;
			this.tlDateDD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.4F));
			this.tlDateDD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.6F));
			this.tlDateDD.Controls.Add(this.tbDD, 0, 0);
			this.tlDateDD.Controls.Add(this.lblDD, 0, 0);
			this.tlDateDD.Location = new System.Drawing.Point(4, 4);
			this.tlDateDD.Name = "tlDateDD";
			this.tlDateDD.RowCount = 1;
			this.tlDateDD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlDateDD.Size = new System.Drawing.Size(373, 38);
			this.tlDateDD.TabIndex = 1;
			// 
			// tbDD
			// 
			this.tbDD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbDD.Location = new System.Drawing.Point(116, 8);
			this.tbDD.Name = "tbDD";
			this.tbDD.ReadOnly = true;
			this.tbDD.Size = new System.Drawing.Size(150, 22);
			this.tbDD.TabIndex = 7;
			// 
			// lblDD
			// 
			this.lblDD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDD.AutoSize = true;
			this.lblDD.Location = new System.Drawing.Point(3, 0);
			this.lblDD.Name = "lblDD";
			this.lblDD.Size = new System.Drawing.Size(107, 38);
			this.lblDD.TabIndex = 3;
			this.lblDD.Text = "Drop Date";
			this.lblDD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.Location = new System.Drawing.Point(4, 1);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(761, 24);
			this.lblDate.TabIndex = 1;
			this.lblDate.Text = "Select Date";
			this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tlSIR
			// 
			this.tlSIR.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlSIR.ColumnCount = 1;
			this.tlSIR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlSIR.Controls.Add(this.tlSIRMain, 0, 1);
			this.tlSIR.Controls.Add(this.lblSIR, 0, 0);
			this.tlSIR.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlSIR.Location = new System.Drawing.Point(4, 128);
			this.tlSIR.Name = "tlSIR";
			this.tlSIR.RowCount = 2;
			this.tlSIR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tlSIR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
			this.tlSIR.Size = new System.Drawing.Size(769, 79);
			this.tlSIR.TabIndex = 2;
			// 
			// tlSIRMain
			// 
			this.tlSIRMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlSIRMain.ColumnCount = 2;
			this.tlSIRMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlSIRMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlSIRMain.Controls.Add(this.tlSIRCost, 0, 0);
			this.tlSIRMain.Controls.Add(this.tlSIRRepSer, 0, 0);
			this.tlSIRMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlSIRMain.Location = new System.Drawing.Point(4, 38);
			this.tlSIRMain.Name = "tlSIRMain";
			this.tlSIRMain.RowCount = 1;
			this.tlSIRMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlSIRMain.Size = new System.Drawing.Size(761, 149);
			this.tlSIRMain.TabIndex = 2;
			// 
			// tlSIRCost
			// 
			this.tlSIRCost.ColumnCount = 2;
			this.tlSIRCost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.51064F));
			this.tlSIRCost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.48936F));
			this.tlSIRCost.Controls.Add(this.tbCost, 0, 0);
			this.tlSIRCost.Controls.Add(this.lblCost, 0, 0);
			this.tlSIRCost.Location = new System.Drawing.Point(384, 4);
			this.tlSIRCost.Name = "tlSIRCost";
			this.tlSIRCost.RowCount = 1;
			this.tlSIRCost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlSIRCost.Size = new System.Drawing.Size(373, 38);
			this.tlSIRCost.TabIndex = 2;
			// 
			// tbCost
			// 
			this.tbCost.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.tbCost.Location = new System.Drawing.Point(221, 8);
			this.tbCost.Name = "tbCost";
			this.tbCost.Size = new System.Drawing.Size(149, 22);
			this.tbCost.TabIndex = 6;
			this.tbCost.TextChanged += new System.EventHandler(this.tbCost_TextChanged);
			this.tbCost.Leave += new System.EventHandler(this.tbCost_Leave);
			// 
			// lblCost
			// 
			this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCost.Location = new System.Drawing.Point(3, 0);
			this.lblCost.Name = "lblCost";
			this.lblCost.Size = new System.Drawing.Size(212, 38);
			this.lblCost.TabIndex = 3;
			this.lblCost.Text = "Cost";
			this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tlSIRRepSer
			// 
			this.tlSIRRepSer.ColumnCount = 2;
			this.tlSIRRepSer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.13333F));
			this.tlSIRRepSer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.86667F));
			this.tlSIRRepSer.Controls.Add(this.cbRS, 0, 0);
			this.tlSIRRepSer.Controls.Add(this.lblRS, 0, 0);
			this.tlSIRRepSer.Location = new System.Drawing.Point(4, 4);
			this.tlSIRRepSer.Name = "tlSIRRepSer";
			this.tlSIRRepSer.RowCount = 1;
			this.tlSIRRepSer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlSIRRepSer.Size = new System.Drawing.Size(373, 38);
			this.tlSIRRepSer.TabIndex = 1;
			// 
			// cbRS
			// 
			this.cbRS.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbRS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRS.FormattingEnabled = true;
			this.cbRS.Location = new System.Drawing.Point(115, 7);
			this.cbRS.Name = "cbRS";
			this.cbRS.Size = new System.Drawing.Size(150, 24);
			this.cbRS.TabIndex = 5;
			this.cbRS.SelectedIndexChanged += new System.EventHandler(this.cbRS_SelectedIndexChanged);
			// 
			// lblRS
			// 
			this.lblRS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRS.AutoSize = true;
			this.lblRS.Location = new System.Drawing.Point(3, 0);
			this.lblRS.Name = "lblRS";
			this.lblRS.Size = new System.Drawing.Size(106, 38);
			this.lblRS.TabIndex = 2;
			this.lblRS.Text = "Repair Service";
			this.lblRS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblSIR
			// 
			this.lblSIR.AutoSize = true;
			this.lblSIR.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblSIR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSIR.Location = new System.Drawing.Point(4, 1);
			this.lblSIR.Name = "lblSIR";
			this.lblSIR.Size = new System.Drawing.Size(761, 24);
			this.lblSIR.TabIndex = 1;
			this.lblSIR.Text = "Select Item Repair";
			this.lblSIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tlMainHeader
			// 
			this.tlMainHeader.ColumnCount = 2;
			this.tlMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 386F));
			this.tlMainHeader.Controls.Add(this.lblTN, 0, 0);
			this.tlMainHeader.Controls.Add(this.lblCN, 0, 0);
			this.tlMainHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlMainHeader.Location = new System.Drawing.Point(4, 4);
			this.tlMainHeader.Name = "tlMainHeader";
			this.tlMainHeader.RowCount = 1;
			this.tlMainHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlMainHeader.Size = new System.Drawing.Size(769, 24);
			this.tlMainHeader.TabIndex = 0;
			// 
			// lblTN
			// 
			this.lblTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTN.AutoSize = true;
			this.lblTN.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTN.Location = new System.Drawing.Point(386, 0);
			this.lblTN.Name = "lblTN";
			this.lblTN.Size = new System.Drawing.Size(380, 24);
			this.lblTN.TabIndex = 2;
			this.lblTN.Text = "#1234";
			this.lblTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCN
			// 
			this.lblCN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCN.AutoSize = true;
			this.lblCN.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCN.Location = new System.Drawing.Point(3, 0);
			this.lblCN.Name = "lblCN";
			this.lblCN.Size = new System.Drawing.Size(377, 24);
			this.lblCN.TabIndex = 1;
			this.lblCN.Text = "First Last";
			this.lblCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tlSI
			// 
			this.tlSI.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tlSI.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlSI.ColumnCount = 1;
			this.tlSI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlSI.Controls.Add(this.lblSI, 0, 0);
			this.tlSI.Controls.Add(this.tlSIMain, 0, 1);
			this.tlSI.Location = new System.Drawing.Point(4, 35);
			this.tlSI.Name = "tlSI";
			this.tlSI.RowCount = 2;
			this.tlSI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tlSI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
			this.tlSI.Size = new System.Drawing.Size(769, 84);
			this.tlSI.TabIndex = 1;
			// 
			// lblSI
			// 
			this.lblSI.AutoSize = true;
			this.lblSI.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblSI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSI.Location = new System.Drawing.Point(4, 1);
			this.lblSI.Name = "lblSI";
			this.lblSI.Size = new System.Drawing.Size(761, 24);
			this.lblSI.TabIndex = 0;
			this.lblSI.Text = "Select Item ";
			this.lblSI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tlSIMain
			// 
			this.tlSIMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tlSIMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlSIMain.ColumnCount = 2;
			this.tlSIMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlSIMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlSIMain.Controls.Add(this.tlSICatItem, 1, 0);
			this.tlSIMain.Controls.Add(this.tlSICategory, 0, 0);
			this.tlSIMain.Location = new System.Drawing.Point(4, 38);
			this.tlSIMain.Name = "tlSIMain";
			this.tlSIMain.RowCount = 1;
			this.tlSIMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlSIMain.Size = new System.Drawing.Size(761, 44);
			this.tlSIMain.TabIndex = 1;
			// 
			// tlSICatItem
			// 
			this.tlSICatItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.tlSICatItem.ColumnCount = 2;
			this.tlSICatItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.62069F));
			this.tlSICatItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.37931F));
			this.tlSICatItem.Controls.Add(this.cbCI, 0, 0);
			this.tlSICatItem.Controls.Add(this.lblCI, 0, 0);
			this.tlSICatItem.Location = new System.Drawing.Point(384, 4);
			this.tlSICatItem.Name = "tlSICatItem";
			this.tlSICatItem.RowCount = 1;
			this.tlSICatItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlSICatItem.Size = new System.Drawing.Size(373, 36);
			this.tlSICatItem.TabIndex = 1;
			// 
			// cbCI
			// 
			this.cbCI.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.cbCI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCI.FormattingEnabled = true;
			this.cbCI.Location = new System.Drawing.Point(221, 6);
			this.cbCI.Name = "cbCI";
			this.cbCI.Size = new System.Drawing.Size(149, 24);
			this.cbCI.TabIndex = 4;
			this.cbCI.SelectedIndexChanged += new System.EventHandler(this.cbCI_SelectedIndexChanged);
			// 
			// lblCI
			// 
			this.lblCI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCI.AutoSize = true;
			this.lblCI.Location = new System.Drawing.Point(3, 0);
			this.lblCI.Name = "lblCI";
			this.lblCI.Size = new System.Drawing.Size(212, 36);
			this.lblCI.TabIndex = 2;
			this.lblCI.Text = "Category Item";
			this.lblCI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tlSICategory
			// 
			this.tlSICategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tlSICategory.ColumnCount = 2;
			this.tlSICategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.22252F));
			this.tlSICategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.77748F));
			this.tlSICategory.Controls.Add(this.cbCat, 0, 0);
			this.tlSICategory.Controls.Add(this.lblCat, 0, 0);
			this.tlSICategory.Location = new System.Drawing.Point(4, 4);
			this.tlSICategory.Name = "tlSICategory";
			this.tlSICategory.RowCount = 1;
			this.tlSICategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlSICategory.Size = new System.Drawing.Size(373, 36);
			this.tlSICategory.TabIndex = 0;
			// 
			// cbCat
			// 
			this.cbCat.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCat.FormattingEnabled = true;
			this.cbCat.Location = new System.Drawing.Point(112, 6);
			this.cbCat.Name = "cbCat";
			this.cbCat.Size = new System.Drawing.Size(150, 24);
			this.cbCat.TabIndex = 9;
			this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCat_SelectedIndexChanged);
			// 
			// lblCat
			// 
			this.lblCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCat.AutoSize = true;
			this.lblCat.Location = new System.Drawing.Point(3, 0);
			this.lblCat.Name = "lblCat";
			this.lblCat.Size = new System.Drawing.Size(103, 36);
			this.lblCat.TabIndex = 8;
			this.lblCat.Text = "Category";
			this.lblCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TicketTemplate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 381);
			this.Controls.Add(this.tlMain);
			this.Name = "TicketTemplate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddTicketForm";
			this.Load += new System.EventHandler(this.Practice_Load);
			this.tlMain.ResumeLayout(false);
			this.tlBtns.ResumeLayout(false);
			this.tlDate.ResumeLayout(false);
			this.tlDate.PerformLayout();
			this.tlDateMain.ResumeLayout(false);
			this.tlDatePD.ResumeLayout(false);
			this.tlDatePD.PerformLayout();
			this.tlDateDD.ResumeLayout(false);
			this.tlDateDD.PerformLayout();
			this.tlSIR.ResumeLayout(false);
			this.tlSIR.PerformLayout();
			this.tlSIRMain.ResumeLayout(false);
			this.tlSIRCost.ResumeLayout(false);
			this.tlSIRCost.PerformLayout();
			this.tlSIRRepSer.ResumeLayout(false);
			this.tlSIRRepSer.PerformLayout();
			this.tlMainHeader.ResumeLayout(false);
			this.tlMainHeader.PerformLayout();
			this.tlSI.ResumeLayout(false);
			this.tlSI.PerformLayout();
			this.tlSIMain.ResumeLayout(false);
			this.tlSICatItem.ResumeLayout(false);
			this.tlSICatItem.PerformLayout();
			this.tlSICategory.ResumeLayout(false);
			this.tlSICategory.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlMain;
		private System.Windows.Forms.TableLayoutPanel tlMainHeader;
		private System.Windows.Forms.Label lblCN;
		private System.Windows.Forms.Label lblTN;
		private System.Windows.Forms.TableLayoutPanel tlSI;
		private System.Windows.Forms.TableLayoutPanel tlDate;
		private System.Windows.Forms.TableLayoutPanel tlSIR;
		private System.Windows.Forms.TableLayoutPanel tlBtns;
		private System.Windows.Forms.Button btnCnl;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label lblSIR;
		private System.Windows.Forms.Label lblSI;
		private System.Windows.Forms.TableLayoutPanel tlSIRMain;
		private System.Windows.Forms.TableLayoutPanel tlSIMain;
		private System.Windows.Forms.TableLayoutPanel tlDateMain;
		private System.Windows.Forms.TableLayoutPanel tlDatePD;
		private System.Windows.Forms.TableLayoutPanel tlDateDD;
		private System.Windows.Forms.TableLayoutPanel tlSIRCost;
		private System.Windows.Forms.TableLayoutPanel tlSIRRepSer;
		private System.Windows.Forms.TableLayoutPanel tlSICatItem;
		private System.Windows.Forms.TableLayoutPanel tlSICategory;
		private System.Windows.Forms.Label lblCat;
		private System.Windows.Forms.ComboBox cbCat;
		private System.Windows.Forms.Label lblCI;
		private System.Windows.Forms.ComboBox cbCI;
		private System.Windows.Forms.Label lblRS;
		private System.Windows.Forms.Label lblCost;
		private System.Windows.Forms.Label lblDD;
		private System.Windows.Forms.Label lblPD;
		private System.Windows.Forms.TextBox tbDD;
		private System.Windows.Forms.DateTimePicker dtpPD;
		private System.Windows.Forms.TextBox tbCost;
		private System.Windows.Forms.ComboBox cbRS;
	}
}