using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C868_Capstone
{
	public partial class TicketTemplate : Form
	{
		int ticketID, ticketNumber, customerID, ticketItemID;
		bool costPass, pickupPass;
		string custName;
		string state;
		string connString = "server = localhost; database=shoerepair_pos; Uid = root; pwd=july72794!; persistsecurityinfo = True; Allow User Variables=True";
		Dictionary<string, int> categoryDict = new Dictionary<string, int>() { {"Pick category", 0 }, { "Women's Shoes", 1 }, { "Men's Shoes", 2 }, { "Luggage", 3 } };
		Font myFont = new Font("Arial", 10, FontStyle.Regular);
		DateTime dropDate;
		int selIndexCI;
		public TicketTemplate()
		{
			InitializeComponent();
		}

		//Add Ticket Button Event
		public TicketTemplate(string Name, string state, int ticketNumber, int customerID)
		{
			InitializeComponent();
			this.customerID = customerID;
			this.custName = Name;
			this.state = state;
			this.ticketNumber = ticketNumber;
		}

		//Add Ticket Item Button Event 
		public TicketTemplate(string state, int ticketID, DateTime dropDate)
		{
			InitializeComponent();
			this.ticketID = ticketID;
			this.state = state;
			this.dropDate = dropDate;
		}

		//Add Item Repair Button Event 
		public TicketTemplate(string state, int categoryID, int ticketItemID)
		{
			InitializeComponent();
			this.ticketItemID = Convert.ToInt32(ticketItemID);
			selIndexCI = categoryID;
			this.state = state;
		}

		private void Practice_Load(object sender, EventArgs e)
		{
			this.Show();

			if(state == "ticket" || state == "ticket item")
			{
				var bindingSrc = new BindingSource();
				bindingSrc.DataSource = categoryDict;
				cbCat.DataSource = bindingSrc;
				cbCat.DisplayMember = "Key";
				cbCat.ValueMember = "Value";
			}

			cbCI.Enabled = false;
			cbRS.Enabled = false;
			tbCost.Enabled = false;
			btnCreate.Enabled = false;

			var date = DateTime.Now;
			if (state == "ticket")
				tbDD.Text = date.ToString("MM-dd-yyyy");
			else if (state == "ticket item")
				tbDD.Text = dropDate.ToString("MM-dd-yyyy");// String.Format("{0:MM-dd-yyyy}",DateTime.Parse(dropDate));
			ticketNumber++;
			lblTN.Text = ticketNumber.ToString();
			lblCN.Text = custName;
			lblTN.Text = ticketNumber.ToString();




			//Btn Text will change depending on which add button is pressed, e.g. btnCreate.Text will change

			//Also hide certain tlTypeMains && for now just hide it ==> Later can clear the control & remove the row & reformat
			switch(state)
			{
				//TODO: Determine whether or not user can create a ticket without customer name or if that is a requirement 
				case "ticket": //TODO: Delete since we are not opening this form for ticket add
					tlMain.Controls.Remove(tlDate);
					TableLayoutPanelCellPosition tlPos = new TableLayoutPanelCellPosition(0, 3);
					tlMain.SetCellPosition(tlBtns, tlPos);
					tlMain.RowStyles.RemoveAt(4);
					lblCN.Text = ToTitleCase(custName);
					break;
				case "ticket item":
					tlMain.Controls.Remove(tlSIR);
					TableLayoutPanelCellPosition _pos = new TableLayoutPanelCellPosition(0, 2);
					tlMain.SetCellPosition(tlDate, _pos);
					TableLayoutPanelCellPosition posBtn = new TableLayoutPanelCellPosition(0, 3);
					tlMain.SetCellPosition(tlBtns, posBtn);
					tlMain.RowStyles.RemoveAt(4);
					btnCreate.Text = "Create Ticket Item";

					break;
				case "ticket item repair":
					tlMain.Controls.Remove(tlSI);
					tlMain.Controls.Remove(tlDate);
					TableLayoutPanelCellPosition posTIR = new TableLayoutPanelCellPosition(0, 1);
					tlMain.SetCellPosition(tlSIR, posTIR);
					TableLayoutPanelCellPosition _posBtn = new TableLayoutPanelCellPosition(0, 2);
					tlMain.SetCellPosition(tlBtns, _posBtn);
					tlMain.RowStyles.RemoveAt(3);

					btnCreate.Text = "Create Repair Service";
					cbRS.Enabled = true;
					CbRSDataBinding();
					break;
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			var ticketID = this.ticketID;//ticket_id;
			var tiID = this.ticketItemID; //ticket_item_id; 
										  //((KeyValuePair<string,int>)cbReportType.SelectedItem).Value;
			int catID = 0;
			if(state == "ticket" || state ==  "ticket item")
			{
				catID = ((KeyValuePair<string, int>)cbCI.SelectedItem).Value;//category_id;
			}
			var pickupDate = dtpPD.Value.Date.ToString("yyyy-MM-dd HH:mm:ss"); //pickup_date;
			var cost = state == "ticket" || state == "ticket item repair" ? Convert.ToInt32(tbCost.Text) : 0;
			int rsID = state == "ticket" || state == "ticket item repair" ? ((KeyValuePair<string, int>)cbRS.SelectedItem).Value : 0;//repair_service_id;
			//var dropDate = tbDD.Text != null ? this.dropDate : "";
			//DateTime dropDate;
			var count = 0;

			

			switch (state)
			{
				case "ticket":
					//execute 3 separate commands??
					var custID = customerID;
					//var dep = 0;

					//ticket_id changes b/c when we insert a new ticket into customer table ==> new ticket id 
					//ticket drop_date needs to be reassigned to DateTime.Now since the tlDate control is removed in "ticket" state
					var ticketNum = this.ticketNumber; //TODO: Is this necessary for @ticketNum or just call this.ticketNumber?

					//var ticket_id = 1;
					//var ticket_item_id = 0;
					//var rsID = ((KeyValuePair<string, int>)cbRS.SelectedItem).Value;
					//var cost = 0;
					//var catID = "";

					//TODO: Change later...to get actually time (local to UTC conversion & all that good stuff for later V2.0)
					//dropDate =  

					//Ticket
					var sqlcmd1 = "INSERT INTO ticket(customer_id, ticket_number, drop_date) " +
								  "VALUES(@custID, @ticketNum, @dropDate);";
					//Ticket Item
					var sqlcmd2 = "INSERT INTO ticket_item(category_item_id, subtotal, drop_date, pickup_date, ticket_id) " +
								  "VALUES(@catID, @subtotal, @dropDate, @pickupDate, @ticketID);";
					//Ticket Item
					var sqlcmd3 = "INSERT INTO item_repair(ticket_item_id, repair_service_id, cost) " +
								  "VALUES(@tiID, @rsID, @cost);";

					using(MySqlConnection conn = new MySqlConnection(connString))
					{
						try
						{
							var drop_Date = DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss");
							conn.Open();
							//var _cmd = sqlcmd1 + sqlcmd2 + sqlcmd3;
							using(MySqlCommand cmd = new MySqlCommand(sqlcmd1, conn))
							{
								cmd.Parameters.Add(new MySqlParameter("@custID", custID));
								cmd.Parameters.Add(new MySqlParameter("@ticketNum", ticketNum));
								cmd.Parameters.Add(new MySqlParameter("@dropDate", drop_Date));

								count += cmd.ExecuteNonQuery();
								ticketID = (int)cmd.LastInsertedId;
							}
							using (MySqlCommand cmd = new MySqlCommand(sqlcmd2, conn))
							{
								cmd.Parameters.Add(new MySqlParameter("@catID", catID));
								cmd.Parameters.Add(new MySqlParameter("@subtotal", cost));
								cmd.Parameters.Add(new MySqlParameter("@dropDate", drop_Date));
								cmd.Parameters.Add(new MySqlParameter("@pickupDate", drop_Date));
								cmd.Parameters.Add(new MySqlParameter("@ticketID", ticketID));

								count += cmd.ExecuteNonQuery();
								tiID = (int)cmd.LastInsertedId;
							}
							using (MySqlCommand cmd = new MySqlCommand(sqlcmd3, conn))
							{
								cmd.Parameters.Add(new MySqlParameter("@tiID", tiID));
								cmd.Parameters.Add(new MySqlParameter("@rsID", rsID));
								cmd.Parameters.Add(new MySqlParameter("@cost", cost));

								count += cmd.ExecuteNonQuery();
							}

							if(count == 3)
							{
								MessageBox.Show("New ticket added.");
								this.Close();
							}
						}
						catch(Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}
					}

					//After all the insertion is completed & all goes well ==> the form closes & the CTV is refreshed...call it again?
					break;
				case "ticket item":
					if (pickupPass)
					{
						//TODO: Probably move this to its own method..likewise for "ticket item repair" case,too
						//var startDate = tbDD.Text;
						//var endDate = dtpPD.Value.ToString();
						//var ticketID = this.ticketID;

						//Need to update subtotal here 
						var sqlcmd = "INSERT INTO ticket_item(category_item_id, drop_date, pickup_date, ticket_id) " +
									 "VALUES(@catID, @dropDate, @pickupDate, @ticketID);";
						var _dropDate = DateTime.Parse(tbDD.Text);
						var dropDate = _dropDate.ToString("yyyy-MM-dd HH:mm:ss");
						using(MySqlConnection conn = new MySqlConnection(connString))
						{
							try
							{
								conn.Open();
								using(MySqlCommand cmd = new MySqlCommand(sqlcmd,conn))
								{
									cmd.Parameters.Add(new MySqlParameter("@catID", catID));
									cmd.Parameters.Add(new MySqlParameter("@dropDate", dropDate));
									cmd.Parameters.Add(new MySqlParameter("@pickupDate", pickupDate));
									cmd.Parameters.Add(new MySqlParameter("@ticketID", ticketID));
									count += Convert.ToInt32(cmd.ExecuteNonQuery());

									if (count == 1)
									{
										//MessageBox.Show("New item added.");
										this.Close();
									}
								}
							}
							catch(Exception ex)
							{
								Console.WriteLine(ex.ToString());
							}
						}

					}
					else
						MessageBox.Show("Please select a pickup date.");
					break;
				case "ticket item repair":
					if (costPass)
					{
						//TODO: double check this 
						//need to update subtotal here for the ticket item 
						var sqlcmd = "INSERT INTO item_repair(ticket_item_id, repair_service_id, cost) " +
							"VALUES(@tiID, @rsID, @cost);";

						using (MySqlConnection conn = new MySqlConnection(connString))
						{
							try
							{
								conn.Open();
								using (MySqlCommand cmd = new MySqlCommand(sqlcmd, conn))
								{
									cmd.Parameters.Add(new MySqlParameter("@tiID", tiID));
									cmd.Parameters.Add(new MySqlParameter("@rsID", rsID));
									cmd.Parameters.Add(new MySqlParameter("@cost", cost));
									count += Convert.ToInt32(cmd.ExecuteNonQuery());

									//if (count == 1)
									//{
									//	MessageBox.Show("New repair added.");
									//	this.Close();
									//}
								}
							}
							catch (Exception ex)
							{
								Console.WriteLine(ex.ToString());
							}
						}
					}
					else
					{
						MessageBox.Show("Please enter in a cost for the repair service.");
					}
					break;
			}
				

			//Also, 
			this.Close();
		}

		private void btnCnl_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCat.SelectedIndex == 0)
			{
				cbCat.SelectedIndex = -1;
				cbCI.DataSource = null;
				cbCI.Enabled = false;
			}
				
			CbCIDataBinding();
		}
		private void cbCI_SelectedIndexChanged(object sender, EventArgs e)
		{
			CbRSDataBinding();
		}

		private void CbCIDataBinding()
		{
			var bindingSrc = new BindingSource();
			DataTable dt = new DataTable();
			var sqlcmd = "SELECT category_item_name, category_item_id FROM category_item WHERE category_id = @catID;";

			var selIndexCat = 0;
			if (cbCat.SelectedIndex > 0)
				selIndexCat = ((KeyValuePair<string, int>)cbCat.SelectedItem).Value;
			else
				return;

			using (MySqlConnection conn = new MySqlConnection(connString))
			{
				try
				{
					conn.Open();
					using (MySqlCommand cmd = new MySqlCommand(sqlcmd, conn))
					{
						cmd.Parameters.Add(new MySqlParameter("@catID", selIndexCat));
						MySqlDataAdapter adapter = new MySqlDataAdapter();
						adapter.SelectCommand = cmd;
						adapter.Fill(dt);
					}
					if (dt.Rows.Count > 0)
					{
						//var blank = dt.NewRow();
						//blank["category_item_name"] = "Pick item";
						//blank["category_item_id"] = 0;
						//dt.Rows.InsertAt(blank, 0);
						var ciDict = GetDict(dt);
						bindingSrc.DataSource = ciDict;
						cbCI.DataSource = bindingSrc;
						cbCI.DisplayMember = "Key";
						cbCI.ValueMember = "Value";
						cbCI.Enabled = true;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}
		}

		private void CbRSDataBinding()
		{
			var bindingSrc = new BindingSource();
			DataTable dt = new DataTable();
			//TODO: Figure out why the sqlcmd query doesn't yield any rows...
			var sqlcmd = "SELECT repair_name, repair_service_id FROM repair_service WHERE category_id = @catID;";
			//int selIndex = 0;
			if(cbCat.SelectedItem != null || state == "ticket item repair") //TODO: Make this logic a bit cleaner later
			{
				if (state != "ticket item repair")
					selIndexCI = ((KeyValuePair<string, int>)cbCat.SelectedItem).Value;
			}
			else
			{
				cbRS.DataSource = null;
				cbRS.Enabled = false;
				return;
			}
			
			
			using (MySqlConnection conn = new MySqlConnection(connString))
			{
				try
				{
					conn.Open();
					using (MySqlCommand cmd = new MySqlCommand(sqlcmd, conn))
					{
						cmd.Parameters.Add(new MySqlParameter("@catID", selIndexCI));
						MySqlDataAdapter adapter = new MySqlDataAdapter();
						adapter.SelectCommand = cmd;
						adapter.Fill(dt);
					}
					if (dt.Rows.Count > 0)
					{
						//var blank = dt.NewRow();
						//blank["repair_name"] = "Pick repair";
						//dt.Rows.InsertAt(blank, 0);
						var rsDict = GetDict(dt);
						bindingSrc.DataSource = rsDict;
						cbRS.DataSource = bindingSrc;
						cbRS.DisplayMember = "Key";
						cbRS.ValueMember = "Value";
						cbRS.Enabled = true;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}
		}

		//private void TicketTemplate_FormClosed(object sender, FormClosedEventArgs e)
		//{
		//	//When the dumas is closed have it run again -- Somehow use the sender...Check during the load??
		//}

		private void tbCost_TextChanged(object sender, EventArgs e)
		{
			if (!Regex.IsMatch(tbCost.Text, @"^[0-9]+$"))
			{
				tbCost.BackColor = Color.IndianRed;
			}
			else
			{
				tbCost.BackColor = Color.White;
				costPass = true;

				if (state == "ticket" && Convert.ToInt32(tbCost.Text) > 0)
				{
						btnCreate.Enabled = true;
				}
				else if(state == "ticket item" && Convert.ToInt32(tbCost.Text) > 0)
				{
					btnCreate.Enabled = true;
				}
				else if(state == "ticket item repair" && Convert.ToInt32(tbCost.Text) > 0)
				{
					btnCreate.Enabled = true;
				}
			}
		}

		private void cbRS_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbCost.Enabled = true;
		}

		private void dtpPD_ValueChanged(object sender, EventArgs e)
		{
			var startDate = DateTime.Parse(tbDD.Text).Date;
			var endDate = dtpPD.Value.Date;

			if (endDate < startDate)
			{
				MessageBox.Show($"Please select a pickup date that is later than {tbDD.Text}");
				btnCreate.Enabled = false;
			}
			else
			{
				pickupPass = true;
				btnCreate.Enabled = true;
			}
		}
		//TODO: DELETE
		//private void cbCat_DropDown(object sender, EventArgs e)
		//{
		//	categoryDict.Remove(" ");
		//	var bindSrc = new BindingSource();
		//	bindSrc.DataSource = categoryDict;
		//	cbCat.DataSource = bindSrc;
		//}

		//private void cbCat_DrawItem(object sender, DrawItemEventArgs e)
		//{
		//	if (e.Index == 0)
		//	{
		//		//Drawing the background 
		//		e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
		//		e.Graphics.DrawString(cbCat.Items[e.Index].ToString(), cbCat.Font, SystemBrushes.GrayText, e.Bounds);
		//	}
		//	else
		//		e.DrawBackground();

		//	Brush brush = ((e.State & DrawItemState.Selected) > 0) ? SystemBrushes.HighlightText : SystemBrushes.ControlText;
		//	e.Graphics.DrawString(cbCat.Items[e.Index].ToString(), cbCat.Font, brush, e.Bounds);

		//	e.DrawFocusRectangle();
		//}

		//TODO: DELETE???
		private void tbCost_Leave(object sender, EventArgs e)
		{
			if (!Regex.IsMatch(tbCost.Text, @"^[0-9]+$"))
			{
				tbCost.BackColor = Color.IndianRed;
			}
			else
			{
				tbCost.BackColor = Color.White;
				costPass = true;
			}
		}
		private string ToTitleCase(string str)
		{
			return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
		}

		//Converts data table to dictionary
		private Dictionary<string, int> GetDict(DataTable dt)
		{
			return dt.AsEnumerable().ToDictionary<DataRow, string, int>(row => row.Field<string>(0),
																		row => row.Field<int>(1));
		}



		//When category combobox selection is made ==> Enable & Bind the category item combo box (Do this during the load up)
		//Until category ite is selected disable repair & cost fields 
		//After category item is selected ==> Enable & bind the repair combobox 
		//After repair is selected ==> Enable the cost box & allow user to type in repair cost 
		//During load up of the form ==> Grab the data for cbCategory
		//Also, during the load-up disable cbCI, cbRepair, tbCost
		//Also, during the load up change lblCN with customer's full name. If no customer was selected ==> Put instead 'New Customer'
		//Also, grab the ticket_number from the DB (Essentially use MAX(ticket_number) from ticket table && increment by 1 to get new 
		//ticket number 
	}
}
