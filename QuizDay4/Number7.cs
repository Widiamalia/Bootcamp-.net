namespace QuizDay4List
{
    class Number7
    {
        public static void No7()
        {
            Console.Write("Input 1 : ");
            string input1 = Console.ReadLine();
            Console.Write("Input 2 : ");
            string input2 = Console.ReadLine();

            char[] val1 = input1.ToCharArray();
            char[] val2 = input2.ToCharArray();

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            list1.Add(int.Parse(val1));
            list2.Add(int.Parse(val2));
            ListAddition(list1, list2);
        }

        public static List<int> ListAddition(List<int> val1, List<int> val2)
        {
            List<string> newVal1 = val1.ConvertAll<string>(delegate (int i) { return i.ToString(); });
            List<string> newVal2 = val2.ConvertAll<string>(delegate (int i) { return i.ToString(); });

            var list1 = new List<int>();
            var list2 = new List<int>();

            for (int i = 0; i < newVal1.Count; i++)
            {
                list1.Add(int.Parse(newVal1[i]));
                list2.Add(int.Parse(newVal2[i]));
            }

            List<int> result = new List<int>();

            for (int i = 0; i < newVal2.Count; i++)
            {
                result.Add(list1[i] + list2[i]);
                Console.Write(result[i]);
            }
            return result;
        }
    }
}