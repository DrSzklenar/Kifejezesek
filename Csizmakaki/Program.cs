using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csizmakaki
{

    class Program
    {
        static List<AdatGorcs> adatok = new List<AdatGorcs>();

        static void Main(string[] args)
        {
            ElsoFeladat();
            MasodikFeladat();

        }

        private static void MasodikFeladat()
        {
            Console.WriteLine($"Az állományban {adatok.Count} kifejezés van");
        }

        private static void ElsoFeladat()
        {
            using (StreamReader sr = new StreamReader("kifejezesek.txt"))
            {
                while (!sr.EndOfStream)
                {
                    adatok.Add(new AdatGorcs(sr.ReadLine()));
                }
            }
        }
    }
}
