namespace QuizLogic
{
    internal class Quiz06
    {
        public static void SummaryAngka()
        {
            int max = 0;
            int n = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter integer [ Type 0 for exit ] :");
                int angka = Convert.ToInt32(Console.ReadLine());
                if (angka > max)
                {
                    max = angka;
                }
                else if (angka == 0)
                {
                    Console.WriteLine($"angka terbesar : {max}");
                    break;
                }
            }
        }
    }
}