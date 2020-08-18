using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace C868_Capstone
{
	public partial class MainScreen1 : Form
	{
		string connString = "server = localhost; database=shoerepair_pos; Uid = root; pwd=july72794!; persistsecurityinfo = True; Allow User Variables=True";
		DataTable custSearchDT = new DataTable();
		DataTable ticketDT = new DataTable();
		string placeholderText = "FirstName LastName";
		bool firstNameChange, lastNameChange, phoneChange;
		bool selectedBefore = false;
		bool searchChange = false;
		public MainScreen1()
		{
			InitializeComponent();
			lblCustInfo.Select();
			ticketSb.Minimum = 0;
			ticketSb.Maximum = 4;
			ticketSb.SmallChange = 1; //increment 
			ticketSb.LargeChange = 2; //overall length/size
			//look for a change event ==> write a method in that event ==> Get the value of the scrollbar 

		}
		private void MainScreen1_Load(object sender, EventArgs e)
		{
			tbSearch.Text = placeholderText;
			tbSearch.Font = new Font(tbSearch.Font, FontStyle.Italic);
			splitContainer2.Panel2Collapsed = true;


		}

		
		private void formatDGV(DataGridView dgv, string hideCell) //might need to make more methods?? Overload with extra param??
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
			if(Regex.IsMatch(tbSearch.Text, @"\A[\p{L}\s]+\Z") && !String.IsNullOrEmpty(tbSearch.Text))
			{
				var searchText = tbSearch.Text;
				string[] names = searchText.Split(' ');
				//TODO: Check if names.Length > 2 ==> Means user has put in multiple names & that is not allowed. 
				var firstName = names[0];
				var lastName = names[1];
				//var searchCmd = $"SELECT * FROM customer WHERE first_name = '{firstName}' AND last_name = '{lastName}'";
				var searchCmd = "SELECT * FROM customer WHERE first_name = @firstName AND last_name = @lastName;";

				if(searchChange)
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
								MessageBox.Show($"{custSearchDT.Rows.Count} result(s) have been found!");
								dgvCust.DataSource = custSearchDT;
								formatDGV(dgvCust, "customer_id");
							}
							else
							{
								MessageBox.Show("No customer found. Please add a new customer.");
								//TODO: Shift focus to customer info field 
								this.tbFirst.Focus();
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
			if(tbFirst.BackColor == Color.White && tbLast.BackColor == Color.White && tbPhone.BackColor == Color.White)
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
					int checkEdit;

					using(MySqlConnection conn = new MySqlConnection(connString))
					{
						if (firstNameChange)
						{
							searchCmd = "UPDATE customer SET first_name = @firstName";

							conn.Open();
							using(MySqlCommand cmd = new MySqlCommand(searchCmd, conn))
							{
								cmd.Parameters.Add(new MySqlParameter("@firstName", firstName));

								checkEdit = cmd.ExecuteNonQuery();
							}
						}
						if (lastNameChange)
						{
							searchCmd = "UPDATE customer SET last_name = @lastName";

							conn.Open();
							using (MySqlCommand cmd = new MySqlCommand(searchCmd, conn))
							{
								cmd.Parameters.Add(new MySqlParameter("@lastName", lastName));

								checkEdit = cmd.ExecuteNonQuery();
							}
						}
						if (phoneChange)
						{
							searchCmd = "UPDATE customer SET phone_number = @phoneNumber";

							conn.Open();
							using (MySqlCommand cmd = new MySqlCommand(searchCmd, conn))
							{
								cmd.Parameters.Add(new MySqlParameter("@phoneNumber", phone));

								checkEdit = cmd.ExecuteNonQuery();
							}
						}
						else
							checkEdit = 0;
					}

					if (checkEdit > 0)
					{
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
			if(dgvCust.SelectedRows.Count > 0)
			{
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

		private void dgvCust_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//Checks to see if a row in customer dgv is selected & then populates the appropriate customer info fields 
			if (dgvCust.SelectedRows.Count > 0)
			{
				
				var firstName = dgvCust.SelectedCells[1].Value.ToString();
				var lastName = dgvCust.SelectedCells[2].Value.ToString();
				var phone = dgvCust.SelectedCells[3].Value.ToString(); //format field to reflect ###) ### - #####

				if (!selectedBefore)
				{
					//Populate customer info section 
					tbFirst.Text = firstName;
					tbLast.Text = lastName;
					tbPhone.Text = String.Format("{0:(###) ### - ####}", Double.Parse(phone));
					btnSubmit.Text = "Edit Customer";
					lblTicket.Text = $"{firstName} {lastName}'s Tickets";

					//Populate Customer's Ticket DGV
					var custID = Convert.ToInt32(dgvCust.SelectedCells[0].Value);
					var searchCmd = "SELECT * FROM ticket WHERE customer_id = @customerId;"; //TODO: Finish SQL cmd with multiple inner joins?


					using (MySqlConnection conn = new MySqlConnection(connString))
					{
						try
						{
							conn.Open();
							using (MySqlCommand cmd = new MySqlCommand(searchCmd, conn))
							{
								cmd.Parameters.Add(new MySqlParameter("@customerId", custID));
								MySqlDataAdapter adapter = new MySqlDataAdapter();

								adapter.SelectCommand = cmd;
								adapter.Fill(ticketDT);
								if (ticketDT.Rows.Count > 0)
								{
									MessageBox.Show($"{firstName} {lastName} has {ticketDT.Rows.Count} ticket(s).");
									dgvTicket.DataSource = ticketDT;
									formatDGV(dgvTicket, "customer_id"); //Hmm which column to hide?? Also, which column to select, to be
																		 //able to use loading into the next form?? 
								}
								else
								{
									MessageBox.Show("No ticket found. Please add a new ticket.");
									//TODO: Shift focus to customer info field 
									//this.tbFirst.Focus(); TODO: Focus can go on the add button? Or that can be highlighted?!
								}

							}
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}
					}
					selectedBefore = true;
				}
				else
				{
					resetCustTicketInfo();
					dgvCust.CurrentRow.Selected = false;
					selectedBefore = false;
				}
			}
		}

		private void resetCustTicketInfo()
		{
			tbFirst.Text = "";
			tbLast.Text = "";
			tbPhone.Text = "";
			btnSubmit.Text = "Add Customer";
			lblTicket.Text = "Customer's Tickets";
			dgvTicket.DataSource = null;
			ticketDT.Clear();
		}

		//TODO: Cases where user accidentally deletes a letter & then puts it back to original
		//      OR situation where user puts in a space, so it becomes changed when essentially it is the same  
		private void tbFirst_TextChanged(object sender, EventArgs e)
		{
			if(dgvCust.DataSource != null)
			{
				var firstName = dgvCust.SelectedCells[1].Value.ToString();
				firstNameChange = tbFirst.Text.Equals(firstName.Trim()) && tbFirst.Text.Trim().Length == 0;
			}
			
		}
		private void tbLast_TextChanged(object sender, EventArgs e)
		{
			var lastName = dgvCust.SelectedCells[2].Value.ToString();
			lastNameChange = tbFirst.Text.Equals(lastName.Trim()) && tbFirst.Text.Trim().Length == 0;
		}

		private void tbPhone_TextChanged(object sender, EventArgs e)
		{
			var phone = dgvCust.SelectedCells[3].Value.ToString();
			phoneChange = tbFirst.Text.Equals(phone.Trim()) && tbFirst.Text.Trim().Length == 0;
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
			}
		}

		private void tbPhone_Leave(object sender, EventArgs e)
		{
			if (!Regex.IsMatch(tbPhone.Text, @"^[0-9]{10}$")) //Verifying valid 10 digit phone number 
			{
				tbPhone.BackColor = Color.IndianRed;
			}
			else
			{
				tbPhone.BackColor = Color.White;
			}
		}

		private void ticketSb_ValueChanged(object sender, EventArgs e)
		{
			Console.WriteLine($"Scrollbar value now {ticketSb.Value}");
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
	}
}
