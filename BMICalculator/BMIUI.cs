using System;
using static System.Console;

namespace BMICalculator
{
    public class BMIUI
    {
        public BMIUI()
        {
        }
        public void BMIMaiModule()
        {
            BMI mainModule = new BMI();
        }

        public void UserDirections()
        {
            WriteLine("This program will calculate your Body Mass Index (BMI)");
            WriteLine("using your height and weight");
        }

        public double RequestUserData(int whichOne)
        {
            string inValue;
            int data;
            WriteLine("Please enter your {0} in inches:\t", whichOne);
            inValue = ReadLine();
            while (int.TryParse(inValue, out data) == false)
            {
                WriteLine("Please enter a whole number for the height and weight");
                inValue = ReadLine();
            }
            return data;
        }

        public void DisplayResults(BMI aUserBMI)
        {
                WriteLine("For your height of " + aUserBMI.HeightInInches + " inches and your weight of " + aUserBMI.WeightInPounds + " pounds,"
                    + "\nyour BMI is" + aUserBMI.BodyMassIndex + " which gives you a weight status of " + aUserBMI.ObtainWeightStatus(aUserBMI.BodyMassIndex));
        }

    }
}
