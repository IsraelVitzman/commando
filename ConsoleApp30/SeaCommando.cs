using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class SeaCommando : Commando
    {


        private string swime;
        private string[] listweapon = { "Chisel", "Bag", "Hammer", "Rope", "Water" };
        private string[] listStatus = { "Standby", "Going", "Hiding" };

        public SeaCommando(string name, string codeName, int changeWeapon, int changeStatus)
            : base(name, codeName, changeStatus, changeWeapon)
        {

            swime = "swimeing";
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"CodeName: {codeName}");
            Console.WriteLine($"Weapon: {weapon}");
            Console.WriteLine($"Status: {status}");
            Console.WriteLine($"parachutist: {swime}");
        }
        public override void attack()
        {
            Console.WriteLine($"attack now blu blu blu: {this.codeName}");
        }
    }
}
