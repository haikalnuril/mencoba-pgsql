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
    public partial class UbahMahasiswa : Form
    {
        private int idMahasiswa;
        public UbahMahasiswa(int Id)
        {
            InitializeComponent();
            this.idMahasiswa = Id;
            var dataMahasiswa = M_Mahasiswa.getById(this.idMahasiswa);
            Nama.Text = dataMahasiswa.Nama;
            Nim.Text = dataMahasiswa.Nim;
            Prodi.Text = dataMahasiswa.Prodi;
        }

        private void ubahButton_Click(object sender, EventArgs e)
        {
            var nama = Nama.Text;
            var nim = Nim.Text;
            var prodi = Prodi.Text;

            // Tambahkan data baru ke model M_Mahasiswa
            M_Mahasiswa.update(this.idMahasiswa, nama, nim, prodi);

            DialogResult message = MessageBox.Show("Data berhasil diubah", "Sukses", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                // tutup form tambahMahasiswa
                this.Close();

            }
        }
    }
}
