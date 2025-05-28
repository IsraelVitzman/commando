using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Weponlist :Weapon 
    {   
        static List<Weapon> weapons=new List<Weapon>();
        public Weponlist(string name, string manufacturer, int balls) 
            : base(name, manufacturer, balls)
        {

        }
        public void add(string name, string manufacturer, int balls)
        {   
            Weapon weapon = new Weapon(name, manufacturer, balls);
            weapons.Add(weapon);
        }
        
    }
}
