using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Scenario_Based.day3
{
    internal class QuizGrader
    {
        public void StudentQuizAnalyser()
        {
            Console.WriteLine("Press enter for start the quiz");
            Console.ReadLine();
            QuizStart();
        }



        public void QuizStart()
        {
            string[] questionsPrint = QuestionsStored();
            char[] questionsAnswer = AnswerStore();
            char[] userAnswer = new char[10];

            Console.WriteLine("Answer your question in A B C D");

            for (int i = 0; i < 10; i++){
                Console.WriteLine(questionsPrint[i]);
                bool isItTrue = true;
                char temporary;
                while(isItTrue == true)
                {
                    temporary = char.ToUpper(Convert.ToChar(Console.ReadLine()));

                    if (temporary == 'A' || temporary == 'B' || temporary == 'C' || temporary == 'D'){
                        isItTrue = false;
                        userAnswer[i] = temporary;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input enter again");
                    }
                }


            }


            double scoreOfStudent = ScoreCalculate(userAnswer, questionsAnswer);
            Console.WriteLine($"Your score is {scoreOfStudent / 10}/10");
            Console.WriteLine($"Percentage of you quiz {scoreOfStudent}%");


            if (scoreOfStudent >= 50){
                Console.WriteLine("Passed");
            }
            else{
                Console.WriteLine("Failed Your percentage is below 50");
            }

        }

        public string[] QuestionsStored()
        {
            string[] questionsArr = {
                                    "Which keyword is used to define a constant in C#? A) const B) static C) readonly D) final",
                                    "Which data type is used to store decimal values with high precision? A) float B) double C) decimal D) long",
                                    "Which statement is used to exit a loop immediately? A) stop B) exit C) break D) return",
                                    "Which keyword is used to handle exceptions in C#? A) catch B) handle C) error D) exception",
                                    "Which access modifier makes a member accessible only within the same assembly? A) public B) private C) protected D) internal",
                                    "Which method converts a string to an integer safely? A) int.Parse() B) Convert.ToInt32() C) int.TryParse() D) ToInt()",
                                    "Which collection stores elements in key-value pairs? A) List B) Array C) Stack D) Dictionary",
                                    "Which keyword prevents a class from being inherited? A) sealed B) static C) private D) final",
                                    "Which operator is used for logical AND in C#? A) & B) && C) | D) ||",
                                    "Which block is always executed whether an exception occurs or not? A) try B) catch C) throw D) finally"
                                 };

            return questionsArr;
        }


        public char[] AnswerStore()
        {
            char[] answersArr = {
            'A', // const
            'C', // decimal
            'C', // break
            'A', // catch
            'D', // internal
            'C', // int.TryParse()
            'D', // Dictionary
            'A', // sealed
            'B', // &&
            'D'  // finally
           };

            return answersArr;
        }


        public double ScoreCalculate(char[] userAnswers, char[] userQuestions)
        {

            double scoreOfStudent = 0;

            for (int i = 0; i < userAnswers.Length; i++)
            {
                if (userAnswers[i] == userQuestions[i])
                {
                    Console.WriteLine($"Ques {i + 1} correct");
                    scoreOfStudent++;
                }
                else
                {
                    Console.WriteLine($"Ques {i + 1} incorrect");
                }
            }

            return (scoreOfStudent / 10) * 100;
        }


    }
}