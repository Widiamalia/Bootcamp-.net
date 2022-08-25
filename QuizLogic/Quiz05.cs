namespace QuizLogic
{
    class Quiz05
    {
        public static void GuessNumbers()
        {
            Console.WriteLine("Guess magic number between 0-20 : ");

            Random random = new Random();
            int number = random.Next(0, 20);

            int guess = -1;

            while (guess != number)
            {
                Console.WriteLine("Enter your guess ?");
                var input = Console.ReadLine();
                int.TryParse(input, out guess);

                // cek kondisi
                if (guess == number)
                {
                    Console.WriteLine($"Tebakan kamu benar, angka yang ditebak {guess}");
                    Console.WriteLine($"Tebak lagi?");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("\n");
                        GuessNumbers();
                    }
                    else if (key.Key == ConsoleKey.N)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Your Quit");
                        break;
                    }
                }
                else if (
                    guess > number)
                {
                    Console.WriteLine($"Your guess is too high");
                }
                else
                {
                    Console.WriteLine($"Your guess is too low");
                }


            }
        }
    }
}