using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeTuerSteuerung
{
    class BellErkennung
    {
        private HundeTuer _tuer;

        public BellErkennung(HundeTuer tuer)
        {
            this._tuer = tuer;
        }

        public void Erkennen(string bellen)
        {
            Console.WriteLine("   BellErknnung: " + bellen + " gehoert");
            _tuer.Oeffnen();
        }
    }
}
