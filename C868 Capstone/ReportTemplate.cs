using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C868_Capstone
{
	public partial class ReportTemplate : Form
	{
		string start, end;
		string sqlCmd = "";
		string reportName = "";
		DataTable reportDT = new DataTable();
		DataTable reportDTBind = new DataTable();
		string connString = "server = 192.168.29.210; database=shoerepair_pos; Uid = root; pwd=123; persistsecurityinfo = True; Allow User Variables=True";

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.Dispose();
			FormProvider.MainScreen.Show();
		}

		public ReportTemplate()
		{
			InitializeComponent();
		}
		public ReportTemplate(int report, int sort, DateTime start, DateTime end, bool isWkly)
		{
			InitializeComponent();
			this.start = start.Date.ToString("yyyy-M-dd HH:mm:ss");
			var _end = end.Date.AddDays(1);
			this.end = _end.ToString("yyyy-M-dd HH:mm:ss");

			//FROM
			switch(report)
			{
				//Sales
				case 0:
					//Have to do it on a daily basis for loop ==> increment date every loop?
					sqlCmd += "SELECT drop_date, SUM(subtotal) Revenue " +
						"FROM ticket_item " +
						"WHERE drop_date IN (SELECT drop_date FROM ticket_item WHERE drop_date >= @startDate AND drop_date < @endDate)" +
						"GROUP BY drop_date;";
					reportName = "Sales Report";
					break;
				//Services
				case 1:
					sqlCmd = "SELECT ti.drop_date, c.category_name as \"Name\", count(*) as Count " +
						"FROM ticket_item ti " +
						"INNER JOIN category_item ci on ti.category_item_id = ci.category_item_id " +
						"INNER JOIN category c on ci.category_id = c.category_id " +
						"WHERE drop_date IN " +
						"(SELECT drop_date FROM ticket_item WHERE drop_date >= @startDate AND drop_date < @endDate)" +
						"GROUP BY drop_date, category_name;";
					reportName = "Repair Services Report";
					break;
				//Report History
				case 2:
					sqlCmd = "SELECT report_date as \"Date\", report_name as \"Name\", report_type \"Report Type\", action_type \"Action\" " +
						"FROM report_history " +
						"WHERE report_date IN (SELECT report_date FROM report_history WHERE report_date>= '2020-08-01' AND report_date <= '2020-08-20');";
					reportName = "Report History Report";
					break;
				default:
					sqlCmd = "";
					break;
			}

			//WHERE
			//switch (sort)
			//{
			//	//Date
			//	case 0:
			//		sqlCmd = "";
			//		break;
			//	//Type/Revenue
			//	case 1:
			//		sqlCmd = "";
			//		break;
			//	//Count
			//	case 2:
			//		sqlCmd = "";
			//		break;
			//	default:
			//		sqlCmd = "";
			//		break;
			//}
			CreateReportDT();
			var dateRN = isWkly ? "Weekly" : "Monthly";
			lblRN.Text = $"({dateRN}) {reportName}";
		}

		//TODO: Probably delete?? XD
		private void CreateReportDT()
		{
			//Execute MySql cmd & fill in data table(s)
			using(MySqlConnection conn = new MySqlConnection(connString))
			{
				try
				{
					conn.Open();
					using(MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
					{
						cmd.Parameters.Add(new MySqlParameter("@startDate", start));
						cmd.Parameters.Add(new MySqlParameter("@endDate", end));

						MySqlDataAdapter adapter = new MySqlDataAdapter();
						adapter.SelectCommand = cmd;
						adapter.Fill(reportDT);
					}

					if(reportDT.Rows.Count > 0)
					{

						//reportDTBind.Columns.Add("Date", typeof(System.String));
						//reportDTBind.Columns.Add("Revenue", typeof(System.Int32));
						//reportDTBind.Columns.Add("Running Total", typeof(System.Int32));

						//var dayOf = DateTime.Parse(start);

						//while (dayOf < DateTime.Parse(end))
						//{
						//	DataRow dr = reportDTBind.NewRow();
						//	dr["Date"] = dayOf.ToString("MM-dd-yyyy");
						//	dr["Revenue"] = 0;
						//	dr["Running Total"] = 0;
						//	reportDTBind.Rows.Add(dr);

						//	//DateTime is immutable ==> Have to assign the result of operation to a variable. 
						//	dayOf = dayOf.AddDays(1);
						//}

						//var dataType = reportDT.Columns[1].DataType;

						//foreach (DataRow row in reportDTBind.Rows)
						//{
						//	var count = 0;
						//	while(count < reportDT.Rows.Count)
						//	{
						//		var date = reportDT.Rows[count].Field<DateTime>("drop_date").ToString("MM-dd-yyyy");
						//		var revenue = Convert.ToInt32(reportDT.Rows[count].ItemArray.ElementAt(1));

						//		if (row.ItemArray.ElementAt(0).Equals(date))
						//		{
						//			//row.ItemArray[1] = revenue; //.SetValue(revenue, 1);
						//			row.SetField(1, revenue);
						//		}
						//			//row.SetField(1, 0);
						//		count++;
						//	}

						//}

						////Running Total Calc
						//var firstTotalVal = reportDTBind.Rows[0].Field<int>("Revenue");
						//reportDTBind.Rows[0].SetField(2, firstTotalVal);

						//for (int i = 1; i < reportDTBind.Rows.Count;i++)
						//{
						//	var parentCell = reportDTBind.Rows[i-1].Field<int>("Running Total"); //i = 0
						//	var childCell = reportDTBind.Rows[i].Field<int>("Revenue"); ; //i = 1

						//	reportDTBind.Rows[i].SetField(2, parentCell + childCell);
						//}

						//var grandTotal = reportDTBind.Rows[reportDTBind.Rows.Count - 1].Field<int>("Running Total");
						//lblGT.Text += $" ${grandTotal}";
						TransformDataTable();
					}
					else
					{
						this.Close();
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}
			//If we have multiple DTs will have to merge them together 
		}


		//TODO: Get rid of hideCell parameter from formatDGV
		private void formatDGV(DataGridView dgv)
		{
			//if (reportDT.Rows.Count > 0)
			//{
			//	dgvReport.DataSource = reportDT;
			//	//formatDGV(dgvReport, "");
			//}
			//else
			//{
			//	this.Close();
			//}

			//Create a date column & add it to the data table 
			
			//reportDT.Columns.Add(col);
			//col.SetOrdinal(0);





			//dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.ColumnHeadersVisible = true;
			dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
			dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			dgv.RowHeadersVisible = false;
			//dgv.Columns[hideCell].Visible = false;
			dgv.ReadOnly = true;
			dgv.AutoResizeColumns();
			dgv.AllowUserToAddRows = false;

			//TODO: [implement] Skip days that have 0 or the store is closed?? (Owner vs Accounting perspective) 

			//dgv.Width = dgv.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + 3;
			//dgv.Height = dgv.Rows.Cast<DataGridViewRow>().Sum(x => x.Height) + 3;
			//dgv.Rows[0].Selected = false;

			DataGridViewElementStates states = DataGridViewElementStates.None;
			dgv.ScrollBars = ScrollBars.Vertical;
			var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
			totalHeight += dgv.Rows.Count * 6; //todo: adjust
			var totalWidth = dgv.Columns.GetColumnsWidth(states);
			if(totalHeight > this.Height)
			{
				dgv.ClientSize = new Size(totalWidth, this.Height);
			}
			else
				dgv.ClientSize = new Size(totalWidth, totalHeight);


			//TODO: Is placing here ok or can it placed it a better spot??
			

		}
		private void ReportTemplate_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit Application", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					Environment.Exit(0);
				}
				else
					e.Cancel = true;
			}
			else
				e.Cancel = true;
		}

		private void TransformDataTable()
		{
			switch(reportName)
			{
				case "Sales Report":
					SalesReportDT();
					dgvReport.DataSource = reportDTBind;
					formatDGV(dgvReport);
					break;
				case "Repair Services Report":
					RepairServiceDT();
					dgvReport.DataSource = reportDTBind;
					formatDGV(dgvReport);
					break;
				case "Report History Report":
					dgvReport.DataSource = reportDT;
					formatDGV(dgvReport);
					lblGT.Hide();
					break;
				default:
					break;
			}
			
		}

		private void SalesReportDT()
		{
			reportDTBind.Columns.Add("Date", typeof(System.String));
			reportDTBind.Columns.Add("Revenue", typeof(System.Int32));
			reportDTBind.Columns.Add("Running Total", typeof(System.Int32));

			var dayOf = DateTime.Parse(start);

			while (dayOf < DateTime.Parse(end))
			{
				DataRow dr = reportDTBind.NewRow();
				dr["Date"] = dayOf.ToString("MM-dd-yyyy");
				dr["Revenue"] = 0;
				dr["Running Total"] = 0;
				reportDTBind.Rows.Add(dr);

				//DateTime is immutable ==> Have to assign the result of operation to a variable. 
				dayOf = dayOf.AddDays(1);
			}

			foreach (DataRow row in reportDTBind.Rows)
			{
				var count = 0;
				while (count < reportDT.Rows.Count)
				{
					var date = reportDT.Rows[count].Field<DateTime>("drop_date").ToString("MM-dd-yyyy");
					var revenue = Convert.ToInt32(reportDT.Rows[count].ItemArray.ElementAt(1));

					if (row.ItemArray.ElementAt(0).Equals(date))
					{
						//row.ItemArray[1] = revenue; //.SetValue(revenue, 1);
						row.SetField(1, revenue);
					}
					//row.SetField(1, 0);
					count++;
				}

			}

			//Running Total Calc
			var firstTotalVal = reportDTBind.Rows[0].Field<int>("Revenue");
			reportDTBind.Rows[0].SetField(2, firstTotalVal);

			for (int i = 1; i < reportDTBind.Rows.Count; i++)
			{
				var parentCell = reportDTBind.Rows[i - 1].Field<int>("Running Total"); //i = 0
				var childCell = reportDTBind.Rows[i].Field<int>("Revenue"); ; //i = 1

				reportDTBind.Rows[i].SetField(2, parentCell + childCell);
			}

			var grandTotal = reportDTBind.Rows[reportDTBind.Rows.Count - 1].Field<int>("Running Total");
			lblGT.Text += $" ${grandTotal}";
		}

		private void RepairServiceDT()
		{
			reportDTBind.Columns.Add("Date", typeof(System.String));
			reportDTBind.Columns.Add("Repair Service Type", typeof(System.String));
			reportDTBind.Columns.Add("Count", typeof(System.Int32));

			var dayOf = DateTime.Parse(start);

			//TODO: Later on prob find a more optimal way of adding 3 rows per day...
			while (dayOf < DateTime.Parse(end))
			{
				DataRow dr = reportDTBind.NewRow();
				dr["Date"] = dayOf.ToString("MM-dd-yyyy");
				dr["Repair Service Type"] = "Women's Shoes";
				dr["Count"] = 0;
				reportDTBind.Rows.Add(dr);

				DataRow dr1 = reportDTBind.NewRow();
				dr1["Date"] = dayOf.ToString("MM-dd-yyyy");
				dr1["Repair Service Type"] = "Men's Shoes";
				dr1["Count"] = 0;
				reportDTBind.Rows.Add(dr1);

				DataRow dr2 = reportDTBind.NewRow();
				dr2["Date"] = dayOf.ToString("MM-dd-yyyy");
				dr2["Repair Service Type"] = "Luggage";
				dr2["Count"] = 0;
				reportDTBind.Rows.Add(dr2);

				//DateTime is immutable ==> Have to assign the result of operation to a variable. 
				dayOf = dayOf.AddDays(1);
			}

			foreach (DataRow row in reportDTBind.Rows)
			{
				var count = 0;
				while (count < reportDT.Rows.Count)
				{
					var date = reportDT.Rows[count].Field<DateTime>("drop_date").ToString("MM-dd-yyyy");
					var repairST = (reportDT.Rows[count].ItemArray.ElementAt(1)).ToString();
					var freq = Convert.ToInt32(reportDT.Rows[count].ItemArray.ElementAt(2));

					if (row.ItemArray.ElementAt(0).Equals(date) && row.ItemArray.ElementAt(1).Equals(repairST))
					{
						//row.ItemArray[1] = revenue; //.SetValue(revenue, 1);
						row.SetField(2, freq);
					}
					//row.SetField(1, 0);
					count++;
				}

			}

			//Just to make it easy on the eyes hide the row where the count column has a value of 0 

			reportDTBind.AcceptChanges();
			foreach(DataRow dr in reportDTBind.Rows)
			{
				var checkCount = Convert.ToInt32(dr.ItemArray.ElementAt(2));
				if(checkCount == 0)
				{
					dr.Delete();
				}
			}
			reportDTBind.AcceptChanges();

			var totalWS = 0;
			var totalMS = 0;
			var totalLug = 0;

			foreach (DataRow dr in reportDTBind.Rows)
			{
				var categoryRS = dr.ItemArray.ElementAt(1).ToString();
				var catFreq = Convert.ToInt32(dr.ItemArray.ElementAt(2));


				switch(categoryRS)
				{
					case "Women's Shoes":
						totalWS += catFreq;
						break;
					case "Men's Shoes":
						totalMS += catFreq;
						break;
					case "Luggage":
						totalLug += catFreq;
						break;
				}
			}

			//TODO: What would we like to display on the BR corner of the form?
			//var firstTotalVal = reportDTBind.Rows[0].Field<int>("Revenue");
			//reportDTBind.Rows[0].SetField(2, firstTotalVal);

			//for (int i = 1; i < reportDTBind.Rows.Count; i++)
			//{
			//	var parentCell = reportDTBind.Rows[i - 1].Field<int>("Running Total"); //i = 0
			//	var childCell = reportDTBind.Rows[i].Field<int>("Revenue"); ; //i = 1

			//	reportDTBind.Rows[i].SetField(2, parentCell + childCell);
			//}

			//var grandTotal = reportDTBind.Rows[reportDTBind.Rows.Count - 1].Field<int>("Running Total");
			lblGT.Text = $"Total Women's Shoes: {totalWS} | Total Men's Shoes: {totalMS} | Total Luggages: {totalLug}";
		}

		//TODO: DELETE!!!
		//private void ReportHistoryDT() //Needa think about this one lul 
		//{
		//	reportDTBind.Columns.Add("Date", typeof(System.String));
		//	reportDTBind.Columns.Add("Repair Service Type", typeof(System.String));
		//	reportDTBind.Columns.Add("Count", typeof(System.Int32));

		//	var dayOf = DateTime.Parse(start);

		//	while (dayOf < DateTime.Parse(end))
		//	{
		//		DataRow dr = reportDTBind.NewRow();
		//		dr["Date"] = dayOf.ToString("MM-dd-yyyy");
		//		dr["Repair Service Type"] = "";
		//		dr["Count"] = 0;
		//		reportDTBind.Rows.Add(dr);
		//		reportDTBind.Rows.Add(dr);
		//		reportDTBind.Rows.Add(dr);

		//		//DateTime is immutable ==> Have to assign the result of operation to a variable. 
		//		dayOf = dayOf.AddDays(1);
		//	}

		//	var dataType = reportDT.Columns[1].DataType;

		//	foreach (DataRow row in reportDTBind.Rows)
		//	{
		//		var count = 0;
		//		while (count < reportDT.Rows.Count)
		//		{
		//			var date = reportDT.Rows[count].Field<DateTime>("drop_date").ToString("MM-dd-yyyy");
		//			var revenue = Convert.ToInt32(reportDT.Rows[count].ItemArray.ElementAt(1));

		//			if (row.ItemArray.ElementAt(0).Equals(date))
		//			{
		//				//row.ItemArray[1] = revenue; //.SetValue(revenue, 1);
		//				row.SetField(1, revenue);
		//			}
		//			//row.SetField(1, 0);
		//			count++;
		//		}

		//	}

		//	//Running Total Calc
		//	var firstTotalVal = reportDTBind.Rows[0].Field<int>("Revenue");
		//	reportDTBind.Rows[0].SetField(2, firstTotalVal);

		//	for (int i = 1; i < reportDTBind.Rows.Count; i++)
		//	{
		//		var parentCell = reportDTBind.Rows[i - 1].Field<int>("Running Total"); //i = 0
		//		var childCell = reportDTBind.Rows[i].Field<int>("Revenue"); ; //i = 1

		//		reportDTBind.Rows[i].SetField(2, parentCell + childCell);
		//	}

		//	var grandTotal = reportDTBind.Rows[reportDTBind.Rows.Count - 1].Field<int>("Running Total");
		//	lblGT.Text += $" ${grandTotal}";
		//}
	}
}
