using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W8_RosDiana
{
    public partial class ShowMatchDetails : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection();
        MySqlCommand sqlCommand = new MySqlCommand();
        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter();
        string connectionString;
        string sqlQuery;
        DataTable dataMatch = new DataTable();
        DataTable dataPlayer = new DataTable();
        DataTable Home = new DataTable();
        DataTable data = new DataTable();
        DataTable tim = new DataTable();
        DataTable help = new DataTable();
        public ShowMatchDetails()
        {
            InitializeComponent();
        }

        private void ShowMatchDetails_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=Ros1311;database=premier_league";
            sqlConnect = new MySqlConnection(connectionString);

            sqlQuery ="select team_id as 'ID', team_name as 'Team' from team;";
            sqlConnect = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(data);
            comboBoxTeamMatch.DataSource = data;
            comboBoxTeamMatch.ValueMember = "ID";
            comboBoxTeamMatch.DisplayMember = "Team";
        }

        private void comboBoxTeamMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            tim = new DataTable();
            sqlQuery = "select p.player_name as 'player name', t.team_name as 'Team name' from player p, team t where p.team_id = t.team_id and t.team_id = '" + comboBoxTeamMatch.ToString() + "';";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(tim);

            dataMatch.Clear();
            dataMatch.Columns.Clear();

            dataMatch = new DataTable();
            sqlQuery = $"select match_id, t1.team_name as 'Team Home', t2.team_name as 'Team Away', t1.team_id, t2.team_id\r\nfrom `match`, team t1, team t2 where `match`.team_home = t1.team_id and `match`.team_away=t2.team_id\r\nand (t1.team_id = '{comboBoxTeamMatch.SelectedValue.ToString()}' or t2.team_id = '{comboBoxTeamMatch.SelectedValue.ToString()}');";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataMatch);

            comboBoxmatchdetail.Items.Clear();

            for (int a = 0; a < dataMatch.Rows.Count; a++)
            {
                string capek = dataMatch.Rows[a][1].ToString();
                string away = dataMatch.Rows[a][2].ToString();
                string gabung = capek + " vs " + away;
                comboBoxmatchdetail.Items.Add(gabung);
            }
        }

        private void comboBoxmatchdetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            Home = new DataTable();
            sqlQuery = $"select t.team_name as 'nama team', p.player_name as 'Player Name' , p.team_number as 'Player Number', p.playing_pos as 'Position' from player p, team t where t.team_id = p.team_id and t.team_id = '{dataMatch.Rows[comboBoxmatchdetail.SelectedIndex][3]}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Home);

            dataPlayer = new DataTable();
            sqlQuery = $"select t.team_name as 'nama team', p.player_name as 'Player Name' , p.team_number as 'Player Number', p.playing_pos as 'Position' from player p, team t where t.team_id = p.team_id and t.team_id = '{dataMatch.Rows[comboBoxmatchdetail.SelectedIndex][4]}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataPlayer);

            dataGridView1.DataSource = Home;
            dataGridView2.DataSource = dataPlayer;

            help = new DataTable();
            sqlQuery = $"select d.`minute` as 'Minute',t.team_name as 'Team Name', p.player_name as 'Player Name', if(d.`type`='go','Goal',if(d.`type`='gw','Own Goal',if(d.`type`='gp','Penalty Goal',if(d.`type`='pm','Penalty Missed',if(d.`type`='cy','Yellow Card','Red Card'))))) as 'Type' from dmatch d, player p, team t where t.team_id = d.team_id and d.player_id = p.player_id and d.match_id = '{dataMatch.Rows[comboBoxmatchdetail.SelectedIndex][0]}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(help);

            dataGridView3.DataSource = help;
        }
    }
}
