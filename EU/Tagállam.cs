using System;

namespace EU
{
    class Tagállam
    {
        public string Név { get; set; }
        public DateTime CsatlakozásDátuma { get; set; }
        public Tagállam(string sor)
        {
            string[] s = sor.Split(';');
            Név = s[0];
            CsatlakozásDátuma = DateTime.Parse(s[1]);
        }
    }
}