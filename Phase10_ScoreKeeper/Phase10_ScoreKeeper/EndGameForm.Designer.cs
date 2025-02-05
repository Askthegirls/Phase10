namespace Phase10_ScoreKeeper
{
	partial class EndGameForm
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
			label1 = new Label();
			PhaseName = new Label();
			WinnerNameLabel = new Label();
			label3 = new Label();
			label4 = new Label();
			WinsLabel = new Label();
			MenuButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Italic);
			label1.ForeColor = Color.White;
			label1.Location = new Point(295, 114);
			label1.Name = "label1";
			label1.Size = new Size(188, 37);
			label1.TabIndex = 6;
			label1.Text = "Score Keeper";
			// 
			// PhaseName
			// 
			PhaseName.AutoSize = true;
			PhaseName.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			PhaseName.ForeColor = Color.White;
			PhaseName.Location = new Point(162, 9);
			PhaseName.Name = "PhaseName";
			PhaseName.Size = new Size(468, 128);
			PhaseName.TabIndex = 5;
			PhaseName.Text = "Phase 10";
			// 
			// WinnerNameLabel
			// 
			WinnerNameLabel.AutoSize = true;
			WinnerNameLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
			WinnerNameLabel.ForeColor = SystemColors.ButtonHighlight;
			WinnerNameLabel.Location = new Point(321, 196);
			WinnerNameLabel.Name = "WinnerNameLabel";
			WinnerNameLabel.Size = new Size(147, 41);
			WinnerNameLabel.TabIndex = 7;
			WinnerNameLabel.Text = "<Player>";
			WinnerNameLabel.Click += WinnerNameLabel_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
			label3.ForeColor = SystemColors.ButtonHighlight;
			label3.Location = new Point(306, 273);
			label3.Name = "label3";
			label3.Size = new Size(169, 32);
			label3.TabIndex = 8;
			label3.Text = "is the winner!";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			label4.ForeColor = SystemColors.ButtonHighlight;
			label4.Location = new Point(302, 346);
			label4.Name = "label4";
			label4.Size = new Size(123, 30);
			label4.TabIndex = 9;
			label4.Text = "Total wins:";
			// 
			// WinsLabel
			// 
			WinsLabel.AutoSize = true;
			WinsLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			WinsLabel.ForeColor = SystemColors.ButtonHighlight;
			WinsLabel.Location = new Point(449, 346);
			WinsLabel.Name = "WinsLabel";
			WinsLabel.Size = new Size(26, 30);
			WinsLabel.TabIndex = 10;
			WinsLabel.Text = "#";
			// 
			// MenuButton
			// 
			MenuButton.BackColor = Color.White;
			MenuButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			MenuButton.ForeColor = Color.Black;
			MenuButton.Location = new Point(12, 12);
			MenuButton.Name = "MenuButton";
			MenuButton.Size = new Size(83, 32);
			MenuButton.TabIndex = 11;
			MenuButton.Text = "Menu";
			MenuButton.UseVisualStyleBackColor = false;
			MenuButton.Click += MenuButton_Click;
			// 
			// EndGameForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DodgerBlue;
			ClientSize = new Size(800, 450);
			Controls.Add(MenuButton);
			Controls.Add(WinsLabel);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(WinnerNameLabel);
			Controls.Add(label1);
			Controls.Add(PhaseName);
			Name = "EndGameForm";
			Text = "EndGameForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label PhaseName;
		private Label WinnerNameLabel;
		private Label label3;
		private Label label4;
		private Label WinsLabel;
		private Button MenuButton;
	}
}