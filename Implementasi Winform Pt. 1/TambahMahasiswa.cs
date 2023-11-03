using Implementasi_Winform_Pt._1.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Implementasi_Winform_Pt._1
{
    public partial class TambahMahasiswa : Form
    {
        Form1 form1;
        public TambahMahasiswa()
        {
            InitializeComponent();
            this.form1 = new Form1();
        }

        private void tombolSimpan_Click(object sender, EventArgs e)
        {
            var nama = Nama.Text;
            var nim = Nim.Text;
            var prodi = Prodi.Text;

            // Tambahkan data baru ke model M_Mahasiswa
            M_Mahasiswa.create(nama, nim, prodi);

            DialogResult message = MessageBox.Show("Data berhasil ditambahkan", "Sukses", MessageBoxButtons.OK);
            if(message == DialogResult.OK)
            {
                // tutup form tambahMahasiswa
                this.Close();

            }
        }
    }
}
