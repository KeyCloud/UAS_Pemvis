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
    public partial class AbsenPerkuliahan : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");
        
        public AbsenPerkuliahan(string nid, string nama)
        {
            InitializeComponent();
            this.lbl_nid.Text = nid.ToString();
            this.lbl_nama_dosen.Text = nama.ToString();
            
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT DISTINCT kode_mk FROM tbl_jadwal WHERE id_dosen ='"+lbl_nid.Text+"' ORDER BY kode_mk";
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                comboBox_kodemk.Items.Add(rdr[0].ToString());
            }
            comboBox_kodemk.Text = comboBox_kodemk.Items.IndexOf(0).ToString();
            connection.Close();
            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "SELECT DISTINCT kelas_mk FROM tbl_jadwal WHERE id_dosen ='" + lbl_nid.Text + "'";
            MySqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {
                
                comboBox_kelas.Items.Add(rdr1[0].ToString());

            }
            connection.Close();
               
          
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            string kode = comboBox_kodemk.SelectedItem.ToString();
            string kelas = comboBox_kelas.SelectedItem.ToString();
            
            MySqlDataReader reader = null;
            checkedListBox_nim.Items.Clear();
            listView_absen.Items.Clear();
            listView_absen.Columns.Clear();
            listView_absen.Columns.Add("Kode", 50, HorizontalAlignment.Left);
            listView_absen.Columns.Add("Nim", 100, HorizontalAlignment.Left);
            listView_absen.Columns.Add("Kelas", 50, HorizontalAlignment.Left);
            listView_absen.GridLines = true;
            listView_absen.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            listView_absen.View = View.Details;
            listView_absen.MultiSelect = false;

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT kode_mk , id_mhs , kelas_mk FROM tbl_jadwal WHERE kode_mk='"+kode+"' AND kelas_mk ='"+kelas+"' AND id_dosen='"+lbl_nid.Text+"' ORDER BY id_mhs";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                checkedListBox_nim.Items.Add(reader["id_mhs"].ToString());
                ListViewItem item1 = new ListViewItem(reader["kode_mk"].ToString(), 0);
                item1.SubItems.Add(reader["id_mhs"].ToString());
                item1.SubItems.Add(reader["kelas_mk"].ToString());
                //checkedListBox_nim.Items.Add(item);
                listView_absen.Items.Add(item1);
            }
            connection.Close();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string kode = comboBox_kodemk.SelectedItem.ToString();
            string kelas = comboBox_kelas.SelectedItem.ToString();
            connection.Open();
            foreach (object cek in checkedListBox_nim.CheckedItems)
            {
                string add_query = "INSERT INTO tbl_absen VALUES('" + kode + "','" + kelas + "','" + cek.ToString() + "','" + dateTimePicker_absen.Value.ToString("yyyy-MM-dd") + "')";
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //assign the query using command text
                cmd.CommandText = add_query;
                //assign the connection using Connection
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                //Execute query
            }
            MessageBox.Show("Success saved");

            connection.Close();
            //MessageBox.Show( dateTimePicker_absen.Value.ToString("yyyy-MM-dd"));
            
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbsenPerkuliahan_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashboardDosen dashboarddosen = new DashboardDosen(lbl_nid.Text, lbl_nama_dosen.Text);
            dashboarddosen.Show();
        }
    }
}
