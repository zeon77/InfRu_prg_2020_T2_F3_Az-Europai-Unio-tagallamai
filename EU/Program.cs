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
        }
    }
}
