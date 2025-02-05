
namespace Phase10_ScoreKeeper
{
	partial class MenuForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			PhaseName = new Label();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			newGame = new Button();
			addPlayer = new Button();
			label1 = new Label();
			PastWinnersButton = new Button();
			SuspendLayout();
			// 
			// PhaseName
			// 
			PhaseName.AutoSize = true;
			PhaseName.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			PhaseName.ForeColor = Color.White;
			PhaseName.Location = new Point(163, 58);
			PhaseName.Name = "PhaseName";
			PhaseName.Size = new Size(468, 128);
			PhaseName.TabIndex = 0;
			PhaseName.Text = "Phase 10";
			// 
			// newGame
			// 
			newGame.BackColor = Color.White;
			newGame.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			newGame.ForeColor = Color.Black;
			newGame.Location = new Point(283, 264);
			newGame.Name = "newGame";
			newGame.Size = new Size(235, 27);
			newGame.TabIndex = 1;
			newGame.Text = "New Game";
			newGame.UseVisualStyleBackColor = false;
			newGame.Click += button1_Click;
			// 
			// addPlayer
			// 
			addPlayer.BackColor = Color.White;
			addPlayer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			addPlayer.ForeColor = Color.Black;
			addPlayer.Location = new Point(283, 310);
			addPlayer.Name = "addPlayer";
			addPlayer.Size = new Size(235, 27);
			addPlayer.TabIndex = 2;
			addPlayer.Text = "Add New Player";
			addPlayer.UseVisualStyleBackColor = false;
			addPlayer.Click += addPlayer_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Italic);
			label1.ForeColor = Color.White;
			label1.Location = new Point(303, 174);
			label1.Name = "label1";
			label1.Size = new Size(188, 37);
			label1.TabIndex = 4;
			label1.Text = "Score Keeper";
			// 
			// PastWinnersButton
			// 
			PastWinnersButton.BackColor = Color.White;
			PastWinnersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			PastWinnersButton.ForeColor = Color.Black;
			PastWinnersButton.Location = new Point(283, 355);
			PastWinnersButton.Name = "PastWinnersButton";
			PastWinnersButton.Size = new Size(235, 27);
			PastWinnersButton.TabIndex = 5;
			PastWinnersButton.Text = "High Scores";
			PastWinnersButton.UseVisualStyleBackColor = false;
			PastWinnersButton.Click += PastWinnersButton_Click;
			// 
			// MenuForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DodgerBlue;
			ClientSize = new Size(800, 450);
			Controls.Add(PastWinnersButton);
			Controls.Add(label1);
			Controls.Add(addPlayer);
			Controls.Add(newGame);
			Controls.Add(PhaseName);
			ForeColor = Color.White;
			Name = "MenuForm";
			Text = "MenuForm";
			ResumeLayout(false);
			PerformLayout();
		}



		#endregion

		private Label PhaseName;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Button newGame;
		private Button addPlayer;
		private Label label1;
		private Button PastWinnersButton;
	}
}