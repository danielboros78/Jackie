using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jackie
{
    class Program
    {
        static List<Race> lista = new List<Race>();
        static void Main(string[] args)
        {
            MasodikFeladat();
            HarmadikFeladat();
            NegyedikFeladat();
            Otodikfeladat();
            HatodikFeladat();
            Console.ReadKey();
        }

        private static void HatodikFeladat()
        {

        }

        private static void Otodikfeladat()
        {
            int hatvanas = 0;
            int hetvenes = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (1960 <= lista[i].Year && lista[i].Year <= 1969)
                {
                    hatvanas += lista[i].Wins;
                }
                if (1970 <= lista[i].Year && lista[i].Year <= 1979)
                {
                    hetvenes += lista[i].Wins;
                }
            }
            Console.WriteLine("5. feladat: ");
            Console.WriteLine($"\t70-es évek: {hetvenes} megnyert verseny");
            Console.WriteLine($"\t60-as évek: {hatvanas} megnyert verseny");
        }

        private static void NegyedikFeladat()
        {
            int maxYear = 0, maxRace = 0;
            foreach (var i in lista)
            {
                if (i.Races > maxRace)
                {
                    maxRace = i.Races;
                    maxYear = i.Year;
                }
            }
            Console.WriteLine($"4. feladat: {maxYear}");
        }

        private static void HarmadikFeladat()
        {
            Console.Write($"3. feladat: {lista.Count}\n");
        }

        private static void MasodikFeladat()
        {
            Console.WriteLine("2. feladat: Adatok beolvasása");
            StreamReader be = new StreamReader("jackie.txt");
            be.ReadLine();
            while (!be.EndOfStream)
            {
                string[] a = be.ReadLine().Split('\t');
                lista.Add(new Race(
                    int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), int.Parse(a[3]), int.Parse(a[4]), int.Parse(a[5])));
            }
            be.Close();
        }
    }
}
