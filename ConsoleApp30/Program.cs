using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Commando commando =new Commando("jhon","007",1,2);
            Weapon weapon = new Weapon("ak47","rusia",40);
            commando.walk();
            commando.Hide();
            commando.attack();
            Commando commando1 = new Commando("jho", "007", 1, 2);
            AirCommando airCommando = new AirCommando("david", "07",1,2);
            SeaCommando seaCommando = new SeaCommando("dav", "027", 1, 2);

            Commando[] sol = { commando1, airCommando, seaCommando };
            foreach (var s in sol)
            { 
                s.attack();
            }
        }
    }
}
