using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace C868_Capstone
{
	public class DataBaseHelper
	{
		private string connString = "server = localhost; user id = root; persistsecurityinfo = True; database = shoerepair_pos";
		private DataTable dt = new DataTable();
		
		/* For now, this method will open & close connection to MySql dB & you can pass a SQL command & will return a datatable*/
		public DataTable ConnDB(string commandText)
		{
			using(MySqlConnection conn = new MySqlConnection(connString))
			{
				try
				{
					conn.Open();
					using (MySqlCommand cmd = new MySqlCommand(commandText, conn))
					{
						MySqlDataAdapter adapter = new MySqlDataAdapter(cmd.CommandText, conn);
						adapter.Fill(dt);
					}
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}

				return dt;	
			}
			
		}
	}
}
