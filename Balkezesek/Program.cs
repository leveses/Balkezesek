using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace Balkezesek
{
    class Program
    {
        static List<Balkez> lista = new List<Balkez>();
        static int beker = 1995;
        static void Main(string[] args)
        {
            Beolvas();
            Console.Write("3. feladat: ");
            Feladat3();
            Console.Write("4. feladat: ");
            Feladat4();
            Console.WriteLine("5. feladat: ");
            Feladat5();
            Console.Write("6.feladat: ");
            Feladat6();
            Console.ReadKey();
        }

        private static void Feladat6()
        {
            int sum = 0;
            List<int> evszam = new List<int>();
            List<int> evszam2 = new List<int>();
            string[] sor = new string[3];
            foreach (var i in lista)
            {
                sor = i.ElsoP.Split('-');
                evszam.Add(int.Parse(sor[0]));
            }
            foreach (var i in lista)
            {
                sor = i.UtolsoP.Split('-');
                evszam2.Add(int.Parse(sor[0]));
            }
            int x = 0;
            for (int i = 0; i < lista.Count(); i++)
            {
                if (evszam[i]<=beker && evszam2[i]>=beker)
                {
                    sum = sum + lista[i].Suly;
                    x++;
                }
                
            }
            sum = sum / x;
            Console.WriteLine($"{sum} font");
        }

        private static void Feladat5()
        {
            //try
            //{
            //    beker = int.Parse(Console.ReadLine());
            //    Console.Write("Kérek egy 1990 és 1999 közötti évszámot!: ");
                
            //    if (beker>=1990 || beker<=1999)
            //    {
            //        Console.WriteLine(beker);
            //    }
                
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
        }

        private static void Feladat4()
        {
            foreach (var i in lista)
            {
                if (i.UtolsoP.Contains("1999-10"))
                {
                    Console.WriteLine($"{i.Nev}: {i.Magassag*2.54}cm");
                }
            }
        }

        private static void Feladat3()
        {
            int x = 0;
            foreach (var i in lista)
            {
                x = lista.Count();
            }
            Console.WriteLine(x);
        }

        private static void Beolvas()
        {
            StreamReader file = new StreamReader("balkezesek.csv");
            file.ReadLine();
            while (!file.EndOfStream)
            {
                lista.Add(new Balkez(file.ReadLine()));
            }
            file.Close();
        }
    }
}
