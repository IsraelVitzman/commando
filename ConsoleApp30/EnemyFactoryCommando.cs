using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class EnemyFactoryCommando : Commando
    {   
        static List<Commando> commandos = new List<Commando>();
        public EnemyFactoryCommando(string name, string codeName, int chengeWeapon, int chengeStatus) 
            : base (name , codeName , chengeWeapon, chengeStatus)
        {   

        }
        public void add(string name, string codeName, int chengeWeapon, int chengeStatus)
        {   
            Commando commando = new Commando(name,codeName,chengeWeapon,chengeStatus);
            commandos.Add(commando);
        }
    }
}
