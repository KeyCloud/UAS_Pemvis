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
    public partial class InputNilai : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");
        
        public InputNilai(string nid, string nama)
        {
            
            InitializeComponent();
            this.lbl_nid.Text = nid.ToString();
            this.lbl_nama_dosen.Text = nama.ToString();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT DISTINCT id_mhs FROM tbl_jadwal WHERE id_dosen='"+lbl_nid.Text+"' ORDER BY id_mhs";
            
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                comboBox_nim.Items.Add(rdr[0].ToString());

            }
            connection.Close();

            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "SELECT DISTINCT kode_mk FROM tbl_jadwal WHERE id_dosen='" + lbl_nid.Text + "' ORDER BY kode_mk";
            MySqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {
                comboBox_kodemk.Items.Add(rdr1[0].ToString());
            }
            connection.Close();

            connection.Open();
            MySqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandText = "SELECT DISTINCT kelas_mk FROM tbl_jadwal WHERE id_dosen='" + lbl_nid.Text + "' ORDER BY kelas_mk";
            MySqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                comboBox_kelas.Items.Add(rdr2[0].ToString());
            }
            connection.Close();
        }


        private void InputNilai_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            
            listView_nilai.Items.Clear();
            listView_nilai.Columns.Clear();
            listView_nilai.Columns.Add("Nim", 100, HorizontalAlignment.Left);
            listView_nilai.Columns.Add("Kode MK", 50, HorizontalAlignment.Left);
            listView_nilai.Columns.Add("Kelas", 50, HorizontalAlignment.Left);
            listView_nilai.Columns.Add("ID Dosen", 50, HorizontalAlignment.Left);
            listView_nilai.Columns.Add("UTS", 50, HorizontalAlignment.Left);
            listView_nilai.Columns.Add("TUGAS ", 50, HorizontalAlignment.Left);
            listView_nilai.Columns.Add("UAS", 50, HorizontalAlignment.Left);
            listView_nilai.Columns.Add("NA", 50, HorizontalAlignment.Left);
            listView_nilai.GridLines = true;
            listView_nilai.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            listView_nilai.View = View.Details;
            listView_nilai.MultiSelect = false;

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM tbl_nilai WHERE id_dosen = '" + lbl_nid.Text + "'";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item1 = new ListViewItem(reader["id_mhs"].ToString(), 0);
                item1.SubItems.Add(reader["kode_mk"].ToString());
                item1.SubItems.Add(reader["kelas_mk"].ToString());
                item1.SubItems.Add(reader["id_dosen"].ToString());
                item1.SubItems.Add(reader["nilai_uts"].ToString());
                item1.SubItems.Add(reader["nilai_tugas"].ToString());
                item1.SubItems.Add(reader["nilai_uas"].ToString());
                item1.SubItems.Add(reader["nilai_akhir"].ToString());
                listView_nilai.Items.Add(item1);
            }
            connection.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(textBox_uts.Text!="" || textBox_uas.Text!="" || textBox_tugas.Text!=""){
                if (textBox_uts.Text != "")
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "UPDATE tbl_nilai SET nilai_uts='" + textBox_uts.Text + "' WHERE id_mhs = '" + comboBox_nim.SelectedItem.ToString() + "' AND kode_mk ='" + comboBox_kodemk.SelectedItem.ToString() + "'AND kelas_mk='" + comboBox_kelas.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    
                    connection.Close();
                }
                
                if(textBox_tugas.Text!="")
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    
                    cmd.CommandText = "UPDATE tbl_nilai SET nilai_tugas='" + textBox_tugas.Text + "' WHERE id_mhs = '" + comboBox_nim.SelectedItem.ToString() + "' AND kode_mk ='" + comboBox_kodemk.SelectedItem.ToString() + "'AND kelas_mk='" + comboBox_kelas.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    
                    connection.Close();
                }
                if (textBox_uas.Text !="")
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "UPDATE tbl_nilai SET nilai_uas='" + textBox_uas.Text + "' WHERE id_mhs = '" + comboBox_nim.SelectedItem.ToString() + "' AND kode_mk ='" + comboBox_kodemk.SelectedItem.ToString() + "'AND kelas_mk='" + comboBox_kelas.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();

                    
                    connection.Close();
                }
                MessageBox.Show("Success updated");
            }
            else if (textBox_tugas.Text == "" || textBox_uas.Text == "" || textBox_uts.Text == "") 
            {
                MessageBox.Show("Silakan input nilai UTS / UAS / TUGAS");
            }

            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputNilai_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashboardDosen dashboarddosen = new DashboardDosen(lbl_nid.Text, lbl_nama_dosen.Text);
            dashboarddosen.Show();
        }
    }
}
