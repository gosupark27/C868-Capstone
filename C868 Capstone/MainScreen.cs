using C868_Capstone.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C868_Capstone
{
	public partial class MainScreen : Form
	{
		string connString = "server = localhost; database=shoerepair_pos; Uid = root; pwd=july72794!; persistsecurityinfo = True; Allow User Variables=True";
		DataTable custSearchDT = new DataTable();
		DataTable ticketDT = new DataTable(); //TODO: DELETE!!!
		string placeholderText = "FirstName LastName";
		bool firstNameChange, lastNameChange, phoneChange;
		bool selectedBefore = false;
		bool searchChange = false;
		bool ticketClosed = false;
		DateTime currentDate = DateTime.Now;
		Dictionary<string, int> reportTypes = new Dictionary<string, int>() { { "Sales", 0 }, { "Repair Services", 1 }, { "Report History", 2 } };
		Dictionary<string, int> sortBySales = new Dictionary<string, int>() { { "Date", 0 }, { "Revenue", 1 }};
		Dictionary<string, int> sortByRS = new Dictionary<string, int>() { { "Date", 0 }, { "Repair Type", 1 }, { "Frequency", 2 } };
		Dictionary<string, int> sortByRH = new Dictionary<string, int>() { { "Date", 0 }, { "Report Type", 1 }, { "Action", 2 } };
		Control ctl;
		int ticketID;
		int width_tlCTVTemp, height_tlCTVTemp;
		string custName = "";
		int ticketNumber;
		int customerID; //or custID?
		string firstName, lastName, phone;
		DateTime dropDate;

		//TODO: DELETE!!
		int testCount = 0;
		public MainScreen()
		{
			InitializeComponent();
			tlCTVTemp.Hide();
			width_tlCTVTemp = tlCTVTemp.Width;
			height_tlCTVTemp = tlCTVTemp.Height;

		}
		private void MainScreen_Load(object sender, EventArgs e)
		{
			this.Show();

			tbSearch.Text = placeholderText;
			tbSearch.Font = new Font(tbSearch.Font, FontStyle.Italic);

			//Bind data source to combo boxes for report section (Maybe move to elsewhere??)
			var bSourceCbRT = new BindingSource();
			bSourceCbRT.DataSource = reportTypes;
			cbReportType.DataSource = bSourceCbRT;
			cbReportType.DisplayMember = "Key";
			cbReportType.ValueMember = "Value"; //Basically chooses the command that will fetch the data (can use CASES here?)
												//var control = ((KeyValuePair<Control, string>)cbReportType.SelectedItem).Value; //Getting the selected value from comboBox
			cbSort.Hide();
			lblSort.Hide();
			btnAddTicket.Hide();

			tbSearch.KeyPress += CheckEnterKeyPress;
			tbSearch.Focus();
		}

		private void formatDGV(DataGridView dgv, string hideCell) 
		{
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.ColumnHeadersVisible = true;
			dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
			dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			dgv.RowHeadersVisible = false;
			dgv.Columns[hideCell].Visible = false;
			dgv.ReadOnly = true;
			dgv.AutoResizeColumns();
			dgv.AllowUserToAddRows = false;
			dgv.Rows[0].Selected = false;
			

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (Regex.IsMatch(tbSearch.Text, @"\A[\p{L}\s]+\Z") && !String.IsNullOrEmpty(tbSearch.Text))
			{
				var searchText = tbSearch.Text.Trim();
				string[] names = searchText.Split(' ');
				//TODO: Check if names.Length > 2 ==> Means user has put in multiple names & that is not allowed. 
				if(names.Length != 2)
				{
					MessageBox.Show("Please enter a first and last name only. E.g. 'FirstName LastName'");
					return;
				}
				var firstName = names[0];
				var lastName = names[1];
				custName = firstName + " " + lastName;
				//var searchCmd = $"SELECT * FROM customer WHERE first_name = '{firstName}' AND last_name = '{lastName}'";
				var searchCmd = "SELECT * FROM customer WHERE first_name = @firstName AND last_name = @lastName;";

				if (searchChange)
				{
					custSearchDT.Clear();
					resetCustTicketInfo();
				}
				using (MySqlConnection conn = new MySqlConnection(connString))
				{
					try
					{
						conn.Open();
						using (MySqlCommand cmd = new MySqlCommand(searchCmd, conn))
						{
							cmd.Parameters.Add(new MySqlParameter("@firstName", firstName));
							cmd.Parameters.Add(new MySqlParameter("@lastName", lastName));
							MySqlDataAdapter adapter = new MySqlDataAdapter();

							adapter.SelectCommand = cmd;
							adapter.Fill(custSearchDT);
							if (custSearchDT.Rows.Count > 0)
							{
								//MessageBox.Show($"{custSearchDT.Rows.Count} result(s) have been found!");
								dgvCust.DataSource = custSearchDT;
								formatDGV(dgvCust, "customer_id");
							}
							else
							{
								MessageBox.Show("No customer found. Please add a new customer.");
							}

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
				MessageBox.Show("Please enter a valid name. Name cannot contain special symbols or numbers."); //To this check when the user leaves the textbox in order to hit search btn
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			//Best way to have nested if statements or...some other structure? Idea is that all the fields are not empty then each field
			//will be individually checked to see if the input passes the error checking then the command will be prepped 
			if (tbFirst.BackColor == Color.White && tbLast.BackColor == Color.White && tbPhone.BackColor == Color.White)
			{
				var firstName = tbFirst.Text;
				var lastName = tbLast.Text;
				var phone = tbPhone.Text;
				

				if (btnSubmit.Text.Equals("Add Customer"))
				{
					var searchCmd = "INSERT INTO customer(first_name, last_name, phone_number) VALUES(@firstName, @lastName, @phone);";

					using (MySqlConnection conn = new MySqlConnection(connString))
					{
						try
						{
							conn.Open();
							using (MySqlCommand cmd = new MySqlCommand(searchCmd, conn))
							{
								cmd.Parameters.Add(new MySqlParameter("@firstName", firstName));
								cmd.Parameters.Add(new MySqlParameter("@lastName", lastName));
								cmd.Parameters.Add(new MySqlParameter("@Phone", phone));

								var checkAdd = cmd.ExecuteNonQuery();
								if (checkAdd > 0)
								{
									MessageBox.Show("New customer successfully added!");
								}
								else
									MessageBox.Show("Unable to add new customer.");
							}
							resetCustTicketInfo();
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}
					}
				}
				else //Edit an existing customer 
				{

					string searchCmd;
					int checkEdit = 0;

					using (MySqlConnection conn = new MySqlConnection(connString))
					{
						conn.Open();
						if (firstNameChange)
						{
							searchCmd = "UPDATE customer SET first_name = @firstName WHERE customer_id = @customerID";

							
							using (MySqlCommand cmd = new MySqlCommand(searchCmd, conn))
							{
								cmd.Parameters.Add(new MySqlParameter("@firstName", firstName));
								cmd.Parameters.Add(new MySqlParameter("@customerID", customerID));

								checkEdit = cmd.ExecuteNonQuery();
							}
						}
						if (lastNameChange)
						{
							searchCmd = "UPDATE customer SET last_name = @lastName WHERE customer_id = @customerID";

							//conn.Open();
							using (MySqlCommand cmd = new MySqlCommand(searchCmd, conn))
							{
								cmd.Parameters.Add(new MySqlParameter("@lastName", lastName));
								cmd.Parameters.Add(new MySqlParameter("@customerID", customerID));

								checkEdit = cmd.ExecuteNonQuery();
							}
						}
						if (phoneChange)
						{
							searchCmd = "UPDATE customer SET phone_number = @phoneNumber WHERE customer_id = @customerID";

							//conn.Open();
							using (MySqlCommand cmd = new MySqlCommand(searchCmd, conn))
							{
								cmd.Parameters.Add(new MySqlParameter("@phoneNumber", phone));
								cmd.Parameters.Add(new MySqlParameter("@customerID", customerID));

								checkEdit = cmd.ExecuteNonQuery();
							}
						}
					}

					if (checkEdit > 0)
					{
						try
						{
							dgvCust.SelectedCells[1].Value = tbFirst.Text;
							dgvCust.SelectedCells[2].Value = tbLast.Text;
							dgvCust.SelectedCells[3].Value = tbPhone.Text;
						}
						catch(Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}
						MessageBox.Show("Customer information successfully updated!");
						
					}
					else
						MessageBox.Show("Cannot edit customer information.");


				}
			}
			else
			{
				MessageBox.Show("Please correct the highlighted field(s).");
			}
		}

		private void btnDelCust_Click(object sender, EventArgs e)
		{
			if (dgvCust.SelectedRows.Count > 0)
			{
				//Do these variables need to be local or can we use the class variables? 
				var custId = Convert.ToInt32(dgvCust.SelectedCells[0].Value);
				var firstName = dgvCust.SelectedCells[1].Value.ToString();
				var lastName = dgvCust.SelectedCells[2].Value.ToString();

				DialogResult result = MessageBox.Show($"Are you sure you want to delete {firstName} {lastName}'s record?.", "Delete Customer", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					var searchCmd = "DELETE FROM customer WHERE customer_id = @customerId;";


					using (MySqlConnection conn = new MySqlConnection(connString))
					{
						try
						{
							conn.Open();
							using (MySqlCommand cmd = new MySqlCommand(searchCmd, conn))
							{
								cmd.Parameters.Add(new MySqlParameter("@customerId", custId));
								var checkDel = cmd.ExecuteNonQuery();
								if (checkDel > 0)
								{
									var rowId = dgvCust.CurrentCell.RowIndex;
									custSearchDT.AcceptChanges();
									custSearchDT.Rows.RemoveAt(rowId);
									custSearchDT.AcceptChanges();
								}
								else
									MessageBox.Show("Unable to delete customer.");
							}
							resetCustTicketInfo();
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}
					}
				}
				else
					return;
			}
		}

		public int AddCustomer(string firstName, string lastName, string phoneNumber)
		{
			if (firstName != null && lastName != null && phoneNumber != null)
			{
				tbFirst.Text = firstName;
				tbLast.Text = lastName;
				tbPhone.Text = phoneNumber;
				return 1;
			}
			return 0;
		}

		public int EditCustomerInfo(string firstName, string lastName, string phoneNumber)
		{
			if (firstName != null && lastName != null && phoneNumber != null)
			{
				tbFirst.Text = firstName;
				tbLast.Text = lastName;
				tbPhone.Text = phoneNumber;
				return 1;
			}
			return 0;
		}

		public int DeleteCustomer(string firstName, string lastName, string phoneNumber)
		{
			if (firstName != null && lastName != null && phoneNumber != null)
			{
				tbFirst.Text = firstName;
				tbLast.Text = lastName;
				tbPhone.Text = phoneNumber;
				return 1;
			}
			return 0;
		}

		private void PopulateCustInfoSec()
		{
			//Populate customer info section 
			tbFirst.Text = firstName;
			tbFirst.BackColor = Color.Empty;
			tbLast.Text = lastName;
			tbLast.BackColor = Color.Empty;
			tbPhone.Text = phone;
			tbPhone.BackColor = Color.Empty;
			btnSubmit.Text = "Edit Customer";
			lblTicket.Text = $"{firstName} {lastName}'s Ticket History";
		}

		private void PopulateCTV()
		{
			btnAddTicket.Show();
			//TODO: Need to keep track of customer ID globally throughout the class (make this change) 
			//TODO: DELETE!!! var custID = Convert.ToInt32(dgvCust.SelectedCells[0].Value);
			var searchCmd = "SELECT * FROM ticket WHERE customer_id = @customerId;"; //TODO: Finish SQL cmd with multiple inner joins?


			using (MySqlConnection conn = new MySqlConnection(connString))
			{
				try
				{
					tlCTV.Controls.Clear();
					tlCTV.RowCount = 0;
					ticketDT.Clear();

					conn.Open();
					using (MySqlCommand cmd = new MySqlCommand(searchCmd, conn))
					{
						cmd.Parameters.Add(new MySqlParameter("@customerId", customerID));
						MySqlDataAdapter adapter = new MySqlDataAdapter();

						adapter.SelectCommand = cmd;
						adapter.Fill(ticketDT);

						if (ticketDT.Rows.Count < 0)
						{
							MessageBox.Show("No ticket found. Please add a new ticket.");
						}

						for (int i = 0; i < ticketDT.Rows.Count; i++)
						{
							var ticketID = ticketDT.Rows[i].Field<int>("ticket_id");
							var ticketNum = ticketDT.Rows[i].Field<int>("ticket_number");
							var dropDate = ticketDT.Rows[i].Field<DateTime>("drop_date").Date;
							this.dropDate = dropDate;
							var ticketStatus = Convert.ToInt32(ticketDT.Rows[i].Field<string>("Status"));
							ticketID = ticketDT.Rows[i].Field<int>("ticket_id");
							this.ticketID = ticketID;
							this.ticketNumber = ticketNum;

							TableLayoutPanel panelTicketInfo = new TableLayoutPanel();
							panelTicketInfo.Size = new Size(width_tlCTVTemp, height_tlCTVTemp);
							panelTicketInfo.RowCount = 2;
							panelTicketInfo.ColumnCount = 2;
							panelTicketInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
							panelTicketInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
							panelTicketInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
							panelTicketInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
							panelTicketInfo.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
							panelTicketInfo.Name = ticketID.ToString();
							panelTicketInfo.SetColumnSpan(panelTicketInfo, 2);

							var font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel);

							//Top Left
							Label lblTN = new Label();
							lblTN.Text = ticketNum.ToString();
							lblTN.Font = font;
							//lblTN.Name = dropDate.ToString("MM-dd-yyyy");
							lblTN.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
							lblTN.TextAlign = ContentAlignment.TopLeft;

							//Bottom Left
							Label lblStatus = new Label();
							lblStatus.Name = "lblStatus";
							lblStatus.Text = ticketStatus == 0 ? "Ticket Closed" : "Ticket Open";
							lblStatus.Font = font;
							lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;

							//Top Right
							Button btnCT = new Button();
							btnCT.Name = "btnCT";
							btnCT.Text = ticketStatus == 0 ? "Open Ticket" : "Close Ticket";
							btnCT.Size = new Size(137, 23);
							btnCT.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
							btnCT.TextAlign = ContentAlignment.MiddleCenter;
							btnCT.BackColor = Color.Transparent;
							btnCT.FlatStyle = FlatStyle.Flat;
							btnCT.FlatAppearance.BorderColor = SystemColors.Control;
							btnCT.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
							//TODO: I'll put this back in when I get the async() event handling to work...
							btnCT.Hide();

							//Bottom Right
							object o = Resources.ResourceManager.GetObject("icons8_trash_18");
							Button btnDel = new Button();
							btnDel.Name = ticketID.ToString();
							btnDel.Image = (Image)o;
							btnDel.FlatStyle = FlatStyle.Flat;
							btnDel.FlatAppearance.BorderSize = 0;
							btnDel.FlatAppearance.MouseDownBackColor = Color.Transparent;
							btnDel.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
							btnDel.ImageAlign = ContentAlignment.BottomCenter;
							btnDel.Size = new Size(75, 34);
							btnDel.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
							btnDel.Margin = new Padding(3, 3, 0, 3);




							panelTicketInfo.Controls.Add(lblTN, 0, 0);
							panelTicketInfo.Controls.Add(lblStatus, 0, 1);
							panelTicketInfo.Controls.Add(btnCT, 1, 0);
							panelTicketInfo.Controls.Add(btnDel, 1, 1);

							panelTicketInfo.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
							panelTicketInfo.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
							panelTicketInfo.Click += new System.EventHandler(this.Panel_Click);

							foreach (Control ctl in panelTicketInfo.Controls)
							{
								ctl.MouseEnter += this.Panel_MouseEnter;
								ctl.MouseLeave += this.Panel_MouseLeave;
								ctl.Click += this.Panel_Click;

								if (ctl.Name.Equals("btnCT"))
								{
									btnCT.Click += btnStatus_Click;
									btnCT.Click -= this.Panel_Click;
								}
								else if(ctl.Name.Equals(ticketID.ToString()))
								{ 
									btnDel.Click += this.btnDelTicket_Click;
									btnDel.Click -= this.Panel_Click;
									//btnDelTicket
								}
							}
							tlCTV.Controls.Add(panelTicketInfo);
						}

						if (ticketDT.Rows.Count <= 3)
						{
							var count = 4 - ticketDT.Rows.Count;
							EmptyCTVPanels(count);
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}
			selectedBefore = true;
			tbSearch.Text = $"{firstName} {lastName}";
		}

		private void dgvCust_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//Checks to see if a row in customer dgv is selected & then populates the appropriate customer info fields 
			if (dgvCust.SelectedRows.Count > 0)
			{

				firstName = dgvCust.SelectedCells[1].Value.ToString();
				lastName = dgvCust.SelectedCells[2].Value.ToString();
				phone = dgvCust.SelectedCells[3].Value.ToString(); //format field to reflect ###) ### - #####
				customerID = Convert.ToInt32(dgvCust.SelectedCells[0].Value);

				if (!selectedBefore)
				{
					PopulateCustInfoSec();
					PopulateCTV();
					
				}
				else
				{
					resetCustTicketInfo();
					
					dgvCust.CurrentRow.Selected = false;
					selectedBefore = false;
				}
			}
		}

		private void EmptyCTVPanels(int count)
		{
			for (int i = 0; i < count; i++)
			{
				TableLayoutPanel panelCustInfo = new TableLayoutPanel();
				panelCustInfo.Size = new Size(width_tlCTVTemp, height_tlCTVTemp);
				panelCustInfo.RowCount = 2;
				panelCustInfo.ColumnCount = 2;
				panelCustInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
				panelCustInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
				panelCustInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
				panelCustInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
				panelCustInfo.SetColumnSpan(panelCustInfo, 2);
				tlCTV.Controls.Add(panelCustInfo);

			}
		}

		private void resetCustTicketInfo()
		{
			tbFirst.Text = "";
			tbLast.Text = "";
			tbPhone.Text = "";
			btnSubmit.Text = "Add Customer";
			lblTicket.Text = "Customer's Ticket History";
			tbSearch.Clear();
			tlCTV.Controls.Clear();
		}
		private void tbFirst_Leave(object sender, EventArgs e)
		{
			if (!Regex.IsMatch(tbFirst.Text, @"\A[\p{L}\s]+\Z") || String.IsNullOrEmpty(tbFirst.Text))
			{
				tbFirst.BackColor = Color.IndianRed;
			}
			else
			{
				tbFirst.BackColor = Color.White;
				firstNameChange = true;
			}
		}

		private void tbLast_Leave(object sender, EventArgs e)
		{
			if (!Regex.IsMatch(tbLast.Text, @"\A[\p{L}\s]+\Z") || String.IsNullOrEmpty(tbLast.Text))
			{
				tbLast.BackColor = Color.IndianRed;
			}
			else
			{
				tbLast.BackColor = Color.White;
				lastNameChange = true;
			}
		}

		private void tbPhone_Leave(object sender, EventArgs e)
		{
			//string phone = ""; 
			//if (btnSubmit.Text.Equals("Edit Customer"))
			//{
				
			//}

			var phone = Regex.Replace(tbPhone.Text, "[^0-9a-zA-Z]", "");


			if (!Regex.IsMatch(phone, @"^[0-9]{10}$"))
			{
				tbPhone.BackColor = Color.IndianRed;
			}
			//	if (!Regex.IsMatch(tbPhone.Text, @"^[0-9]{10}$")) //Verifying valid 10 digit phone number 
			//{
			//	tbPhone.BackColor = Color.IndianRed;
			//}
			else
			{
				tbPhone.BackColor = Color.White;
				phoneChange = true;
			}
		}
		private void btnAddTicket_Click(object sender, EventArgs e)
		{
			GetMaxTicketNum();
			//TicketTemplate pr;
			//look into disposeasync?? Or do the populateCTV asynchronously?? 
			//https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-disposeasync
			//using (pr = new TicketTemplate(custName, "ticket", ticketNumber, customerID))
			//{
			//	pr.Show();
			//}
			//if(pr.IsDisposed)
			//	PopulateCTV();

			TicketTemplate tt = new TicketTemplate(custName, "ticket", ticketNumber, customerID);
			tt.FormClosed += TT_FormClosed;
			tt.Show();
			
		}

		private void TT_FormClosed(object sender, FormClosedEventArgs e)
		{
			PopulateCTV();
		}

		private void rbWk_CheckedChanged(object sender, EventArgs e)
		{
			if(rbWk.Checked)
			{
				handleWeek();
			}

		}

		private void handleWeek()
		{
			monthCal.RemoveAllBoldedDates();
			monthCal.UpdateBoldedDates();

			if(currentDate.DayOfWeek == DayOfWeek.Sunday)
			{
				for(int i = 0; i < 7;i++)
				{
					monthCal.AddBoldedDate(currentDate.AddDays(i));
				}
			}
			else
			{
				DateTime startSun = currentDate.AddDays(DayOfWeek.Sunday - currentDate.DayOfWeek);
				for (int i = 0; i < 7; i++)
				{
					monthCal.AddBoldedDate(startSun.AddDays(i));
				}
			}
			monthCal.UpdateBoldedDates();
		}

		private void rbMo_CheckedChanged(object sender, EventArgs e)
		{
			if(rbMo.Checked)
			{
				handleMonth();
			}
		}

		private void handleMonth()
		{
			monthCal.RemoveAllBoldedDates();
			monthCal.UpdateBoldedDates();

			var mo = currentDate.Month;
			var yr = currentDate.Year;
			int day;
			//TODO: DELETE!!!
			//string endDate; //TODO: Used for making reports -- for the WHERE clause in the sql cmd 

			var startDate = mo.ToString() + "/01/" + yr.ToString();
			DateTime tempDate = Convert.ToDateTime(startDate);

			//ASDF
			switch(mo)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
					day = 31;
					break;
				case 4:
				case 6:
				case 9:
				case 11:
					day = 30;
					break;
				default:
					day = 29;
					break;
			}

			for(int i = 0; i < day; i++)
			{
				monthCal.AddBoldedDate(tempDate.AddDays(i));
			}
			monthCal.UpdateBoldedDates();
		}

		private void monthCal_DateChanged(object sender, DateRangeEventArgs e)
		{
			if(rbMo.Checked)
			{
				currentDate = e.Start;
				handleMonth();
			}
			else if(rbWk.Checked)
			{
				currentDate = e.Start;
				handleWeek();
			}
		}

		private void monthCal_DateSelected(object sender, DateRangeEventArgs e)
		{
			if (rbMo.Checked)
			{
				currentDate = e.Start;
				handleMonth();
			}
			else if (rbWk.Checked)
			{
				currentDate = e.Start;
				handleWeek();
			}
		}

		private void Panel_MouseEnter(object sender, EventArgs e)
		{
			var testPt = tlCTV.PointToClient(Cursor.Position);
			ctl = tlCTV.GetChildAtPoint(testPt);
			ctl.BackColor = SystemColors.GradientInactiveCaption; //Throws an error?? Conflicts with close ticket btn area??
			var lblList = ctl.Controls.OfType<Label>();

			var font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);
			
			for(int i = 0; i < lblList.Count();i++)
			{
				lblList.ElementAt(i).Font = font;
			}
		}

		private void Panel_MouseLeave(object sender, EventArgs e)
		{
			//tableLayoutPanel2.BackColor = SystemColors.Control;
			//var testPt = tlCTV.PointToClient(Cursor.Position);
			//ctl = tlCTV.GetChildAtPoint(testPt);
			ctl.BackColor = SystemColors.Control;
			var lblList = ctl.Controls.OfType<Label>();

			var font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel);
			for (int i = 0; i < lblList.Count(); i++)
			{

				lblList.ElementAt(i).Font = font;
			}
		}

		private void Panel_Click(object sender, EventArgs e)
		{

			FormProvider.MainScreen.Hide();
			var ticketID = Convert.ToInt32(ctl.Name);
			//var dropDate = ctl.GetNextControl(ctl, true).Name;
			var ms2 = new MainScreenDos(ticketID, ticketNumber, custName, dropDate); //add pickupDate? 
			ms2.Show();
		}

		//private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
		//{
		//	if (e.CloseReason == CloseReason.UserClosing)
		//	{
		//		DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit Application", MessageBoxButtons.YesNo);
		//		if (result == DialogResult.Yes)
		//		{
		//			Environment.Exit(0); //TODO: Error? Application.Exit(0), no?!?
		//		}
		//		else
		//			e.Cancel = true;
		//	}
		//	else
		//		e.Cancel = true;
		//}

		private void btnReport_Click(object sender, EventArgs e)
		{
			//ASDFG
			var reportType = ((KeyValuePair<string,int>)cbReportType.SelectedItem).Value;
			var sort = ((KeyValuePair<string,int>)cbSort.SelectedItem).Value;
			bool isWkly = rbWk.Checked ? true : false;
			var length = monthCal.BoldedDates.Length;
			if(rbWk.Checked || rbMo.Checked)
			{
				//format start & end dates to MM/DD/YYYY
				var start = monthCal.BoldedDates[0];
				var end = monthCal.BoldedDates[monthCal.BoldedDates.Length - 1];

				//Create an interface?? To have a list of multiple data types???
				ReportTemplate rt = new ReportTemplate(reportType, sort, start, end, isWkly);
				//Create this into separate method? 
				FormProvider.MainScreen.Hide();
				if(!rt.IsDisposed)
				{
					rt.Show();
				}
				else
				{
					MessageBox.Show("Sorry, not enough data available to generate a report. Please try out different parameters.");
					FormProvider.MainScreen.Show();
				}
					

			}
			else
			{
				MessageBox.Show("Please select either the weekly or monthly option.");
			}
		}

		//TODO: Work on this bug??
		private void dgvCust_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if(e.ColumnIndex == 3)
			{
				e.Value = String.Format("{0:(###) ### - ####}", e.Value);
				e.FormattingApplied = true;
			}
		}

		private void btnDelTicket_Click(object sender, EventArgs e)
		{
			ticketID = Convert.ToInt32(ctl.GetNextControl(ctl, false).Name);
			var sqlcmd = "DELETE FROM ticket WHERE ticket_id = @ticketID;";
			using(MySqlConnection conn = new MySqlConnection(connString))
			{
				try
				{
					conn.Open();
					using(MySqlCommand cmd = new MySqlCommand(sqlcmd, conn))
					{
						cmd.Parameters.Add(new MySqlParameter("@ticketID", ticketID));
						var count = (int)cmd.ExecuteNonQuery();

						if(count > 0)
						{	
							PopulateCTV();
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}
			
			
		}

		private void btnStatus_Click(object sender, EventArgs e)
		{

			if(ticketClosed)
			{
				//Perhaps open up the ticket to make edits? 
				//Why is the method being called twice -- FIXED. if(x || y) {Add Event handler} ==> Added twice instead of just once!
				//https://stackoverflow.com/questions/15667117/c-sharp-method-is-being-called-twice-in-a-row/15667173#:~:text=Since%20you%20are%20declaring%20the,be%20called%20three%20times...
				//MessageBox.Show("Ticket is closed."); That is if you only want to close the ticket & that's it!
				Control _ctl;

				foreach (Control ctl in ctl.Controls)
				{
					if (ctl.Name.Equals("btnCT"))
						_ctl = ctl;
					else
						_ctl = null;

					if (ctl.Name.Equals("lblStatus"))
					{
						ctl.Text = "Ticket Open";
					}
					else if (_ctl != null)
					{
						_ctl.Text = "Close Ticket";
						ticketClosed = false;
					}
				}
				//return;
			}
			else
			{
				var sqlcmd = "UPDATE ticket SET status = 0 WHERE ticket_id = @ticketID;";
				ticketID = Convert.ToInt32(ctl.GetNextControl(ctl, false).Name);

				using (MySqlConnection conn = new MySqlConnection(connString))
				{
					try
					{
						conn.Open();
						using (MySqlCommand cmd = new MySqlCommand(sqlcmd, conn))
						{
							cmd.Parameters.Add(new MySqlParameter("@ticketID", ticketID)); //TICKET_ID ALWAYS 7 WTF
							var count = Convert.ToInt32(cmd.ExecuteNonQuery());

							if (count > 0)
							{
								Control _ctl; //Close Ticket button
											  //TODO: Change ticket status to CLOSE && disable the button (Find a way to optimize it??) 
								foreach (Control ctl in ctl.Controls)
								{
									if (ctl.Name.Equals("btnCT"))
										_ctl = ctl;
									else
										_ctl = null;

									if (ctl.Name.Equals("lblStatus"))
									{
										ctl.Text = "Ticket Closed";
									}
									else if (_ctl != null)
									{
										_ctl.Text = "Open Ticket";
										ticketClosed = true;
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
				//return;
			}
			testCount++;

		}

		private void cbReportType_SelectedIndexChanged(object sender, EventArgs e)
		{
			//ABC
			var bSourceCbSB = new BindingSource();
			var reportTypeSel = ((KeyValuePair<string,int>)cbReportType.SelectedItem).Value;
			if (reportTypeSel == 0)
			{
				bSourceCbSB.DataSource = sortBySales;
			}
			else if (reportTypeSel == 1)
			{
				bSourceCbSB.DataSource = sortByRS;
			}
			else
				bSourceCbSB.DataSource = sortByRH;
			cbSort.DataSource = bSourceCbSB;
			cbSort.DisplayMember = "Key";
			cbReportType.ValueMember = "Value";
		}

		private void tbSearch_Enter(object sender, EventArgs e)
		{
			if (tbSearch.Text == placeholderText)
			{
				tbSearch.Text = "";
				tbSearch.Font = new Font(tbSearch.Font, FontStyle.Regular);
			}
		}

		private void tbSearch_TextChanged(object sender, EventArgs e)
		{
			searchChange = true;
		}

		private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter)
			{
				btnSearch_Click(null, null); //TODO: Better way to call a delegate/event??? 
			}
		}
		private void GetMaxTicketNum()
		{
			var sqlcmd = "SELECT ticket_number FROM ticket;";
			using (MySqlConnection conn = new MySqlConnection(connString))
			{
				try
				{
					conn.Open();
					DataTable dt = new DataTable();
					using (MySqlCommand cmd = new MySqlCommand(sqlcmd, conn))
					{
						MySqlDataAdapter adapter = new MySqlDataAdapter();
						adapter.SelectCommand = cmd;
						adapter.Fill(dt);

						List<int> ticketNumList = new List<int>();
						if(dt.Rows.Count > 0)
						{
							foreach(DataRow row in dt.Rows)
							{
								ticketNumList.Add(Convert.ToInt32(row.ItemArray[0]));
							}

							ticketNumber = ticketNumList.Max();
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
}

