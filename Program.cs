using System;
using rpg_project.src.Entities;

namespace rpg_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Aros",13,"Knight");
            Devil devil = new Devil("Urus",100,"Devil");
            Wizard wiz = new Wizard("Eve",10,"Wizard");
            
            Console.WriteLine(hero);
            Console.WriteLine(hero.Attack(devil.getName(), 40));
            Console.WriteLine(devil.gotDamage(50));
            Console.WriteLine("XP: "+hero.getXp());


        }
    }
}
