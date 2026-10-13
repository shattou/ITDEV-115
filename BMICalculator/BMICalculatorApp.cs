using System;
using static System.Console;

namespace BMICalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Display info = new Display();
            info.DisplayInfo("BMI Calculator App");
            BMIUI view = new BMIUI();
            BMI model = new BMI();
            ReadKey();
        }
    }
}
