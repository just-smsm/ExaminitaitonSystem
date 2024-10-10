using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinition_system
{
    internal class Text
    {
        public string Level { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public double Grade { get; set; }
        public Text()
        {

        }
        public Text(string _lev, string _quest, string _ans, double _grade)
        {
            Level = _lev;
            Question = _quest;
            Answer = _ans;
            Grade = _grade;
        }
        public void Add_Question(List<Text> lists)
        {
            Console.WriteLine("Enter level of question");
            string _lev = (Console.ReadLine());
            Console.WriteLine("Enter Question [Text] :: ");
            string _quest = Console.ReadLine();
            Console.WriteLine("Enter Correct ans");
            string _cor = Console.ReadLine();
            Console.WriteLine("Enter Question Grade");
            double _grade = double.Parse(Console.ReadLine());
            Text exam = new Text(_lev, _quest, _cor, _grade);
            lists.Add(exam);
        }
    }
}

