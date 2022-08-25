namespace QuizLogic
{
    internal class Quiz02
    {
        public static void TotalDigit()
        {
            int total = 0;
            int count = 0;
            Console.Write("Enter Number Integer : ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                total = total + (number % 10);
                number = number / 10;
                count++;
            }
            Console.WriteLine($"Count {count}");
        }
    }
}



