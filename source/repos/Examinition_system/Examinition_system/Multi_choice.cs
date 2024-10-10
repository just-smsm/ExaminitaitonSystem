using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinition_system
{
    internal class Multi_choice : True_False
    {
        public string Choice_1 { get; set; }
        public string Choice_2 { get; set; }
        public string Choice_3 { get; set; }
        public string Choice_4 { get; set; }
        public Multi_choice()
        {

        }
        public Multi_choice(string _lev, string _quest, string _cor, string choice1, string choice2, string choice3, string choice4, double _grade)
        {
            Level = _lev;
            Question = _quest;
            Answer = _cor;
            Choice_1 = choice1;
            Choice_2 = choice2;
            Choice_3 = choice3;
            Choice_4 = choice4;
            Grade = _grade;
        }
        public void Add_Question(List<Multi_choice> lists)
        {
            Console.WriteLine("Enter the level of the question:");
            string lev = (Console.ReadLine());

            Console.WriteLine("Enter the question:");
            string quest = Console.ReadLine();

            Console.WriteLine("Enter choice 1:");
            string choice1 = Console.ReadLine();

            Console.WriteLine("Enter choice 2:");
            string choice2 = Console.ReadLine();

            Console.WriteLine("Enter choice 3:");
            string choice3 = Console.ReadLine();

            Console.WriteLine("Enter choice 4:");
            string choice4 = Console.ReadLine();

            Console.WriteLine("Enter the correct answer:");
            string cor = Console.ReadLine();
            Console.WriteLine("Enter Question Grade");
            double _grade = double.Parse(Console.ReadLine());

            Multi_choice multi_Choice = new Multi_choice(lev, quest, cor, choice1, choice2, choice3, choice4, _grade);

            lists.Add(multi_Choice);
        }
    }
}
