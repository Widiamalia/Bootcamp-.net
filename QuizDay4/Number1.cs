namespace QuizDay4List
{
    class Number1
    {
        public static void No1()
        {

            var inputA = new List<int>() { 1, 2, 5, 6, 9 };
            var inputB = new List<int>() { 1, 2, 3, 4 };

            Console.WriteLine("Same Element Between 2 HashSet : ");
            DisplayElement(SameElement(inputA, inputB));
            Console.WriteLine();

            Console.WriteLine("Union Result Between 2 HashSet : ");
            DisplayElement(MergeElement(inputA, inputB));
            Console.WriteLine();

            Console.WriteLine("Except Element : ");
            DisplayElement(ExceptElement(inputA, inputB));
            Console.WriteLine();

            Console.WriteLine("Except Element Between 2 HashSet : ");
            DisplayElement(Except2Element(inputA, inputB));
            Console.WriteLine();

        }

        public static List<int> SameElement(List<int> A, List<int> B)
        {
            var sameElement = new List<int>();
            foreach (var i in A)
            {
                foreach (var j in B)
                {
                    if (i == j)
                    {
                        sameElement.Add(j);
                    }
                }
            }
            return sameElement;
        }

        public static List<int> MergeElement(List<int> A, List<int> B)
        {
            var mergeElement = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (!mergeElement.Contains(i))
                {
                    mergeElement.Add(A[i]);
                }
            }

            for (int i = 0; i < B.Count; i++)
            {
                if (mergeElement.Contains(i))
                {
                    mergeElement.Add(B[i]);
                }
            }
            mergeElement.Sort();
            return mergeElement;
        }

        public static List<int> ExceptElement(List<int> A, List<int> B)
        {
            var exceptElement = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (!B.Contains(A[i]))
                {
                    exceptElement.Add(A[i]);
                }
            }
            return exceptElement;

        }

        public static List<int> Except2Element(List<int> A, List<int> B)
        {
            var element = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (!B.Contains(A[i]))
                {
                    element.Add(A[i]);
                }
            }

            for (int i = 0; i < B.Count; i++)
            {
                if (!A.Contains(B[i]))
                {
                    element.Add(B[i]);
                }
            }
            element.Sort();
            return element;
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