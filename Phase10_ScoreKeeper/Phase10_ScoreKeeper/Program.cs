namespace Phase10_ScoreKeeper
{
	//Program by
	//Sarah K Johnson
	//11-27-24
	//sarahkristinej@outlook.com

	internal static class Program
	{

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			GlobalConfiguration.InitializeConnection();
			MenuForm menuForm = new MenuForm();
			Application.Run(menuForm);
		}
	}
}