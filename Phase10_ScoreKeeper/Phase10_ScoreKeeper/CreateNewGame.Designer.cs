namespace Phase10_ScoreKeeper.Forms
{
	partial class CreateNewGame
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
			label1 = new Label();
			playerSelect = new CheckedListBox();
			backButton = new Button();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			GotoAddNewPlayerFormButton = new Button();
			StartGameButton = new Button();
			SelectedListBox = new ListBox();
			AddPlayersButton = new Button();
			label5 = new Label();
			SuspendLayout();
			// 
			// PhaseName
			// 
			PhaseName.AutoSize = true;
			PhaseName.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold | FontStyle.Italic);
			PhaseName.ForeColor = Color.White;
			PhaseName.Location = new Point(267, 46);
			PhaseName.Name = "PhaseName";
			PhaseName.Size = new Size(263, 72);
			PhaseName.TabIndex = 1;
			PhaseName.Text = "Phase 10";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Italic);
			label1.ForeColor = Color.White;
			label1.Location = new Point(286, 105);
			label1.Name = "label1";
			label1.Size = new Size(213, 37);
			label1.TabIndex = 2;
			label1.Text = "Create a Game";
			// 
			// playerSelect
			// 
			playerSelect.BackColor = SystemColors.HotTrack;
			playerSelect.ForeColor = Color.White;
			playerSelect.FormattingEnabled = true;
			playerSelect.Location = new Point(26, 151);
			playerSelect.Name = "playerSelect";
			playerSelect.Size = new Size(219, 220);
			playerSelect.TabIndex = 3;
			playerSelect.SelectedIndexChanged += playerSelect_SelectedIndexChanged;
			// 
			// backButton
			// 
			backButton.BackColor = Color.White;
			backButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			backButton.ForeColor = Color.Black;
			backButton.Location = new Point(12, 12);
			backButton.Name = "backButton";
			backButton.Size = new Size(83, 32);
			backButton.TabIndex = 4;
			backButton.Text = "Back";
			backButton.UseVisualStyleBackColor = false;
			backButton.Click += backButton_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14F);
			label2.Location = new Point(57, 115);
			label2.Name = "label2";
			label2.Size = new Size(149, 25);
			label2.TabIndex = 5;
			label2.Text = "Previous Players";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 8F);
			label3.Location = new Point(56, 373);
			label3.Name = "label3";
			label3.Size = new Size(147, 13);
			label3.TabIndex = 6;
			label3.Text = "If a player is not on the list,";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 8F);
			label4.Location = new Point(65, 391);
			label4.Name = "label4";
			label4.Size = new Size(126, 13);
			label4.TabIndex = 7;
			label4.Text = "click the button below.";
			// 
			// GotoAddNewPlayerFormButton
			// 
			GotoAddNewPlayerFormButton.BackColor = Color.White;
			GotoAddNewPlayerFormButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			GotoAddNewPlayerFormButton.ForeColor = Color.Black;
			GotoAddNewPlayerFormButton.Location = new Point(69, 412);
			GotoAddNewPlayerFormButton.Name = "GotoAddNewPlayerFormButton";
			GotoAddNewPlayerFormButton.Size = new Size(116, 26);
			GotoAddNewPlayerFormButton.TabIndex = 9;
			GotoAddNewPlayerFormButton.Text = "Add new Player";
			GotoAddNewPlayerFormButton.UseVisualStyleBackColor = false;
			GotoAddNewPlayerFormButton.Click += GotoAddNewPlayerFormButton_Click;
			// 
			// StartGameButton
			// 
			StartGameButton.BackColor = Color.White;
			StartGameButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			StartGameButton.ForeColor = Color.Black;
			StartGameButton.Location = new Point(322, 391);
			StartGameButton.Name = "StartGameButton";
			StartGameButton.Size = new Size(162, 29);
			StartGameButton.TabIndex = 10;
			StartGameButton.Text = "Start Game";
			StartGameButton.UseVisualStyleBackColor = false;
			StartGameButton.Click += StartGameButton_Click;
			// 
			// SelectedListBox
			// 
			SelectedListBox.BackColor = SystemColors.HotTrack;
			SelectedListBox.ForeColor = Color.White;
			SelectedListBox.FormattingEnabled = true;
			SelectedListBox.ItemHeight = 15;
			SelectedListBox.Location = new Point(551, 151);
			SelectedListBox.Name = "SelectedListBox";
			SelectedListBox.Size = new Size(226, 229);
			SelectedListBox.TabIndex = 11;
			SelectedListBox.SelectedIndexChanged += SelectedListBox_SelectedIndexChanged;
			// 
			// AddPlayersButton
			// 
			AddPlayersButton.BackColor = Color.White;
			AddPlayersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			AddPlayersButton.ForeColor = Color.Black;
			AddPlayersButton.Location = new Point(340, 236);
			AddPlayersButton.Name = "AddPlayersButton";
			AddPlayersButton.Size = new Size(118, 25);
			AddPlayersButton.TabIndex = 12;
			AddPlayersButton.Text = "Add Players";
			AddPlayersButton.UseVisualStyleBackColor = false;
			AddPlayersButton.Click += AddPlayersButton_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 14F);
			label5.Location = new Point(591, 115);
			label5.Name = "label5";
			label5.Size = new Size(148, 25);
			label5.TabIndex = 13;
			label5.Text = "Selected players";
			// 
			// CreateNewGame
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DodgerBlue;
			ClientSize = new Size(800, 450);
			Controls.Add(label5);
			Controls.Add(AddPlayersButton);
			Controls.Add(SelectedListBox);
			Controls.Add(StartGameButton);
			Controls.Add(GotoAddNewPlayerFormButton);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(backButton);
			Controls.Add(playerSelect);
			Controls.Add(label1);
			Controls.Add(PhaseName);
			ForeColor = Color.White;
			Name = "CreateNewGame";
			Text = "CreateNewGame";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label PhaseName;
		private Label label1;
		private CheckedListBox playerSelect;
		private Button backButton;
		private Label label2;
		private Label label3;
		private Label label4;
		private Button GotoAddNewPlayerFormButton;
		private Button StartGameButton;
		private ListBox SelectedListBox;
		private Button AddPlayersButton;
		private Label label5;
	}
}