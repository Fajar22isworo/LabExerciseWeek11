using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabExerciseWeek11.EmployeeData
{
	public class KaryawanTetap : Karyawan
	{
		public double GajiBulanan {get;set;}
        
        public KaryawanTetap(double gajiBulanan=0)
        {
            this.GajiBulanan = gajiBulanan;
        }
        
		public override double Gaji()
		{
			double Gaji = 0;
			Gaji = GajiBulanan;
			return Gaji;
		}
	}
}