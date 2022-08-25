namespace QuizLogic
{
    internal class Quiz01
    {
        public static void SummaryAngka1()
        {
            int sum = 0;
            Console.Write("Enter Number Integer : ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                sum = sum + (number % 10);
                number = number / 10;
            }
            Console.WriteLine($"Total sum : {sum}");
        }


        public static void SummaryAngka2()
        {
            int sum = 0;
            Console.Write("Enter Number Integer : ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                sum = sum + (number % 10);
                number = number / 10;
            }
            Console.Write(sum + "");
        }

    }
}    
  
        