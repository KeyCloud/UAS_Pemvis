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
    
    public partial class FormLogin : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=project_pemvis;username=root;password=;");
        
      
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text.Trim().Equals("") || textBox_password.Text.Trim().Equals(""))
                MessageBox.Show("Isi username dan password", "Error Message");
            else
            {
                connection.Open();
                string login_admin = "SELECT * FROM tbl_login WHERE username = '" + textBox_username.Text.Trim() + "'and password = '" + textBox_password.Text.Trim() + "'";
                string login_dosen = "SELECT nama_dosen FROM tbl_dosen WHERE id_dosen = '" + textBox_username.Text.Trim() + "'and birth_dosen = '" + textBox_password.Text.Trim() + "'";
                string login_mhs = "SELECT nama_mhs FROM tbl_mhs WHERE id_mhs = '" + textBox_username.Text.Trim() + "'and birth_mhs = '" + textBox_password.Text.Trim() + "'";
                // ngambil string namanya
                MySqlCommand cmd = connection.CreateCommand();
                MySqlDataReader reader;

                //mahasiswa
                /*MySqlDataAdapter mhs = new MySqlDataAdapter(login_mhs, connection);
                DataTable dt_mhs = new DataTable();
                mhs.Fill(dt_mhs);*/
                ////////////////////////////
                cmd.CommandText = login_mhs;
                reader = cmd.ExecuteReader();
                ////////////////////////////

                if (reader.Read())// && reader.RecordsAffected == 1)//dt_mhs.Rows.Count == 1)
                {
                    /*cmd.CommandText = login_mhs;
                    reader = cmd.ExecuteReader();*/
                    login_mhs = reader[0].ToString();
                    reader.Close();
                    DashboardMhs dashboard_mhs = new DashboardMhs(textBox_username.Text,login_mhs);
                    this.Hide();
                    dashboard_mhs.Show();
                }
                else
                {
                    //dosen
                    /*MySqlDataAdapter dosen = new MySqlDataAdapter(login_dosen, connection);
                    DataTable dt_dosen = new DataTable();
                    dosen.Fill(dt_dosen);*/
                    //////////////////
                    reader.Close();
                    cmd.CommandText = login_dosen;
                    reader = cmd.ExecuteReader();
                    //////////////////
                    if (reader.Read())// && reader.RecordsAffected == 1)//dt_dosen.Rows.Count == 1)
                    {
                        /*cmd.CommandText = login_dosen;
                        reader = cmd.ExecuteReader();*/
                        login_dosen = reader[0].ToString();
                        reader.Close();
                        DashboardDosen dashboard_dosen = new DashboardDosen(textBox_username.Text, login_dosen);
                        this.Hide();
                        dashboard_dosen.Show();
                        /*if(reader.Read())
                        {
                            
                            login_dosen = reader[0].ToString();
                            DashboardDosen dashboard_dosen = new DashboardDosen(textBox_username.Text, login_dosen);
                            this.Hide();
                            dashboard_dosen.Show();
                        }*/
                    }
                    else
                    {
                        //admin
                        reader.Close();
                        MySqlDataAdapter admin = new MySqlDataAdapter(login_admin, connection);
                        DataTable dt_admin = new DataTable();
                        admin.Fill(dt_admin);

                        if (dt_admin.Rows.Count == 1)
                        {
                            DashboardAdmin dashboard_admin = new DashboardAdmin();
                            this.Hide();
                            dashboard_admin.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password is wrong !", "WARNING !!");
                        }
                    }
                }
                connection.Close();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
