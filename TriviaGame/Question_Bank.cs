using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;

namespace TriviaGame
{
    public class Question_Bank
    {
        private string fileName = "Trivia.txt";
        public const int NO_OF_QUESTIONS = 5;
        public const int NO_OF_ANSWERS = 4;
        private Question_Unit[] questionBank = new Question_Unit[NO_OF_QUESTIONS];


        public string[] GetAnswers(int index)
        {
            return questionBank[index].Answers;
        }

        public string GetCorrectAnswer(int index)
        {
            return questionBank[index].CorrectAnswer;
        }

        public string GetExplanation(int index)
        {
            return questionBank[index].Explanation;
        }

        public string GetQuestion(int index)
        {
            return questionBank[index].Question;
        }


        public int ReadQuestionFile()
        {
           int fileFound = 1;
            int index = 0;
            try
            {
                using (StreamReader streamReader = new StreamReader(fileName))
                {
                    string text;
                    while ((text = streamReader.ReadLine()) != null)
                    {
                        questionBank[index] = new Question_Unit();
                        questionBank[index].Question = text;
                        questionBank[index].Answers[index] = streamReader.ReadLine();
                        questionBank[index].CorrectAnswer = streamReader.ReadLine();
                        questionBank[index].Explanation = streamReader.ReadLine();
                        index++;
                    }
                }
            }
            catch
            {
                fileFound = 0;
            }
            return fileFound;
        }
        //public void ReadQuestionFile()
        //{


        //    string question;
        //    string[] answers;
        //    char correct;
        //    string explanation;

        //   StreamReader streamReader = new StreamReader(fileName);


        //    for (int index = 0; index < questionBank.Length; index++)
        //    {
        //        question = streamReader.ReadLine();
        //        answers = new string[NO_OF_ANSWERS];
        //        for (int x = 0; x < answers.Length; x++)
        //        {
        //            answers[x] = streamReader.ReadLine();
        //        }
        //        correct = streamReader.ReadLine()[0];
        //        explanation = streamReader.ReadLine();
        //        questionBank[index] = new Question_Unit();
        //        questionBank[index].Answers = answers;
        //        questionBank[index].Question = question;
        //    }


        //    streamReader.Close();

        //}

    }
}
