using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class Program
    { 
        enum Swords {Excalibur, Durendal, Muramasa, Skofnung, Rebellion, Yamato};
        static void Main(string[] args)
        {            
            string heroName = "", swordName="";
            int choice;
            string exit="t";
            Random rnd = new Random();   
            Console.WriteLine("Witaj w moim sklepie..");
            Console.Write("\nPodaj swoje imie: ");
            heroName = Console.ReadLine();
            Player player = new Player(heroName);
            Console.WriteLine("");
            player.Display();
            while (exit=="t")
            {
                Console.Clear();
                swordName = Convert.ToString((Swords)rnd.Next(0, 5));
                Weapon sword = new Weapon(swordName, rnd.Next(10, 50), 10, rnd.Next(80, 100));
                ToUse potion = new ToUse("potion", 20, 5, 50, "leczenie");
                Armor helm = new Armor("helm", rnd.Next(20, 30), 10, rnd.Next(20, 30));
                Console.WriteLine("\n{0}, dzisiaj dostaniesz u mnie:", heroName);
                Console.WriteLine("\n1) Miecz ({0}) - cena: {1} | dmg: {2}", swordName, sword.Price(), sword.Damage);
                Console.WriteLine("\n2) Mikstura - cena: {0} | heal: {1}", potion.Price(), 50);
                Console.WriteLine("\n3) Helm - cena: {0} | def: {1}", helm.Price(), helm.Defence);
                Console.Write("\nCo wybierasz: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                if (choice == 1)
                {
                    sword.Display();
                    player.Damage = player.Damage + sword.Damage;
                    player.Cash = player.Cash - sword.Price();
                }
                if (choice == 2)
                {
                    potion.Display();
                    player.Cash = player.Cash - potion.Price();
                }

                if (choice == 3)
                {
                    helm.Display();
                    player.Defence = player.Defence+ helm.Defence;
                    player.Cash = player.Cash - helm.Price();
                }
                Console.WriteLine("\nPo zakupie przedmiotu Twoje statystyki wyglądają następująco.\n");
                player.Display();
                Console.Write("\nChesz kupic coś jeszcze? (t/n) ");
                exit = Console.ReadLine();         
            }
        }
    }
}
