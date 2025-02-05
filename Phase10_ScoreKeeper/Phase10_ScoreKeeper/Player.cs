using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase10_ScoreKeeper
{

	//Program by
	//Sarah K Johnson
	//11-27-24
	//sarahkristinej@outlook.com

	//	Class to create Player objects to be added to the CreateGame object
	public class Player
	{

		public int userid { get; set; }

		public string fullname { get; set; }

		public string email { get; set; }

		public int phase { get; set; }

		public int score { get; set; }

		public int wins { get; set; }



	}

}
