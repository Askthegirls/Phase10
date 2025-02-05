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
	public partial class AddPlayer : Form
	{
		
		public AddPlayer()
		{
			InitializeComponent();
			LoadPlayers();
		}

		private void LoadPlayers()
		{
			List<Player> players = GlobalConfiguration.Connection.GetPlayers();
			CurrentPlayersListBox.DataSource = null;
			CurrentPlayersListBox.DataSource = players;
			CurrentPlayersListBox.DisplayMember = "fullname";
		}

		private void AddNewPlayerButton_Click(object sender, EventArgs e)
		{
			Player person = new Player();
			person.fullname = FullNameTextBox.Text;
			person.email = EmailTextBox.Text;

			GlobalConfiguration.Connection.CreatePlayer(person);

			FullNameTextBox.ResetText();
			EmailTextBox.ResetText();
			LoadPlayers();
		}

		private void EmailTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void CurrentPlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void backButton_Click(object sender, EventArgs e)
		{
			MenuForm menuForm = new MenuForm();
			menuForm.Show();
			this.Close();
		}
	}
}
