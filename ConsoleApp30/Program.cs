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
        }
    }
}
