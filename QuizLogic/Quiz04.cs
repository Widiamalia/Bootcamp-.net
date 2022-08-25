namespace QuizLogic
{
    class Quiz04
    {
        public static void MaxNumber()
        {
            int count = 0;
            Console.Write("Enter max number loop : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number-1; i++)
            {
            count++;
                
            }
            
                Console.Write($"count : {count}");
            
        }

    }
}