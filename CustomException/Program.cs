using System;
using static System.Console;

namespace CustomException
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double value1 = 0, value2 = 0, answer;

            try
            {
                answer = GetResult(value1, value2);

            } catch(FloatingPtDivisionException fpException)
            {
                Error.WriteLine(fpException.Message);
            }
        }

        static double GetResult(double value1, double value2)
        {
            if (value2 < 0.0000001)
            {
                FloatingPtDivisionException fpException = new
                    FloatingPtDivisionException("Exception type: floating-point division by zero");
                throw fpException;
            }
            return value1 / value2;
        }
    }
}
