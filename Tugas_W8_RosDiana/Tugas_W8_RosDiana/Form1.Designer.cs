namespace Tugas_W8_RosDiana
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PlayerData = new System.Windows.Forms.ToolStripMenuItem();
            this.showMatchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_team = new System.Windows.Forms.ComboBox();
            this.comboBox_Player = new System.Windows.Forms.ComboBox();
            this.dataGridViewPlayerData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelJumlahOwenGol = new System.Windows.Forms.Label();
            this.labelJumlahPenaltiGagal = new System.Windows.Forms.Label();
            this.labelJumlahPenalti = new System.Windows.Forms.Label();
            this.labelJumlahGol = new System.Windows.Forms.Label();
            this.labelKartuMerah = new System.Windows.Forms.Label();
            this.labelKartuKuning = new System.Windows.Forms.Label();
            this.labelNomorPunggung = new System.Windows.Forms.Label();
            this.labelPosisiPemain = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelTeam = new System.Windows.Forms.Label();
            this.labelnama = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayerData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayerData,
            this.showMatchDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PlayerData
            // 
            this.PlayerData.Name = "PlayerData";
            this.PlayerData.Size = new System.Drawing.Size(117, 29);
            this.PlayerData.Text = "Player Data";
            this.PlayerData.Click += new System.EventHandler(this.PlayerData_Click);
            // 
            // showMatchDetailsToolStripMenuItem
            // 
            this.showMatchDetailsToolStripMenuItem.Name = "showMatchDetailsToolStripMenuItem";
            this.showMatchDetailsToolStripMenuItem.Size = new System.Drawing.Size(184, 29);
            this.showMatchDetailsToolStripMenuItem.Text = "Show Match Details";
            this.showMatchDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMatchDetailsToolStripMenuItem_Click);
            // 
            // comboBox_team
            // 
            this.comboBox_team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_team.FormattingEnabled = true;
            this.comboBox_team.Location = new System.Drawing.Point(99, 53);
            this.comboBox_team.Name = "comboBox_team";
            this.comboBox_team.Size = new System.Drawing.Size(147, 28);
            this.comboBox_team.TabIndex = 1;
            this.comboBox_team.SelectedIndexChanged += new System.EventHandler(this.comboBox_team_SelectedIndexChanged);
            // 
            // comboBox_Player
            // 
            this.comboBox_Player.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Player.FormattingEnabled = true;
            this.comboBox_Player.Location = new System.Drawing.Point(352, 53);
            this.comboBox_Player.Name = "comboBox_Player";
            this.comboBox_Player.Size = new System.Drawing.Size(147, 28);
            this.comboBox_Player.TabIndex = 2;
            this.comboBox_Player.SelectedIndexChanged += new System.EventHandler(this.comboBox_Player_SelectedIndexChanged);
            // 
            // dataGridViewPlayerData
            // 
            this.dataGridViewPlayerData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPlayerData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPlayerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayerData.Location = new System.Drawing.Point(0, 100);
            this.dataGridViewPlayerData.Name = "dataGridViewPlayerData";
            this.dataGridViewPlayerData.RowHeadersVisible = false;
            this.dataGridViewPlayerData.RowHeadersWidth = 62;
            this.dataGridViewPlayerData.RowTemplate.Height = 28;
            this.dataGridViewPlayerData.Size = new System.Drawing.Size(499, 347);
            this.dataGridViewPlayerData.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelJumlahOwenGol);
            this.panel1.Controls.Add(this.labelJumlahPenaltiGagal);
            this.panel1.Controls.Add(this.labelJumlahPenalti);
            this.panel1.Controls.Add(this.labelJumlahGol);
            this.panel1.Controls.Add(this.labelKartuMerah);
            this.panel1.Controls.Add(this.labelKartuKuning);
            this.panel1.Controls.Add(this.labelNomorPunggung);
            this.panel1.Controls.Add(this.labelPosisiPemain);
            this.panel1.Controls.Add(this.labelNationality);
            this.panel1.Controls.Add(this.labelTeam);
            this.panel1.Controls.Add(this.labelnama);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(505, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 347);
            this.panel1.TabIndex = 6;
            // 
            // labelJumlahOwenGol
            // 
            this.labelJumlahOwenGol.AutoSize = true;
            this.labelJumlahOwenGol.Location = new System.Drawing.Point(255, 274);
            this.labelJumlahOwenGol.Name = "labelJumlahOwenGol";
            this.labelJumlahOwenGol.Size = new System.Drawing.Size(28, 20);
            this.labelJumlahOwenGol.TabIndex = 21;
            this.labelJumlahOwenGol.Text = "--- ";
            // 
            // labelJumlahPenaltiGagal
            // 
            this.labelJumlahPenaltiGagal.AutoSize = true;
            this.labelJumlahPenaltiGagal.Location = new System.Drawing.Point(259, 240);
            this.labelJumlahPenaltiGagal.Name = "labelJumlahPenaltiGagal";
            this.labelJumlahPenaltiGagal.Size = new System.Drawing.Size(24, 20);
            this.labelJumlahPenaltiGagal.TabIndex = 20;
            this.labelJumlahPenaltiGagal.Text = "---";
            // 
            // labelJumlahPenalti
            // 
            this.labelJumlahPenalti.AutoSize = true;
            this.labelJumlahPenalti.Location = new System.Drawing.Point(259, 208);
            this.labelJumlahPenalti.Name = "labelJumlahPenalti";
            this.labelJumlahPenalti.Size = new System.Drawing.Size(24, 20);
            this.labelJumlahPenalti.TabIndex = 19;
            this.labelJumlahPenalti.Text = "---";
            // 
            // labelJumlahGol
            // 
            this.labelJumlahGol.AutoSize = true;
            this.labelJumlahGol.Location = new System.Drawing.Point(72, 274);
            this.labelJumlahGol.Name = "labelJumlahGol";
            this.labelJumlahGol.Size = new System.Drawing.Size(24, 20);
            this.labelJumlahGol.TabIndex = 18;
            this.labelJumlahGol.Text = "---";
            // 
            // labelKartuMerah
            // 
            this.labelKartuMerah.AutoSize = true;
            this.labelKartuMerah.Location = new System.Drawing.Point(106, 240);
            this.labelKartuMerah.Name = "labelKartuMerah";
            this.labelKartuMerah.Size = new System.Drawing.Size(24, 20);
            this.labelKartuMerah.TabIndex = 17;
            this.labelKartuMerah.Text = "---";
            // 
            // labelKartuKuning
            // 
            this.labelKartuKuning.AutoSize = true;
            this.labelKartuKuning.Location = new System.Drawing.Point(116, 208);
            this.labelKartuKuning.Name = "labelKartuKuning";
            this.labelKartuKuning.Size = new System.Drawing.Size(24, 20);
            this.labelKartuKuning.TabIndex = 16;
            this.labelKartuKuning.Text = "---";
            // 
            // labelNomorPunggung
            // 
            this.labelNomorPunggung.AutoSize = true;
            this.labelNomorPunggung.Location = new System.Drawing.Point(161, 170);
            this.labelNomorPunggung.Name = "labelNomorPunggung";
            this.labelNomorPunggung.Size = new System.Drawing.Size(0, 20);
            this.labelNomorPunggung.TabIndex = 15;
            // 
            // labelPosisiPemain
            // 
            this.labelPosisiPemain.AutoSize = true;
            this.labelPosisiPemain.Location = new System.Drawing.Point(161, 134);
            this.labelPosisiPemain.Name = "labelPosisiPemain";
            this.labelPosisiPemain.Size = new System.Drawing.Size(0, 20);
            this.labelPosisiPemain.TabIndex = 14;
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(161, 97);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(0, 20);
            this.labelNationality.TabIndex = 13;
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Location = new System.Drawing.Point(161, 57);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(0, 20);
            this.labelTeam.TabIndex = 12;
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Location = new System.Drawing.Point(161, 20);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(0, 20);
            this.labelnama.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(146, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Owen Goal :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(146, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Goal Penalty :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Penalty Miss :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Goal :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Red Card :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Yellow Card :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Squad Number  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Playing Pos :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nationality :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Team :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nama :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPlayerData);
            this.Controls.Add(this.comboBox_Player);
            this.Controls.Add(this.comboBox_team);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayerData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PlayerData;
        private System.Windows.Forms.ToolStripMenuItem showMatchDetailsToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_team;
        private System.Windows.Forms.ComboBox comboBox_Player;
        private System.Windows.Forms.DataGridView dataGridViewPlayerData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelJumlahOwenGol;
        private System.Windows.Forms.Label labelJumlahPenaltiGagal;
        private System.Windows.Forms.Label labelJumlahPenalti;
        private System.Windows.Forms.Label labelJumlahGol;
        private System.Windows.Forms.Label labelKartuMerah;
        private System.Windows.Forms.Label labelKartuKuning;
        private System.Windows.Forms.Label labelNomorPunggung;
        private System.Windows.Forms.Label labelPosisiPemain;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label labelnama;
    }
}

