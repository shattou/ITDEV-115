using System;

//Aisha Kabir Final Project

namespace StudentGrades
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Info display = new Info();
            display.DisplayInfo("Final Program");
            GradesUI ui = new GradesUI();
            ui.MainMethod();
        }
    }
}
