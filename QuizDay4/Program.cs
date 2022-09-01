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

 
        //N02

        static void Main(string[] args)
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
        }
         
    }
}