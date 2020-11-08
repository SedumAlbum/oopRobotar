using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopRobotar
{
    class MaskinPark
    {
        private Robot[] mp;

        public MaskinPark()
        {
            mp = new Robot[Globals.klarAntal];
        }

        public void add(Robot r)
        {
            if (Robot.antalRobotar < Globals.klarAntal)
                mp[Robot.antalRobotar - 1] = r;
            else
            {
                mp[Globals.klarAntal - 1] = r;
                Globals.klar = true;
            }
        }

        public string dennaManad()
        {
            int s = 0, b = 0;            
            for(int i = 0; i < Robot.antalRobotar; i++)
            {
                    if (mp[i].Verksamhet == 's')
                        s++;
                    else
                        b++;           
            }
            string resultat = " samlar " + s + " st och bygger " + b + " st robotar.";
            return resultat;
        }

        public void tick()
        {
            int nyRobot = 0;
            for (int i = 0; i < Robot.antalRobotar; i++)
            {
                if (mp[i].Verksamhet == 's' && mp[i].Manad < Globals.samlar)
                    mp[i].Manad++;
                else if(mp[i].Verksamhet == 's')
                {
                    mp[i].Verksamhet = 'b';
                    mp[i].Manad = 1;
                }
                else if (mp[i].Verksamhet == 'b' && mp[i].Manad < Globals.bygger)
                {
                    mp[i].Manad++;
                    nyRobot++;
                }
                else
                {
                    mp[i].Verksamhet = 's';
                    mp[i].Manad = 1;
                    nyRobot++;
                }
            }
            for (int i = 0; i < nyRobot; i++)
                this.add(new Robot());
        }
    }
}