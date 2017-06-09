namespace Project_UAS
{
    partial class JadwalDosen
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
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_nid = new System.Windows.Forms.Label();
            this.listView_jadwal = new System.Windows.Forms.ListView();
            this.lbl_nama_dosen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(248, 211);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_nid
            // 
            this.lbl_nid.AutoSize = true;
            this.lbl_nid.Location = new System.Drawing.Point(230, 22);
            this.lbl_nid.Name = "lbl_nid";
            this.lbl_nid.Size = new System.Drawing.Size(102, 13);
            this.lbl_nid.TabIndex = 2;
            this.lbl_nid.Text = "Nomor Induk Dosen";
            // 
            // listView_jadwal
            // 
            this.listView_jadwal.Location = new System.Drawing.Point(12, 46);
            this.listView_jadwal.Name = "listView_jadwal";
            this.listView_jadwal.Size = new System.Drawing.Size(568, 159);
            this.listView_jadwal.TabIndex = 3;
            this.listView_jadwal.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_nama_dosen
            // 
            this.lbl_nama_dosen.AutoSize = true;
            this.lbl_nama_dosen.Location = new System.Drawing.Point(247, 9);
            this.lbl_nama_dosen.Name = "lbl_nama_dosen";
            this.lbl_nama_dosen.Size = new System.Drawing.Size(69, 13);
            this.lbl_nama_dosen.TabIndex = 4;
            this.lbl_nama_dosen.Text = "Nama Dosen";
            // 
            // JadwalDosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 262);
            this.Controls.Add(this.lbl_nama_dosen);
            this.Controls.Add(this.listView_jadwal);
            this.Controls.Add(this.lbl_nid);
            this.Controls.Add(this.btn_back);
            this.Name = "JadwalDosen";
            this.Text = "JadwalDosen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JadwalDosen_FormClosed);
            this.Load += new System.EventHandler(this.JadwalDosen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_nid;
        private System.Windows.Forms.ListView listView_jadwal;
        private System.Windows.Forms.Label lbl_nama_dosen;
    }
}