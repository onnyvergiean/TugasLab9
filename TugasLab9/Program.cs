using System;
using TugasLab9.ClassInduk;
using TugasLab9.ClassAnak;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace TugasLab9
{
    public class Program 
    {
        static void Main(string[] args)
        {
            List<Karyawan> listKaryawan = new List<Karyawan>();

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            KaryawanHarian karyawanHarian = new KaryawanHarian();
            Sales sales = new Sales();

            void menu(List<Karyawan> listKaryawan)
            {  
            back:
                Console.Clear();
                Console.WriteLine("Pilih Menu Aplikasi");
                Console.WriteLine();

                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("5. About Me");

                Console.WriteLine();
                Console.Write("Nomor Menu [1..5]: ");
                int Menu = int.Parse(Console.ReadLine());
                if (Menu == 1)
                {

                    tambahDataKaryawan(listKaryawan);
                    Console.WriteLine();
                }
                else if (Menu == 2)
                {
                    hapusDataKaryawan(listKaryawan);
                    Console.WriteLine();
                }
                else if (Menu == 3)
                {
                    tampilDataKaryawan(listKaryawan);
                    Console.WriteLine();
                }
                else if (Menu == 4)
                {
                    System.Environment.Exit(1);
                }
                else if (Menu == 5)
                {
                    aboutme();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Input Salah");
                    goto back;
                }
            }

            void tambahDataKaryawan(List<Karyawan> listKaryawan)
            {
            back:
                Console.Clear();
                Console.WriteLine("Tambah Data Karyawan");
                Console.WriteLine();

                Console.Write("Jenis Karyawan [1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : ");

                int kar = int.Parse(Console.ReadLine());
                if (kar == 1)
                {
                    Console.Write("NIK : ");
                    karyawanTetap.NIK = Console.ReadLine();
                    Console.Write("Nama : ");
                    karyawanTetap.Nama = Console.ReadLine();
                    Console.Write("Gaji Bulanan : ");
                    karyawanTetap.GajiBulanan = Convert.ToDouble(Console.ReadLine());

                    listKaryawan.Add(karyawanTetap);

                    Console.WriteLine();
                    Console.WriteLine("Tekan Enter Untuk Kembali Ke Menu");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        menu(listKaryawan);
                    }
                    else
                    {
                        Console.WriteLine("Inputan Salah");
                        goto back;
                    }
                }
                else if (kar == 2)
                {
                    Console.Write("NIK : ");
                    karyawanHarian.NIK = Console.ReadLine();
                    Console.Write("Nama : ");
                    karyawanHarian.Nama = Console.ReadLine();
                    Console.Write("Upah Per Jam : ");
                    karyawanHarian.UpahPerJam = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Jumlah Jam Kerja : ");
                    karyawanHarian.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());

                    listKaryawan.Add(karyawanHarian);

                    Console.WriteLine();
                    Console.WriteLine("Tekan Enter Untuk Kembali Ke Menu");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        menu(listKaryawan);
                    }
                    else
                    {
                        Console.WriteLine("Inputan Salah");
                        goto back;
                    }
                }
                else if (kar == 3)
                {
                    Console.Write("NIK : ");
                    sales.NIK = Console.ReadLine();
                    Console.Write("Nama : ");
                    sales.Nama = Console.ReadLine();
                    Console.Write("Jumlah Penjualan : ");
                    sales.JumlahPenjualan = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Komisi : ");
                    sales.Komisi = Convert.ToDouble(Console.ReadLine());

                    listKaryawan.Add(sales);

                    Console.WriteLine();
                    Console.WriteLine("Tekan Enter Untuk Kembali Ke Menu");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        menu(listKaryawan);
                    }
                    else
                    {
                        Console.WriteLine("Inputan Salah");
                        goto back;
                    }

                }
                else
                {
                    Console.WriteLine("Inputan Anda Salah!");
                    goto back;
                }
            }


            void hapusDataKaryawan(List<Karyawan> listKaryawan)
            {
                Console.Clear();
                bool ketemu = false;
                Console.WriteLine("Hapus Data Karyawan");
                Console.Write("NIK : ");
                string nik = Console.ReadLine();

                for(int i =0;i<listKaryawan.Count;i++)
                {
                    if (listKaryawan[i].NIK == nik)
                    {
                        listKaryawan.Remove(listKaryawan[i]);
                        ketemu = true;
                    }
                    else
                    {
                        ketemu = false;
                    } 
                }

                if (ketemu == false)
                {
                    Console.WriteLine("NIK tidak ditemukan");
                }
                else
                {
                    Console.WriteLine("Data Karyawan Berhasil dihapus");
                }

            back:
                Console.WriteLine();
                Console.WriteLine("Tekan Enter Untuk Kembali Ke Menu");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    menu(listKaryawan);
                }
                else
                {
                    Console.WriteLine("Inputan Salah");
                    goto back;
                }
            }



            void tampilDataKaryawan(List<Karyawan> listKaryawan)
            {
                Console.Clear();
                int noUrut = 1;
                foreach (Karyawan karyawan in listKaryawan)
                {
                    Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3:N0}, {4}",
                        noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji(), karyawan.jenis(karyawan));
                  
                    noUrut++;

                }
                back:
                Console.WriteLine();
                Console.WriteLine("Tekan Enter Untuk Kembali Ke Menu");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    menu(listKaryawan);
                }
                else
                {
                    Console.WriteLine("Inputan Salah");
                    goto back;
                }
            }

            void aboutme()
            {
            back:
                Console.Clear();
                Console.WriteLine("ABOUT ME");
                Console.WriteLine("CREATED BY");
                Console.WriteLine("Onny Vergiean Saputra");
                Console.WriteLine("19.11.27371");
                Console.WriteLine();
                Console.WriteLine("Tekan Enter Untuk Kembali Ke Menu");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    menu(listKaryawan);
                }
                else
                {
                    Console.WriteLine("Inputan Salah");
                    goto back;
                }
            }
            menu(listKaryawan);
 
        }
    }
}
