using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C868_Capstone
{
	public class FormProvider
	{
		//Implementing singleton pattern ==> Only creating a form instance once. 
		public static MainScreen MainScreen
		{
			get
			{
				if(_mainScreen == null)
				{
					_mainScreen = new MainScreen();
				}
				return _mainScreen;
			}
		}

		public static MainScreenDos MainScreenDos
		{
			get
			{
				if (_mainScreenDos == null)
				{
					_mainScreenDos = new MainScreenDos();
				}
				return _mainScreenDos;
			}
		}

		public static Login Login
		{
			get
			{
				if(_login == null)
				{
					_login = new Login();
				}
				return _login;
			}
			
		}
		private static MainScreen _mainScreen;
		private static MainScreenDos _mainScreenDos;
		private static Login _login;
	}
}
