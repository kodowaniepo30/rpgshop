using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class Player
    {
        private string name = "Beziminny";
        private double cash = 100.0;
        private int health = 100;
        private int damage = 50;
        private int defence = 50;
        
        public Player(string name)
        {
            this.name = name;
        }

        public double Cash
        {
            get { return cash; }
            set
            {
                if (cash < 0)
                {
                    Console.WriteLine("\nNie chcę żebyś był moim dłużnikiem.");
                    Console.WriteLine("\nMasz tu ode mnie 100 zł.");
                    cash = 100;
                    Console.ReadLine();
                }
                else
                    cash = value;
            }
        }

        public int Health
        {
            get { return health; }
            set
            {
                if (health <= 0)
                    Console.WriteLine("Jesteś trupem.");
                else
                    health = value;
            }
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }

        public void Display()
        {
            Console.WriteLine("Gracz: {0} | Kasa {1} | Zdrowie {2} | Obrażenia {3} | Obrona {4}", name, cash, health, damage, defence);
        }
    }
}
