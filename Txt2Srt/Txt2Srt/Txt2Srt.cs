using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Txt2Srt
{
    class Txt2Srt
    {
        static List<IdozitettFelirat> felirat = new List<IdozitettFelirat>();

        static void Main(string[] args)
        {
            Beolvas();
            FeladatKiiras FK = new FeladatKiiras("5. feladat");
            FK.FKiiras();
            Console.WriteLine("Feliratok száma: {0}", felirat.Count());
            FeladatKiiras FK2 = new FeladatKiiras("7. feladat");
            FK2.FKiiras();
            Console.WriteLine(Legtobb());
            Console.WriteLine();
            FeladatKiiras FK3 = new FeladatKiiras("8. feladat");
            FK3.FKiiras();
            Srtkeszites();


            Console.ReadKey();
        }

        static void Beolvas()
        {
            StreamReader sr = new StreamReader("feliratok.txt");
            string sor = sr.ReadLine();
            string sor2;
            while (sor != null)
            {
                sor2 = sr.ReadLine();
                felirat.Add(new IdozitettFelirat (sor, sor2));
                sor = sr.ReadLine();
            }
            sr.Close();
        }
    
        static string Legtobb()
        {
            string lh = felirat[0].Felirat;
            foreach (IdozitettFelirat item in felirat)
            {
                if (item.SzavakSzama(item.Felirat)>item.SzavakSzama(lh))
                {
                    lh = item.Felirat;
                }
            }
            return lh;
        }

        static void Srtkeszites()
        {
            StreamWriter sw = new StreamWriter("felirat.srt");
            int ssz = 0;
            foreach (IdozitettFelirat item in felirat)
            {
                ssz++;
                sw.WriteLine(ssz);
                sw.WriteLine(item.SrtIdozites(item.Idozites));
                sw.WriteLine(item.Felirat);
                sw.WriteLine();
            }
        }
    
    }
}
