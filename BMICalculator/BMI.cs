using System;
namespace BMICalculator
{
    public class BMI
    {
        private double bodyMassIndex, heightInInches, weightInPounds;


        public BMI()
        {}

        public BMI(double height, double weight)
        {
            this.heightInInches = height;
            this.weightInPounds = weight;
        }

        public double BodyMassIndex
        {
            get { return bodyMassIndex; }
        }
        public double HeightInInches
        {
            get { return heightInInches; }
        }
        public double WeightInPounds
        {
            get { return weightInPounds; }
        }

        public void CalculateBMI()
        {
            bodyMassIndex = (weightInPounds / (heightInInches * heightInInches)) * 703.0;
        }

        public string  ObtainWeightStatus(double bodyMassIndex)
        {
            string weightStatus;

            if (bodyMassIndex >= 30)
            {
                weightStatus = "Obese";
                return weightStatus;

            }else if (bodyMassIndex >= 29.9)
            {
                weightStatus = "Overweight";
                return weightStatus;

            }
            else if (bodyMassIndex >= 24.9)
            {
                weightStatus = "Normal";
                return weightStatus;
            }
            else
            {
                weightStatus = "Underweight";
                return weightStatus;
            }



        }
    }
}
