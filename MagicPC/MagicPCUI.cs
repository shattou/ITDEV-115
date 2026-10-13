using System;
using static System.Console;

namespace MagicPC
{
    public class MagicPCUI
    {
        MagicPC userMagic = new MagicPC();

        public MagicPCUI()
        {
        }

        public void UserInstructions()
        {
            WriteLine("**********************************************************************");
            WriteLine("\n\tWelcome my friend welcome. Come closer. That's right."+
            "\n\n\tThis is the magic PC screen. All your questions will be answered!"+
            "\n\tJust enter a question and the magic PC screen will give you the answer!"+
            "\n\n\tHowever, it must be question that can be answered with a yes or a no"+
            "\n\tTo exit the program, just hit the Enter key\n");
            WriteLine("**********************************************************************");
        }

        public void Start()
        {
            WriteLine("**********************************************************************");
            WriteLine("\n\tHit any key to continue");
            ReadKey();

        }

        public string GetUserQuestion()
        {
            WriteLine("\n\n\tEnter a question if you dare", ForegroundColor = ConsoleColor.Black);
            string question = ReadLine();
            return question;
        }

        public void RespondToQuestion()
        {
            string answer = userMagic.GetUserAnswer();
            WriteLine("\n\n\t" + answer, ForegroundColor = ConsoleColor.DarkYellow);
        }
    }
}
