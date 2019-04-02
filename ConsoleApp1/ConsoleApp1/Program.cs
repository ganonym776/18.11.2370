using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanmethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarasi variable
            int hasil;

            //membuat objek dari class calculator
            Kalkulator kalkulator = new Kalkulator();

            //penggil method penjumlah
            hasil = kalkulator.Penjumlah(10, 2);
            CetakHasil("Hasil Penjumlahan = " + hasil);

            //panggil method penjumlah dengan 3 parameter
            hasil = kalkulator.Penjumlah(10, 2, 3);
            CetakHasil("Hasil Penjumlahan = " + hasil);

            //panggil method pengurangan
            hasil = kalkulator.Pengurangan(7, 2);
            CetakHasil("Hasil Pengurangan = " + hasil);

            //panggil static method, langsung dari nama classnya
            hasil = Kalkulator.Perkalian(5, 2);
            CetakHasil("Hasil Perkalian = " + hasil);

            Console.ReadKey();
        }
        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}
