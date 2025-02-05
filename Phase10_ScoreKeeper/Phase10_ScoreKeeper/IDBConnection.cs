using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase10_ScoreKeeper
{
	//Program by
	//Sarah K Johnson
	//11-27-24
	//sarahkristinej@outlook.com

	public interface IDBConnection
	{
		Player CreatePlayer(Player player);
		Player DeclairWinner(Player player);
		List<Player> GetPlayers();
		List<Wins> GetWinsList();
		List<Player> PlayerGetWinsList();
		//List<PlayerScore> GetPlayerScore();
	}
}
