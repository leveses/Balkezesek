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
        static int beker = 0;
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
            Console.WriteLine("7.feladat: ");
            Feladat7();
            Console.ReadKey();
        }

        private static void Feladat7()
        {
            
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
            bool hibas = false;
            do
            {

                Console.Write("Adjon meg egy évszámot 1990 és 1999 között: ");
                beker = int.Parse(Console.ReadLine());
                if (beker < 1990 || beker > 1999)
                {
                    hibas = true;
                    Console.WriteLine("Hibás adat adjon meg másik évszámot!");
                }
                else
                {
                    hibas = false;
                }
            }
            while (hibas);

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
