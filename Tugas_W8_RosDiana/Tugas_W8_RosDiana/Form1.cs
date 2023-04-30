using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tugas_W8_RosDiana
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection();
        MySqlCommand sqlCommand = new MySqlCommand();
        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter();
        string connectionString;
        string sqlQuery;
        DataTable dtTeamName = new DataTable();
        DataTable dtpemain = new DataTable();
        DataTable dttampil = new DataTable();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=Ros1311;database=premier_league";
            sqlConnect = new MySqlConnection(connectionString);

        }
        private void PlayerData_Click(object sender, EventArgs e)
        {
            sqlQuery = "SELECT team_name as `Team Name` FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamName);
            comboBox_team.DataSource = dtTeamName;
            comboBox_team.ValueMember = "Team Name";
            comboBox_team.DisplayMember = "Team Name";
        }
        private void comboBox_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            // Kosongkan ComboBox player
            comboBox_Player.Items.Clear();

            // Ambil nama tim yang dipilih
            string selectedTeam = comboBox_team.SelectedValue.ToString();

            // Buat query SQL untuk mengambil data pemain yang bermain untuk tim tersebut
            sqlQuery = "SELECT p.player_name as `Player Name` FROM player p INNER JOIN team t " +
                     "ON t.team_id = p.team_id WHERE t.team_name = '" + selectedTeam + "'";

            // Eksekusi query SQL dan isi data pemain ke dalam DataTable dtpemain
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            dtpemain.Clear(); // Bersihkan data sebelum diisi yang baru
            sqlAdapter.Fill(dtpemain);

            // Tambahkan data pemain baru ke dalam ComboBox player
            foreach (DataRow row in dtpemain.Rows)
            {
                comboBox_Player.Items.Add(row["Player Name"].ToString());
            }

            // Tampilkan ComboBox player
            comboBox_Player.Visible = true;


        }


        private void showMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMatchDetails matchDetails = new ShowMatchDetails();

            matchDetails.Show();
        }

    
        private void comboBox_Player_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Ambil pemain yang dipilih
            string selectedPlayer = comboBox_Player.SelectedItem.ToString();

            // Buat query SQL untuk mengambil detail pemain dan pertandingannya
            sqlQuery = "SELECT p.player_name as 'Nama', t.team_name as 'Team', n.nation as 'nationality', p.playing_pos as 'playing pos', p.team_number as 'squad number'," +
                        "COALESCE(SUM(CASE WHEN d.type = 'CY' THEN 1 ELSE 0 END), 0) as 'Yellow Card'," +
                        "COALESCE(SUM(CASE WHEN d.type = 'CR' THEN 1 ELSE 0 END), 0) as 'Red Card'," +
                        "COALESCE(SUM(CASE WHEN d.type = 'GO' THEN 1 ELSE 0 END), 0) as 'Goal'," +
                        "COALESCE(SUM(CASE WHEN d.type = 'GP' THEN 1 ELSE 0 END), 0) as 'Goal Penalty'," +
                        "COALESCE(SUM(CASE WHEN d.type = 'PM' THEN 1 ELSE 0 END), 0) as 'Penalty Miss'," +
                        "COALESCE(SUM(CASE WHEN d.type = 'GW' THEN 1 ELSE 0 END), 0) as 'Owen Goal'" +
                        " FROM player p " +
                        " INNER JOIN nationality n ON p.nationality_id = n.nationality_id " +
                        " INNER JOIN team t ON t.team_id = p.team_id " +
                        " LEFT JOIN dmatch d ON p.player_id = d.player_id " +
                        " WHERE p.player_name = '" + selectedPlayer + "' " +
                        " GROUP BY 1, 2, 3, 4, 5";

            // Eksekusi query SQL dan isi data ke dalam DataTable
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            dttampil.Clear(); // Bersihkan data sebelum diisi yang baru
            sqlAdapter.Fill(dttampil);

            // Set DataTable sebagai DataSource dari DataGridView
            dataGridViewPlayerData.DataSource = dttampil;

            // Tampilkan data player di dalam label
            labelnama.Text = dttampil.Rows[0]["Nama"].ToString();
            labelTeam.Text = dttampil.Rows[0]["Team"].ToString();
            labelNationality.Text = dttampil.Rows[0]["nationality"].ToString();
            labelPosisiPemain.Text = dttampil.Rows[0]["playing pos"].ToString();
            labelNomorPunggung.Text = dttampil.Rows[0]["squad number"].ToString();
            labelKartuKuning.Text = dttampil.Rows[0]["Yellow Card"].ToString();
            labelKartuMerah.Text = dttampil.Rows[0]["Red Card"].ToString();
            labelJumlahGol.Text = dttampil.Rows[0]["Goal"].ToString();
            labelJumlahPenalti.Text = dttampil.Rows[0]["Goal Penalty"].ToString();
            labelJumlahPenaltiGagal.Text = dttampil.Rows[0]["Penalty Miss"].ToString();
            labelJumlahOwenGol.Text = dttampil.Rows[0]["Owen Goal"].ToString();

        }
    }
}
