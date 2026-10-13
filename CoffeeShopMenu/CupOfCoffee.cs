using System;
using System.Collections;
using System.Linq;

namespace CoffeeShopMenu
{
    public class CupOfCoffee : Item
    {
        private const double BASEPRICE = 2.15;

        public CupOfCoffee(string name, string[] options, double[] addedPrice) : base(name, options, addedPrice) { }

        public override double Cost
        {
            get { return BASEPRICE; }
        }

        public override double CalcCost()
        {
            double total = BASEPRICE + base.CalcCost();
            return total;
        }

    }
    //private const double BASEPRICE = 2.15;
    //private ArrayList toppings = new ArrayList();
    //private string[] options = { "Brown Sugar", "Molasses", "Honey", "Chocolate Chip", "Whipped Cream", "Mint", "Marshmelows", "Ice Cream" };
    //private double[] addedPrice = { 0.25, 0.20, 0.10, 0.30, 0.15, 0.17, 0.05, 1.25 };
    ////private enum modCoffee //listing of  a label that you can use. For adding and removing options.
    ////{
    ////    Add = 1,
    ////    Remove
    ////}

    //public double Cost
    //{
    //    get { return BASEPRICE; }
    //}
    //public string[] Options
    //{
    //    get { return options; }
    //}

    //public double[] AddedPrice
    //{
    //    get { return addedPrice; }
    //}
    //public ArrayList Topping
    //{
    //    get { return toppings; }
    //}

    //public string option(int index)
    //{
    //    string selected = "";
    //    if ((index >= 0) && (index < options.Length))
    //    {
    //        selected = options[index];
    //    }
    //    return selected;
    //}

    //public bool ModifyCoffee(string selectedTopping, out string addRemove)
    //{
    //    addRemove = "";
    //    bool completed = false; //haven't completed adding or removing the toppings

    //    bool validMenuSelection = options.Contains(selectedTopping); //if toppings selected is valid i.e in our options.
    //    bool selectionAddedToCoffee = toppings.Contains(selectedTopping); //if selected topping has been added or not

    //    if (validMenuSelection)
    //    {
    //        if (selectionAddedToCoffee)
    //        {
    //            toppings.Remove(selectedTopping); //removing the selected topping because it's already been selected.
    //            addRemove = "remove";
    //        }
    //        else
    //        {
    //            toppings.Add(selectedTopping);
    //            addRemove = "add";
    //        }
    //        completed = true;
    //    }
    //    return completed;

    //}

    //private int FindIndex(string topping) //worker method to find the index of a chosen topping
    //{
    //    int found = -1;
    //    for (int index = 0; index < options.Length; index++)
    //    {
    //        if (options[index] == topping)

    //            found = index;
    //        index = options.Length;
    //    }
    //    return found;
    //}

    //public double CalcCost()
    //{
    //    double total = BASEPRICE;
    //    double addition = 0;
    //    int link;

    //    foreach (string topping in toppings)
    //    {
    //        link = FindIndex(topping);
    //        //if (link == -1)
    //        //{
    //        //    total = total + 0;
    //        //}
    //        //else
    //        //{
    //        //    total = total + addedPrice[link];
    //        //}

    //        addition = (link == -1) ? 0 : addedPrice[link];
    //        total += addition;
    //    }
    //    return total;
    //}

    //public double getPrice(string topping)
    //{
    //    int link = FindIndex(topping);
    //     return (link == -1 ? 0 : addedPrice[link]);
    //}





    //    public bool AddToCoffee(string topping)
    //    {
    //        bool toppingAdded = false;
    //        if (options.Contains(topping))
    //        {
    //            toppingAdded = AddTopping(topping);
    //        }
    //        return toppingAdded;
    //    }

    //    private bool AddTopping(string option)
    //    {
    //        bool added = false;
    //        if(toppings.Contains(option) == false)
    //        {
    //            toppings.Add(option);
    //            added = true;
    //        }
    //        return added;
    //    }

    //    public bool RemoveFromCoffee(string option)
    //    {
    //        bool toppingRemoved = false;
    //        if (Topping.Contains(option))
    //        {
    //            toppingRemoved = RemoveTopping(option);
    //        }
    //        return toppingRemoved;
    //    }

    //    private bool RemoveTopping(string option)
    //    {
    //        bool removed = false;
    //        if (toppings.Contains(option))
    //        {
    //            toppings.Remove(option);
    //            removed = true;
    //        }
    //        return removed;
    //    }

}
