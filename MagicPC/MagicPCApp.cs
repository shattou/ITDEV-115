using System;
using static System.Console;

namespace MagicPC
{
    class MagicPCApp
    {
        public static void Main(string[] args)
        {

            Info display = new Info();
            display.DisplayInfo("Magic PC App");
            MagicPCUI view = new MagicPCUI();
            string question;
            view.UserInstructions();
            view.Start();

            do
            {
               question = view.GetUserQuestion();
               view.RespondToQuestion();
            }

            while (question != "");

            {
                Clear();
                WriteLine("Until we meet again, have good fortune ahead");

            }

        }

    }
}
