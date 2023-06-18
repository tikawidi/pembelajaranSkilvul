using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulasi sederhana Banget: ");
            Console.WriteLine("Pilian kalkulasi: ");
            Console.WriteLine(" (+) = Pertambahan");
            Console.WriteLine(" (-) = Pengurangan");
            Console.WriteLine(" (X) = Perkalian");
            Console.WriteLine(" (:) = Pembagian");
            Console.Write("Pilian kalkulasi anda dengan menekan sesuai dengan simbol kalkulasi: ");
            string input = Console.ReadLine();
            if (input == "+"){
                Penjumlahan();
            }
            else if (input == "-"){
                Pengurangan();
            }
            else if (input == "X"){
                Perkalian();
            }
            else if (input == ":"){
                Pembagian();
            }
            else 
            {
                Console.WriteLine("Kode salah");
            }

        }


        static void Penjumlahan()
        {
           Console.WriteLine("x: ");
           int x = int.Parse(Console.ReadLine());
           Console.WriteLine("y: ");
           int y = int.Parse(Console.ReadLine());
           int tambah = 0;
           tambah = x + y;
           Console.WriteLine("hasil= "+ x + "+ " + y + "= "+ tambah); 
           
        }
        static void Pengurangan()
        {
           Console.WriteLine("x: ");
           int x = int.Parse(Console.ReadLine());
           Console.WriteLine("y: ");
           int y = int.Parse(Console.ReadLine());
           int kurang = 0;
           kurang = x - y;
           Console.WriteLine("hasil= "+ x + "- " + y + "= "+ kurang); 
           
        }
        static void Perkalian()
        {
           Console.WriteLine("x: ");
           int x = int.Parse(Console.ReadLine());
           Console.WriteLine("y: ");
           int y = int.Parse(Console.ReadLine());
           int kali = 0;
           kali = x * y;
           Console.WriteLine("hasil= "+ x + "x " + y + "= "+ kali); 
           
        }
        static void Pembagian()
        {
           Console.WriteLine("x: ");
           double x = int.Parse(Console.ReadLine());
           Console.WriteLine("y: ");
           double y = int.Parse(Console.ReadLine());
           double bagi = 0;
           bagi = x / y;
           Console.WriteLine("hasil= "+ x + ": " + y + "= "+ bagi); 
           
        }
    }
}
