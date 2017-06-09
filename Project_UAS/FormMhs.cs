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
    public partial class FormMhs : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");
        
        public FormMhs()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (textBox_nim.Text.Trim() == "" || textBox_nama.Text.Trim() == "" || textBox_date.Text.Trim() == "")
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
                string add_query = "INSERT INTO tbl_mhs VALUES('" + textBox_nim.Text.Trim() + "','" + textBox_nama.Text.Trim() + "','" + jk + "','" + textBox_email.Text.Trim() + "','" + textBox_date.Text.Trim() + "','" + textBox_hp.Text.Trim() + "')";
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
                    FormMhs_Load(sender, e);
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Failed Insert");
                    connection.Close();
                }
            }
        }

        private void FormMhs_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            listView_mhs.Items.Clear();
            listView_mhs.Columns.Clear();
            listView_mhs.Columns.Add("NIM", 50, HorizontalAlignment.Left);
            listView_mhs.Columns.Add("NAMA MHS", 100, HorizontalAlignment.Left);
            listView_mhs.Columns.Add("JENIS KELAMIN", 100, HorizontalAlignment.Left);
            listView_mhs.Columns.Add("EMAIL", 100, HorizontalAlignment.Left);
            listView_mhs.Columns.Add("TANGGAL LAHIR", 100, HorizontalAlignment.Left);
            listView_mhs.Columns.Add("NOMOR HP", 100, HorizontalAlignment.Left);
            listView_mhs.GridLines = true;
            listView_mhs.FullRowSelect = true;
            //listView1.Activation = ItemActivation.TwoClick;
            listView_mhs.View = View.Details;
            listView_mhs.MultiSelect = false;

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM tbl_mhs";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item1 = new ListViewItem(reader["id_mhs"].ToString(), 0);
                item1.SubItems.Add(reader["nama_mhs"].ToString());
                item1.SubItems.Add(reader["jk_mhs"].ToString());
                item1.SubItems.Add(reader["email_mhs"].ToString());
                item1.SubItems.Add(reader["birth_mhs"].ToString());
                item1.SubItems.Add(reader["hp_mhs"].ToString());
                listView_mhs.Items.Add(item1);
            }
            connection.Close();
            /*
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM tbl_mhs";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            gridView_mhs.DataSource = ds.Tables[0].DefaultView;
            connection.Close();
            */
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MhsUpdate mhsupdate = new MhsUpdate();
            this.Hide();
            mhsupdate.Show();
        }

        private void FormMhs_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashboardAdmin dashboardadmin = new DashboardAdmin();
            dashboardadmin.Show();
        }
    }
}
