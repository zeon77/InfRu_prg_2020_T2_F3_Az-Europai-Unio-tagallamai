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

        }
    }
}
