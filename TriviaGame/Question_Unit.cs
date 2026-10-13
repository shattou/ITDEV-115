using System;
namespace TriviaGame
{
    public class Question_Unit
    {
        //private string[] answer = new string[4];
        private string[] answer;
        private string correctAnswer;
        private string explanation;
        private string question;

        public string[] Answers
        {
            get
            {
                return answer;
            }

            set
            {
                this.answer = value;
            }
        }

        public string CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }
            set
            {
                this.correctAnswer = value;
            }
        }

        public string Explanation
        {
            get
            {
                return explanation;
            }
            set
            {
                this.explanation = value;
            }
        }

        public string Question
        {
            get
            {
                return question;
            }
            set
            {
                this.question = value;
            }
        }
    }
}
