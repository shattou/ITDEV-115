using System;
using static System.Console;

namespace StoreInventory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StoreUI storeUI = new StoreUI();
            storeUI.MainMethod();
            ReadKey();
        }
    }
}
