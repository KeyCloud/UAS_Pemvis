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
    public partial class DosenUpdate1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");
        public DosenUpdate1(string nid)
        {
            InitializeComponent();
            this.textBox_nid.Text = nid.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
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
            connection.Open();
            string update_query = "UPDATE tbl_dosen SET nama_dosen='"+textBox_nama.Text+"', jk_dosen='"+jk+"',email_dosen='"+textBox_email.Text+"', birth_dosen='"+textBox_date.Text+"', hp_dosen ='"+textBox_hp.Text+"' WHERE id_dosen='"+textBox_nid.Text+"'";
            
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = update_query;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Success update");
                connection.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed update");
                connection.Close();
            }
        }
        

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DosenUpdate1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormDosen formdosen = new FormDosen();
            formdosen.Show();
        }
    }
}
