using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Mahasiswa
    {
        public Mahasiswa()
        {
        }

        //constructor dengan 2 parameter
        public Mahasiswa(string nim, string nama)
        {
            Nim = nim;
            Nama = nama;
        }

        //properties
        public string Nim { get; set; }
        public string Nama { get; set; }
    }
}
