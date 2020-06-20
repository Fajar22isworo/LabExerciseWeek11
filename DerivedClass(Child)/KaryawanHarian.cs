using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabExerciseWeek11.EmployeeData
{
	public class KaryawanHarian : Karyawan
	{
		public double UpahPerJam {get;set;}
		public double JumlahJamKerja {get;set;}
        
        public KaryawanHarian(double upahPerJam=0, double jumlahJamKerja=0)
        {
            this.UpahPerJam = upahPerJam;
            this.JumlahJamKerja = jumlahJamKerja;
        }
        
		public override double Gaji()
		{
			double Gaji = 0;
			Gaji = UpahPerJam * JumlahJamKerja;
			return Gaji;
		}
	}
}