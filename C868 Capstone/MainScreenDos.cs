using C868_Capstone.Properties;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C868_Capstone
{
	public partial class MainScreenDos : Form
	{
		string connString = "server = 192.168.29.210; database=shoerepair_pos; Uid = root; pwd=123; persistsecurityinfo = True; Allow User Variables=True";
		DataTable ticketItemDT = new DataTable();
		DataTable itemrepairDT = new DataTable();
		int widthTILTemp;
		int heightTILTemp;
		int widthIRLTemp;
		int heightIRLTemp;
		int ticketID;
		int ticketNumber;
		int ticketItemID;
		int itemRepairID;
		int categoryID;
		int ticketGT;
		int subTotal;
		Control ctl;
		string itemName = "";
		string custName = "";
		DateTime dropDate;
		DateTime pickupDate; //Need to grab the pickup Date when a ticket is selected...
		bool init = false;
		public MainScreenDos()
		{
			InitializeComponent();
		}

		public MainScreenDos(int ticketID, int ticketNumber, string custName, DateTime dropDate)
		{
			InitializeComponent();
			this.ticketID = ticketID;
			this.custName = custName;
			this.dropDate = dropDate;
			this.ticketNumber = ticketNumber;
			
		}

		private void MainScreenDos_Load(object sender, EventArgs e)
		{
			this.Show();
			init = true;
			PopulateTicketList();
			init = false;
			tlIRLTemp.Hide();
			tlTILTemp.Hide();
			widthTILTemp = tlTILTemp.Width;
			heightTILTemp = tlTILTemp.Height;
			widthIRLTemp = tlIRLTemp.Width;
			heightIRLTemp = tlIRLTemp.Height;
			lblTIL.Text = $"Ticket #{ticketNumber}'s Item List";
			dtpPD.CustomFormat = " ";
			dtpPD.Format = DateTimePickerFormat.Custom;
			btnAddTI.Focus();
			btnAddIR.Hide();
			PopulateTicketOV();
			


		}

		private void PopulateTicketList()
		{
			//Create MySql cmd with selectedTicketID
			
			var searchCmd = "SELECT subtotal, ti.ticket_item_id as \"TID\", " +
				"pickup_date, " +
				"(SELECT category_item_name FROM category_item ci WHERE ti.category_item_id = ci.category_item_id) " +
				"as \"Item's Name\", " +
				"(SELECT category_name FROM category " +
				"WHERE category_id = " +
				"(SELECT category_id FROM category_item ci WHERE ci.category_item_id = ti.category_item_id) ) " +
				"as \"Item's Category\", " +
				"(SELECT category_id FROM category " +
				"WHERE category_id = " +
				"(SELECT category_id FROM category_item ci WHERE ci.category_item_id = ti.category_item_id) ) " +
				"as \"categoryID\", " +
				"ti.drop_date " +
				"FROM ticket_item ti " +
				"WHERE ti.ticket_id = @ticketID";

			//Connect to database & fill data table with all of the ticket items 
			using (MySqlConnection conn = new MySqlConnection(connString))
			{
				tlTIL.Controls.Clear();
				tlTIL.RowCount = 0;
				ticketItemDT.Clear();

				try
				{
					conn.Open();
					using (MySqlCommand cmd = new MySqlCommand(searchCmd, conn))
					{
						cmd.Parameters.Add(new MySqlParameter("@ticketId", ticketID));
						MySqlDataAdapter adapter = new MySqlDataAdapter();

						adapter.SelectCommand = cmd;
						adapter.Fill(ticketItemDT);
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}

			for (int i = 0; i < ticketItemDT.Rows.Count; i++)
			{
				//UML diagram -- Data Model of each object ==> static class TIcketItem.Subtotal
				var subTotal = ticketItemDT.Rows[i].Field<int>("subtotal");
				var itemName = ticketItemDT.Rows[i].Field<string>("Item's Name");
				var itemCategoryName = ticketItemDT.Rows[i].Field<string>("Item's Category");
				var categoryID = ticketItemDT.Rows[i].Field<int>("categoryID");
				var ticketItemID = ticketItemDT.Rows[i].Field<int>("TID");
				var pickupDate = ticketItemDT.Rows[i].Field<DateTime>("pickup_date");
				this.ticketItemID = ticketItemID; //Points to the last item (i.e. the newest ticket item added)
				if(init)
					ticketGT += subTotal;

				TableLayoutPanel panelTicketItemInfo = new TableLayoutPanel();
				panelTicketItemInfo.Size = new Size(tlTILTemp.Width, tlTILTemp.Height);
				panelTicketItemInfo.RowCount = 2;
				panelTicketItemInfo.ColumnCount = 2;
				panelTicketItemInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
				panelTicketItemInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
				panelTicketItemInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
				panelTicketItemInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
				panelTicketItemInfo.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
				panelTicketItemInfo.Name = "panelTI"; //TODO: Where else do I find this?
				panelTicketItemInfo.Tag = ticketItemID.ToString();
				panelTicketItemInfo.SetColumnSpan(panelTicketItemInfo, 2);
				//TODO: Adjust the SizeType to a fixed size?? E.g. Have the row be 100px?? 
				Label lblTL = new Label();
				Label lblBL = new Label();
				var font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel);

				//Top Left 
				lblTL.Text = itemName;
				lblTL.Font = font;
				lblTL.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
				lblTL.TextAlign = ContentAlignment.TopLeft;
				lblTL.AutoSize = true;
				lblTL.Name = categoryID.ToString();
				lblTL.Tag = "itemName";

				//Bottom Left
				lblBL.Text = subTotal.ToString();//subTotal.ToString(); TODO: Gotta have the subtotal be current & accurate when it loads up from the MainScreen to MainScreen2...
				lblBL.Font = font;
				lblBL.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
				lblBL.TextAlign = ContentAlignment.BottomLeft;
				lblBL.AutoSize = true;
				lblBL.Name = "subtotal";
				lblBL.TextChanged += lblSubT_TextChanged;
				lblBL.Tag = pickupDate;


				//Top Right
				Label lblTR = new Label();
				lblTR.Text = itemCategoryName;
				lblTR.Font = font;
				lblTR.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
				lblTR.TextAlign = ContentAlignment.TopRight;
				lblTR.TextAlign = ContentAlignment.MiddleRight;

				//Bottom Right
				object o = Resources.ResourceManager.GetObject("icons8_trash_18"); //"C868_Capstone.Properties.Resources.icons8_trash_18"
				Button btnDel = new Button();
				btnDel.Image = (Image)o;
				btnDel.FlatStyle = FlatStyle.Flat;
				btnDel.FlatAppearance.BorderSize = 0;
				btnDel.FlatAppearance.MouseDownBackColor = Color.Transparent;
				btnDel.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
				btnDel.ImageAlign = ContentAlignment.BottomRight;
				btnDel.Size = new Size(75, 34);
				btnDel.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
				btnDel.Margin = new Padding(3, 3, 0, 3);
				btnDel.Name = dropDate.ToString(); //TODO: Is this necessary? lol

				panelTicketItemInfo.Controls.Add(lblTL, 0, 0);
				panelTicketItemInfo.Controls.Add(lblBL, 0, 1);
				panelTicketItemInfo.Controls.Add(lblTR, 1, 0);
				panelTicketItemInfo.Controls.Add(btnDel, 1, 1);


				panelTicketItemInfo.MouseEnter += new System.EventHandler(this.tlTIL_MouseEnter);
				panelTicketItemInfo.MouseLeave += new System.EventHandler(this.tableLayoutPanel_MouseLeave);
				panelTicketItemInfo.Click += new System.EventHandler(this.panelTIL_Click);

				foreach(Control ctl in panelTicketItemInfo.Controls)
				{
					ctl.MouseEnter += new System.EventHandler(this.tlTIL_MouseEnter);
					ctl.MouseLeave += new System.EventHandler(this.tableLayoutPanel_MouseLeave);
					ctl.Click += new System.EventHandler(this.panelTIL_Click);

					if(ctl.Name.Equals(dropDate.ToString())) //Change this as well...smh
					{
						ctl.Click -= this.panelTIL_Click;
						ctl.Click += btnDelItem_Click;
					}
				}



				tlTIL.Controls.Add(panelTicketItemInfo);
			}

			if (ticketItemDT.Rows.Count <= 8)
			{
				var count = 9 - ticketItemDT.Rows.Count;
				CreateEmptyPanels(count, tlTIL);
			}



		}

		public void PopulateItemRepairList(int itemTicketID)
		{
			//TODO: Change mySQL cmd
			var searchCmd = "SELECT rs.repair_name as \"rn\", ir.cost as \"c\", item_repair_id as irID " +
				"FROM repair_service rs, item_repair ir " +
				"WHERE rs.repair_service_id = ir.repair_service_id AND ticket_item_id = @ticketItemID;";

			//Connect to database & fill data table with all of the ticket items 
			using (MySqlConnection conn = new MySqlConnection(connString))
			{
				tlIRL.Controls.Clear();
				tlIRL.RowCount = 0;
				itemrepairDT.Clear();

				try
				{
					conn.Open();
					using (MySqlCommand cmd = new MySqlCommand(searchCmd, conn))
					{
						cmd.Parameters.Add(new MySqlParameter("@ticketItemID", itemTicketID));

						MySqlDataAdapter adapter = new MySqlDataAdapter();

						adapter.SelectCommand = cmd;
						adapter.Fill(itemrepairDT);
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}

			for (int i = 0; i < itemrepairDT.Rows.Count; i++)
			{
				//TODO: Change fields!
				var repairName = itemrepairDT.Rows[i].Field<string>("rn");
				var repairCost = itemrepairDT.Rows[i].Field<int>("c");
				var itemRepairID = itemrepairDT.Rows[i].Field<int>("irID");
				this.itemRepairID = itemRepairID; //Tehcnically now, the itemrepairID will always point to the last panel
												 //in other words, if a new repair is added it'll be pointing at that 
				//var itemCategory = itemrepairDT.Rows[i].Field<string>("Item's Category");
				//var ticketID = itemrepairDT.Rows[i].Field<string>("TID");

				TableLayoutPanel panelTicketItemInfo = new TableLayoutPanel();
				panelTicketItemInfo.Size = new Size(tlIRL.Width, tlIRL.Height); //(584,83)
				panelTicketItemInfo.RowCount = 2;
				panelTicketItemInfo.ColumnCount = 2;
				panelTicketItemInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
				panelTicketItemInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
				panelTicketItemInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
				panelTicketItemInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
				panelTicketItemInfo.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
				//panelTicketItemInfo.Name = ticketID.ToString(); TODO: DELETE?? Or am I gonna need this for a future use??
				panelTicketItemInfo.SetColumnSpan(panelTicketItemInfo, 2);
				panelTicketItemInfo.Tag = itemRepairID.ToString();
				panelTicketItemInfo.Name = "panelIR";
				//TODO: Adjust the SizeType to a fixed size?? E.g. Have the row be 100px?? 
				
				
				var font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel);

				//Top Left 
				Label lblTL = new Label();
				lblTL.Text = repairName;
				lblTL.Font = font;
				lblTL.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
				lblTL.TextAlign = ContentAlignment.TopLeft;
				lblTL.Name = "repairName";

				//Bottom Left
				Label lblBL = new Label();
				lblBL.Text = repairCost.ToString();
				lblBL.Font = font;
				lblBL.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
				lblBL.TextAlign = ContentAlignment.BottomLeft;
				lblBL.Name = "cost";

				//Top Right
				Label lblTR = new Label();
				lblTR.Text = "Edit option here???";
				lblTR.Font = font;


				//Bottom Right
				object o = Resources.ResourceManager.GetObject("icons8_trash_18"); //"C868_Capstone.Properties.Resources.icons8_trash_18"
				Button btnDel = new Button();
				btnDel.Image = (Image)o;
				btnDel.FlatStyle = FlatStyle.Flat;
				btnDel.FlatAppearance.BorderSize = 0;
				btnDel.FlatAppearance.MouseDownBackColor = Color.Transparent;
				btnDel.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
				btnDel.ImageAlign = ContentAlignment.BottomRight;
				btnDel.Size = new Size(75, 34);
				btnDel.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
				btnDel.Margin = new Padding(3, 3, 0, 3);
				btnDel.Name = "btnDel";

				panelTicketItemInfo.Controls.Add(lblTL, 0, 0);
				panelTicketItemInfo.Controls.Add(lblBL, 0, 1);
				//TODO: Hide the edit cost option for now -- do it for V2.0
				//panelTicketItemInfo.Controls.Add(lblTR, 1, 0);
				panelTicketItemInfo.Controls.Add(btnDel, 1, 1);


				panelTicketItemInfo.MouseEnter += new System.EventHandler(this.tlIRL_MouseEnter);
				panelTicketItemInfo.MouseLeave += new System.EventHandler(this.tableLayoutPanel_MouseLeave);
				//panelTicketItemInfo.Click += new System.EventHandler(this.panelIRL_Click);

				foreach (Control ctl in panelTicketItemInfo.Controls)
				{
					ctl.MouseEnter += new System.EventHandler(this.tlIRL_MouseEnter);
					ctl.MouseLeave += new System.EventHandler(this.tableLayoutPanel_MouseLeave);
					//ctl.Click += new System.EventHandler(this.panelIRL_Click);

					if (ctl.Name.Equals("btnDel"))
					{
						//ctl.Click -= this.panelIRL_Click;
						ctl.Click += btnDelRepair_Click;
					}
				}



				tlIRL.Controls.Add(panelTicketItemInfo);
				

			}
			if (itemrepairDT.Rows.Count <= 5)
			{
				var count = 6 - itemrepairDT.Rows.Count;
				CreateEmptyPanels(count, tlIRL);
			}

			//TODO: Maybe move this to a better place later on?
			lblIRL.Text = $"{itemName}'s Repair List";

		}

		//Helper method that populates table with empty panels to make formatting look nice 
		private void CreateEmptyPanels(int count, TableLayoutPanel tl)
		{
			for (int i = 0; i < count; i++)
			{
				TableLayoutPanel panelCustInfo = new TableLayoutPanel();
				if (tl.Name.Equals("tlTIL"))
				{
					panelCustInfo.Size = new Size(widthTILTemp, heightTILTemp);
				}
				else
					panelCustInfo.Size = new Size(widthIRLTemp, heightIRLTemp);

				panelCustInfo.RowCount = 2;
				panelCustInfo.ColumnCount = 2;
				panelCustInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
				panelCustInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
				panelCustInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
				panelCustInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
				panelCustInfo.SetColumnSpan(panelCustInfo, 2);
				tl.Controls.Add(panelCustInfo);

			}
		}

		//TODO: Wait do I even need this event handler??
		//private void panelIRL_Click(object sender, EventArgs e)
		//{
		//	categoryID = Convert.ToInt32(ctl.GetNextControl(ctl, true).Name);
		//	itemName = ctl.GetNextControl(ctl, true).Text; //do I need this tho?
			
		//	//TODO: Double click dumas
		//}

		private void panelTIL_Click(object sender, EventArgs e)
		{
			ticketItemID = Convert.ToInt32(ctl.Tag); 
			categoryID = Convert.ToInt32(ctl.GetNextControl(ctl, true).Name);
			itemName = ctl.GetNextControl(ctl, true).Text;
			foreach(Control ctl in ctl.Controls)
			{
				if(ctl.Name.Equals("subtotal"))
				{
					this.pickupDate = (DateTime)ctl.Tag;
				}
			}
			//Reset the running subtotal to 0 
			this.subTotal = 0;

			Control lbl = (Control)sender;
			
			int currentSub = 0;
			Control lblSubtotal = null;

			if(lbl is Label)
			{
				var _lbl = lbl.Parent;
				foreach (Control ctl in _lbl.Controls)
				{
					if (ctl.Name.Equals("subtotal"))
					{
						currentSub = String.IsNullOrEmpty(ctl.Text) ? 0 : Convert.ToInt32(ctl.Text); //this is b/c the label is dynamically created with ctl.Text = ""
						lblSubtotal = ctl;
					}

				}
			}
			else if(lbl is TableLayoutPanel) //Not sure if this bug will occur again, but just in case...
			{
				foreach(Control ctl in lbl.Controls)
				{
					if (ctl.Name.Equals("subtotal"))
					{
						currentSub = Convert.ToInt32(ctl.Text);
						lblSubtotal = ctl;
					}
				}
			}


			PopulateItemRepairList(ticketItemID);

			if (currentSub == 0 && lblSubtotal != null)
			{
				foreach (Control ctl in tlIRL.Controls)
				{
					if (String.IsNullOrEmpty(ctl.Name))
						continue;
					if (ctl.Name.Equals("panelIR"))
					{
						foreach (Control _ctl in ctl.Controls)
						{
							if (_ctl.Name.Equals("cost"))
							{
								var _subtotal = Convert.ToInt32(_ctl.Text);
								this.subTotal += _subtotal;
							}

						}
					}

					
				}
				lblSubtotal.Text = this.subTotal.ToString();
			}

			
			
			btnAddIR.Show();
			var dtpVal = pickupDate.ToString("MM-dd-yyyy"); ;
			dtpPD.Value = DateTime.Parse(dtpVal);

			//Double click dumas 
		}

		private void tlTIL_MouseEnter(object sender, EventArgs e)
		{
			var testPt = tlTIL.PointToClient(Cursor.Position);
			try
			{
				ctl = tlTIL.GetChildAtPoint(testPt);
				if (ctl == null) //See if this works or not...
					return;
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			

			//TODO: Why do I get this bug/issue with null object reference? 
			try
			{
				ctl.BackColor = SystemColors.GradientInactiveCaption;
				var lblList = ctl.Controls.OfType<Label>();

				var font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);

				for (int i = 0; i < lblList.Count(); i++)
				{
					lblList.ElementAt(i).Font = font;
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			

		}

		private void tlIRL_MouseEnter(object sender, EventArgs e)
		{
			var testPt = tlIRL.PointToClient(Cursor.Position);
			ctl = tlIRL.GetChildAtPoint(testPt);
			ctl.BackColor = SystemColors.GradientInactiveCaption;
			var lblList = ctl.Controls.OfType<Label>();

			var font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);

			for (int i = 0; i < lblList.Count(); i++)
			{
				lblList.ElementAt(i).Font = font;
			}
		}

		private void tableLayoutPanel_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				if (ctl != null)
					ctl.BackColor = SystemColors.Control;
				else
					return;
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			
			var lblList = ctl.Controls.OfType<Label>();

			var font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel);
			for (int i = 0; i < lblList.Count(); i++)
			{

				lblList.ElementAt(i).Font = font;
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			UpdateTicketDeposit();
			UpdateSubtotal();
			FormProvider.MainScreen.Show();
			this.Close();
			
		}

		//TODO: DELETE this method & button probably lol. D
		private void btnExt_Click(object sender, EventArgs e)
		{
			//Save changes made. 
			UpdateTicketDeposit();
			UpdateSubtotal();
			this.Close();
			FormProvider.MainScreen.Close();
		}

		//private void MainScreenDos_FormClosing(object sender, FormClosingEventArgs e)
		//{
		//	if (e.CloseReason == CloseReason.UserClosing)
		//	{
		//		DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit Application", MessageBoxButtons.YesNo);
		//		if (result == DialogResult.Yes)
		//		{
		//			Environment.Exit(0);
		//		}
		//		else
		//			e.Cancel = true;
		//	}
		//	else
		//		e.Cancel = true;
		//}

		private void btnAddIR_Click(object sender, EventArgs e)
		{
			TicketTemplate pr = new TicketTemplate("ticket item repair", categoryID, ticketItemID); //nono we need the categoryID to be sent
			pr.FormClosed += PR_FormClosedIRL;
			pr.Show();
		}

		private void btnAddTI_Click(object sender, EventArgs e)
		{
			TicketTemplate pr = new TicketTemplate("ticket item", ticketID, dropDate);
			pr.FormClosed += PR_FormClosedTIL;
			pr.Show();
		}

		private void PR_FormClosedIRL(object sender, FormClosedEventArgs e)
		{
			PopulateItemRepairList(ticketItemID);
			//Call update subtotal method here
			CalculateSubtotal();

			//Test it out 
			//lblSubT_TextChanged(null, null);
		}

		private void PR_FormClosedTIL(object sender, FormClosedEventArgs e)
		{
			PopulateTicketList();
		}

		//private void DisplayTicketOV(bool show)
		//{
		//	if(show)
		//	{
		//		tlTicketOV.Show();
		//	}
		//	else
		//	{
		//		tlTicketOV.Hide();
		//	}
		//}

		private void PopulateTicketOV()
		{
			//Grab ticket deposit 
			var sqlcmd = "SELECT deposit FROM ticket WHERE ticket_id = @ticketID;";
			using (MySqlConnection conn = new MySqlConnection(connString))
			{
				try
				{
					DataTable dt = new DataTable();
					conn.Open();
					using(MySqlCommand cmd = new MySqlCommand(sqlcmd, conn))
					{
						cmd.Parameters.Add(new MySqlParameter("@ticketID", this.ticketID));
						MySqlDataAdapter adapter = new MySqlDataAdapter();
						adapter.SelectCommand = cmd;
						adapter.Fill(dt);

						if (dt.Rows.Count > 0)
						{
							tbDep.Text = dt.Rows[0].Field<int>(0).ToString();
						}
						else
							tbDep.Text = "0";
					}
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}

			tbGT.Text = ticketGT.ToString();
			lblCustName.Text = ToTitleCase(custName);
			tbDD.Text = dropDate.ToString("MM-dd-yyyy");
			CalculateTicketAcc();
			
		}
		private void tbGT_TextChanged(object sender, EventArgs e)
		{
			CalculateTicketAcc();
		}

		private void tbDep_TextChanged(object sender, EventArgs e)
		{
			//Validation checking 


			int deposit = 0;
			if(!String.IsNullOrEmpty(tbDep.Text))
			{
				if (!Regex.IsMatch(tbDep.Text, @"^[0-9]+$"))
				{
					MessageBox.Show("Please enter a numerical value.");
					return;
				}
				else if (tbDep.Text[0].Equals('-'))
				{
					if (tbDep.Text.Length == 1)
					{
						return;
					}
					else
						deposit = Convert.ToInt32(tbDep.Text); 
				}
				deposit = Convert.ToInt32(tbDep.Text);
			}

			if (deposit < 0)
			{
				//tbDep.BackColor = Color.IndianRed;
				MessageBox.Show("Deposit amount cannot be negative!");
				tbDep.Text = "";
			}
			//else if(deposit >= 0)
			//{
			//	deposit = Convert.ToInt32(tbDep.Text);
			//}
			else if (deposit > ticketGT)
			{
				//tbDep.BackColor = Color.IndianRed;
				MessageBox.Show($"Deposit should not exceed ${ticketGT}.");
				tbDep.Text = "";
			}
			else
				CalculateTicketAcc();
		}
		private void CalculateTicketAcc()
		{
			var gt = Convert.ToInt32(tbGT.Text);
			int dep;
			if (!String.IsNullOrEmpty(tbDep.Text))
			{
				dep = Convert.ToInt32(tbDep.Text); //TODO: Gotta check that the number is not negative!! 
			}
			else
				dep = 0;	
			var balance = gt - dep;
			tbBal.Text = balance.ToString();
		}

		private void CalculateSubtotal()
		{
			//All the panels in the IRL belong to one ticket item 
			int subtotal = 0;
			foreach (Control ctl in tlIRL.Controls)
			{
				if (String.IsNullOrEmpty(ctl.Name))
					continue;
				//TODO? This could probably done recursively tbh...
				if (ctl.Name.Equals("panelIR")) 
				{
					foreach(Control _ctl in ctl.Controls)
					{
						if(_ctl.Name.Equals("cost"))
						{
							subTotal += Convert.ToInt32(_ctl.Text); 
						}
					}
				}
			}

			//Should only be updating a particular ticket item's subtotal here...gotta use the ticketItemID
			foreach(Control ctl in tlTIL.Controls) //Going through all the ticket item panels 
			{
				if (ctl.Tag == null) //SKip over the filler panels 
					continue;
				if(ctl.Name.Equals("panelTI")) 
				{
					if(ctl.Tag.Equals(this.ticketItemID.ToString()))
					{
						foreach (Control _ctl in ctl.Controls)
						{
							if (_ctl.Name.Equals("subtotal"))
							{
								_ctl.Text = subTotal.ToString();
							}
						}
					}
				}
			}


		}

		private void UpdateSubtotal()
		{
			var sqlcmd = "UPDATE ticket_item " +
						 "SET subtotal = @subTotal " +
						 "WHERE ticket_item_id = @tiID;";
			int subtotal = 0;
			int ticketItemID = 0;
			string itemName = "";
			foreach(Control ctl in tlTIL.Controls)
			{
				if(ctl.Name.Equals("panelTI"))
				{
					ticketItemID = Convert.ToInt32(ctl.Tag);
				}
				foreach(Control _ctl in ctl.Controls)
				{
					//if (_ctl.Tag == null)
					//	continue;
					if(_ctl.Name.Equals("subtotal"))
					{
						subtotal = Convert.ToInt32(_ctl.Text);
						using (MySqlConnection conn = new MySqlConnection(connString))
						{
							try
							{
								conn.Open();
								using (MySqlCommand cmd = new MySqlCommand(sqlcmd, conn))
								{
									cmd.Parameters.Add(new MySqlParameter("@subTotal", subtotal));
									cmd.Parameters.Add(new MySqlParameter("@tiID", ticketItemID));
									var count = cmd.ExecuteNonQuery();

									//if (count > 0)
									//	MessageBox.Show($"{itemName}'s subtotal is ${subtotal}.");
								}
							}
							catch (Exception ex)
							{
								Console.WriteLine(ex.ToString());
							}
						}
					}
					//else if(_ctl.Tag.Equals("itemName"))
					//{
					//	itemName = _ctl.Text;
					//}


				}


			}
			//TODO: DELETE!!! var subtotal =;// Convert.ToInt32(tbDep.Text); -- This needs to be the subtotal for each panel
			//DELETE var ticketItemID =; //Need to grab the ticket_item_id for each panel 

			//TODO: Have a bool for ticket items who's subtotals have changed, so we don't have to update all the subtotals...

			//for loop through all the controls & update the subtotal

		}

		private void UpdateTicketDeposit()
		{
			var sqlcmd = "UPDATE ticket " +
						 "SET deposit = @dep " +
						 "WHERE ticket_id = @ticketID;";
			var deposit = !String.IsNullOrEmpty(tbDep.Text) ? Convert.ToInt32(tbDep.Text) : 0;
			using (MySqlConnection conn = new MySqlConnection(connString))
			{
				try
				{
					conn.Open();
					using (MySqlCommand cmd = new MySqlCommand(sqlcmd, conn))
					{
						cmd.Parameters.Add(new MySqlParameter("@dep", deposit));
						cmd.Parameters.Add(new MySqlParameter("@ticketID", ticketID));
						var count = cmd.ExecuteNonQuery();

						//if (count > 0)
						//	MessageBox.Show($"Deposit successfully update to ${deposit}.");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}
		}

		private string ToTitleCase(string str)
		{
			return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
		}

		private void btnDelItem_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			var _ctl = btn.Parent;
			ticketItemID = Convert.ToInt32(_ctl.Tag);
			
			//Is this going to give me panelticketInfo.Name - this has the ticketItemID...

			DialogResult delResult = MessageBox.Show($"Are you sure you want to delete {itemName}?", "Delete Ticket Item", MessageBoxButtons.YesNo);
			if(delResult == DialogResult.Yes)
			{
				var sqlcmd = "DELETE FROM ticket_item WHERE ticket_item_id = @tiID;";
				using (MySqlConnection conn = new MySqlConnection(connString))
				{
					try
					{
						conn.Open();
						using (MySqlCommand cmd = new MySqlCommand(sqlcmd, conn))
						{
							cmd.Parameters.Add(new MySqlParameter("@tiID", ticketItemID));
							var count = (int)cmd.ExecuteNonQuery();

							if (count > 0)
							{
								PopulateTicketList();
								tlIRL.Controls.Clear();
								foreach (Control ctl in _ctl.Controls)
								{
									if (ctl.Name.Equals("subtotal"))
									{
										var negSubtotal = Convert.ToInt32(ctl.Text) * -1;
										ctl.Text = negSubtotal.ToString(); //check to see this has the intended effect ASDF
									}
								}
							}
						}
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.ToString());
					}
				}
			}


		}

		private void btnDelRepair_Click(object sender, EventArgs e)
		{
			//itemRepairID = Convert.ToInt32(ctl.GetNextControl(ctl, false).Name);
			itemRepairID = Convert.ToInt32(ctl.Tag);
			//
			string repairName = "";
			foreach(Control ctl in ctl.Controls)
			{
				if(ctl.Name.Equals("repairName"))
				{
					repairName = ctl.Text;
				}
			}


			DialogResult delResult = MessageBox.Show($"Are you sure you want to delete {repairName}?", "Delete Repair Item", MessageBoxButtons.YesNo);
			if (delResult == DialogResult.Yes)
			{
				var sqlcmd = "DELETE FROM item_repair WHERE item_repair_id = @irID;";
				using (MySqlConnection conn = new MySqlConnection(connString))
				{
					try
					{
						conn.Open();
						using (MySqlCommand cmd = new MySqlCommand(sqlcmd, conn))
						{
							cmd.Parameters.Add(new MySqlParameter("@irID", itemRepairID));
							var count = (int)cmd.ExecuteNonQuery();

							if (count > 0)
							{
								PopulateItemRepairList(ticketItemID);
							}
						}
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.ToString());
					}
				}

				int cost = 0;
				foreach (Control ctl in ctl.Controls)
				{
					if (ctl.Name.Equals("cost"))
					{
						cost = Convert.ToInt32(ctl.Text);
					}
				}
				foreach (Control ctl in tlTIL.Controls)
				{
					if (ctl.Tag == null)
						continue;
					if (ctl.Tag.Equals(this.ticketItemID.ToString()))
					{
						foreach (Control _ctl in ctl.Controls)
						{
							if (_ctl.Name.Equals("subtotal"))
							{
								var oldST = Convert.ToInt32(_ctl.Text);
								var newSubTotal = oldST - cost;
								if (newSubTotal > 0)
								{
									_ctl.Text = (newSubTotal).ToString();
								}
								else if (newSubTotal == 0)
								{
									_ctl.Text ="0";
								}
								else
									return;
								

							}
						}
					}
				}
			}
		}

		private void dtPD_ValueChanged(object sender, EventArgs e)
		{
			var dropDate = this.dropDate;
			var pickupDate = dtpPD.Value.Date;
			var tiID = ticketItemID;
			var itemName = "";

			foreach(Control ctl in tlTIL.Controls)
			{
				if (ctl.Tag == null)
					continue;
				if(ctl.Tag.Equals(tiID.ToString()))
				{
					foreach(Control _ctl in ctl.Controls)
					{
						if (_ctl.Tag == null)
							continue;
						if(_ctl.Tag.Equals("itemName"))
						{
							itemName = _ctl.Text;
						}
					}
				}
			}

			if (pickupDate < dropDate)
			{
				try
				{
					
					MessageBox.Show($"Please select a pickup date that is later than {dropDate}");
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}

				
				dtpPD.ResetText(); //Good feature or nah? 
			}
			else
			{
				//Here update the pickup_date for the ticket_item 
				var sqlcmd = "UPDATE ticket_item " +
							 "SET pickup_date = @pickupDate " +
							 "WHERE ticket_item_id = @tiID;";
				using (MySqlConnection conn = new MySqlConnection(connString))
				{
					try
					{
						conn.Open();
						using(MySqlCommand cmd = new MySqlCommand(sqlcmd, conn))
						{
							cmd.Parameters.Add(new MySqlParameter("@pickupDate", pickupDate.ToString("yyyy-MM-dd HH:mm:ss")));
							cmd.Parameters.Add(new MySqlParameter("@tiID", tiID));
							var count = cmd.ExecuteNonQuery();

							if(count > 0)
							{
								var newDate = pickupDate.ToString("MM-dd-yyyy");
								//MessageBox.Show($"{itemName}'s pickup date is now {newDate}");

								dtpPD.CustomFormat = "MM-dd-yyyy";
								dtpPD.Format = DateTimePickerFormat.Custom;
							}
						}
					}
					catch(Exception ex)
					{
						Console.WriteLine(ex.ToString());
					}
				}
			}
		}
		private void lblSubT_TextChanged(object sender, EventArgs e)
		{
			//Several ways to go about this -- updating the grand total whenever a subtotal changes 
			//For now, I'm just going to loop through all the controls & add up the subtotals
			int newGT = 0;
			//use the sender...which is the label bruh LOL 
			foreach(Control ctl in tlTIL.Controls)
			{
				if (String.IsNullOrEmpty(ctl.Name))
					continue; 
				foreach(Control _ctl in ctl.Controls)
				{
					if(_ctl.Name.Equals("subtotal"))
					{
						var subT = Convert.ToInt32(_ctl.Text);
						newGT += subT;
					}

				}
			}
			this.ticketGT = newGT;
			tbGT.Text = this.ticketGT.ToString();
		}
	}
}
