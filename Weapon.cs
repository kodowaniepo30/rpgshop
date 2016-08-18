using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class Weapon : Item
    {
        private int damage;

        public Weapon(string name, double price, byte rarity, int damage)
            : base(name, price, rarity)
        {
            this.damage = damage;
        } 

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public new double Price()
        {
            return base.Price();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(", obrazenia {0}", damage);
        }
    }
}
