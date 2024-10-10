namespace Examinition_system
{
    internal class Program
    {
        static void Shuffle<T>(List<T> list)
        {
            Random random = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        public static void Mains()
        {
            List<Multi_choice> Multi_choice_list = new List<Multi_choice>();
            List<Text> Exam_list = new List<Text>();
            List<True_False> T_F_list = new List<True_False>();
            Console.WriteLine("Enter the number of questions you want to add:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {


                Console.WriteLine("Enter 1 for multiple choice");
                Console.WriteLine("Enter 2 for text question");
                Console.WriteLine("Enter 3 for true/false");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {

                    Multi_choice m = new Multi_choice();
                    m.Add_Question(Multi_choice_list);
                }
                else if (choice == 2)
                {
                    Text m = new Text();
                    m.Add_Question(Exam_list);
                }
                else if (choice == 3)
                {
                    True_False tf = new True_False();
                    tf.Add_Question(T_F_list);
                }
            }
            List<object> combinedList = new List<object>();
            combinedList.AddRange(Multi_choice_list);
            combinedList.AddRange(Exam_list);
            combinedList.AddRange(T_F_list);
            Shuffle(combinedList);
            Student s = new();
            s.getAns(combinedList);
        }
        static void Main(string[] args)
        {
            Mains();
        }
    }
}