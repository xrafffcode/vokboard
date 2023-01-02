using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator");

            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Masukkan angka pertama : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan Operator : ");
            Console.WriteLine("\ta - +");
            Console.WriteLine("\ts - -");
            Console.WriteLine("\tm - *");
            Console.WriteLine("\td - %");
            string op = Console.ReadLine();
            Console.WriteLine("Masukkan angka kedua : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case "a":
                    Console.WriteLine("Hasil : " + (num1 + num2));
                    Console.WriteLine("Apakah ingin melakukan perhitungan lagi? (y/n)");
                    break;
                case "s":
                    Console.WriteLine("Hasil : " + (num1 - num2));
                    Console.WriteLine("Apakah ingin melakukan perhitungan lagi? (y/n)");
                    break;
                case "m":
                    Console.WriteLine("Hasil : " + (num1 * num2));
                    Console.WriteLine("Apakah ingin melakukan perhitungan lagi? (y/n)");
                    break;
                case "d":
                    Console.WriteLine("Hasil : " + (num1 / num2));
                    Console.WriteLine("Apakah ingin melakukan perhitungan lagi? (y/n)");
                    break;
                default:
                    Console.WriteLine("Operator tidak dikenali");
                    break;
            }

            string answer = Console.ReadLine();
            if (answer == "y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Terima kasih telah menggunakan kalkulator ini");
            }
        }  
    }
}
