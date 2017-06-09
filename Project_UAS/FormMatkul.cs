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
    public partial class FormMatkul : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");
        
        public FormMatkul()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string sks,hari,kelas,kode;
            sks = comboBox_sks.SelectedItem.ToString();
            hari = comboBox_hari.SelectedItem.ToString();
            kelas = comboBox_kelas.SelectedItem.ToString();
            kode = comboBox_kode.SelectedItem.ToString();
            //open connection
            connection.Open();
            string add_query = "INSERT INTO tbl_matkul VALUES('" + kode+textBox_kode_mk.Text.Trim() +"','" + textBox_nama_mk.Text.Trim() + "','" + sks + "','" + textBox_nid.Text.Trim() +"','"+hari+"','"+kelas+"')";
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //assign the query using command text
            cmd.CommandText = add_query;
            //assign the connection using Connection
            cmd.Connection = connection;
            //Execute query
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Success Insert");

            }
            else
            {
                MessageBox.Show("Failed Insert");

            }
            connection.Close();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DashboardAdmin dashboardadmin = new DashboardAdmin();
            this.Close();
            dashboardadmin.Show();
        }

        private void FormMatkul_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            listView_matkul.Items.Clear();
            listView_matkul.Columns.Clear();
            listView_matkul.Columns.Add("Kode", 50, HorizontalAlignment.Left);
            listView_matkul.Columns.Add("Nama", 100, HorizontalAlignment.Left);
            listView_matkul.Columns.Add("Hari", 50, HorizontalAlignment.Left);
            listView_matkul.Columns.Add("Kelas", 50, HorizontalAlignment.Left);
            listView_matkul.Columns.Add("No. Induk Dosen", 100, HorizontalAlignment.Left);
            listView_matkul.GridLines = true;
            listView_matkul.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            listView_matkul.View = View.Details;
            listView_matkul.MultiSelect = false;

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT DISTINCT * FROM tbl_matkul";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item1 = new ListViewItem(reader["kode_mk"].ToString(), 0);
                item1.SubItems.Add(reader["nama_mk"].ToString());
                item1.SubItems.Add(reader["hari"].ToString());
                item1.SubItems.Add(reader["kelas"].ToString());
                item1.SubItems.Add(reader["id_dosen"].ToString());
                listView_matkul.Items.Add(item1);
            }
            connection.Close();
            //MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //adap.Fill(ds);
            

            //gridView_mhs.DataSource = ds.Tables[0].DefaultView;
            //connection.Close();
        }
    }
}
