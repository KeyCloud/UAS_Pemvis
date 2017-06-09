namespace Project_UAS
{
    partial class DashboardMhs
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
            this.lbl_nim = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_jadwal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_absen = new System.Windows.Forms.Button();
            this.btn_nilaiMatkul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nim
            // 
            this.lbl_nim.AutoSize = true;
            this.lbl_nim.Location = new System.Drawing.Point(12, 9);
            this.lbl_nim.Name = "lbl_nim";
            this.lbl_nim.Size = new System.Drawing.Size(68, 13);
            this.lbl_nim.TabIndex = 0;
            this.lbl_nim.Text = "Nomor Induk";
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Location = new System.Drawing.Point(102, 9);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(58, 13);
            this.lbl_nama.TabIndex = 1;
            this.lbl_nama.Text = "Nama Mhs";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(353, 9);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_jadwal
            // 
            this.btn_jadwal.Location = new System.Drawing.Point(163, 77);
            this.btn_jadwal.Name = "btn_jadwal";
            this.btn_jadwal.Size = new System.Drawing.Size(93, 23);
            this.btn_jadwal.TabIndex = 3;
            this.btn_jadwal.Text = "Jadwal Kuliah";
            this.btn_jadwal.UseVisualStyleBackColor = true;
            this.btn_jadwal.Click += new System.EventHandler(this.btn_jadwal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // btn_absen
            // 
            this.btn_absen.Location = new System.Drawing.Point(163, 120);
            this.btn_absen.Name = "btn_absen";
            this.btn_absen.Size = new System.Drawing.Size(93, 23);
            this.btn_absen.TabIndex = 5;
            this.btn_absen.Text = "Absensi";
            this.btn_absen.UseVisualStyleBackColor = true;
            this.btn_absen.Click += new System.EventHandler(this.btn_absen_Click);
            // 
            // btn_nilaiMatkul
            // 
            this.btn_nilaiMatkul.Location = new System.Drawing.Point(163, 161);
            this.btn_nilaiMatkul.Name = "btn_nilaiMatkul";
            this.btn_nilaiMatkul.Size = new System.Drawing.Size(93, 23);
            this.btn_nilaiMatkul.TabIndex = 6;
            this.btn_nilaiMatkul.Text = "Nilai Matkul";
            this.btn_nilaiMatkul.UseVisualStyleBackColor = true;
            this.btn_nilaiMatkul.Click += new System.EventHandler(this.btn_nilaiMatkul_Click);
            // 
            // DashboardMhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 262);
            this.Controls.Add(this.btn_nilaiMatkul);
            this.Controls.Add(this.btn_absen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_jadwal);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.lbl_nim);
            this.Name = "DashboardMhs";
            this.Text = "DashboardMhs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardMhs_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nim;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_jadwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_absen;
        private System.Windows.Forms.Button btn_nilaiMatkul;
    }
}