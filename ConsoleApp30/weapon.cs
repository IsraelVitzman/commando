using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Weapon
    {   
        private string name;
        private string manufacturer;
        private int balls;
        public Weapon(string name,string manufacturer, int balls) 
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.balls = balls;
        
        }
        public  void shoot()
        {
            Console.WriteLine("shoot.... boom!!!!!!!");
            this.balls-= 1;
        }

    }
}
