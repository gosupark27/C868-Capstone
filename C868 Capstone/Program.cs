﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C868_Capstone
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(FormProvider.MainScreen);
			Application.Run(FormProvider.Login);
			//Application.Run(new Practice());
			//Application.Run(new MainScreenDos());
		}
	}
}
