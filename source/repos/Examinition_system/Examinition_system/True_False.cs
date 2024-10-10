using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Examinition_system
{
    internal class True_False:Text
    {
        public string Choice_1 { get; set; }
        public string Choice_2 { get; set; }
        public True_False()
        {

        }
        public True_False(string _lev, string _quest, string _cor, string choice1, string choice2, double _grade)
        {
            this.Level = _lev;
            this.Question = _quest;
            this.Answer = _cor;
            this.Choice_1 = choice1;
            this.Choice_2 = choice2;
            this.Grade = _grade;
        }
        public void Add_Question(List<True_False> lists)
        {
            Console.WriteLine("Enter the level of the question:");
            string lev = (Console.ReadLine());

            Console.WriteLine("Enter the question[True,False] : ");
            string quest = Console.ReadLine();

            Console.WriteLine("Enter choice 1:");
            string choice1 = Console.ReadLine();

            Console.WriteLine("Enter choice 2:");
            string choice2 = Console.ReadLine();

            Console.WriteLine("Enter the correct answer:");
            string cor = Console.ReadLine();
            Console.WriteLine("Enter Question Grade");
            double _grade = double.Parse(Console.ReadLine());

            True_False true_False = new True_False(lev, quest, cor, choice1, choice2, _grade);

            lists.Add(true_False);
        }
    }
}

