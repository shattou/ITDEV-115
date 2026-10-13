using System;

namespace TriviaGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Controller controller = new Controller();
            controller.Play();
            Console.ReadKey();


        }
    }
}
