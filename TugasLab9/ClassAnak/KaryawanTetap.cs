using System;
using System.Collections.Generic;
using System.Text;
using TugasLab9.ClassInduk;

namespace TugasLab9.ClassAnak
{
    public class KaryawanTetap : Karyawan
    {
       
        public double GajiBulanan { get; set; }

        


        public override double Gaji() => GajiBulanan;
      

    }
}
