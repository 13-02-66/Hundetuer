using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace HundeTuerSteuerung
{
    class FernSteurung
    {
        private readonly HundeTuer tuer;

        public FernSteurung(HundeTuer tuer)
        {
            this.tuer = tuer;
        }
        public void DrueckeKnopf()
        {
            Console.WriteLine("Druecke Fernsteuerungskopf");
            if(tuer.IsOffen())
            {
                tuer.Schließen();
            }
            else
            {
                tuer.Oeffnen();
   
            }

        }
        

        
    }
}
