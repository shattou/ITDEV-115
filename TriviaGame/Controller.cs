using System;
using System.IO;
using static System.Console;


namespace TriviaGame
{
    public class Controller
    {
        public void Play()
        {
            Question_Bank qBank = new Question_Bank();
            string[] answers;
            int correct;

            Welcome();


            try
            {
                qBank.ReadQuestionFile();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }

            do
            {
                correct = 0;
                Clear();
                for (int index = 0; index < Question_Bank.NO_OF_QUESTIONS; index++)
                {
                    string response;
                    WriteLine(qBank.GetQuestion(index));
                    WriteLine("\n\n\n\nQuestion " + (index + 1) + ":" );

                    answers = qBank.GetAnswers(index);

                    WriteLine("A.) " + answers[0]);
                    WriteLine("B.) " + answers[1]);
                    WriteLine("C.) " + answers[2]);
                    WriteLine("D.) " + answers[3]);
                    Write("\n\nPlease type your answer: ");

                    response = ReadLine();

                    if (!string.IsNullOrEmpty(response) && response.ToUpper() == qBank.GetCorrectAnswer(index))
                    {
                        WriteLine("\nYou are correct!");
                        correct++;
                    }
                    else
                    {
                        WriteLine("\nOops! Wrong answer.");
                        WriteLine("The correct answer is " + qBank.GetCorrectAnswer(index));
                    }
                    WriteLine("\n" + qBank.GetExplanation(index));
                    WriteLine("\n\n\nPlease press the Enter key when you are ready to continue");
                    ReadKey();
                    Clear();
                }
                WriteLine("\n\n\n\nYou had " + correct + " correct answers out of " + Question_Bank.NO_OF_QUESTIONS);
                WriteLine("This gives you a percentage of {0:P}", ((double)correct / Question_Bank.NO_OF_QUESTIONS));
            } while (PlayAgain() == 1);
        }

        public void Welcome()
        {
            WriteLine("\n\n\n\tWelcome to Harry Potter Trivia Game. You will be shown a series of questions about the movie franchise Harry Potter," +
                "\n\tone at a time. Each question will have four possible answers, only one" +
                "\n\tis the correct answer. The goal is to pick the correct answer.");
            Write("\n\nPress the Enter key when you are ready to begin. GoodLuck!\t");
            ReadKey();
        }

        public int PlayAgain()
        {
            int again = 0;
            string resp;

            Write("\n\nWould you like to play again? (Y or N): ");
            resp = ReadLine();

            if (!string.IsNullOrEmpty(resp))
            {
                if (resp.ToUpper()[0] == 'Y')
                {
                    again = 1;
                }
            }
            return again;
        }

    }

}
