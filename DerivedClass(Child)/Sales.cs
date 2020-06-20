using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabExerciseWeek11.EmployeeData
{
	public class Sales : Karyawan
	{
		public double JumlahPenjualan {get;set;}
		public double Komisi {get;set;}
        
		public Sales(double jumlahPenjualan=0, double komisi=0)
		{
			this.JumlahPenjualan = jumlahPenjualan;
			this.Komisi = komisi;
		}
        
		public override double Gaji()
		{
			double Gaji = 0;
			Gaji = JumlahPenjualan * Komisi;
			return Gaji;
		}
	}
}