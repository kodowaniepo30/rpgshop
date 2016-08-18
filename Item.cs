using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class Item
    {
        private string name = "";
        private double price;
        private byte rarity;

        public Item(string name, double price, byte rarity)
        {
            this.name = name;
            this.price = price;
            this.rarity = rarity;
        }

        public double Price()
        {
            return price;
        }

        public virtual void Display()
        {
            Console.Write("{0} - koszt: {1}", name, price);
        }
    }
}
