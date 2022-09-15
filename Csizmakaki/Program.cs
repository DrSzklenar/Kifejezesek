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
            HarmadikFeladat();
            NegyedikFeladat();
            OtodikFeladat();

            Console.ReadKey();
        }

        private static void OtodikFeladat()
        {
            Dictionary<string, int> hang = new Dictionary<string, int>();
            for (int i = 0; i < adatok.Count; i++)
            {
                
            }
        }

        private static void NegyedikFeladat()
        {
            bool van = false;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].Elso % 10 == 0 && adatok[i].Harmadik % 10 == 0)
                {
                    van = true;
                    break;
                }
            }
            if (van == true)
            {
                Console.WriteLine($"Van benne olyan");
            }
        }

        private static void HarmadikFeladat()
        {
            int counter = 0;
            foreach (var i in adatok)
            {
                if (i.Masodik == "mod") counter++;
            }
            Console.WriteLine($"{counter} Darab osztás van");
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
