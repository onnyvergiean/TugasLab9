using System;
using System.Collections.Generic;
using System.Text;
using TugasLab9.ClassAnak;

namespace TugasLab9.ClassInduk
{
    public abstract class Karyawan
    {
        public abstract double Gaji();
        public string NIK { get; set; }
        public string Nama { get; set; }
        
        public string jenis(object karyawan)
        {
            if(karyawan is KaryawanTetap)
            {
                return ("Karyawan Tetap");
            }
            else if(karyawan is KaryawanHarian)
            {
                return ("Karyawan Harian");
            }
            else
            {
                return ("Sales");
            }

            throw new ArgumentException("Salah");
        }

        
    }
}
