using System;
using static System.Console;

namespace NumberAverage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double n1, n2, n3;
            Presentation UI = new Presentation();
            UI.UserDirections();
            n1 = UI.RequestUserData(1);
            n2 = UI.RequestUserData(2);
            n3 = UI.RequestUserData(3);
            DataCalculations dataObject = new DataCalculations(n1, n2, n3);
            UI.DisplayResults(dataObject);
            ReadKey();
        }
    }
}
