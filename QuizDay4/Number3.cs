namespace QuizDay4List
{
    class Number3
    {
        public static void No3()
        {
            var input1 = new List<int>() { 1, 1, 2, 3, 4, 1, 2, 3 };
            var input2 = new List<int>() { 7, 5, 3, 5, 1 };
            var input3 = new List<int>() { 1, 1, 1, 1, 1, 1, 1 };

            Console.Write("Input 1 : ");
            DisplayElement(input1);
            Console.WriteLine();
            Console.Write("Return : ");
            DisplayElement(RemoveDuplicate(input1));

            Console.WriteLine();
            Console.Write("Input 2 : ");
            DisplayElement(input2);
            Console.WriteLine();
            Console.Write("Return : ");
            DisplayElement(RemoveDuplicate(input2));

            Console.WriteLine();
            Console.Write("Input 3 : ");
            DisplayElement(input3);
            Console.WriteLine();
            Console.Write("Return 3 : ");
            DisplayElement(RemoveDuplicate(input3));
        }

        public static List<int> RemoveDuplicate(List<int> input)
        {
            var newElement = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {

                if (newElement.Contains(input[i]))
                {
                    continue;
                }
                else
                {
                    newElement.Add(input[i]);
                }
            }
            return newElement;
        }
        public static void DisplayElement(List<int> input)
        {
            foreach (var i in input)
            {
                Console.Write(i + " ");
            }
        }
    }
}