using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Project_UAS
{
    public partial class DashboardDosen : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");
        public DashboardDosen(string nid, string nama)
        {
            InitializeComponent();
            this.lbl_dosen.Text = nid.ToString();
            /*connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT nama_dosen FROM tbl_dosen WHERE id_dosen = '"+lbl_dosen.Text+"'";
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbl_nama_dosen.Text= reader[0].ToString();
            }*/
            this.lbl_nama_dosen.Text = nama;
        }

        private void btn_jadwal_Click(object sender, EventArgs e)
        {

            JadwalDosen jadwaldosen = new JadwalDosen(lbl_dosen.Text, lbl_nama_dosen.Text);
            this.Hide();
            jadwaldosen.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_absen_Click(object sender, EventArgs e)
        {
            AbsenPerkuliahan absenperkuliahan = new AbsenPerkuliahan(lbl_dosen.Text, lbl_nama_dosen.Text);
            this.Hide();
            absenperkuliahan.Show();
        }

        private void btn_inputNilai_Click(object sender, EventArgs e)
        {
            InputNilai inputnilai = new InputNilai(lbl_dosen.Text, lbl_nama_dosen.Text);
            this.Hide();
            inputnilai.Show();
        }

        private void DashboardDosen_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin formlogin = new FormLogin();
            formlogin.Show();
        }
    }
}
