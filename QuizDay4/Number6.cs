namespace QuizDay4List
{
    class Number6
    {
        public static void No6()
        {
            var input1 = new List<int>() { 1, 2, 3, 4, 4, 4, 3, 3, 2, 4 };
            var input2 = new List<int>() { 1, 1, 1, 2, 2, 2, 3, 3, 3 };

            ValueCount(input1);
            ValueCount(input2);
        }

        public static void ValueCount(List<int> input)
        {
            var result = new Dictionary<int, long>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > 0)
                {
                    long value = 0;
                    int max = input[i];
                    for (int j = 0; j < input.Count; j++)
                    {
                        if (max == input[j])
                        {
                            value++;
                            input[j] = -1;
                        }
                    }
                    result.Add(max, value);
                }
            }

            long maxValue = result.Values.Max();

            foreach (var i in result)
            {
                if (i.Value == maxValue)
                {
                    Console.WriteLine("Angka yang sering muncul : " + i.Key + "\n" +
                        "Banyaknya angka yang muncul : " + i.Value);
                }
            }
        }
    }
}