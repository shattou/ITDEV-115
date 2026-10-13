using System;
using static System.Console;

namespace StudyHoursTracker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Info info = new Info();
            info.AssignmentInfo("Student Study App");
            StudentUI studentUI = new StudentUI();
            studentUI.MainMethod();
            ReadKey();
        }
    }
}
