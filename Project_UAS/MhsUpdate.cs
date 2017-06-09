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
    public partial class MhsUpdate : Form
    {
        public MhsUpdate()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            
            MhsUpdate1 mhsupdate1 = new MhsUpdate1(textBox_nim.Text);
            this.Hide();
            mhsupdate1.Show();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MhsUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMhs formmhs = new FormMhs();
            formmhs.Show();
        }
    }
}
