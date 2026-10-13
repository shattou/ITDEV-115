using System;
using System.Linq;

namespace StudyHoursTracker
{
    public class Student
    {
        private int id;
        private string name;
        private double[] hours = new double[7];

        public Student()
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

        public void EnterHours(int index, double hour)
        {
            hours[index] = hour;
        }
        public double GetNumberHours(int index)
        {
            return hours[index];
        }

        public double CalculateAvg()
        {
            double average = Queryable.Average(hours.AsQueryable());
            return average;
        }
    }
}
