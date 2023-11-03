namespace Implementasi_Winform_Pt._1
{
    partial class TambahMahasiswa
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
            Judul = new Label();
            LabelNama = new Label();
            Nama = new TextBox();
            Nim = new TextBox();
            labelNim = new Label();
            labelProdi = new Label();
            tombolSimpan = new Button();
            Prodi = new ComboBox();
            SuspendLayout();
            // 
            // Judul
            // 
            Judul.AutoSize = true;
            Judul.Location = new Point(104, 18);
            Judul.Name = "Judul";
            Judul.Size = new Size(110, 15);
            Judul.TabIndex = 0;
            Judul.Text = "Tambah Mahasiswa";
            // 
            // LabelNama
            // 
            LabelNama.AutoSize = true;
            LabelNama.Location = new Point(29, 59);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(39, 15);
            LabelNama.TabIndex = 1;
            LabelNama.Text = "Nama";
            // 
            // Nama
            // 
            Nama.Location = new Point(74, 56);
            Nama.Name = "Nama";
            Nama.Size = new Size(202, 23);
            Nama.TabIndex = 2;
            // 
            // Nim
            // 
            Nim.Location = new Point(74, 99);
            Nim.Name = "Nim";
            Nim.Size = new Size(202, 23);
            Nim.TabIndex = 4;
            // 
            // labelNim
            // 
            labelNim.AutoSize = true;
            labelNim.Location = new Point(29, 102);
            labelNim.Name = "labelNim";
            labelNim.Size = new Size(30, 15);
            labelNim.TabIndex = 3;
            labelNim.Text = "NIM";
            // 
            // labelProdi
            // 
            labelProdi.AutoSize = true;
            labelProdi.Location = new Point(29, 142);
            labelProdi.Name = "labelProdi";
            labelProdi.Size = new Size(35, 15);
            labelProdi.TabIndex = 5;
            labelProdi.Text = "Prodi";
            // 
            // tombolSimpan
            // 
            tombolSimpan.Location = new Point(126, 188);
            tombolSimpan.Name = "tombolSimpan";
            tombolSimpan.Size = new Size(75, 32);
            tombolSimpan.TabIndex = 7;
            tombolSimpan.Text = "Simpan";
            tombolSimpan.UseVisualStyleBackColor = true;
            tombolSimpan.Click += tombolSimpan_Click;
            // 
            // Prodi
            // 
            Prodi.FormattingEnabled = true;
            Prodi.Items.AddRange(new object[] { "Sistem Informasi", "Teknologi Informasi", "Informatika" });
            Prodi.Location = new Point(74, 139);
            Prodi.Name = "Prodi";
            Prodi.Size = new Size(202, 23);
            Prodi.TabIndex = 8;
            // 
            // TambahMahasiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(334, 271);
            Controls.Add(Prodi);
            Controls.Add(tombolSimpan);
            Controls.Add(labelProdi);
            Controls.Add(Nim);
            Controls.Add(labelNim);
            Controls.Add(Nama);
            Controls.Add(LabelNama);
            Controls.Add(Judul);
            Name = "TambahMahasiswa";
            Text = "TambahMahasiswa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Judul;
        private Label LabelNama;
        private TextBox Nama;
        private TextBox Nim;
        private Label labelNim;
        private Label labelProdi;
        private Button tombolSimpan;
        private ComboBox Prodi;
    }
}