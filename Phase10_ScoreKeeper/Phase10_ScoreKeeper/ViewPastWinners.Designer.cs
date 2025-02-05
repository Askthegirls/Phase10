namespace Phase10_ScoreKeeper.Forms
{
	partial class ViewPastWinners
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
			WinnerListBox = new ListBox();
			WinnersNameListBox = new ListBox();
			WinsListBox = new ListBox();
			label2 = new Label();
			label3 = new Label();
			SuspendLayout();
			// 
			// PhaseName
			// 
			PhaseName.AutoSize = true;
			PhaseName.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold | FontStyle.Italic);
			PhaseName.ForeColor = Color.White;
			PhaseName.Location = new Point(276, 19);
			PhaseName.Name = "PhaseName";
			PhaseName.Size = new Size(263, 72);
			PhaseName.TabIndex = 2;
			PhaseName.Text = "Phase 10";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold | FontStyle.Italic);
			label1.ForeColor = Color.White;
			label1.Location = new Point(206, 81);
			label1.Name = "label1";
			label1.Size = new Size(406, 46);
			label1.TabIndex = 3;
			label1.Text = "Past Phase 10 Winners!";
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
			backButton.Text = "Back";
			backButton.UseVisualStyleBackColor = false;
			backButton.Click += backButton_Click;
			// 
			// WinnerListBox
			// 
			WinnerListBox.BackColor = Color.DodgerBlue;
			WinnerListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			WinnerListBox.ForeColor = Color.White;
			WinnerListBox.FormattingEnabled = true;
			WinnerListBox.ItemHeight = 25;
			WinnerListBox.Location = new Point(276, 166);
			WinnerListBox.Name = "WinnerListBox";
			WinnerListBox.Size = new Size(263, 254);
			WinnerListBox.TabIndex = 6;
			WinnerListBox.SelectedIndexChanged += WinnerListBox_SelectedIndexChanged;
			// 
			// WinnersNameListBox
			// 
			WinnersNameListBox.BackColor = Color.DodgerBlue;
			WinnersNameListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			WinnersNameListBox.ForeColor = Color.White;
			WinnersNameListBox.FormattingEnabled = true;
			WinnersNameListBox.ItemHeight = 25;
			WinnersNameListBox.Location = new Point(279, 188);
			WinnersNameListBox.Name = "WinnersNameListBox";
			WinnersNameListBox.Size = new Size(181, 229);
			WinnersNameListBox.TabIndex = 7;
			WinnersNameListBox.SelectedIndexChanged += WinnersNameListBox_SelectedIndexChanged;
			// 
			// WinsListBox
			// 
			WinsListBox.BackColor = Color.DodgerBlue;
			WinsListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			WinsListBox.ForeColor = Color.White;
			WinsListBox.FormattingEnabled = true;
			WinsListBox.ItemHeight = 25;
			WinsListBox.Location = new Point(460, 188);
			WinsListBox.Name = "WinsListBox";
			WinsListBox.Size = new Size(76, 229);
			WinsListBox.TabIndex = 8;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			label2.Location = new Point(284, 170);
			label2.Name = "label2";
			label2.Size = new Size(49, 19);
			label2.TabIndex = 9;
			label2.Text = "Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			label3.Location = new Point(459, 170);
			label3.Name = "label3";
			label3.Size = new Size(78, 19);
			label3.TabIndex = 10;
			label3.Text = "Total Wins";
			// 
			// ViewPastWinners
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DodgerBlue;
			ClientSize = new Size(800, 450);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(WinsListBox);
			Controls.Add(WinnersNameListBox);
			Controls.Add(WinnerListBox);
			Controls.Add(backButton);
			Controls.Add(label1);
			Controls.Add(PhaseName);
			ForeColor = Color.White;
			Name = "ViewPastWinners";
			Text = "ViewPastWinners";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label PhaseName;
		private Label label1;
		private Button backButton;
		private ListBox WinnerListBox;
		private ListBox WinnersNameListBox;
		private ListBox WinsListBox;
		private Label label2;
		private Label label3;
	}
}



































//Program by Sarah K Johnson 11-27-24 sarahkristinej@outlook.com