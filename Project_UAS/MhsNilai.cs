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
    public partial class MhsNilai : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");
        
        public MhsNilai(string nim, string nama)
        {
            InitializeComponent();
            this.lbl_nim.Text = nim.ToString();
            this.lbl_nama.Text = nama.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MhsNilai_Load(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM tbl_nilai WHERE id_mhs = '"+lbl_nim.Text+"'";
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                string uts,tugas,uas,na="";
                uts= rdr.GetValue(4).ToString();
                tugas = rdr.GetValue(5).ToString();
                uas= rdr.GetValue(6).ToString();
                //lbl_nilai.Text = tugas;

                int result,uts1,uas1,tugas1;
                int.TryParse(na, out result);
                int.TryParse(uts, out uts1);
                int.TryParse(uas, out uas1);
                int.TryParse(tugas, out tugas1);
                result = (uts1 * 30/100)+(tugas1*30/100)+(uas1*40/100);
                lbl_nilai.Text = result.ToString();

                //na= uts*30/100;
                
            }
            //cmd.ExecuteReader();
            connection.Close();

            MySqlDataReader reader = null;
            //reader = cmd1.ExecuteReader();
            //string uts = reader["nilai_uts"].ToString();
            //lbl_nilai.Text = uts.ToString();
            
            listView_nilai.Items.Clear();
            listView_nilai.Columns.Clear();
            listView_nilai.Columns.Add("Kode MK", 50, HorizontalAlignment.Left);
            listView_nilai.Columns.Add("Kelas", 50, HorizontalAlignment.Left);
            listView_nilai.Columns.Add("NID", 50, HorizontalAlignment.Left);
            listView_nilai.Columns.Add("UTS", 50, HorizontalAlignment.Left);
            listView_nilai.Columns.Add("UAS", 50, HorizontalAlignment.Left);
            listView_nilai.Columns.Add("TUGAS", 50, HorizontalAlignment.Left);
            listView_nilai.Columns.Add("NA", 50, HorizontalAlignment.Left);

            
            listView_nilai.GridLines = true;
            listView_nilai.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            listView_nilai.View = View.Details;
            listView_nilai.MultiSelect = false;

            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "SELECT kode_mk , kelas_mk , id_dosen , nilai_uts , nilai_uas , nilai_tugas , nilai_uts*30/100+nilai_tugas*30/100+nilai_uas*40/100 AS nilai_akhir FROM tbl_nilai WHERE id_mhs = '"+lbl_nim.Text+"' ";
            cmd1.ExecuteNonQuery();
            reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item1 = new ListViewItem(reader["kode_mk"].ToString(), 0);
                item1.SubItems.Add(reader["kelas_mk"].ToString());
                item1.SubItems.Add(reader["id_dosen"].ToString());
                item1.SubItems.Add(reader["nilai_uts"].ToString());
                item1.SubItems.Add(reader["nilai_uas"].ToString());
                item1.SubItems.Add(reader["nilai_tugas"].ToString());
                item1.SubItems.Add(reader["nilai_akhir"].ToString());
                listView_nilai.Items.Add(item1);
            }
            connection.Close();
        }

        private void MhsNilai_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashboardMhs dashboard = new DashboardMhs(lbl_nim.Text, lbl_nama.Text);
            dashboard.Show();
        }
    }
}
