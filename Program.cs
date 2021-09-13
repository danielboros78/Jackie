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

        }

        private static void NegyedikFeladat()
        {

        }

        private static void HarmadikFeladat()
        {
            Console.Write($"3. feladat: {lista.Count}");
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
