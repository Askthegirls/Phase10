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
	public partial class EndGameForm : Form
	{
		public EndGameForm()
		{
			InitializeComponent();
			Display();
		}
		private void Display()
		{
			WinnerNameLabel.Text = ActivePlayerList.winner.fullname;
			WinsLabel.Text = ActivePlayerList.winner.wins.ToString();
		}
		private void WinnerNameLabel_Click(object sender, EventArgs e)
		{

		}

		private void MenuButton_Click(object sender, EventArgs e)
		{
			MenuForm menuForm = new MenuForm();
			menuForm.Show();
			this.Close();
		}
	}
}
