namespace QuizLogic
{
    class Quiz03
    {
        public static void Reversed()
        {
            int total = 0;
            Console.Write("Enter number integer : ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                total = number % 10;
                number = number / 10;
                Console.Write(total + " ");
            }

        }
    }
}