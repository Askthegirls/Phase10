using Phase10_ScoreKeeper.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phase10_ScoreKeeper
{
	public partial class MenuForm : Form
	{
		private int i = 0;
		public MenuForm()
		{
			InitializeComponent();
		}

		private void ClosePage()
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			CreateNewGame newGame = new CreateNewGame();
			newGame.Show();

			if (i == 0)
			{
				this.Hide();
				i++;
			}
			else
			{
				this.ClosePage();
			}
			//this.ClosePage();
		}
		private void addPlayer_Click(object sender, EventArgs e)
		{
			AddPlayer addPlayerForm = new AddPlayer();
			addPlayerForm.Show();
			if (i == 0)
			{
				this.Hide();
				i++;
			}
			else
			{
				this.ClosePage();
			}
		}

		private void viewWinners_Click(object sender, EventArgs e)
		{
			ViewPastWinners viewWinners = new ViewPastWinners();
			viewWinners.Show();
			if (i == 0)
			{
				this.Hide();
				i++;
			}
			else
			{
				this.ClosePage();
			}
		}

		private void PastWinnersButton_Click(object sender, EventArgs e)
		{
			ViewPastWinners viewWinners = new ViewPastWinners();
			viewWinners.Show();
			if (i == 0)
			{
				this.Hide();
				i++;
			}
			else
			{
				this.ClosePage();
			}
		}
	}
}














//Program by Sarah K Johnson 11-27-24 sarahkristinej@outlook.com