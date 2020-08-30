using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
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
	public partial class Login : Form
	{
		string connString = "server = localhost; database=shoerepair_pos; Uid = root; pwd=july72794!; persistsecurityinfo = True; Allow User Variables=True";
		bool namePass, pwdPass, pinPass;
		public Login()
		{
			InitializeComponent();
		}
		private void Login_Load(object sender, EventArgs e)
		{
			this.Show();
			tbUserName.Focus();
			tbPwd.PasswordChar = '\u25CF';
			tbPIN.PasswordChar = '\u25CF';
		}
		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (pinPass || (namePass && pwdPass))
			{
				var name = tbUserName.Text;
				var pwd = tbPwd.Text;
				int pin = -1;
				if (!String.IsNullOrEmpty(tbPIN.Text))
				{
					pin = Convert.ToInt32(tbPIN.Text);
				}

				using (MySqlConnection conn = new MySqlConnection(connString))
				{
					try
					{
						conn.Open();
						var sqlcmd = "SELECT user_id FROM user_table WHERE username = @name AND user_pwd = @pwd OR user_pin = @pin;";
						using (MySqlCommand cmd = new MySqlCommand(sqlcmd, conn))
						{
							cmd.Parameters.Add(new MySqlParameter("@name", name));
							cmd.Parameters.Add(new MySqlParameter("@pwd", pwd));
							cmd.Parameters.Add(new MySqlParameter("@pin", pin)); //Convert.ToInt32(pin))

							var count = Convert.ToInt32(cmd.ExecuteScalar());

							if (count > 0)
							{
								FormProvider.Login.Hide();
								FormProvider.MainScreen.Show();
							}
							else
								MessageBox.Show("Please login with the correct security credentials.");
						}

					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.ToString());
					}
				}
			}
			else
				MessageBox.Show("Please fill in either the PIN field or the username and password field in order to login.");

			
		}
		private void tbUserName_Leave(object sender, EventArgs e)
		{
			if (!Regex.IsMatch(tbUserName.Text, @"\A[\p{L}\s]+\Z") || String.IsNullOrEmpty(tbUserName.Text))
			{
				tbUserName.BackColor = Color.IndianRed;
			}
			else
			{
				tbUserName.BackColor = Color.White;
				namePass = true;
			}
		}
		private void tbPwd_Leave(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(tbPwd.Text))
			{
				tbPwd.BackColor = Color.IndianRed;
			}
			else
			{
				tbPwd.BackColor = Color.White;
				pwdPass = true;
			}
		}
		private void tbPIN_Leave(object sender, EventArgs e)
		{
			if (!Regex.IsMatch(tbPIN.Text, @"^[0-9]+$")) 
			{
				tbPIN.BackColor = Color.IndianRed;
			}
			else
			{
				tbPIN.BackColor = Color.White;
				pinPass = true;
			}
		}
	}
}
