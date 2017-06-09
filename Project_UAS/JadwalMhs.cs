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
    public partial class JadwalMhs : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");

        public JadwalMhs(string nim, string nama)
        {
            InitializeComponent();
            this.lbl_nim.Text = nim.ToString();
            this.lbl_nama.Text = nama.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JadwalMhs_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;

            listView_jadwal.Items.Clear();
            listView_jadwal.Columns.Clear();
            listView_jadwal.Columns.Add("Hari", 50, HorizontalAlignment.Left);
            listView_jadwal.Columns.Add("Kelas", 50, HorizontalAlignment.Left);
            listView_jadwal.Columns.Add("Kode MK", 100, HorizontalAlignment.Left);
            listView_jadwal.Columns.Add("Nama MK", 100, HorizontalAlignment.Left);
            listView_jadwal.GridLines = true;
            listView_jadwal.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            listView_jadwal.View = View.Details;
            listView_jadwal.MultiSelect = false;

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT DISTINCT tbl_matkul.hari ,tbl_jadwal.kode_mk ,tbl_jadwal.kelas_mk, tbl_matkul.nama_mk FROM tbl_jadwal INNER JOIN tbl_matkul ON tbl_jadwal.kode_mk = tbl_matkul.kode_mk WHERE tbl_jadwal.kelas_mk=tbl_matkul.kelas AND tbl_jadwal.id_mhs='"+lbl_nim.Text+"'";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item1 = new ListViewItem(reader["hari"].ToString(), 0);
                item1.SubItems.Add(reader["kode_mk"].ToString());
                item1.SubItems.Add(reader["kelas_mk"].ToString());
                item1.SubItems.Add(reader["nama_mk"].ToString());
                listView_jadwal.Items.Add(item1);
            }
            connection.Close();
        }

        private void JadwalMhs_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashboardMhs dashboardmhs = new DashboardMhs(lbl_nim.Text, lbl_nama.Text);
            dashboardmhs.Show();
        }
    }
}
