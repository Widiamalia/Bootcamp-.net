namespace QuizLogic
{
    class Quiz08
    {
        public static void PrimeNumber()
        {
            Console.Write("Enter number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i <= number; i++)
            {
                int jumlah = 0;
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        jumlah++;
                    }
                }
                if(jumlah == 2)
                {
                    Console.Write(i + " ");
                }
                
            }
        }

    }
}