using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HundeTuerSteuerung
{
    class HundeTuer
    {
        public Timer aTimer = new Timer();  
        private bool _offen;

        public bool Offen
        {
            get
            {
                return _offen;
            }
            set
            {
                _offen = value;
            }
        }

        public HundeTuer()
        {
            this._offen = false;
            this.aTimer.Interval = 2000;
            this.aTimer.Elapsed += OnTimedEvent;
            this.aTimer.AutoReset = false;
        }

        public void Oeffnen()
        {
            Console.WriteLine("Die Hundetuer geht auf");
            _offen = true;
            aTimer.Start();
        }
        public void Schließen()
        {
            Console.WriteLine("Die Hundetuer geht zu");
            _offen = false; 
        }
        public bool IsOffen()
        {
            return _offen;
        }
        
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Schließen();
            aTimer.Stop();   
        }
    }
}
