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
            HetedikFeladat();
            NyolcasFeladat();
            Console.ReadKey();
        }

        private static void NyolcasFeladat()
        {
            StreamWriter sw = new StreamWriter("Eredmenyek.txt");
            for (int i = 0; i < adatok.Count; i++)
            {
                sw.WriteLine($"{adatok[i].Elso} {adatok[i].Masodik} {adatok[i].Harmadik} =  {Szamitas(Convert.ToDouble(adatok[i].Elso), adatok[i].Masodik, Convert.ToDouble(adatok[i].Harmadik))}");

            }
            sw.Close();
        }

        private static string Szamitas(double v1, string v2, double v3)
        {
            string temp = "";
            switch (v2)
            {
                case "+":
                    return temp = Convert.ToString(v1 + v3);
                    break;

                case "-":
                    return temp = Convert.ToString(v1 - v3);
                    break;

                case "*":
                    return temp = Convert.ToString(v1 * v3);
                    break;

                case "/":
                    return temp = Convert.ToString(v1 / v3);
                    break;

                case "div":
                    return temp = Convert.ToString(Math.Round(v1 / v3));
                    break;

                case "mod":
                    return temp = Convert.ToString(v1 / v3);
                    break;



                default:
                    return "hibás operátor!";
                    break;
            }
        }

        private static void HetedikFeladat()
        {
            Console.WriteLine("Írjon be egy kifejezést");
            string[] geccccccooo = Console.ReadLine().Split();
            Console.WriteLine(Szamitas(Convert.ToDouble(geccccccooo[0]), geccccccooo[1], Convert.ToDouble(geccccccooo[2])));
        }

        private static void OtodikFeladat()
        {
            Dictionary<string, int> statisztika  = new Dictionary<string, int>();
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].Masodik == "div" || adatok[i].Masodik == "mod" || adatok[i].Masodik == "+" || adatok[i].Masodik == "-" || adatok[i].Masodik == "*" || adatok[i].Masodik == "/")
                {
                    if (!statisztika.ContainsKey(adatok[i].Masodik))
                    {

                        statisztika.Add(adatok[i].Masodik, 1);
                    }
                    else
                    {
                        statisztika[adatok[i].Masodik]++;
                    }
                }
            }
            foreach (var i in statisztika)
            {
                Console.WriteLine($"\t{i.Key} -> {i.Value}");
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
