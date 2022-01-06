using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HundeTuerSteuerung
{
    class Program
    {
        static void Main(string[] args)
        {
            HundeTuer tuer = new HundeTuer();
            BellErkennung erkennung  = new BellErkennung(tuer);
            FernSteurung fs =  new FernSteurung(tuer);
            Console.WriteLine("Fido bellt!");
            fs.DrueckeKnopf();
            //erkennung.Erkennen("wulf");
            Console.WriteLine("Fido geht raus! ....");
            Console.WriteLine("Fido  ist fertig! ....");
            try
            {
                Thread.Sleep(10000);
            }catch(Exception)
            {
                
            }
            Console.WriteLine("... aber ist ausgesperrt!");
            Console.WriteLine("Fido bellt.");
            erkennung.Erkennen("Wuff");
            Console.WriteLine("Fido ist wieder drinnen ....");
            Console.ReadKey();

        }
    }
}
