using System;
using System.Collections.Generic;
using System.Text;
using TugasLab9.ClassInduk;

namespace TugasLab9.ClassAnak
{
    public class KaryawanHarian : Karyawan
    {

        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }

        public override double Gaji() => UpahPerJam * JumlahJamKerja;
       
    }
}
