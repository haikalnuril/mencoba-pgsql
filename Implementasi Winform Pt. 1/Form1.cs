using Implementasi_Winform_Pt._1.App.Models;

namespace Implementasi_Winform_Pt._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Insert init data
            TabelMahasiswa.DataSource = M_Mahasiswa.all();
            // Modifikasi datagridview
            DataGridViewButtonColumn ubahButton = new DataGridViewButtonColumn();
            ubahButton.HeaderText = "Ubah";
            ubahButton.Text = "Update";
            ubahButton.Name = "ubahButton";
            ubahButton.UseColumnTextForButtonValue = true;
            TabelMahasiswa.Columns.Insert(0, ubahButton);

            DataGridViewButtonColumn hapusButton = new DataGridViewButtonColumn();
            hapusButton.HeaderText = "Hapus";
            hapusButton.Text = "Delete";
            hapusButton.Name = "hapusButton";
            hapusButton.UseColumnTextForButtonValue = true;
            TabelMahasiswa.Columns.Insert(1, hapusButton);
        }
        private void tambahButton_Click(object sender, EventArgs e)
        {
            using (TambahMahasiswa formTambahMahasiswa = new TambahMahasiswa())
            {
                TambahMahasiswa halamanTambahMahasiswa = new TambahMahasiswa();
                halamanTambahMahasiswa.ShowDialog();
            }
            // kosongi data lalu isi kembali dengan object baru yang sudah diisi
            TabelMahasiswa.DataSource = null;
            TabelMahasiswa.DataSource = M_Mahasiswa.all();
        }

        private void TabelMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == TabelMahasiswa.Columns["hapusButton"].Index && e.RowIndex >= 0)
            {
                // Menyusun kode yang akan dijalankan saat tombol "Hapus" diklik
                // Anda bisa menggunakan e.RowIndex untuk mengidentifikasi baris yang diklik.
                // Misalnya, Anda dapat mengambil ID dari baris yang diklik dan kemudian menghapusnya dari data.

                int idToDelete = Convert.ToInt32(TabelMahasiswa.Rows[e.RowIndex].Cells["Id"].Value);

                // Panggil metode destroy dari kelas M_Mahasiswa untuk menghapus mahasiswa
                M_Mahasiswa.destroy(idToDelete);

                // Kemudian, perbarui DataGridView dengan data yang telah diperbarui
                TabelMahasiswa.DataSource = null;
                TabelMahasiswa.DataSource = M_Mahasiswa.all();
            }
            if(e.ColumnIndex == TabelMahasiswa.Columns["ubahButton"].Index && e.RowIndex >= 0)
            {
                int idToUpdate = Convert.ToInt32(TabelMahasiswa.Rows[e.RowIndex].Cells["Id"].Value);
                using (UbahMahasiswa formUpdateMahasiswa = new UbahMahasiswa(idToUpdate))
                {
                    UbahMahasiswa halamanUbahMahasiswa = new UbahMahasiswa(idToUpdate);
                    halamanUbahMahasiswa.ShowDialog();
                }
                TabelMahasiswa.DataSource = null;
                TabelMahasiswa.DataSource = M_Mahasiswa.all();
            }
        }
    }
}