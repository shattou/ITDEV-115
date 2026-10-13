using System;
using static System.Console;

namespace MagicPC
{
    public class MagicPC
    {
        public MagicPC()
        {
        }

        Random random = new Random();

        public string GetUserAnswer()
        {
            long number = random.Next(5);
            string answer;

            switch (number)
            {
                case 1:
                    answer = "Yes";
                    break;

                case 2:
                    answer = "No";
                    break;

                case 3:
                    answer = "Maybe";
                    break;

                case 4:
                    answer = "The answer is cloudy";
                    break;

                default:
                    answer = "Definitely yes";
                    break;
            }
            return answer;
        }

    }
}
