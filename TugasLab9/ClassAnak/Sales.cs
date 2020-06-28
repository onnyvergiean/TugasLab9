using System;
using System.Collections.Generic;
using System.Text;
using TugasLab9.ClassInduk;

namespace TugasLab9.ClassAnak
{
   class Sales : Karyawan
    {
       
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }

        public override double Gaji() => JumlahPenjualan * Komisi;
        
    }
}
