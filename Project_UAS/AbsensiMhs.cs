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
    public partial class AbsensiMhs : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");

        public AbsensiMhs(string nim, string nama)
        {
            
            InitializeComponent();
            this.lbl_nim.Text = nim.ToString();
            this.lbl_nama.Text = nama.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbsensiMhs_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            listView_absensi.Items.Clear();
            listView_absensi.Columns.Clear();
            listView_absensi.Columns.Add("Kode MK", 50, HorizontalAlignment.Left);
            listView_absensi.Columns.Add("Kelas", 50, HorizontalAlignment.Left);
            listView_absensi.Columns.Add("Tanggal Hadir", 100, HorizontalAlignment.Left);
            listView_absensi.GridLines = true;
            listView_absensi.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            listView_absensi.View = View.Details;
            listView_absensi.MultiSelect = false;

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM tbl_absen WHERE id_mhs ='"+lbl_nim.Text+"'";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item1 = new ListViewItem(reader["kode_mk"].ToString(), 0);
                item1.SubItems.Add(reader["kelas_mk"].ToString());
                item1.SubItems.Add(reader["date_absen"].ToString());
                listView_absensi.Items.Add(item1);
            }
            connection.Close();
        }

        private void AbsensiMhs_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashboardMhs dashboardmhs = new DashboardMhs(lbl_nim.Text, lbl_nama.Text);
            dashboardmhs.Show();
        }
    }
}
