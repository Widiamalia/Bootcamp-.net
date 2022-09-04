namespace QuizDay4List
{
    class Number4
    {
        public static List<int> No4()
        {
            var a = new List<int> { 7, 2, 7, 1, 2, 5, 7, 1 };
            var b = new List<int> { 7, 2, 7, 1, 2, 3, 8, 1, 2, 3, 4, 5 };
            var c = new List<int> { 1, 1, 2, 2, 2, 3, 3, 3, 3 };

            Console.Write("Input 1 : ");
            Display(a);
            Console.WriteLine();
            Console.Write("Find Longest Sequence A: ");
            Display(FindSec(a));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Input 2 : ");
            Display(b);
            Console.Write("\nFind Longest Sequence B: ");
            Display(FindSec(b));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Input 3 : ");
            Display(c);
            Console.Write("\nFind Longest Sequence C: ");
            Display(FindSec(c));
            return a;
        }

        static List<int> FindSec(List<int> ax)
        {
            int temp = 0;
            List<int> num = ax;
            var hasil = new List<int>();

            for (int i = 0; i < num.Count; i++)
            {
                List<int> numbers = new List<int>();

                for (int y = i; y < num.Count; y++)
                {
                    if (y == i)
                    {
                        numbers.Add(num[y]);
                    }
                    else
                    {
                        if (num[y] < num[y - 1])
                        {
                            break;
                        }
                        else
                        {
                            numbers.Add(num[y]);
                        }
                    }
                }
                if (numbers.Count > temp)
                {
                    temp = numbers.Count;
                    hasil = numbers;
                }

            }

            return hasil;
        }

        public static void Display(List<int> x)
        {
            foreach (var i in x)
            {
                Console.Write(i + " ");
            }
        }
    }
}