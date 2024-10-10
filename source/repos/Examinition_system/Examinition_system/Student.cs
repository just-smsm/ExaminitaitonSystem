using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinition_system
{
    internal class Student
    {
        static string GetDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        public void getAns(List<object> list)
        {
            var grade = 0.0;
            Console.WriteLine($"=======The exam started at :: {GetDate()} ==============");
            int ctr = 1;

            foreach (var item in list)
            {
                if (item is Multi_choice multiChoice)
                {
                    Console.WriteLine($"Question [{ctr}]            (Level: {multiChoice.Level}) ");
                    Console.WriteLine($"Question: {multiChoice.Question}");
                    Console.WriteLine($"Choices: [ {multiChoice.Choice_1} , {multiChoice.Choice_2} , {multiChoice.Choice_3} , {multiChoice.Choice_4} ]      (Grade: {multiChoice.Grade})");
                    ctr++;
                    Console.WriteLine("Enter your answer:");
                    string ans = Console.ReadLine();
                    Console.WriteLine("-------------------------------------");
                    if (ans == multiChoice.Answer)
                    {
                        grade += multiChoice.Grade;
                    }

                }
                else if (item is True_False tf)
                {
                    Console.WriteLine($"Question [{ctr}]            (Level: {tf.Level}) ");
                    Console.WriteLine($"Question: {tf.Question}");
                    Console.WriteLine($"Choices: [ {tf.Choice_1} , {tf.Choice_2} ]      (Grade: {tf.Grade})");
                    Console.WriteLine("enter your answer");
                    string ans = Console.ReadLine();
                    ctr++;
                    Console.WriteLine("-------------------------------------");
                    if (ans == tf.Answer)
                    {
                        grade += tf.Grade;
                    }
                }
                else if (item is Text exam)
                {
                    Console.WriteLine($"Question [{ctr}]            (Level: {exam.Level})       (Grade: {exam.Grade})");
                    Console.WriteLine($"Question: {exam.Question}");
                    ctr++;
                    Console.WriteLine("enter your answer");
                    string ans = Console.ReadLine();
                    Console.WriteLine("-------------------------------------");
                    if (ans == exam.Answer)
                    {
                        grade += exam.Grade;
                    }
                }
                

            }

            Console.WriteLine($"Your Grade :: {grade}");
        }
    }
    }

