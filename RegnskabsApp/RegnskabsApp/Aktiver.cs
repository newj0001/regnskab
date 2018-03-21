using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegnskabsApp
{
    class Aktiver
    {
        
    }
    class AnlaegsAktiver
    {
        public int ImmaterielleAktiver { get; set; }
        public int Materielle { get; set; }
        public int Finansielle { get; set; }
        public AnlaegsAktiver()
        {
            int sum;
            sum = ImmaterielleAktiver + Materielle + Finansielle;
        }
    }
}
