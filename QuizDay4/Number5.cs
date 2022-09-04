namespace QuizDay4List
{
    class Number5
    {
        public static void No5()
        {
            var array1 = new List<string>() { "Mangga", "Apel", "Melon", "Pisang", "Sirsak", "Tomat", "Nanas", "Nangka", "Timun", "Mangga" };
            var array2 = new List<string>() { "Bayam", "Wortel", "Kangkung", "Mangga", "Tomat", "Kembang Kol", "Nangka", "Timun" };

            var same = new List<string>();
            var diff = new List<string>();
            for (int i = 0; i < array1.Count; i++)
            {
                if (array2.Contains(array1[i]))
                {
                    if (!same.Contains(array1[i]))
                    {
                        same.Add(array1[i]);
                    }
                }
                else
                {
                    diff.Add(array1[i]);
                }
            }

            for (int j = 0; j < array2.Count; j++)
            {
                if (!array1.Contains(array2[j]))
                {
                    if (!diff.Contains(array2[j]))
                    {
                        diff.Add(array2[j]);
                    }
                }
            }

            Console.Write("var array 1: ");
            DisplayElement(array1);
            Console.WriteLine();
            Console.Write("var array 2: ");
            DisplayElement(array2);

            Console.WriteLine();

            Console.Write("Same       : ");
            foreach (var i in same)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Difference : ");
            foreach (var j in diff)
            {
                Console.Write(j + " ");
            }
        }

        public static void DisplayElement(List<string> input)
        {
            foreach (var i in input)
            {
                Console.Write(i + " ");
            }
        }
    }
}