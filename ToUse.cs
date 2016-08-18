using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class ToUse : Item
    {
        private int action;
        private string nameOfAction = "";

        public ToUse(string name, double price, byte rarity, int action, string nameOfAction)
            : base(name, price, rarity)
        {
            this.action = action;
            this.nameOfAction = nameOfAction;
        }

        public new double Price()
        {
            return base.Price();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(", + {0} do {1}", action, nameOfAction);
        }
    }
}
