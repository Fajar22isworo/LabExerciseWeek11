using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabExerciseWeek11.EmployeeData
{
	public abstract class Karyawan
	{
		public string NIK {get;set;}
		public string Nama {get;set;}
        
        public Karyawan(string nik="null", string nama="null")
        {
            this.NIK = nik;
            this.Nama = nama;
        }
        
	public abstract double Gaji();
	}
}
