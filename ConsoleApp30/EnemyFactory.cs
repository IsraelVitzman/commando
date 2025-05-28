using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class EnemyFactory : Responcibility
    {

        static List<Responcibility> responcibilities = new List<Responcibility>();
        public EnemyFactory(string name, bool ifLife, string life, string voice) 
            : base (name, ifLife, life, voice)
        {
            
        
        }
        public void add (string name, bool ifLife, string life, string voice)
        {
            EnemyFactory enemyFactory = new EnemyFactory(name, ifLife, life, voice);    
            responcibilities.Add(enemyFactory);
        }
        

    }
}
