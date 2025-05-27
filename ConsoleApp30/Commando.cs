using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Commando
    {
        private string name;
        private string codeName;
        private string status;

        private string[] weapon = { "Chisel", " bag", "hammer", "rope", "water" };
        private string[] listStatus = { "stande", "going", "hiding" };
        public Commando(string name, string codeName, string[] weapon, int chengeStatus)
        {
            this.name = name;
            this.codeName = codeName;
            this.weapon = weapon;
            this.status = listStatus[chengeStatus];

        }
        public void alk()
        { 
           this.status=listStatus[1];
           Console.WriteLine(this.status);
        }
        public void Hide()
        {
            this.status = listStatus[listStatus.Length];
            Console.WriteLine(this.status);
        }
        public void attack()
        {
            Console.WriteLine($"attack now: {this.codeName}");
        }
    }
}
