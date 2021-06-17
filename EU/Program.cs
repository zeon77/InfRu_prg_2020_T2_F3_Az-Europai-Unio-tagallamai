using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace EU
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            List<Tagállam> tagállamok = new List<Tagállam>();
            foreach (var sor in File.ReadAllLines("EUcsatlakozas.txt", Encoding.UTF8))
                tagállamok.Add(new Tagállam(sor));

            //3. feladat
            Console.WriteLine($"3. feladat: Az EU tagállamainak száma: {tagállamok.Count} db");

            //4. feladat
            Console.WriteLine($"4. feladat: 2007-ben {tagállamok.Where(x => x.CsatlakozásDátuma.Year == 2007).Count()} ország csatlakozott.");

            //5. feladat
            Console.WriteLine($"5. feladat: Magyarország csatlakozásának dátuma: " +
                $"{tagállamok.Single(x => x.Név == "Magyarország").CsatlakozásDátuma.ToString("yyyy.MM.dd")}");

            //6. feladat
            bool volt = tagállamok.Any(x => x.CsatlakozásDátuma.Month == 5);
            Console.WriteLine($"6. feladat: Májusban {(volt ? "volt" : "nem volt")} csatlakozás");

            //7. feladat
            Console.WriteLine($"7. feladat: Legutoljára csatlakozott ország: {tagállamok.OrderBy(x => x.CsatlakozásDátuma).Last().Név}");

            //8. feladat
            Console.WriteLine($"8. feladat: Statisztika");
            tagállamok
                .GroupBy(x => x.CsatlakozásDátuma.Year)
                .Select(group => new { Ország = group.Key, Darab = group.Count() })
                .ToList()
                .ForEach(x => Console.WriteLine($"\t {x.Ország} - {x.Darab} ország"));
        }
    }
}
