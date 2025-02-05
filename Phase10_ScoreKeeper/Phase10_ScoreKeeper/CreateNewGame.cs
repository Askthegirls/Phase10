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
	public partial class CreateNewGame : Form
	{
		public List<Player> players = GlobalConfiguration.Connection.GetPlayers();
		//public List<PlayerScore> playerscore = GlobalConfiguration.Connection.GetPlayerScore();
		public List<Player> selectedPlayers = new List<Player>();
		//public List<PlayerScore> selectedPlayerScore = new List<PlayerScore>();

		public CreateNewGame()
		{
			InitializeComponent();
			LoadPlayers();
		}

		private void LoadPlayers()
		{
			playerSelect.DataSource = null;
			playerSelect.DataSource = players;
			playerSelect.DisplayMember = "fullname";
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			MenuForm menuForm = new MenuForm();
			menuForm.Show();
			this.Close();
		}

		private void StartGameButton_Click(object sender, EventArgs e)
		{
			//selectedPlayers.Clear();

			//ActiveScoreList.PlayerScore = selectedPlayerScore;
			if (selectedPlayers.Count != 0) { 
				PlayGame viewGame = new PlayGame();
				viewGame.Show();
				this.Close();
			}
		}

		private void GotoAddNewPlayerFormButton_Click(object sender, EventArgs e)
		{
			AddPlayer addPlayerForm = new AddPlayer();
			addPlayerForm.Show();
			this.Close();
		}

		private void playerSelect_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void SelectedListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void AddPlayersButton_Click(object sender, EventArgs e)
		{
			SelectedListBox.Items.Clear();
			selectedPlayers.Clear();
			foreach(Player i in playerSelect.CheckedItems) 
			{
				SelectedListBox.Items.Add(i);
				selectedPlayers.Add(i);
			}
			SelectedListBox.DisplayMember = "FullName";
			ActivePlayerList.PlayerList = selectedPlayers;
		}
	}
}








//Program by Sarah K Johnson 11-27-24 sarahkristinej@outlook.com