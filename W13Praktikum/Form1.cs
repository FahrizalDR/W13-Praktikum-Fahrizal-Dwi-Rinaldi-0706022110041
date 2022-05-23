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

namespace W13Praktikum
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        String sqlQueryTeamNumber;
        DataTable DTPlayer = new DataTable();
        DataTable DTNationality = new DataTable();
        DataTable DTTeamName = new DataTable();
        int PositionRightNow = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select player.player_id as 'player id', player.player_name, player.birthdate, nationality.nation as 'nation', team.team_name as 'team name', player.team_number from player, nationality, team where player.nationality_id = nationality.nationality_id and player.team_id = team.team_id";            
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(DTPlayer);
            sqlQuery = "select nation, nationality_id as 'nationality id' from nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(DTNationality);
            sqlQuery = "select team_name as 'team name', team_id as 'team id' from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(DTTeamName);

            PlayerData(0);
        }

        public void PlayerData (int position)
        {
            textBoxPlayerID.Text = DTPlayer.Rows[position][0].ToString();
            textBoxName.Text = DTPlayer.Rows[position][1].ToString();
            comboBoxNationality.DataSource = DTNationality;
            comboBoxNationality.DisplayMember = "nation";
            comboBoxNationality.ValueMember = "nationality id";
            comboBoxTeam.DataSource = DTTeamName;
            comboBoxTeam.DisplayMember = "team name";
            comboBoxTeam.ValueMember = "team id";
            PositionRightNow = position;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            PlayerData(0);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (PositionRightNow > 0)
            {
                PositionRightNow--;
                PlayerData(PositionRightNow);
            }
            else
            {
                MessageBox.Show("Data Ini Sudah Data Pertama");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (PositionRightNow < DTPlayer.Rows.Count - 1)
            {
                PositionRightNow++;
                PlayerData(PositionRightNow);
            }
            else
            {
                MessageBox.Show("Data Ini Sudah Data Terakhir");
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            PlayerData(DTPlayer.Rows.Count - 1);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            sqlQuery = "update player set player_name = '" + textBoxName.Text + "', birthdate = '"+dateTimePickerBirthDate.Text+"', nationality_id = '"+comboBoxNationality.Text+"', team_id = '"+comboBoxTeam.Text+"', team_number = '"+numUpDownTeamNumber+"' where player_id = '"+textBoxPlayerID.Text+"'";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data player dengan ID : " + textBoxPlayerID.Text + " sudah di update");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
