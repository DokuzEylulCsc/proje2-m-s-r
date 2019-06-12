using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevKonsol
{
    class Yonetici
    {
        private string id;
        private string sifre;

        public string Id { get => id; }
        public string Sifre { get => sifre; }
        public Yonetici(string k_id,string s_sifre)
        {
            this.id = k_id;
            this.sifre = s_sifre;
        }
        public bool KontrolEt()
        {
            if (id=="admin" && sifre=="pass")
                return true;
            else
                return false;
        }
    }
}
