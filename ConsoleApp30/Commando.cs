using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Commando
    {
        public string name {  get; set; }
        public string codeName {  get; set; }

        protected string status;
        protected string weapon;


        private string[] listweapon = { "Chisel", " bag", "hammer", "rope", "water" };
        private string[] listStatus = { "stande", "going", "hiding" };

        public Commando(string name, string codeName,int chengeWeapon, int chengeStatus)
        {
            this.name = name;
            this.codeName = codeName;
            this.weapon = listweapon[chengeWeapon];
            this.status = listStatus[chengeStatus];

        }
        public string getcodeName()
        {
           return this.codeName;
        }
        public string getName()
        {
            return this.name;
        }
        public void setcodeName(string codeName)
        {
             this.codeName=codeName;
        }
        public void setName(string name)
        {
            this.name = name;
        }





        public void walk()
        { 
           this.status=listStatus[1];
           Console.WriteLine(this.status);
        }
        public void Hide()
        {
            this.status = listStatus[listStatus.Length-1];
            Console.WriteLine(this.status);
        }
        public void attack()
        {
            Console.WriteLine($"attack now: {this.codeName}");
        }
    }
}
