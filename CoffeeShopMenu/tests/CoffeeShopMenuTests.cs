using System;
using CoffeeShopMenu;

class CoffeeShopMenuTests
{
    static void Check(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
    public static void Main()
    {
        var coffee = new CupOfCoffee("coffee", new[]{"Honey"}, new[]{0.10});
        var sandwich = new Sandwich("sandwich", new[]{"Cheese"}, new[]{0.32});
        string action;
        Check(coffee.ModifyItem("Honey", out action), "Add a coffee topping");
        Check(Math.Abs(coffee.CalcCost() - 2.25) < 0.001, "Coffee total includes topping");
        coffee.ModifyItem("Honey", out action);
        Check(Math.Abs(coffee.CalcCost() - 2.15) < 0.001, "Remove topping");
        Check(!coffee.ModifyItem("Invalid", out action), "Reject unavailable topping");
        sandwich.ModifyItem("Cheese", out action);
        Check(Math.Abs(sandwich.CalcCost() - 3.82) < 0.001, "Sandwich total");
        Console.WriteLine("CoffeeShopMenu tests passed.");
    }
}
