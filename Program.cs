using System;
using System.Collections.Generic;
using TugasPolyDanCol.ClassAnak;
using TugasPolyDanCol.ClassInduk;

namespace TugasPolyDanCol
{
	class Program
	{
		static void Main(string[] args)
		{
            		Console.Title = "Aplikasi Perhitungan Gaji Karyawan";

            		karyawanHarian karyawan1 = new karyawanHarian();
            		karyawan1.Nik = "2643";
            		karyawan1.Nama = "Mohammad";
            		karyawan1.upahPerjam = 70000;
            		karyawan1.jumlahJam = 8;

            		karyawanTetap karyawan2 = new karyawanTetap();
            		karyawan2.Nik = "1976";
            		karyawan2.Nama = "Naufal";
            		karyawan2.gajiBulanan = 4000000;

            		sales karyawan3 = new sales();
            		karyawan3.Nik = "1933";
            		karyawan3.Nama = "Hafiizh";
            		karyawan3.jumlahPenjualan = 30;
            		karyawan3.komisi = 100000;

            		List<Karyawan> listKaryawan = new List<Karyawan>();
            		listKaryawan.Add(karyawan1);
            		listKaryawan.Add(karyawan2);
            		listKaryawan.Add(karyawan3);

            		int nomorUrut = 1;

            		foreach(Karyawan karyawan in listKaryawan)
            		{
                		Console.WriteLine("{0}." + " " + "Nik : {1}" + "\t" + "Nama : {2}" + "\t" + "Gaji : {3}", nomorUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                		nomorUrut++;
            		}
            		Console.ReadKey();
        	}
	}
}
