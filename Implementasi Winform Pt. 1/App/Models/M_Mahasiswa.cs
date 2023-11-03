using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementasi_Winform_Pt._1.App.Models
{
    internal class M_Mahasiswa
    {
        public int? Id { get; set; }
        public string Nama { get; set; }
        public string Nim { get; set; }
        public string Prodi { get; set; }

        private static List<M_Mahasiswa> dataMahasiswa = new List<M_Mahasiswa>
        {
            new M_Mahasiswa
            {
                Id =  1,
                Nama = "Christianus Yoga Wibisono",
                Nim = "212410101005",
                Prodi = "Sistem Informasi"
            },
            new M_Mahasiswa
            {
                Id = 2,
                Nama = "Reihan Wudd",
                Nim = "212410102005",
                Prodi = "Teknologi Informasi"
            }
        };

        public static List<M_Mahasiswa> all()
        {
            return dataMahasiswa;
        }

        public static M_Mahasiswa getById(int id)
        {
            return dataMahasiswa.FirstOrDefault(m => m.Id == id);
        }

        public static void create(string Nama, string Nim, string Prodi)
        {
            int nextId = dataMahasiswa.Count + 1; // Menentukan ID berikutnya
            M_Mahasiswa newMahasiswa = new M_Mahasiswa
            {
                Id = nextId,
                Nama = Nama,
                Nim = Nim,
                Prodi = Prodi
            };

            dataMahasiswa.Add(newMahasiswa); // Menambahkan mahasiswa baru ke daftar
        }

        public static void destroy(int id)
        {
            var hapusMahasiswa = dataMahasiswa.FirstOrDefault(m => m.Id == id);
            dataMahasiswa.Remove(hapusMahasiswa);
        }

        public static void update(int id, string Nama, string Nim, string Prodi)
        {
            var mahasiswaToUpdate = dataMahasiswa.FirstOrDefault(m => m.Id == id);

            if (mahasiswaToUpdate != null)
            {
                mahasiswaToUpdate.Nama = Nama;
                mahasiswaToUpdate.Nim = Nim;
                mahasiswaToUpdate.Prodi = Prodi;
            }
        }
    }
}
