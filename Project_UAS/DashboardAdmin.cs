using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_UAS
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dosen_Click(object sender, EventArgs e)
        {
            FormDosen formdosen = new FormDosen();
            this.Hide();
            formdosen.Show();
        }

        private void btn_mhs_Click(object sender, EventArgs e)
        {
            FormMhs formhs = new FormMhs();
            this.Hide();
            formhs.Show();
        }

        private void btn_matkul_Click(object sender, EventArgs e)
        {
            FormMatkul formmatkul = new FormMatkul();
            this.Hide();
            formmatkul.Show();
        }

        private void btn_krs_Click(object sender, EventArgs e)
        {
            FormKrs formkrs = new FormKrs();
            this.Hide();
            formkrs.Show();
        }

        private void DashboardAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin formlogin = new FormLogin();
            formlogin.Show();
        }
    }
}
