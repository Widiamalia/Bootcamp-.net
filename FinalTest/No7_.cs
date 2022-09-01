namespace FinalTest
{
    public static class Anagrams
    {
        public static bool anagrams1(string first, string second)
        {
            if (String.IsNullOrEmpty(first) || String.IsNullOrEmpty(second) || first.Length != second.Length)
                return false;

            var array1 = first.ToLower().ToCharArray();
            Array.Sort(array1);

            var array2 = second.ToLower().ToCharArray();
            Array.Sort(array2);

            var newfirst = new string(array1);
            var newSecond = new string(array2);

            if (newfirst == newSecond)
                return true;
            return false;
        }
        class Program
        {
            static void Main(string[] args)
            {
                var result = Anagrams.anagrams1("Hello", "HELLo");
                Console.WriteLine(true);
            }
        }

    }
}