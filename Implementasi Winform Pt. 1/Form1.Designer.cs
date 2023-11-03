namespace Implementasi_Winform_Pt._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TabelMahasiswa = new DataGridView();
            tambahButton = new Button();
            tambahMahasiswaBindingSource = new BindingSource(components);
            tambahMahasiswaBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)TabelMahasiswa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tambahMahasiswaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tambahMahasiswaBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // TabelMahasiswa
            // 
            TabelMahasiswa.AllowUserToAddRows = false;
            TabelMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelMahasiswa.Location = new Point(46, 62);
            TabelMahasiswa.Name = "TabelMahasiswa";
            TabelMahasiswa.ReadOnly = true;
            TabelMahasiswa.RowTemplate.Height = 25;
            TabelMahasiswa.Size = new Size(700, 343);
            TabelMahasiswa.TabIndex = 0;
            TabelMahasiswa.CellContentClick += TabelMahasiswa_CellContentClick;
            // 
            // tambahButton
            // 
            tambahButton.BackColor = Color.Blue;
            tambahButton.ForeColor = Color.White;
            tambahButton.Location = new Point(46, 12);
            tambahButton.Name = "tambahButton";
            tambahButton.Size = new Size(98, 33);
            tambahButton.TabIndex = 1;
            tambahButton.Text = "Tambah Data";
            tambahButton.UseVisualStyleBackColor = false;
            tambahButton.Click += tambahButton_Click;
            // 
            // tambahMahasiswaBindingSource
            // 
            tambahMahasiswaBindingSource.DataSource = typeof(TambahMahasiswa);
            // 
            // tambahMahasiswaBindingSource1
            // 
            tambahMahasiswaBindingSource1.DataSource = typeof(TambahMahasiswa);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tambahButton);
            Controls.Add(TabelMahasiswa);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)TabelMahasiswa).EndInit();
            ((System.ComponentModel.ISupportInitialize)tambahMahasiswaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tambahMahasiswaBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TabelMahasiswa;
        private Button tambahButton;
        private BindingSource tambahMahasiswaBindingSource;
        private BindingSource tambahMahasiswaBindingSource1;
    }
}