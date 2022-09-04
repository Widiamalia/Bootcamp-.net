namespace QuizDay4List
{
    class Number2
    {
        public static void No2()
        {
            var input1 = new List<int>() { 1, 2, 3, 4 };
            var input2 = new List<string>() { "A", "BB", "CCC", "DDDD" };

            input1.Reverse();
            input2.Reverse();

            foreach (var a in input1)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();

            foreach (var b in input2)
            {
                Console.Write(b + " ");
            }
        }
    }
}