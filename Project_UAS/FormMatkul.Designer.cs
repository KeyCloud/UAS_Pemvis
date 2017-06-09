namespace Project_UAS
{
    partial class FormMatkul
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_kode_mk = new System.Windows.Forms.TextBox();
            this.textBox_nama_mk = new System.Windows.Forms.TextBox();
            this.textBox_nid = new System.Windows.Forms.TextBox();
            this.comboBox_sks = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_hari = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_kelas = new System.Windows.Forms.ComboBox();
            this.comboBox_kode = new System.Windows.Forms.ComboBox();
            this.listView_matkul = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(133, 187);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(133, 227);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode Mata Kuliah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Mata Kuliah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jumlah SKS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nomor Induk Dosen";
            // 
            // textBox_kode_mk
            // 
            this.textBox_kode_mk.Location = new System.Drawing.Point(185, 6);
            this.textBox_kode_mk.Name = "textBox_kode_mk";
            this.textBox_kode_mk.Size = new System.Drawing.Size(84, 20);
            this.textBox_kode_mk.TabIndex = 6;
            // 
            // textBox_nama_mk
            // 
            this.textBox_nama_mk.Location = new System.Drawing.Point(133, 38);
            this.textBox_nama_mk.Name = "textBox_nama_mk";
            this.textBox_nama_mk.Size = new System.Drawing.Size(136, 20);
            this.textBox_nama_mk.TabIndex = 7;
            // 
            // textBox_nid
            // 
            this.textBox_nid.Location = new System.Drawing.Point(133, 99);
            this.textBox_nid.Name = "textBox_nid";
            this.textBox_nid.Size = new System.Drawing.Size(136, 20);
            this.textBox_nid.TabIndex = 9;
            // 
            // comboBox_sks
            // 
            this.comboBox_sks.FormattingEnabled = true;
            this.comboBox_sks.Items.AddRange(new object[] {
            "---JUMLAH SKS---",
            "1 sks",
            "2 sks",
            "3 sks"});
            this.comboBox_sks.Location = new System.Drawing.Point(133, 67);
            this.comboBox_sks.Name = "comboBox_sks";
            this.comboBox_sks.Size = new System.Drawing.Size(136, 21);
            this.comboBox_sks.TabIndex = 10;
            this.comboBox_sks.Text = "---JUMLAH SKS---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hari Kuliah";
            // 
            // comboBox_hari
            // 
            this.comboBox_hari.FormattingEnabled = true;
            this.comboBox_hari.Items.AddRange(new object[] {
            "---HARI---",
            "Senin",
            "Selasa",
            "Rabu",
            "Kamis",
            "Jumat"});
            this.comboBox_hari.Location = new System.Drawing.Point(133, 126);
            this.comboBox_hari.Name = "comboBox_hari";
            this.comboBox_hari.Size = new System.Drawing.Size(136, 21);
            this.comboBox_hari.TabIndex = 12;
            this.comboBox_hari.Text = "---HARI---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kelas Mata Kuliah";
            // 
            // comboBox_kelas
            // 
            this.comboBox_kelas.FormattingEnabled = true;
            this.comboBox_kelas.Items.AddRange(new object[] {
            "---KELAS---",
            "A",
            "B",
            "C",
            "D"});
            this.comboBox_kelas.Location = new System.Drawing.Point(133, 160);
            this.comboBox_kelas.Name = "comboBox_kelas";
            this.comboBox_kelas.Size = new System.Drawing.Size(136, 21);
            this.comboBox_kelas.TabIndex = 14;
            this.comboBox_kelas.Text = "---KELAS---";
            // 
            // comboBox_kode
            // 
            this.comboBox_kode.FormattingEnabled = true;
            this.comboBox_kode.Items.AddRange(new object[] {
            "CE",
            "TI",
            "IF"});
            this.comboBox_kode.Location = new System.Drawing.Point(133, 6);
            this.comboBox_kode.Name = "comboBox_kode";
            this.comboBox_kode.Size = new System.Drawing.Size(46, 21);
            this.comboBox_kode.TabIndex = 15;
            // 
            // listView_matkul
            // 
            this.listView_matkul.FullRowSelect = true;
            this.listView_matkul.GridLines = true;
            this.listView_matkul.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView_matkul.Location = new System.Drawing.Point(292, 6);
            this.listView_matkul.Name = "listView_matkul";
            this.listView_matkul.Size = new System.Drawing.Size(362, 244);
            this.listView_matkul.TabIndex = 16;
            this.listView_matkul.UseCompatibleStateImageBehavior = false;
            // 
            // FormMatkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 262);
            this.Controls.Add(this.listView_matkul);
            this.Controls.Add(this.comboBox_kode);
            this.Controls.Add(this.comboBox_kelas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_hari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_sks);
            this.Controls.Add(this.textBox_nid);
            this.Controls.Add(this.textBox_nama_mk);
            this.Controls.Add(this.textBox_kode_mk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_submit);
            this.Name = "FormMatkul";
            this.Text = "FormMatkul";
            this.Load += new System.EventHandler(this.FormMatkul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_kode_mk;
        private System.Windows.Forms.TextBox textBox_nama_mk;
        private System.Windows.Forms.TextBox textBox_nid;
        private System.Windows.Forms.ComboBox comboBox_sks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_hari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_kelas;
        private System.Windows.Forms.ComboBox comboBox_kode;
        private System.Windows.Forms.ListView listView_matkul;
    }
}