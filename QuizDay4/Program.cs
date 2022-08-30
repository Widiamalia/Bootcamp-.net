using System;

namespace HelloWorld
{
    class Program
    {
        //NO1

        public static void displayHashset(HashSet<int> satu)
        {

            foreach (int sat in satu)
            {
                Console.Write($" {sat}");
            }
        }
        public static void SameElement(HashSet<int> satu, HashSet<int> dua)
        {
            HashSet<int> hasil = new HashSet<int>(satu);
            hasil.IntersectWith(dua);
            Console.WriteLine("Same Element Between 2 HashSet : ");
            displayHashset(hasil);
        }
        public static void MergeElement(HashSet<int> satu, HashSet<int> dua)
        {

            var result1 = new HashSet<int>(satu);
            result1.UnionWith(dua);
            Console.WriteLine("Union Result Between 2 HashSet : ");
            displayHashset(result1);
        }

        public static void ExceptElement(HashSet<int> satu, HashSet<int> dua)
        {
            var result2 = new HashSet<int>(dua);
            result2.ExceptWith(satu);
            Console.WriteLine("Except Element : ");
            displayHashset(result2);
        }

        public static void Except2Element(HashSet<int> satu, HashSet<int> dua)
        {
            var result3 = new HashSet<int>(satu);
            result3.SymmetricExceptWith(dua);
            Console.WriteLine("Except Element Between 2 HashSet : ");
            displayHashset(result3);
        }

        //No.4
        public static int GetRightPosition(List<int> output, int value)
        {
            int l = 0;
            int r = output.Count - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (output[mid] < value)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return l;
        }

        public static bool IsElementExist(List<int> output, int value)
        {
            int l = 0;
            int r = output.Count - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (output[mid] == value)
                {
                    return true;
                }

                if (output[mid] < value)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return false;
        }

        public static List<int> LongestIncreasingSubSequence(int[] input)
        {
            List<int> output = new List<int>();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (output.Count == 0)
                {
                    output.Add(input[i]);
                    dictionary[input[i]] = Int32.MinValue;
                }
                else
                {
                    if (!IsElementExist(output, input[i]))
                    {
                        if (input[i] > output.Last())
                        {
                            output.Add(input[i]);
                            dictionary[input[i]] = output[output.Count - 2];
                        }
                        else
                        {
                            int position = GetRightPosition(output, input[i]);

                            output[position] = input[i];

                            if (position == 0)
                            {
                                dictionary[input[i]] = Int32.MinValue;
                            }
                            else
                            {
                                dictionary[input[i]] = output[position - 1];
                            }

                        }
                    }
                }
            }

            int lastElement = output.Last();
            List<int> finalResult = new List<int>();

            while (lastElement != Int32.MinValue)
            {
                finalResult.Add(lastElement);
                lastElement = dictionary[lastElement];
            }

            return finalResult;
        }


        static void Main(string[] args)
        {
            int[] input = { 1, 2, 6, 10, 3 };
            List<int> finaList = LongestIncreasingSubSequence(input);

            for (int i = finaList.Count - 1; i >= 0; i--)
            {

                HashSet<int> hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
                HashSet<int> hs2 = new HashSet<int>() { 1, 2, 3, 4 };

                displayHashset(hs1);
                Console.WriteLine();
                displayHashset(hs2);
                Console.WriteLine();
                SameElement(hs1, hs2);
                Console.WriteLine();
                MergeElement(hs1, hs2);
                Console.WriteLine();
                ExceptElement(hs2, hs1);
                Console.WriteLine();
                Except2Element(hs2, hs1);
                Console.WriteLine();
                Console.WriteLine(finaList[i]);
            }
        }
         
    }
}