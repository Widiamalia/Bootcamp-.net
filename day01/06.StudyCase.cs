namespace day01
{
    class StudyCase
    {
        public static void GuessNumber()
        {
            Console.WriteLine("Guess magic number between 0-20 : ");

            Random random = new Random();
            int number = random.Next(0, 20);

            int guess = -1;

            while(guess != number)
            {
                Console.WriteLine("Enter your guess ?");
                var input = Console.ReadLine();
                int.TryParse(input, out guess);

                // cek kondisi
                if (guess == number)
                {
                    Console.WriteLine($"You're right, number :{guess} ");
                }
                else if (
                    guess > number)
                {
                    Console.WriteLine($"Your guess is too high. Try again!");
                }
                else
                {
                    Console.WriteLine($"Your guess is too low. Try again!");
                }


            }
        }
    }
}