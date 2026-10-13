using System;
using static System.Console;

namespace StudyHoursTracker
{
    public class StudentUI
    {
        private string[] days = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

        public void MainMethod()
        {
            Student myStudent = new Student();
            GetName(myStudent);
            GetStudentID(myStudent);
            FillHours(myStudent);
            DisplayData(myStudent);
            DisplayAverage(myStudent);

        }

        private String GetName(Student myStudent)
        {
            WriteLine("Please enter your name:\t\t");
            return myStudent.Name = ReadLine();
        }

        private int GetStudentID(Student myStudent)
        {
            string inValue;
            int id;
            WriteLine("Please enter student ID number:\t\t");
            inValue = ReadLine();
            while(int.TryParse(inValue, out id) == false)
            {
                WriteLine("\nInvalid response. Try again\n\n");
                WriteLine("Please enter student ID number:\t\t");
                inValue = ReadLine();
            }
            return myStudent.ID = id;
        }

        private void FillHours(Student myStudent)
        {
            for (int index = 0; index < days.Length; index++)
            {
                string inValue;
                double hours;
                WriteLine("Enter the hours that you studied on {0}:\t", days[index]);
                inValue = ReadLine();
                while(double.TryParse(inValue, out hours) == false)
                {
                    WriteLine("\nInvalid response. Try again\n\n");
                    WriteLine("Enter the hours that you studied on {0}:\t");
                    inValue = ReadLine();
                }
                myStudent.EnterHours(index, hours);
            }
        }

        private void DisplayData(Student myStudent)
        {
            Clear();
            WriteLine("\n\nName:\t{0}", myStudent.Name);
            WriteLine("\n\nID:\t{0}", myStudent.ID);
            WriteLine("\n\nThe number of hours of study that  you  did during the week are as follows:\n");

            for(int index = 0; index < days.Length; index++)
            {
                WriteLine("{0,15}: {1,15:N2}", days[index], myStudent.GetNumberHours(index));

            }
        }

        private void DisplayAverage(Student myStudent)
        {
            WriteLine("\n\nThe average number of hours studied per day was: " + myStudent.CalculateAvg());
        }
    }
}
