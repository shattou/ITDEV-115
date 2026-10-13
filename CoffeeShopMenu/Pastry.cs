using System;
namespace CoffeeShopMenu
{
    public class Pastry : Item
    {
        private const double BASEPRICE = 0;
        private double discount;

        public Pastry(string name, string[] options, double[] addedPrice) : base(name, options, addedPrice)
        {
        }

        public Pastry (string name, string[] options, double [] addedPrice, double discount):base(name, options, addedPrice)
        {
            this.discount = discount;
        }

        public override double Cost
        {
            get { return BASEPRICE; }
        }

        public override double CalcCost()
        {
            double total = base.CalcCost();
            if(Toppings.Count > 1)
            {
                total = total * (1 - discount);

            }
            return total;
        }
    }
}
