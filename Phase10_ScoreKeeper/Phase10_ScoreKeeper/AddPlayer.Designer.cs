namespace Phase10_ScoreKeeper.Forms
{
	partial class AddPlayer
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
			backButton = new Button();
			label2 = new Label();
			label4 = new Label();
			CurrentPlayersListBox = new ListBox();
			EmailTextBox = new TextBox();
			AddNewPlayerButton = new Button();
			FullNameTextBox = new TextBox();
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
			PhaseName.TabIndex = 2;
			PhaseName.Text = "Phase 10";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Italic);
			label1.ForeColor = Color.White;
			label1.Location = new Point(281, 105);
			label1.Name = "label1";
			label1.Size = new Size(231, 37);
			label1.TabIndex = 3;
			label1.Text = "Add New Player";
			// 
			// backButton
			// 
			backButton.BackColor = Color.White;
			backButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			backButton.ForeColor = Color.Black;
			backButton.Location = new Point(12, 12);
			backButton.Name = "backButton";
			backButton.Size = new Size(83, 32);
			backButton.TabIndex = 5;
			backButton.Text = "Menu";
			backButton.UseVisualStyleBackColor = false;
			backButton.Click += backButton_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.Location = new Point(316, 226);
			label2.Name = "label2";
			label2.Size = new Size(92, 21);
			label2.TabIndex = 6;
			label2.Text = "Full Name:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label4.Location = new Point(316, 286);
			label4.Name = "label4";
			label4.Size = new Size(57, 21);
			label4.TabIndex = 8;
			label4.Text = "Email:";
			// 
			// CurrentPlayersListBox
			// 
			CurrentPlayersListBox.BackColor = SystemColors.HotTrack;
			CurrentPlayersListBox.ForeColor = Color.White;
			CurrentPlayersListBox.FormattingEnabled = true;
			CurrentPlayersListBox.ItemHeight = 15;
			CurrentPlayersListBox.Location = new Point(23, 178);
			CurrentPlayersListBox.Name = "CurrentPlayersListBox";
			CurrentPlayersListBox.Size = new Size(214, 244);
			CurrentPlayersListBox.TabIndex = 9;
			CurrentPlayersListBox.SelectedIndexChanged += CurrentPlayersListBox_SelectedIndexChanged;
			// 
			// EmailTextBox
			// 
			EmailTextBox.Location = new Point(464, 288);
			EmailTextBox.Name = "EmailTextBox";
			EmailTextBox.Size = new Size(191, 23);
			EmailTextBox.TabIndex = 12;
			EmailTextBox.TextChanged += EmailTextBox_TextChanged;
			// 
			// AddNewPlayerButton
			// 
			AddNewPlayerButton.BackColor = Color.White;
			AddNewPlayerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			AddNewPlayerButton.ForeColor = Color.Black;
			AddNewPlayerButton.Location = new Point(398, 364);
			AddNewPlayerButton.Name = "AddNewPlayerButton";
			AddNewPlayerButton.Size = new Size(177, 33);
			AddNewPlayerButton.TabIndex = 13;
			AddNewPlayerButton.Text = "Add New Player";
			AddNewPlayerButton.UseVisualStyleBackColor = false;
			AddNewPlayerButton.Click += AddNewPlayerButton_Click;
			// 
			// FullNameTextBox
			// 
			FullNameTextBox.Location = new Point(464, 228);
			FullNameTextBox.Name = "FullNameTextBox";
			FullNameTextBox.Size = new Size(191, 23);
			FullNameTextBox.TabIndex = 14;
			// 
			// AddPlayer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DodgerBlue;
			ClientSize = new Size(800, 450);
			Controls.Add(FullNameTextBox);
			Controls.Add(AddNewPlayerButton);
			Controls.Add(EmailTextBox);
			Controls.Add(CurrentPlayersListBox);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(backButton);
			Controls.Add(label1);
			Controls.Add(PhaseName);
			ForeColor = Color.White;
			Name = "AddPlayer";
			Text = "AddPlayer";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label PhaseName;
		private Label label1;
		private Button backButton;
		private Label label2;
		private Label label3;
		private Label label4;
		private ListBox CurrentPlayersListBox;

		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox EmailTextBox;
		private Button AddNewPlayerButton;
		private TextBox FullNameTextBox;
	}
}