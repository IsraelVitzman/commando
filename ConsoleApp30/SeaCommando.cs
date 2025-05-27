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

        public SeaCommando(string name, string codeName, int changeWeapon, int changeStatus, string swime)
            : base(name, codeName, changeStatus, changeWeapon)
        {

            this.swime = swime;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"CodeName: {codeName}");
            Console.WriteLine($"Weapon: {weapon}");
            Console.WriteLine($"Status: {status}");
            Console.WriteLine($"parachutist: {swime}");
        }

    }
}
