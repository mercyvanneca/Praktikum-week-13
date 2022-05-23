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

namespace Praktikum_week_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPemain_premiere = new DataTable();
        int PosisiSekarang = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT p.player_id, p.player_name, p.birthdate, n.nation AS 'Nationality', t.team_name AS 'Team Member', p.team_number FROM player p LEFT JOIN nationality n ON p.nationality_id = n.nationality_id LEFT JOIN team t ON p.team_id = t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain_premiere);
            IsiDataPemain(0);
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            sqlQuery = "UPDATE player SET player_name = '" + Txt_PlayerName.Text + "',  birthdate = '" + DT_DateTime.Text + "', nationality_id = '" + CB_Nationality.Text + "', team_id = '" + CB_Team.Text + "', team_number = '" + NUD_TeamN.Text + "' WHERE player_id = '" + Txt_PlayerID.Text + "';'";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }

        public void IsiDataPemain(int Posisi)
        {

            Txt_PlayerID.Text = dtPemain_premiere.Rows[Posisi][0].ToString();
            Txt_PlayerName.Text = dtPemain_premiere.Rows[Posisi][1].ToString();
            DT_DateTime.Text = dtPemain_premiere.Rows[Posisi][2].ToString();
            CB_Nationality.DataSource = dtPemain_premiere; 
            CB_Nationality.DisplayMember = "Nationality";

            CB_Nationality.Text = dtPemain_premiere.Rows[Posisi][3].ToString();

            CB_Team.DataSource = dtPemain_premiere; 
            CB_Team.DisplayMember = "Team Member";
            CB_Team.Text = dtPemain_premiere.Rows[Posisi][4].ToString();
            NUD_TeamN.Text = dtPemain_premiere.Rows[Posisi][5].ToString();
            PosisiSekarang = Posisi;
        }


        private void Btn_First_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void Btn_Prev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtPemain_premiere.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void Btn_Last_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtPemain_premiere.Rows.Count - 1);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
