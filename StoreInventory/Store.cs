using System;
using static System.Console;

namespace StoreInventory
{
    public class Store
    {

        const int size = 5;
        private string name;
        int id;
        string[] items = new string[size];

        public Store()
        {
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Size
        {
            get { return size; }

        }

        public void EnterInventory(int index, string item)
        {
            items[index] = item;
        }

        public string GetItems(int index)
        {
            return items[index];
        }
    }
}
