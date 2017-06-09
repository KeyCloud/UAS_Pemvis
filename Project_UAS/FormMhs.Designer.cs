namespace Project_UAS
{
    partial class FormMhs
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_nim = new System.Windows.Forms.TextBox();
            this.textBox_nama = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_hp = new System.Windows.Forms.TextBox();
            this.rb_L = new System.Windows.Forms.RadioButton();
            this.rb_P = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.listView_mhs = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(408, 39);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Insert";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(408, 68);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(408, 99);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nomor Induk Mahasiswa*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Lengkap*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tanggal Lahir*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nomor Handphone";
            // 
            // textBox_nim
            // 
            this.textBox_nim.Location = new System.Drawing.Point(164, 24);
            this.textBox_nim.Name = "textBox_nim";
            this.textBox_nim.Size = new System.Drawing.Size(183, 20);
            this.textBox_nim.TabIndex = 10;
            // 
            // textBox_nama
            // 
            this.textBox_nama.Location = new System.Drawing.Point(164, 68);
            this.textBox_nama.Name = "textBox_nama";
            this.textBox_nama.Size = new System.Drawing.Size(183, 20);
            this.textBox_nama.TabIndex = 11;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(164, 136);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(183, 20);
            this.textBox_email.TabIndex = 12;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(164, 170);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(183, 20);
            this.textBox_date.TabIndex = 13;
            // 
            // textBox_hp
            // 
            this.textBox_hp.Location = new System.Drawing.Point(164, 204);
            this.textBox_hp.Name = "textBox_hp";
            this.textBox_hp.Size = new System.Drawing.Size(183, 20);
            this.textBox_hp.TabIndex = 14;
            // 
            // rb_L
            // 
            this.rb_L.AutoSize = true;
            this.rb_L.Checked = true;
            this.rb_L.Location = new System.Drawing.Point(164, 102);
            this.rb_L.Name = "rb_L";
            this.rb_L.Size = new System.Drawing.Size(31, 17);
            this.rb_L.TabIndex = 15;
            this.rb_L.TabStop = true;
            this.rb_L.Text = "L";
            this.rb_L.UseVisualStyleBackColor = true;
            // 
            // rb_P
            // 
            this.rb_P.AutoSize = true;
            this.rb_P.Location = new System.Drawing.Point(219, 102);
            this.rb_P.Name = "rb_P";
            this.rb_P.Size = new System.Drawing.Size(32, 17);
            this.rb_P.TabIndex = 16;
            this.rb_P.Text = "P";
            this.rb_P.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "/";
            // 
            // listView_mhs
            // 
            this.listView_mhs.Location = new System.Drawing.Point(29, 243);
            this.listView_mhs.Name = "listView_mhs";
            this.listView_mhs.Size = new System.Drawing.Size(454, 174);
            this.listView_mhs.TabIndex = 19;
            this.listView_mhs.UseCompatibleStateImageBehavior = false;
            // 
            // FormMhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 429);
            this.Controls.Add(this.listView_mhs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rb_P);
            this.Controls.Add(this.rb_L);
            this.Controls.Add(this.textBox_hp);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_nama);
            this.Controls.Add(this.textBox_nim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Name = "FormMhs";
            this.Text = "FormMhs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMhs_FormClosed);
            this.Load += new System.EventHandler(this.FormMhs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_nim;
        private System.Windows.Forms.TextBox textBox_nama;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_hp;
        private System.Windows.Forms.RadioButton rb_L;
        private System.Windows.Forms.RadioButton rb_P;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView_mhs;
    }
}