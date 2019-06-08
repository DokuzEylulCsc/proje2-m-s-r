using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Oteltipi
    {
        string tipi;
        public Oteltipi(string tip)
        {
            this.tipi = tip;
        }

        public string tip
        {
            get { return tipi; }
        }
    }
}
