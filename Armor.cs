using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class Armor : Item
    {
        private int defence;

        public Armor(string name, double price, byte rarity, int defence)
            : base(name, price, rarity)
        {
            this.defence = defence;
        }

        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }

        public new double Price()
        {
            return base.Price();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(", obrona {0}", defence);
        }
    }
}
