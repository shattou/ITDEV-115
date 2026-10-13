using System;

namespace ElectionResults
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Info info = new Info();
            ElectionUI ElectionMain = new ElectionUI();

            info.AssignmentInfo("MidTerm: Election Program");
            ElectionMain.MainMethod();
        }
    }
}
