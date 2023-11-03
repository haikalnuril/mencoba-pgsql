namespace Implementasi_Winform_Pt._1
{
    partial class UbahMahasiswa
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Nama = new TextBox();
            Nim = new TextBox();
            Prodi = new ComboBox();
            ubahButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 28);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Ubah Mahasiswa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 71);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 115);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "NIM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 155);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "Prodi";
            // 
            // Nama
            // 
            Nama.Location = new Point(70, 72);
            Nama.Name = "Nama";
            Nama.Size = new Size(183, 23);
            Nama.TabIndex = 4;
            // 
            // Nim
            // 
            Nim.Location = new Point(70, 115);
            Nim.Name = "Nim";
            Nim.Size = new Size(183, 23);
            Nim.TabIndex = 5;
            // 
            // Prodi
            // 
            Prodi.FormattingEnabled = true;
            Prodi.Items.AddRange(new object[] { "Sistem Informasi", "Teknologi Informasi", "Informatika" });
            Prodi.Location = new Point(69, 161);
            Prodi.Name = "Prodi";
            Prodi.Size = new Size(184, 23);
            Prodi.TabIndex = 6;
            // 
            // ubahButton
            // 
            ubahButton.Location = new Point(112, 218);
            ubahButton.Name = "ubahButton";
            ubahButton.Size = new Size(75, 23);
            ubahButton.TabIndex = 7;
            ubahButton.Text = "Simpan";
            ubahButton.UseVisualStyleBackColor = true;
            ubahButton.Click += ubahButton_Click;
            // 
            // UbahMahasiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 313);
            Controls.Add(ubahButton);
            Controls.Add(Prodi);
            Controls.Add(Nim);
            Controls.Add(Nama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UbahMahasiswa";
            Text = "UbahMahasiswa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nama;
        private TextBox Nim;
        private ComboBox Prodi;
        private Button ubahButton;
    }
}