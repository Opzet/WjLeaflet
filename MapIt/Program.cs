using System;
using Wisej.Web;

namespace MapIt
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
		//	Application.MainPage = new frmWidget_Leafletjs();
            Application.MainPage = new frmWjLeafletjs();
        }

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}