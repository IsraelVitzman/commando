using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Abstrction
    {
        Commando commando;
        public Abstrction(string rank)
        {

            if (rank.Equals("GENERAL"))
            {
                Console.WriteLine(commando.getName()); 

            }else if (rank.Equals("comander"))
            {
                Console.WriteLine(commando.getcodeName()); 
            }
            else
            {
                Console.WriteLine("yoe have not acses");
            }
        }
            
    }
}
