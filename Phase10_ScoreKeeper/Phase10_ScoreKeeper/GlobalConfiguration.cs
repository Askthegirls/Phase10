using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase10_ScoreKeeper
{
	//Program by
	//Sarah K Johnson
	//11-27-24
	//sarahkristinej@outlook.com

	public static class GlobalConfiguration
	{
		public static IDBConnection Connection { get; private set; }

		public static void InitializeConnection() 
		{
			DBConnector sql = new DBConnector();
			Connection = sql;
		}

		public static string GetConnectionString(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}
	}
}
