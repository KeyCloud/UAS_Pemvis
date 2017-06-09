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
    public partial class MhsUpdate1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");
        public MhsUpdate1(string nim)
        {
            InitializeComponent();
            this.textBox_nim.Text = nim.ToString();
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
            string update_query = "UPDATE tbl_mhs SET nama_mhs='" + textBox_nama.Text + "', jk_mhs='" + jk + "',email_mhs='" + textBox_email.Text + "', birth_mhs='" + textBox_date.Text + "', hp_mhs ='" + textBox_hp.Text + "' WHERE id_mhs='" + textBox_nim.Text + "'";

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

        private void MhsUpdate1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMhs formmhs = new FormMhs();
            formmhs.Show();
        }
    }
}
