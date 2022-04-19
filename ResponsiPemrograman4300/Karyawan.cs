using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4300
{
    internal class Karyawan
    {
        public String NIK { get; set; }
        public String Nama { get; set; }
        public int Gaji { get; set; }
        public void kayawan()
        {
            Console.WriteLine("N0 |NIK\t\t |Nama\t\t |Gaji");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1  |{0}\t |{1}\t\t |{2}", NIK, Nama, Gaji);
            Console.WriteLine("2  |{0}\t |{1}\t\t |{2}", NIK, Nama, Gaji);
        }

        public void KenaikanGaji(int Gaji)
        {
            int Gajibaru;

            Console.WriteLine("Assik Kenaikan Gaji 10%");
            Gajibaru = Gaji * 110;
            Gaji = Gajibaru / 100;

        }
    }
}
