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
    public partial class DashboardMhs : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");
        
        public DashboardMhs(string nim, string nama)
        {
            InitializeComponent();
            this.lbl_nim.Text = nim.ToString();
            /*connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT nama_mhs FROM tbl_mhs WHERE id_mhs = '" + lbl_nim.Text + "'";
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbl_nama.Text = reader[0].ToString();
            }*/
            this.lbl_nama.Text = nama.ToString();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            //FormLogin formlogin = new FormLogin();
            this.Close();
            //formlogin.Show();
        }

        private void btn_jadwal_Click(object sender, EventArgs e)
        {
            JadwalMhs jadwalmhs = new JadwalMhs(lbl_nim.Text, lbl_nama.Text);
            this.Hide();
            jadwalmhs.Show();
        }

        private void btn_absen_Click(object sender, EventArgs e)
        {
            AbsensiMhs absensimhs = new AbsensiMhs(lbl_nim.Text, lbl_nama.Text);
            this.Hide();
            absensimhs.Show();
        }

        private void btn_nilaiMatkul_Click(object sender, EventArgs e)
        {
            MhsNilai mhsnilai = new MhsNilai(lbl_nim.Text, lbl_nama.Text);
            this.Hide();
            mhsnilai.Show();
        }

        private void DashboardMhs_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin formlogin = new FormLogin();
            formlogin.Show();
        }
    }
}
