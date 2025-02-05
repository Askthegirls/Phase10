using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phase10_ScoreKeeper.Forms
{
	//Program by
	//Sarah K Johnson
	//11-27-24
	//sarahkristinej@outlook.com

	public partial class ViewPastWinners : Form
	{
		public List<Wins> winslist = GlobalConfiguration.Connection.GetWinsList();
		public List<Player> players = GlobalConfiguration.Connection.GetPlayers();
		public Player tempa = new Player();
		public Player tempb = new Player();

		public ViewPastWinners()
		{
			InitializeComponent();
			winslist = winslist.OrderByDescending(w => w.wins).ToList();
			Sort();
			Load();
		}

		public void Sort()
		{
			int a = 0;
			int b = 0;

			while (b <= winslist.Count - 1)
			{
				/*if (players[a].userid != winslist[b].userid)
				{
					a++;
				}*/
				if (players[a].userid == winslist[b].userid)
				{
					tempb = players[b];
					players[b] = players[a];
					players[a] = tempb;
					b++;
					a = b;
				}
				else
				{
					a++;
				}
			}


		}

		public void Load()
		{
			WinsListBox.DataSource = null;
			WinsListBox.DataSource = winslist;
			WinsListBox.DisplayMember = "wins";

			WinnersNameListBox.DataSource = null;
			WinnersNameListBox.DataSource = players;
			WinnersNameListBox.DisplayMember = "fullname";
		}

		private void WinnerListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void backButton_Click(object sender, EventArgs e)
		{
			MenuForm menuForm = new MenuForm();
			menuForm.Show();
			this.Close();
		}

		private void WinnersNameListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}












































































//Program by Sarah K Johnson 11-27-24 sarahkristinej@outlook.com