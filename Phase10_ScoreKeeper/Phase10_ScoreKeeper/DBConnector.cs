using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Pipes;
using System.Linq;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Reflection;


namespace Phase10_ScoreKeeper
{
	//Program by
	//Sarah K Johnson
	//11-27-24
	//sarahkristinej@outlook.com

	//	Database connector that will use processes to add player information to the database, as well as update the number of wins each player has
	public class DBConnector : IDBConnection
	{
		//SqlConnection connection = new SqlConnection("PHASE10ScoreDB");

		public Player CreatePlayer(Player person) 
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfiguration.GetConnectionString("PHASE10ScoreDB")))
			{
				var d = new DynamicParameters();
				d.Add("@FullName", person.fullname);
				d.Add("@Email", person.email);
				d.Add("@UserID", 0, DbType.Int32, direction: ParameterDirection.Output);
				//person.id = d.Get<int>("@UserID");


				connection.Execute("CreatePlayer", d, commandType:CommandType.StoredProcedure);

				return person;
			}
		}

		public List<Player> GetPlayers()
		{
			List<Player> list;
			using (IDbConnection connection = new SqlConnection(GlobalConfiguration.GetConnectionString("PHASE10ScoreDB")))
			{
				list = connection.Query<Player>("GetPlayers").ToList();
			}
			return list;
		}
		public Player DeclairWinner(Player person)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfiguration.GetConnectionString("PHASE10ScoreDB")))
			{
				var d = new DynamicParameters();
				d.Add("@Wins", person.wins);
				d.Add("@WinnerID", person.userid);

				connection.Execute("UpdateWins", d, commandType: CommandType.StoredProcedure);

				return person;
			}
		}
		public List<Wins> GetWinsList()
		{
			List<Wins> list;
			using (IDbConnection connection = new SqlConnection(GlobalConfiguration.GetConnectionString("PHASE10ScoreDB")))
			{
				var d = new DynamicParameters();
				//d.Get<int>("@id");
				list = connection.Query<Wins>("GetWins").ToList();
				
				return list;
			}
		}

		public List<Player> PlayerGetWinsList()
		{
			List<Player> list;
			using (IDbConnection connection = new SqlConnection(GlobalConfiguration.GetConnectionString("PHASE10ScoreDB")))
			{
				list = connection.Query<Player>("PlayerGetWins").ToList();

				return list;
			}
		}
		/*public List<PlayerScore> GetPlayerScore(Player Person)
		{
			List<PlayerScore> list;
			using (IDbConnection connection = new SqlConnection(GlobalConfiguration.GetConnectionString("PHASE10ScoreDB")))
			{
				list = connection.Query<PlayerScore>("GetPlayerScore").ToList();
			}
			return list;
		}

			public List<PlayerScore> GetPlayerScore()
			{
				List<PlayerScore> list;
				using (IDbConnection connection = new SqlConnection(GlobalConfiguration.GetConnectionString("PHASE10ScoreDB")))
				{
					list = connection.Query<PlayerScore>("GetPlayerScore").ToList();
				}
				return list;
			}

			public void DeclairWinner(IDbConnection connection)
		{
			var d = new DynamicParameters();
			//d.Add("@Wins", person.wins);
		}*/


	}
}
