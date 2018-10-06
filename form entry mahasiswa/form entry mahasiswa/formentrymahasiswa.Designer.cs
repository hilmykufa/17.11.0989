namespace form_entry_mahasiswa
{
    partial class Frmmhs
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
            this.txtNim = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoLakilaki = new System.Windows.Forms.RadioButton();
            this.rdoPerempuan = new System.Windows.Forms.RadioButton();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(99, 12);
            this.txtNim.Mask = "##.##.####";
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(70, 20);
            this.txtNim.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 20);
            this.txtName.TabIndex = 1;
            // 
            // rdoLakilaki
            // 
            this.rdoLakilaki.AutoSize = true;
            this.rdoLakilaki.Checked = true;
            this.rdoLakilaki.Location = new System.Drawing.Point(99, 63);
            this.rdoLakilaki.Name = "rdoLakilaki";
            this.rdoLakilaki.Size = new System.Drawing.Size(70, 17);
            this.rdoLakilaki.TabIndex = 2;
            this.rdoLakilaki.TabStop = true;
            this.rdoLakilaki.Text = "Laki - laki";
            this.rdoLakilaki.UseVisualStyleBackColor = true;
            // 
            // rdoPerempuan
            // 
            this.rdoPerempuan.AutoSize = true;
            this.rdoPerempuan.Location = new System.Drawing.Point(177, 65);
            this.rdoPerempuan.Name = "rdoPerempuan";
            this.rdoPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rdoPerempuan.TabIndex = 2;
            this.rdoPerempuan.Text = "Perempuan";
            this.rdoPerempuan.UseVisualStyleBackColor = true;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(99, 88);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(232, 20);
            this.txtAlamat.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(99, 115);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(95, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jenis Kelamin";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(99, 152);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(256, 152);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 5;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tempat lahir";
            // 
            // Frmmhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 187);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.rdoPerempuan);
            this.Controls.Add(this.rdoLakilaki);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNim);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmmhs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Mahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtNim;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdoLakilaki;
        private System.Windows.Forms.RadioButton rdoPerempuan;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label label4;
    }
}