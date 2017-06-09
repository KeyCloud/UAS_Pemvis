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
    public partial class JadwalDosen : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");
        
        public JadwalDosen(string nid, string nama)
        {
            InitializeComponent();
            this.lbl_nid.Text = nid.ToString();
            this.lbl_nama_dosen.Text = nama.ToString();
        }

        private void JadwalDosen_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;

            listView_jadwal.Items.Clear();
            listView_jadwal.Columns.Clear();
            listView_jadwal.Columns.Add("Hari", 50, HorizontalAlignment.Left);
            listView_jadwal.Columns.Add("Kelas", 50, HorizontalAlignment.Left);
            listView_jadwal.Columns.Add("Kode MK", 100, HorizontalAlignment.Left);
            listView_jadwal.Columns.Add("Nama MK", 100, HorizontalAlignment.Left);
            listView_jadwal.Columns.Add("Sks ", 50, HorizontalAlignment.Left);
            listView_jadwal.Columns.Add("Nama Dosen", 100, HorizontalAlignment.Left);
            listView_jadwal.GridLines = true;
            listView_jadwal.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            listView_jadwal.View = View.Details;
            listView_jadwal.MultiSelect = false;

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT hari ,kelas ,kode_mk , nama_mk , sks ,nama_dosen FROM tbl_matkul INNER JOIN tbl_dosen USING(id_dosen)WHERE id_dosen = '" + lbl_nid.Text + "'";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item1 = new ListViewItem(reader["hari"].ToString(), 0);
                item1.SubItems.Add(reader["kelas"].ToString());
                item1.SubItems.Add(reader["kode_mk"].ToString());
                item1.SubItems.Add(reader["nama_mk"].ToString());
                item1.SubItems.Add(reader["sks"].ToString());
                item1.SubItems.Add(reader["nama_dosen"].ToString());
                listView_jadwal.Items.Add(item1);
            }
            connection.Close();
            /*
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT hari ,kelas ,kode_mk , nama_mk , sks ,nama_dosen FROM tbl_matkul INNER JOIN tbl_dosen USING(id_dosen)WHERE id_dosen = '"+lbl_nid.Text+"'";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            gridViewJadwalDosen.DataSource = ds.Tables[0].DefaultView;
             */

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JadwalDosen_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashboardDosen dashboarddosen = new DashboardDosen(lbl_nid.Text, lbl_nama_dosen.Text);
            dashboarddosen.Show();
        }
    }
}
