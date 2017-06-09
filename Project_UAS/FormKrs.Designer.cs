namespace Project_UAS
{
    partial class FormKrs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_nim = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.comboBox_kodematkul = new System.Windows.Forms.ComboBox();
            this.comboBox_kelas = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.listView_krs = new System.Windows.Forms.ListView();
            this.comboBox_nid = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomor Induk Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Mata Kuliah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            // 
            // comboBox_nim
            // 
            this.comboBox_nim.FormattingEnabled = true;
            this.comboBox_nim.Location = new System.Drawing.Point(160, 9);
            this.comboBox_nim.Name = "comboBox_nim";
            this.comboBox_nim.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nim.TabIndex = 4;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(160, 123);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(121, 23);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // comboBox_kodematkul
            // 
            this.comboBox_kodematkul.FormattingEnabled = true;
            this.comboBox_kodematkul.Location = new System.Drawing.Point(160, 37);
            this.comboBox_kodematkul.Name = "comboBox_kodematkul";
            this.comboBox_kodematkul.Size = new System.Drawing.Size(121, 21);
            this.comboBox_kodematkul.TabIndex = 6;
            // 
            // comboBox_kelas
            // 
            this.comboBox_kelas.FormattingEnabled = true;
            this.comboBox_kelas.Location = new System.Drawing.Point(160, 65);
            this.comboBox_kelas.Name = "comboBox_kelas";
            this.comboBox_kelas.Size = new System.Drawing.Size(121, 21);
            this.comboBox_kelas.TabIndex = 7;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(160, 161);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(121, 23);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // listView_krs
            // 
            this.listView_krs.Location = new System.Drawing.Point(308, 9);
            this.listView_krs.Name = "listView_krs";
            this.listView_krs.Size = new System.Drawing.Size(311, 175);
            this.listView_krs.TabIndex = 10;
            this.listView_krs.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox_nid
            // 
            this.comboBox_nid.FormattingEnabled = true;
            this.comboBox_nid.Location = new System.Drawing.Point(160, 93);
            this.comboBox_nid.Name = "comboBox_nid";
            this.comboBox_nid.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nid.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nomor Induk Dosen";
            // 
            // FormKrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 196);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_nid);
            this.Controls.Add(this.listView_krs);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.comboBox_kelas);
            this.Controls.Add(this.comboBox_kodematkul);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.comboBox_nim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKrs";
            this.Text = "FormKrs";
            this.Load += new System.EventHandler(this.FormKrs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_nim;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ComboBox comboBox_kodematkul;
        private System.Windows.Forms.ComboBox comboBox_kelas;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListView listView_krs;
        private System.Windows.Forms.ComboBox comboBox_nid;
        private System.Windows.Forms.Label label4;
    }
}