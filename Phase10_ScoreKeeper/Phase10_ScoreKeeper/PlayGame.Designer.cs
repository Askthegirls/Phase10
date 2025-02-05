namespace Phase10_ScoreKeeper.Forms
{
	partial class PlayGame
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
			MenuButton = new Button();
			label2 = new Label();
			PhaseCheckBox = new CheckBox();
			ScoreTextBox = new TextBox();
			groupBox2 = new GroupBox();
			ScoreListBox = new ListBox();
			PhaseListBox = new ListBox();
			label25 = new Label();
			label23 = new Label();
			label24 = new Label();
			ScoreboardListBox = new ListBox();
			listBox1 = new ListBox();
			groupBox3 = new GroupBox();
			label13 = new Label();
			label14 = new Label();
			label15 = new Label();
			label16 = new Label();
			label17 = new Label();
			label18 = new Label();
			label19 = new Label();
			label20 = new Label();
			label21 = new Label();
			label22 = new Label();
			label12 = new Label();
			label11 = new Label();
			label10 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			listView1 = new ListView();
			SaveScoreButton = new Button();
			FullNameLabel = new Label();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// PhaseName
			// 
			PhaseName.AutoSize = true;
			PhaseName.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold | FontStyle.Italic);
			PhaseName.ForeColor = Color.White;
			PhaseName.Location = new Point(261, 42);
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
			label1.Location = new Point(296, 100);
			label1.Name = "label1";
			label1.Size = new Size(188, 37);
			label1.TabIndex = 3;
			label1.Text = "Score Keeper";
			// 
			// MenuButton
			// 
			MenuButton.BackColor = Color.White;
			MenuButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			MenuButton.ForeColor = Color.Black;
			MenuButton.Location = new Point(12, 12);
			MenuButton.Name = "MenuButton";
			MenuButton.Size = new Size(83, 32);
			MenuButton.TabIndex = 5;
			MenuButton.Text = "Menu";
			MenuButton.UseVisualStyleBackColor = false;
			MenuButton.Click += quitButton_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(302, 254);
			label2.Name = "label2";
			label2.Size = new Size(77, 15);
			label2.TabIndex = 9;
			label2.Text = "Round Score:";
			// 
			// PhaseCheckBox
			// 
			PhaseCheckBox.AutoSize = true;
			PhaseCheckBox.Location = new Point(339, 297);
			PhaseCheckBox.Name = "PhaseCheckBox";
			PhaseCheckBox.Size = new Size(112, 19);
			PhaseCheckBox.TabIndex = 12;
			PhaseCheckBox.Text = "Phase Complete";
			PhaseCheckBox.UseVisualStyleBackColor = true;
			// 
			// ScoreTextBox
			// 
			ScoreTextBox.Location = new Point(385, 251);
			ScoreTextBox.Name = "ScoreTextBox";
			ScoreTextBox.Size = new Size(100, 23);
			ScoreTextBox.TabIndex = 13;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(ScoreListBox);
			groupBox2.Controls.Add(PhaseListBox);
			groupBox2.Controls.Add(label25);
			groupBox2.Controls.Add(label23);
			groupBox2.Controls.Add(label24);
			groupBox2.Controls.Add(ScoreboardListBox);
			groupBox2.Controls.Add(listBox1);
			groupBox2.Location = new Point(26, 151);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(264, 266);
			groupBox2.TabIndex = 13;
			groupBox2.TabStop = false;
			groupBox2.Text = "Score Board";
			// 
			// ScoreListBox
			// 
			ScoreListBox.BackColor = SystemColors.HotTrack;
			ScoreListBox.ForeColor = Color.White;
			ScoreListBox.FormattingEnabled = true;
			ScoreListBox.ItemHeight = 15;
			ScoreListBox.Location = new Point(209, 43);
			ScoreListBox.Name = "ScoreListBox";
			ScoreListBox.Size = new Size(49, 214);
			ScoreListBox.TabIndex = 21;
			// 
			// PhaseListBox
			// 
			PhaseListBox.BackColor = SystemColors.HotTrack;
			PhaseListBox.ForeColor = Color.White;
			PhaseListBox.FormattingEnabled = true;
			PhaseListBox.ItemHeight = 15;
			PhaseListBox.Location = new Point(156, 43);
			PhaseListBox.Name = "PhaseListBox";
			PhaseListBox.Size = new Size(53, 214);
			PhaseListBox.TabIndex = 20;
			PhaseListBox.SelectedIndexChanged += PhaseListBox_SelectedIndexChanged;
			// 
			// label25
			// 
			label25.AutoSize = true;
			label25.BackColor = SystemColors.HotTrack;
			label25.Location = new Point(212, 23);
			label25.Name = "label25";
			label25.Size = new Size(36, 15);
			label25.TabIndex = 18;
			label25.Text = "Score";
			// 
			// label23
			// 
			label23.AutoSize = true;
			label23.BackColor = SystemColors.HotTrack;
			label23.Location = new Point(7, 22);
			label23.Name = "label23";
			label23.Size = new Size(39, 15);
			label23.TabIndex = 16;
			label23.Text = "Name";
			// 
			// label24
			// 
			label24.AutoSize = true;
			label24.BackColor = SystemColors.HotTrack;
			label24.Location = new Point(159, 23);
			label24.Name = "label24";
			label24.Size = new Size(38, 15);
			label24.TabIndex = 17;
			label24.Text = "Phase";
			// 
			// ScoreboardListBox
			// 
			ScoreboardListBox.BackColor = SystemColors.HotTrack;
			ScoreboardListBox.ForeColor = Color.White;
			ScoreboardListBox.FormattingEnabled = true;
			ScoreboardListBox.ItemHeight = 15;
			ScoreboardListBox.Location = new Point(7, 43);
			ScoreboardListBox.Margin = new Padding(4, 12, 4, 4);
			ScoreboardListBox.MultiColumn = true;
			ScoreboardListBox.Name = "ScoreboardListBox";
			ScoreboardListBox.Size = new Size(149, 214);
			ScoreboardListBox.TabIndex = 0;
			ScoreboardListBox.SelectedIndexChanged += ScoreboardListBox_SelectedIndexChanged;
			// 
			// listBox1
			// 
			listBox1.BackColor = SystemColors.HotTrack;
			listBox1.ForeColor = Color.White;
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(5, 15);
			listBox1.Margin = new Padding(4, 12, 4, 4);
			listBox1.MultiColumn = true;
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(255, 244);
			listBox1.TabIndex = 19;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(label13);
			groupBox3.Controls.Add(label14);
			groupBox3.Controls.Add(label15);
			groupBox3.Controls.Add(label16);
			groupBox3.Controls.Add(label17);
			groupBox3.Controls.Add(label18);
			groupBox3.Controls.Add(label19);
			groupBox3.Controls.Add(label20);
			groupBox3.Controls.Add(label21);
			groupBox3.Controls.Add(label22);
			groupBox3.Controls.Add(label12);
			groupBox3.Controls.Add(label11);
			groupBox3.Controls.Add(label10);
			groupBox3.Controls.Add(label9);
			groupBox3.Controls.Add(label8);
			groupBox3.Controls.Add(label7);
			groupBox3.Controls.Add(label6);
			groupBox3.Controls.Add(label5);
			groupBox3.Controls.Add(label4);
			groupBox3.Controls.Add(label3);
			groupBox3.Controls.Add(listView1);
			groupBox3.Location = new Point(521, 153);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(256, 260);
			groupBox3.TabIndex = 12;
			groupBox3.TabStop = false;
			groupBox3.Text = "Phases";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.BackColor = SystemColors.HotTrack;
			label13.Font = new Font("Segoe UI", 9F);
			label13.Location = new Point(73, 229);
			label13.Name = "label13";
			label13.Size = new Size(157, 15);
			label13.TabIndex = 33;
			label13.Text = "One set of 5 and one set of 3";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.BackColor = SystemColors.HotTrack;
			label14.Font = new Font("Segoe UI", 9F);
			label14.Location = new Point(73, 207);
			label14.Name = "label14";
			label14.Size = new Size(157, 15);
			label14.TabIndex = 32;
			label14.Text = "One set of 5 and one set of 2";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.BackColor = SystemColors.HotTrack;
			label15.Font = new Font("Segoe UI", 9F);
			label15.Location = new Point(73, 184);
			label15.Name = "label15";
			label15.Size = new Size(164, 15);
			label15.TabIndex = 31;
			label15.Text = "Seven cards of the same color";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.BackColor = SystemColors.HotTrack;
			label16.Font = new Font("Segoe UI", 9F);
			label16.Location = new Point(73, 162);
			label16.Name = "label16";
			label16.Size = new Size(74, 15);
			label16.TabIndex = 30;
			label16.Text = "Two sets of 4";
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.BackColor = SystemColors.HotTrack;
			label17.Font = new Font("Segoe UI", 9F);
			label17.Location = new Point(73, 140);
			label17.Name = "label17";
			label17.Size = new Size(73, 15);
			label17.TabIndex = 29;
			label17.Text = "One run of 9";
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.BackColor = SystemColors.HotTrack;
			label18.Font = new Font("Segoe UI", 9F);
			label18.Location = new Point(73, 117);
			label18.Name = "label18";
			label18.Size = new Size(73, 15);
			label18.TabIndex = 28;
			label18.Text = "One run of 8";
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.BackColor = SystemColors.HotTrack;
			label19.Font = new Font("Segoe UI", 9F);
			label19.Location = new Point(73, 95);
			label19.Name = "label19";
			label19.Size = new Size(73, 15);
			label19.TabIndex = 27;
			label19.Text = "One run of 7";
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.BackColor = SystemColors.HotTrack;
			label20.Font = new Font("Segoe UI", 9F);
			label20.Location = new Point(73, 73);
			label20.Name = "label20";
			label20.Size = new Size(160, 15);
			label20.TabIndex = 26;
			label20.Text = "One set of 4 and one run of 4";
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.BackColor = SystemColors.HotTrack;
			label21.Font = new Font("Segoe UI", 9F);
			label21.Location = new Point(73, 51);
			label21.Name = "label21";
			label21.Size = new Size(160, 15);
			label21.TabIndex = 25;
			label21.Text = "One set of 3 and one run of 4";
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.BackColor = SystemColors.HotTrack;
			label22.Font = new Font("Segoe UI", 9F);
			label22.Location = new Point(73, 30);
			label22.Name = "label22";
			label22.Size = new Size(74, 15);
			label22.TabIndex = 24;
			label22.Text = "Two sets of 3";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.BackColor = SystemColors.HotTrack;
			label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			label12.Location = new Point(14, 229);
			label12.Name = "label12";
			label12.Size = new Size(63, 15);
			label12.TabIndex = 23;
			label12.Text = "Phase 10: ";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.BackColor = SystemColors.HotTrack;
			label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			label11.Location = new Point(14, 207);
			label11.Name = "label11";
			label11.Size = new Size(56, 15);
			label11.TabIndex = 22;
			label11.Text = "Phase 9: ";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = SystemColors.HotTrack;
			label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			label10.Location = new Point(14, 184);
			label10.Name = "label10";
			label10.Size = new Size(56, 15);
			label10.TabIndex = 21;
			label10.Text = "Phase 8: ";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = SystemColors.HotTrack;
			label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			label9.Location = new Point(14, 162);
			label9.Name = "label9";
			label9.Size = new Size(56, 15);
			label9.TabIndex = 20;
			label9.Text = "Phase 7: ";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = SystemColors.HotTrack;
			label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			label8.Location = new Point(14, 140);
			label8.Name = "label8";
			label8.Size = new Size(56, 15);
			label8.TabIndex = 19;
			label8.Text = "Phase 6: ";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = SystemColors.HotTrack;
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			label7.Location = new Point(14, 117);
			label7.Name = "label7";
			label7.Size = new Size(56, 15);
			label7.TabIndex = 18;
			label7.Text = "Phase 5: ";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = SystemColors.HotTrack;
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			label6.Location = new Point(14, 95);
			label6.Name = "label6";
			label6.Size = new Size(56, 15);
			label6.TabIndex = 17;
			label6.Text = "Phase 4: ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = SystemColors.HotTrack;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			label5.Location = new Point(14, 73);
			label5.Name = "label5";
			label5.Size = new Size(56, 15);
			label5.TabIndex = 16;
			label5.Text = "Phase 3: ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = SystemColors.HotTrack;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			label4.Location = new Point(14, 51);
			label4.Name = "label4";
			label4.Size = new Size(56, 15);
			label4.TabIndex = 15;
			label4.Text = "Phase 2: ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = SystemColors.HotTrack;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			label3.Location = new Point(14, 30);
			label3.Name = "label3";
			label3.Size = new Size(56, 15);
			label3.TabIndex = 14;
			label3.Text = "Phase 1: ";
			// 
			// listView1
			// 
			listView1.BackColor = SystemColors.HotTrack;
			listView1.Location = new Point(6, 21);
			listView1.Name = "listView1";
			listView1.Size = new Size(244, 232);
			listView1.TabIndex = 0;
			listView1.UseCompatibleStateImageBehavior = false;
			// 
			// SaveScoreButton
			// 
			SaveScoreButton.BackColor = Color.White;
			SaveScoreButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			SaveScoreButton.ForeColor = Color.Black;
			SaveScoreButton.Location = new Point(354, 334);
			SaveScoreButton.Name = "SaveScoreButton";
			SaveScoreButton.Size = new Size(75, 24);
			SaveScoreButton.TabIndex = 15;
			SaveScoreButton.Text = "Save";
			SaveScoreButton.UseVisualStyleBackColor = false;
			SaveScoreButton.Click += SaveScoreButton_Click;
			// 
			// FullNameLabel
			// 
			FullNameLabel.AutoSize = true;
			FullNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			FullNameLabel.Location = new Point(360, 194);
			FullNameLabel.Name = "FullNameLabel";
			FullNameLabel.Size = new Size(69, 19);
			FullNameLabel.TabIndex = 16;
			FullNameLabel.Text = "<Name>";
			FullNameLabel.Click += FullNameLabel_Click;
			// 
			// PlayGame
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DodgerBlue;
			ClientSize = new Size(800, 450);
			Controls.Add(FullNameLabel);
			Controls.Add(SaveScoreButton);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(ScoreTextBox);
			Controls.Add(PhaseCheckBox);
			Controls.Add(label2);
			Controls.Add(MenuButton);
			Controls.Add(label1);
			Controls.Add(PhaseName);
			ForeColor = Color.White;
			Name = "PlayGame";
			Text = "PlayGame";
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label PhaseName;
		private Label label1;
		private Button MenuButton;
		private Label label2;
		private CheckBox PhaseCheckBox;
		private TextBox ScoreTextBox;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private Label label12;
		private Label label11;
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private ListView listView1;
		private Label label13;
		private Label label14;
		private Label label15;
		private Label label16;
		private Label label17;
		private Label label18;
		private Label label19;
		private Label label20;
		private Label label21;
		private Label label22;
		private ListBox ScoreboardListBox;
		private Button SaveScoreButton;
		private Label label25;
		private Label label23;
		private Label label24;
		private ListBox listBox1;
		private Label FullNameLabel;
		private ListBox ScoreListBox;
		private ListBox PhaseListBox;
	}
}