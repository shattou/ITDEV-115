using System;
using static System.Console;

namespace StoreInventory
{
    public class StoreUI
    {
        private double[] priceList;

        public void MainMethod()
        {
            Store store = new Store();
            priceList = new double[store.Size];
            GetName(store);
            GetStoreID(store);
            StockInventory(store);
            WriteLine("\n");
            PriceFill(store);
            DisplayData(store);
        }


        private String GetName(Store store)
        {
            Write("please eneter store name:\t\t");
            return store.Name = ReadLine();
        }

        private int GetStoreID(Store store)
        {
            string inValue;
            int id;
            Write("Please enter store id:\t\t");
            inValue = ReadLine();
            while (int.TryParse(inValue, out id) == false)
            {
                WriteLine("\nInvalid response. Try again\n\n");
                WriteLine("Please enter store ID:\t\t");
                inValue = ReadLine();
            }
            return store.ID = id;
        }

        private void StockInventory(Store store)
        {
            string description;
            Clear();
            WriteLine("Welcome {0}", store.Name);
            WriteLine("Please enter  store inventory:\n");

            for (int item=0; item < store.Size; item++)
            {
                Write("enter item {0} decription:\t", item + 1);
                description = ReadLine();
                store.EnterInventory(item, description);
            }

        }

        private  void PriceFill(Store store)
        {
            for (int index = 0; index < priceList.Length; index++)
            {
                string inValue;
                double price;
                Write("Enter price of item {0}:\t", store.GetItems(index));
                inValue = ReadLine();
                while (double.TryParse(inValue, out price) == false)
                {
                    WriteLine("\nInvalid response. Try again\n\n");
                    WriteLine("Please enter price of item {0}");
                    inValue = ReadLine();
                }
                priceList[index] = price;
            }
        }

        public void DisplayData(Store store)
        {
            Clear();
            WriteLine("\n\nName:\t{0}", store.Name);
            WriteLine("\n\nID:\t{0}", store.ID);
            WriteLine("\n\nFull Store Inventory:\n");

            WriteLine("{0,15} {1,7}", "ITEM", "PRICE");

            for (int index=0; index < store.Size; index++)
            {
                Write("{0,15}:", store.GetItems(index));
                WriteLine("{0, 7:N2}", priceList[index]);
            }
        }
    }
}
