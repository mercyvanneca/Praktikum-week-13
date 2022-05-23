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
        DataTable dtnation = new DataTable();
        DataTable dtteam = new DataTable();
        int PosisiSekarang = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select p.player_id, p.player_name, P.birthdate, n.nation, t.team_name, team_number from player p, nationality n, team t where p.nationality_id = n.nationality_id and p.team_id = t.team_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain_premiere);
            //DT_DateTime.CustomFormat = "yyyy, MMMM dd, dddd";
            // DT_DateTime.Format = DateTimePickerFormat.Custom;

            sqlQuery = "select nationality_id as 'ID', nation as 'Nation' from nationality;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtnation);
            CB_Nationality.DataSource = dtnation;
            CB_Nationality.DisplayMember = "Nation";
            CB_Nationality.ValueMember = "ID";

            sqlQuery = "select t.team_id as 'ID Tim', t.team_name as 'Team Member' from team t;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtteam);
            CB_Team.DataSource = dtteam;
            CB_Team.DisplayMember = "Nama Tim";
            CB_Team.ValueMember = "ID Tim";

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
            CB_Nationality.DataSource = dtnation;
            CB_Nationality.DisplayMember = "Nation";
            CB_Nationality.ValueMember = "ID";
            Lbl_NotAvailable.Text = dtPemain_premiere.Rows[Posisi].ToString();
            CB_Nationality.Text = dtPemain_premiere.Rows[Posisi][3].ToString();

            CB_Team.DataSource = dtteam;
            CB_Team.DisplayMember = "Nama Tim";
            CB_Team.ValueMember = "ID Tim";
            CB_Team.Text = dtPemain_premiere.Rows[Posisi][4].ToString();
            NUD_TeamN.Text = dtPemain_premiere.Rows[Posisi][5].ToString();
            //PosisiSekarang = Posisi;
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
