using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp30
{
    internal  class Game
    {
        static   EnemyFactory enemyFactory;
        static  EnemyFactoryCommando enemyFactoryCommando;
        static  Weponlist Weponlist;
        static void Main(string[] args)
        {   
            var input = Console.ReadLine();
            switch (input)
            {
                 case "1":
                    string name1 = Console.ReadLine();
                    bool ifLife = true;
                    string life = Console.ReadLine();
                    string voice = Console.ReadLine();
                    enemyFactory.add(name1 ,ifLife ,life,voice);

                    break;

                 case "2":

                    string name2 = Console.ReadLine();
                    string codeName= Console.ReadLine();
                    int chengeWeapon= int.Parse(Console.ReadLine());
                    int chengeStatus = int.Parse(Console.ReadLine());
                    enemyFactoryCommando.add(name2, codeName, chengeWeapon, chengeStatus);
                    break;

                 case "3":

                    string name3 = Console.ReadLine();
                    string manufacturer = Console.ReadLine();
                    int balls = int.Parse(Console.ReadLine());
                    Weponlist.add(name3, manufacturer, balls);
                    break;
                  default:
                    Console.WriteLine("invalid error");
                    break;
            }        

            

        }
    }
}
