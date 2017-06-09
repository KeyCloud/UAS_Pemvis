namespace Project_UAS
{
    partial class DashboardDosen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_jadwal = new System.Windows.Forms.Button();
            this.lbl_dosen = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_nama_dosen = new System.Windows.Forms.Label();
            this.btn_absen = new System.Windows.Forms.Button();
            this.btn_inputNilai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_jadwal
            // 
            this.btn_jadwal.Location = new System.Drawing.Point(158, 68);
            this.btn_jadwal.Name = "btn_jadwal";
            this.btn_jadwal.Size = new System.Drawing.Size(130, 23);
            this.btn_jadwal.TabIndex = 0;
            this.btn_jadwal.Text = "Jadwal Dosen";
            this.btn_jadwal.UseVisualStyleBackColor = true;
            this.btn_jadwal.Click += new System.EventHandler(this.btn_jadwal_Click);
            // 
            // lbl_dosen
            // 
            this.lbl_dosen.AutoSize = true;
            this.lbl_dosen.Location = new System.Drawing.Point(191, 9);
            this.lbl_dosen.Name = "lbl_dosen";
            this.lbl_dosen.Size = new System.Drawing.Size(68, 13);
            this.lbl_dosen.TabIndex = 1;
            this.lbl_dosen.Text = "Nomor Induk";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(393, 13);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_nama_dosen
            // 
            this.lbl_nama_dosen.AutoSize = true;
            this.lbl_nama_dosen.Location = new System.Drawing.Point(191, 32);
            this.lbl_nama_dosen.Name = "lbl_nama_dosen";
            this.lbl_nama_dosen.Size = new System.Drawing.Size(69, 13);
            this.lbl_nama_dosen.TabIndex = 3;
            this.lbl_nama_dosen.Text = "Nama Dosen";
            // 
            // btn_absen
            // 
            this.btn_absen.Location = new System.Drawing.Point(158, 122);
            this.btn_absen.Name = "btn_absen";
            this.btn_absen.Size = new System.Drawing.Size(130, 23);
            this.btn_absen.TabIndex = 4;
            this.btn_absen.Text = "Absensi Perkuliahan";
            this.btn_absen.UseVisualStyleBackColor = true;
            this.btn_absen.Click += new System.EventHandler(this.btn_absen_Click);
            // 
            // btn_inputNilai
            // 
            this.btn_inputNilai.Location = new System.Drawing.Point(158, 179);
            this.btn_inputNilai.Name = "btn_inputNilai";
            this.btn_inputNilai.Size = new System.Drawing.Size(130, 23);
            this.btn_inputNilai.TabIndex = 5;
            this.btn_inputNilai.Text = "Input Nilai Mata Kuliah";
            this.btn_inputNilai.UseVisualStyleBackColor = true;
            this.btn_inputNilai.Click += new System.EventHandler(this.btn_inputNilai_Click);
            // 
            // DashboardDosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 288);
            this.Controls.Add(this.btn_inputNilai);
            this.Controls.Add(this.btn_absen);
            this.Controls.Add(this.lbl_nama_dosen);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_dosen);
            this.Controls.Add(this.btn_jadwal);
            this.Name = "DashboardDosen";
            this.Text = "DashboardDosen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardDosen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_jadwal;
        private System.Windows.Forms.Label lbl_dosen;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_nama_dosen;
        private System.Windows.Forms.Button btn_absen;
        private System.Windows.Forms.Button btn_inputNilai;
    }
}