using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopRobotar
{
    class Robot
    {
        public static int antalRobotar;
        private char verksamhet;
        private ushort manad;

        public Robot()
        {
            if(antalRobotar < Globals.klarAntal)
                antalRobotar++;
            verksamhet = 's';
            manad = 0;
        }

        public char Verksamhet
        { 
            get { return verksamhet; }
            set { verksamhet = value; }
        }

        public ushort Manad
        {
            get { return manad; }
            set { manad = value; }
        }

        public string visaRobot()
        {
            string resultat = "";
            if (verksamhet == 's')
                resultat += "Denna robot samlar ";
            else
                resultat += "Denna robot bygger ";

            resultat += "och det är månad " + manad;
            return resultat;
        }

    }
}
