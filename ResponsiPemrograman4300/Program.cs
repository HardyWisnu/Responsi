using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4300
{
    class Program
    {
        static void Main(String[] args)
        {
            Karyawan karyawan = new Karyawan();


            karyawan.NIK = "190302123";
            karyawan.Nama = "Paijo";
            karyawan.Gaji = 3000000;

            karyawan.NIK = "190302124";
            karyawan.Nama = "Jono";
            karyawan.Gaji = 2000000;


            karyawan.kayawan();
            karyawan.KenaikanGaji(Gaji);
            karyawan.kayawan();


        }
    }
}
