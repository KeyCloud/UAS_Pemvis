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
    public partial class FormDosen : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");
        
        public FormDosen()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (textBox_nid.Text.Trim() == "" || textBox_nama.Text.Trim() == "" || textBox_date.Text.Trim() == "")
            {
                MessageBox.Show("Harap isi yang dibintangi", "Error Message");
            }
            else
            {
                string jk;
                if (rb_L.Checked == true)
                {
                    jk = "Laki-laki";
                }
                else
                {
                    jk = "Perempuan";
                }
                //open connection
                connection.Open();
                string add_query = "INSERT INTO tbl_dosen VALUES('" + textBox_nid.Text.Trim() + "','" + textBox_nama.Text.Trim() + "','" + jk + "','" + textBox_email.Text.Trim() + "','" + textBox_date.Text.Trim() + "','" + textBox_hp.Text.Trim() + "')";
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //assign the query using command text
                cmd.CommandText = add_query;
                //assign the connection using Connection
                cmd.Connection = connection;
                //Execute query
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Insert");
                    connection.Close();
                    FormDosen_Load(sender, e);
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Failed Insert");
                    connection.Close();
                }
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DosenUpdate dosenupdate = new DosenUpdate();
            this.Hide();
            dosenupdate.Show();
        }

        private void FormDosen_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            listView_dosen.Items.Clear();
            listView_dosen.Columns.Clear();
            listView_dosen.Columns.Add("NID", 50, HorizontalAlignment.Left);
            listView_dosen.Columns.Add("NAMA DOSEN", 100, HorizontalAlignment.Left);
            listView_dosen.Columns.Add("JENIS KELAMIN", 100, HorizontalAlignment.Left);
            listView_dosen.Columns.Add("EMAIL", 100, HorizontalAlignment.Left);
            listView_dosen.Columns.Add("TANGGAL LAHIR", 100, HorizontalAlignment.Left);
            listView_dosen.Columns.Add("NOMOR HP", 100, HorizontalAlignment.Left);
            listView_dosen.GridLines = true;
            listView_dosen.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            listView_dosen.View = View.Details;
            listView_dosen.MultiSelect = false;

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM tbl_dosen";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item1 = new ListViewItem(reader["id_dosen"].ToString(), 0);
                item1.SubItems.Add(reader["nama_dosen"].ToString());
                item1.SubItems.Add(reader["jk_dosen"].ToString());
                item1.SubItems.Add(reader["email_dosen"].ToString());
                item1.SubItems.Add(reader["birth_dosen"].ToString());
                item1.SubItems.Add(reader["hp_dosen"].ToString());
                listView_dosen.Items.Add(item1);
            }
            connection.Close();
            /*
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM tbl_dosen";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            gridView_dosen.DataSource = ds.Tables[0].DefaultView;
             */
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDosen_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashboardAdmin dashboardadmin = new DashboardAdmin();
            dashboardadmin.Show();
        }
    }
}
