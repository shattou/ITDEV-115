using System;
using static System.Console;

namespace ExceptionHandling
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] examScores;
            int totalScores = 0, countOfScores = 0; ;
            string inValue;
            double averageTestScores;

            try
            {
                Write("How many scores will you enter?");
                inValue = ReadLine();
                countOfScores = int.Parse(inValue);
                examScores = new int[countOfScores];

                for (int index=0; index < countOfScores; index++)
                {
                    Write("Enter Score{0}: ", index + 1);
                    inValue = ReadLine();
                    examScores[index] = int.Parse(inValue);
                    totalScores += examScores[index];
                }
                averageTestScores = totalScores / countOfScores;
                WriteLine("The average is {0}", averageTestScores);
            }

            catch (FormatException e)
            {
                Error.WriteLine("Problem with one of the operands - Cannot compute average!");
                Error.WriteLine("Exception type {0}", e.Message);
            }

            catch (Exception e) when (countOfScores == 0)
            {
                Error.WriteLine("No scores entered - Division by zero avoided!");
                Error.WriteLine("Exception type {0}", e.Message);
            }

            catch (DivideByZeroException e)
            {
                Error.WriteLine("Divide by zero Exception");
                Error.WriteLine ("Exception type {0}", e.Message);
            }

            finally
            {
                WriteLine("....Finally ran!");
            }
        }
    }
}
