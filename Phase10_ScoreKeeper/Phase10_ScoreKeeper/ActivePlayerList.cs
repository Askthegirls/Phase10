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

	public static class ActivePlayerList
	{
		public static List<Player> PlayerList {  get; set; } = new List<Player>();
		public static Player winner { get; set; }
		public static List<Wins> winCount { get; set; } = new List<Wins>();
	}
	public static class Winner
	{
		
	}
}
