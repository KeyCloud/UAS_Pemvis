namespace Project_UAS
{
    partial class AbsenPerkuliahan
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
            this.dateTimePicker_absen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_kodemk = new System.Windows.Forms.ComboBox();
            this.comboBox_kelas = new System.Windows.Forms.ComboBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.listView_absen = new System.Windows.Forms.ListView();
            this.checkedListBox_nim = new System.Windows.Forms.CheckedListBox();
            this.lbl_nid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_nama_dosen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker_absen
            // 
            this.dateTimePicker_absen.Location = new System.Drawing.Point(341, 24);
            this.dateTimePicker_absen.Name = "dateTimePicker_absen";
            this.dateTimePicker_absen.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker_absen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode Matkul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kelas";
            // 
            // comboBox_kodemk
            // 
            this.comboBox_kodemk.FormattingEnabled = true;
            this.comboBox_kodemk.Location = new System.Drawing.Point(85, 6);
            this.comboBox_kodemk.Name = "comboBox_kodemk";
            this.comboBox_kodemk.Size = new System.Drawing.Size(121, 21);
            this.comboBox_kodemk.TabIndex = 4;
            // 
            // comboBox_kelas
            // 
            this.comboBox_kelas.FormattingEnabled = true;
            this.comboBox_kelas.Location = new System.Drawing.Point(85, 31);
            this.comboBox_kelas.Name = "comboBox_kelas";
            this.comboBox_kelas.Size = new System.Drawing.Size(121, 21);
            this.comboBox_kelas.TabIndex = 5;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(212, 4);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 6;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // listView_absen
            // 
            this.listView_absen.Location = new System.Drawing.Point(15, 69);
            this.listView_absen.Name = "listView_absen";
            this.listView_absen.Size = new System.Drawing.Size(272, 257);
            this.listView_absen.TabIndex = 7;
            this.listView_absen.UseCompatibleStateImageBehavior = false;
            // 
            // checkedListBox_nim
            // 
            this.checkedListBox_nim.FormattingEnabled = true;
            this.checkedListBox_nim.Location = new System.Drawing.Point(305, 96);
            this.checkedListBox_nim.Name = "checkedListBox_nim";
            this.checkedListBox_nim.Size = new System.Drawing.Size(119, 229);
            this.checkedListBox_nim.TabIndex = 8;
            // 
            // lbl_nid
            // 
            this.lbl_nid.AutoSize = true;
            this.lbl_nid.Location = new System.Drawing.Point(444, 6);
            this.lbl_nid.Name = "lbl_nid";
            this.lbl_nid.Size = new System.Drawing.Size(102, 13);
            this.lbl_nid.TabIndex = 9;
            this.lbl_nid.Text = "Nomor Induk Dosen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Absen";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(447, 259);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(99, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(447, 301);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(99, 23);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_nama_dosen
            // 
            this.lbl_nama_dosen.AutoSize = true;
            this.lbl_nama_dosen.Location = new System.Drawing.Point(338, 6);
            this.lbl_nama_dosen.Name = "lbl_nama_dosen";
            this.lbl_nama_dosen.Size = new System.Drawing.Size(69, 13);
            this.lbl_nama_dosen.TabIndex = 13;
            this.lbl_nama_dosen.Text = "Nama Dosen";
            // 
            // AbsenPerkuliahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 338);
            this.Controls.Add(this.lbl_nama_dosen);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_nid);
            this.Controls.Add(this.checkedListBox_nim);
            this.Controls.Add(this.listView_absen);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.comboBox_kelas);
            this.Controls.Add(this.comboBox_kodemk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_absen);
            this.Name = "AbsenPerkuliahan";
            this.Text = "AbsenPerkuliahan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AbsenPerkuliahan_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_absen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_kodemk;
        private System.Windows.Forms.ComboBox comboBox_kelas;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.ListView listView_absen;
        private System.Windows.Forms.CheckedListBox checkedListBox_nim;
        private System.Windows.Forms.Label lbl_nid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_nama_dosen;
    }
}