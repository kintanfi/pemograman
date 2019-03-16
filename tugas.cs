using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilih;
            float x, y, z, a;
        menu:
            Console.WriteLine("Menu pilihan kalkulator");
            Console.WriteLine("1.Penjumlahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");
            Console.WriteLine("====Masukkan pilihan (1-4)====");
            pilih = Convert.ToInt16(Console.ReadLine());
            switch (pilih)
            {
                case 1:
                    Console.WriteLine("===Anda Memilih Penjumlahan===");
                    Console.WriteLine("Masukkan angka 1 : ");
                    x = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Masukkan angka 2 : ");
                    y = Convert.ToSingle(Console.ReadLine());
                    z = x + y;
                    Console.WriteLine("Hasilnya adalah " + z);
                    Console.WriteLine("Apakah ingin kembali ke menu ? (1=Yes/2=No) ");
                    a = Convert.ToInt16(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            goto menu;
                            break;
                        default:
                            goto selesai;
                            break;
                    }

                    Console.ReadKey();

                    break;
                case 2:
                    Console.WriteLine("===Anda Memilih Pengurangan===");
                    Console.WriteLine("Masukkan angka 1 : ");
                    x = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Masukkan angka 2 : ");
                    y = Convert.ToSingle(Console.ReadLine());
                    z = x - y;
                    Console.WriteLine("Hasilnya adalah " + z);
                    Console.WriteLine("Apakah ingin kembali ke menu ? (1=Yes/2=No) ");
                    a = Convert.ToInt16(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            goto menu;
                            break;
                        default:
                            goto selesai;
                            break;
                    }

                    Console.ReadKey();

                    break;
                case 3:
                    Console.WriteLine("===Anda Memilih Perkalian===");
                    Console.WriteLine("Masukkan angka 1 : ");
                    x = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Masukkan angka 2 : ");
                    y = Convert.ToSingle(Console.ReadLine());
                    z = x * y;
                    Console.WriteLine("Hasilnya adalah " + z);
                    Console.WriteLine("Apakah ingin kembali ke menu ? (1=Yes/2=No) ");
                    a = Convert.ToInt16(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            goto menu;
                            break;
                        default:
                            goto selesai;
                            break;
                    }

                    Console.ReadKey();

                    break;
                case 4:
                    Console.WriteLine("===Anda Memilih Pembagian===");
                    Console.WriteLine("Masukkan angka 1 : ");
                    x = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Masukkan angka 2 : ");
                    y = Convert.ToSingle(Console.ReadLine());
                    z = x / y;
                    Console.WriteLine("Hasilnya adalah " + z);
                    Console.WriteLine("Apakah ingin kembali ke menu ? (1=Yes/2=No) ");
                    a = Convert.ToInt16(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            goto menu;
                            break;
                        default:
                            goto selesai;
                            break;
                    }

                    Console.ReadKey();

                    break;
                default:
                    Console.WriteLine("Maaf Pilihan anda tidak tersedia");
                    Console.ReadKey();
                    break;
            }
        selesai:
            Console.WriteLine("====================");
            Console.WriteLine("=====Thanks You=====");
            Console.WriteLine("====================");
            Console.ReadKey();

        }
    }
}
