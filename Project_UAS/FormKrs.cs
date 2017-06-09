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
    public partial class FormKrs : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");
        
        public FormKrs()
        {
            InitializeComponent();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id_mhs FROM tbl_mhs";
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) 
            {
                comboBox_nim.Items.Add(rdr[0].ToString());

            }
            connection.Close();

            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "SELECT DISTINCT kode_mk FROM tbl_matkul ";
            MySqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {
                comboBox_kodematkul.Items.Add(rdr1[0].ToString());
                //comboBox_kelas.Items.Add(rdr1[1].ToString());
            }
            connection.Close();

            connection.Open();
            MySqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandText = "SELECT DISTINCT kelas FROM tbl_matkul ";
            MySqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                //comboBox_kodematkul.Items.Add(rdr1[0].ToString());
                comboBox_kelas.Items.Add(rdr2[0].ToString());
            }
            connection.Close();

            connection.Open();
            MySqlCommand cmd3 = connection.CreateCommand();
            cmd3.CommandText = "SELECT DISTINCT id_dosen FROM tbl_matkul ";
            MySqlDataReader rdr3 = cmd3.ExecuteReader();
            while (rdr3.Read())
            {
                //comboBox_kodematkul.Items.Add(rdr1[0].ToString());
                comboBox_nid.Items.Add(rdr3[0].ToString());
            }
            connection.Close();
         
        }



        private void btn_submit_Click(object sender, EventArgs e)
        {
            string nim, kode_mk, kelas,nid;
            nim = comboBox_nim.SelectedItem.ToString();
            kode_mk = comboBox_kodematkul.SelectedItem.ToString();
            kelas = comboBox_kelas.SelectedItem.ToString();
            nid = comboBox_nid.SelectedItem.ToString();
            //open connection
            connection.Open();
            string add_query = "INSERT INTO tbl_jadwal VALUES('" + nim + "','" + kode_mk + "','" + kelas + "','"+nid+"')";
            string add_query1 = "INSERT INTO tbl_nilai VALUES('"+nim+"','"+kode_mk+"','"+kelas+"','"+nid+"',NULL,NULL,NULL,NULL)";
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd1 = new MySqlCommand();
            //assign the query using command text
            cmd.CommandText = add_query;
            cmd1.CommandText = add_query1;
            //assign the connection using Connection
            cmd.Connection = connection;
            cmd1.Connection = connection;
            
            //Execute query
            if (cmd.ExecuteNonQuery()== 1)
            {
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Success Insert");

            }
            else
            {
                MessageBox.Show("Failed Insert");

            }
            connection.Close();
        }

        private void FormKrs_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;

            listView_krs.Items.Clear();
            listView_krs.Columns.Clear();
            listView_krs.Columns.Add("Kode", 50, HorizontalAlignment.Left);
            listView_krs.Columns.Add("Hari", 50, HorizontalAlignment.Left);
            listView_krs.Columns.Add("Kelas", 50, HorizontalAlignment.Left);
            listView_krs.Columns.Add("Nama", 100, HorizontalAlignment.Left);
            listView_krs.Columns.Add("NID", 50, HorizontalAlignment.Left);
           
            listView_krs.GridLines = true;
            listView_krs.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            listView_krs.View = View.Details;
            listView_krs.MultiSelect = false;

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT kelas,hari,kode_mk,nama_mk, id_dosen FROM tbl_matkul ORDER BY kode_mk";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item1 = new ListViewItem(reader["kode_mk"].ToString(), 0);
                item1.SubItems.Add(reader["hari"].ToString());
                item1.SubItems.Add(reader["kelas"].ToString());
                item1.SubItems.Add(reader["nama_mk"].ToString());
                item1.SubItems.Add(reader["id_dosen"].ToString());
                listView_krs.Items.Add(item1);
            }
            connection.Close();
            /*
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT kelas ,kode_mk , nama_mk FROM tbl_matkul ORDER BY kode_mk";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            gridViewJadal.DataSource=ds.Tables[0].DefaultView;
            connection.Close();
             */
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DashboardAdmin dashboardadmin = new DashboardAdmin();
            this.Close();
            dashboardadmin.Show();
        }

       
    }
}
