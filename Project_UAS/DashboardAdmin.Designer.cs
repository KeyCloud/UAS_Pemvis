namespace Project_UAS
{
    partial class DashboardAdmin
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
            this.btn_dosen = new System.Windows.Forms.Button();
            this.btn_mhs = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_matkul = new System.Windows.Forms.Button();
            this.btn_krs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dosen
            // 
            this.btn_dosen.Location = new System.Drawing.Point(216, 59);
            this.btn_dosen.Name = "btn_dosen";
            this.btn_dosen.Size = new System.Drawing.Size(75, 23);
            this.btn_dosen.TabIndex = 0;
            this.btn_dosen.Text = "Dosen";
            this.btn_dosen.UseVisualStyleBackColor = true;
            this.btn_dosen.Click += new System.EventHandler(this.btn_dosen_Click);
            // 
            // btn_mhs
            // 
            this.btn_mhs.Location = new System.Drawing.Point(216, 100);
            this.btn_mhs.Name = "btn_mhs";
            this.btn_mhs.Size = new System.Drawing.Size(75, 23);
            this.btn_mhs.TabIndex = 1;
            this.btn_mhs.Text = "Mahasiswa";
            this.btn_mhs.UseVisualStyleBackColor = true;
            this.btn_mhs.Click += new System.EventHandler(this.btn_mhs_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(449, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_matkul
            // 
            this.btn_matkul.Location = new System.Drawing.Point(216, 142);
            this.btn_matkul.Name = "btn_matkul";
            this.btn_matkul.Size = new System.Drawing.Size(75, 23);
            this.btn_matkul.TabIndex = 3;
            this.btn_matkul.Text = "Mata Kuliah";
            this.btn_matkul.UseVisualStyleBackColor = true;
            this.btn_matkul.Click += new System.EventHandler(this.btn_matkul_Click);
            // 
            // btn_krs
            // 
            this.btn_krs.Location = new System.Drawing.Point(216, 182);
            this.btn_krs.Name = "btn_krs";
            this.btn_krs.Size = new System.Drawing.Size(75, 23);
            this.btn_krs.TabIndex = 4;
            this.btn_krs.Text = "Krs Mhs";
            this.btn_krs.UseVisualStyleBackColor = true;
            this.btn_krs.Click += new System.EventHandler(this.btn_krs_Click);
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 285);
            this.Controls.Add(this.btn_krs);
            this.Controls.Add(this.btn_matkul);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_mhs);
            this.Controls.Add(this.btn_dosen);
            this.Name = "DashboardAdmin";
            this.Text = "DashboardAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardAdmin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dosen;
        private System.Windows.Forms.Button btn_mhs;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_matkul;
        private System.Windows.Forms.Button btn_krs;
    }
}