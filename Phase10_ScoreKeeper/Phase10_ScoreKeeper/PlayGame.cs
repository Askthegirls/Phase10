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
	public partial class PlayGame : Form
	{
		private int i = 0;
		int n;
		Player player = new Player();
		public List<Player> winschecklist = GlobalConfiguration.Connection.PlayerGetWinsList();
		Player name = new Player();
		public List<Wins> winslist = GlobalConfiguration.Connection.GetWinsList();
		//PlayerScore playerscore = new PlayerScore();
		public PlayGame()
		{
			InitializeComponent();

			//SelectPlayersCheckBox.Items.AddRange(Players);
			LoadPlayers();
		}

		private void LoadPlayers()
		{
			ScoreboardListBox.DataSource = null;
			ScoreboardListBox.DataSource = ActivePlayerList.PlayerList;
			ScoreboardListBox.DisplayMember = "fullname";

			PhaseListBox.DataSource = null;
			PhaseListBox.DataSource = ActivePlayerList.PlayerList;
			PhaseListBox.DisplayMember = "phase";

			ScoreListBox.DataSource = null;
			ScoreListBox.DataSource = ActivePlayerList.PlayerList;
			ScoreListBox.DisplayMember = "score";


		}

		private void ScoreboardListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			n = ScoreboardListBox.SelectedIndex;
			name = ActivePlayerList.PlayerList[i];
			//List<PlayerScore> playerscore = GlobalConfiguration.Connection.GetPlayerScore();
			FullNameLabel.Text = name.fullname;
		}

		private void EndPhaseButton_Click(object sender, EventArgs e)
		{


		}

		private void quitButton_Click(object sender, EventArgs e)
		{
			MenuForm menuForm = new MenuForm();
			menuForm.Show();
			this.Close();
		}

		/*private void PlayerComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			PlayerComboBox.DataSource = null;
			PlayerComboBox.DataSource = ActivePlayerList.PlayerList;
			PlayerComboBox.DisplayMember = "fullname";
		}*/

		private void FullNameLabel_Click(object sender, EventArgs e)
		{

		}

		private void SaveScoreButton_Click(object sender, EventArgs e)
		{
			Player person = ActivePlayerList.PlayerList[ScoreboardListBox.SelectedIndex];
			//string score = ScoreTextBox.ToString();
			int a = 0;
			if(ScoreTextBox.Text.Length > 0)
			{
				a = int.Parse(ScoreTextBox.Text);
				person.score = a + person.score;
			}




			if (PhaseCheckBox.Checked && person.phase < 10)
			{
				person.phase = person.phase + 1;

				PhaseCheckBox.Checked = false;
			}
			else if (PhaseCheckBox.Checked && person.phase == 10)
			{

				ActivePlayerList.winner = person;
				int i = 0;
				//int t = winslist[0].id;
				//ActivePlayerList.winner = person;
				while (ActivePlayerList.winner.userid != winslist[i].userid)
				{
					i++;
				}
				//label26.Text = winslist[0].userid.ToString();
				//label27.Text = winslist[1].userid.ToString();
				//ActivePlayerList.winner = person;
				//label26.Text = winslist[i].wins.ToString();

				//t = winslist[i].id;
				ActivePlayerList.winner.wins = winslist[i].wins + 1;
				//ActivePlayerList.winner.id = winslist[i].id;
				//person.wins = ActivePlayerList.winner.wins;
				GlobalConfiguration.Connection.DeclairWinner(ActivePlayerList.winner);
				EndGameForm endGameForm = new EndGameForm();
				endGameForm.Show();
				this.Close();
			}

			//GlobalConfiguration.Connection.DeclairWinner(person);

			ScoreTextBox.ResetText();
			LoadPlayers();
		}

		private void PhaseListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
















//Program by Sarah K Johnson 11-27-24 sarahkristinej@outlook.com