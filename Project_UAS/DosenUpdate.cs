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
    public partial class DosenUpdate : Form
    {
        public DosenUpdate()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //string nid = textBox_nid.Text.ToString();
            DosenUpdate1 dosenupdate1 = new DosenUpdate1(textBox_nid.Text);
            this.Hide();
            dosenupdate1.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DosenUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormDosen formdosen = new FormDosen();
            formdosen.Show();
        }
    }
}
