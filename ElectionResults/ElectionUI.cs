using System;
using static System.Console;


namespace ElectionResults
{
    public class ElectionUI
    {
        private int candidates;
        private Election theElection = new Election();

        public void DisplayResults()
        {
            Clear();
            WriteLine("\tName\tVotes\tPercentage");

            for (int i = 0; i < theElection.NumOFCANDIDATES; i++)
            {
                WriteLine("\t{0}\t{1}\t{2:N1}%",
                     theElection.GetCandidateName(i),
                     theElection.GetCandidateVotes(i),
                     (((double)theElection.GetCandidateVotes(i) / (double)theElection.TotalVotes()) * 100));
            }
            WriteLine("\nThe winner is {0}", theElection.FindWinner());
            ReadKey();
        }

        public ElectionUI()
        {
        }

        public void MainMethod()
        {
            for (int i = 0; i < theElection.NumOFCANDIDATES; i++)
            {
                PromptforString(i);
                PromptforInt(i);
            }

            DisplayResults();
        }

        public void PromptforInt(int candidate)
        {
            int tempInt;
            Write("Enter {0}'s vote count: ", theElection.GetCandidateName(candidate));
            while (!Int32.TryParse(ReadLine(), out tempInt))
            {
                WriteLine("Incorrect data entered.\nPlease enter a numberical value for number of votes.");
                Write("Enter {0}'s vote count: ", theElection.GetCandidateName(candidate));
            }
            theElection.SetVote(tempInt, candidate);
        }

        public void PromptforString(int candidate)
        {
            Write("\nEnter candiate {0}'s name: ", (candidate + 1));
            theElection.SetCandidateName(ReadLine(), candidate);
        }
    }
}
