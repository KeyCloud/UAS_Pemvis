namespace Project_UAS
{
    partial class AbsensiMhs
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
            this.listView_absensi = new System.Windows.Forms.ListView();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nim
            // 
            this.lbl_nim.AutoSize = true;
            this.lbl_nim.Location = new System.Drawing.Point(101, 22);
            this.lbl_nim.Name = "lbl_nim";
            this.lbl_nim.Size = new System.Drawing.Size(124, 13);
            this.lbl_nim.TabIndex = 0;
            this.lbl_nim.Text = "Nomor Induk Mahasiswa";
            // 
            // listView_absensi
            // 
            this.listView_absensi.Location = new System.Drawing.Point(12, 53);
            this.listView_absensi.Name = "listView_absensi";
            this.listView_absensi.Size = new System.Drawing.Size(315, 135);
            this.listView_absensi.TabIndex = 1;
            this.listView_absensi.UseCompatibleStateImageBehavior = false;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(126, 206);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Location = new System.Drawing.Point(133, 9);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(58, 13);
            this.lbl_nama.TabIndex = 3;
            this.lbl_nama.Text = "Nama Mhs";
            // 
            // AbsensiMhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 262);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.listView_absensi);
            this.Controls.Add(this.lbl_nim);
            this.Name = "AbsensiMhs";
            this.Text = "AbsensiMhs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AbsensiMhs_FormClosed);
            this.Load += new System.EventHandler(this.AbsensiMhs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nim;
        private System.Windows.Forms.ListView listView_absensi;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_nama;
    }
}