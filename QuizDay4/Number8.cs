namespace QuizDay4List
{
    class Number8
    {
        public static void No8()
        {

            List<int> list1a = new List<int> { 1, 2, 3 };
            List<int> list1b = new List<int> { 4, 5, 6 };
            List<int> list2a = new List<int> { 9, 2, 7 }; // 729
            List<int> list2b = new List<int> { 1, 3, 5 };// 531


            String str1a = string.Join("", list1a.ToArray());
            String str1b = string.Join("", list1b.ToArray());
            String str2a = string.Join("", list2a.ToArray());
            String str2b = string.Join("", list2b.ToArray());

            char[] val1a = str1a.ToCharArray();
            char[] val1b = str1b.ToCharArray();

            char[] val2a = str2a.ToCharArray();
            char[] val2b = str2b.ToCharArray();

            List<int> list1aTemp = new List<int>();
            List<int> list1bTemp = new List<int>();

            List<int> list2aTemp = new List<int>();
            List<int> list2bTemp = new List<int>();

            list1aTemp.Add(int.Parse(val1a));
            list1bTemp.Add(int.Parse(val1b));
            list2aTemp.Add(int.Parse(val2a));
            list2bTemp.Add(int.Parse(val2b));

            List<int> hasil1 = AddReverse(list1aTemp, list1bTemp);
            List<int> hasil2 = AddReverse(list2aTemp, list2bTemp);
            int[] hasilArr1 = hasil1.ToArray();
            int[] hasilArr2 = hasil2.ToArray();

            String test1 = string.Join("", hasilArr1);
            String test2 = string.Join("", hasilArr2);
            char[] testChar1 = test1.ToCharArray();
            char[] testChar2 = test2.ToCharArray();

            Console.Write(test1 + " = [");
            for (int i = 0; i < testChar1.Length; i++)
            {
                if (i == testChar1.Length - 1)
                {
                    Console.Write(testChar1[testChar1.Length - i - 1] + "]");
                }
                else
                {
                    Console.Write(testChar1[testChar1.Length - i - 1] + ", ");
                }
            }

            Console.WriteLine();
            Console.Write(test2 + " = [");
            for (int i = 0; i < testChar2.Length; i++)
            {
                if (i == testChar2.Length - 1)
                {
                    Console.Write(testChar2[testChar2.Length - i - 1] + "]");
                }
                else
                {
                    Console.Write(testChar2[testChar2.Length - i - 1] + ", ");
                }
            }
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

        public static List<int> AddReverse(List<int> val1, List<int> val2)
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
                // Console.Write(result[i]);
            }


            List<int> resultReverse = new List<int>();

            for (int i = 0; i < result.Count; i++)
            {

                resultReverse.Insert(i, result[result.Count - i - 1]);
            }



            return resultReverse;
        }

        public static void DisplayForList(List<int> xy)
        {
            for (int i = 0; i < xy.Count; i++)
            {
                Console.Write(xy[i]);
            }
        }
    }
}