namespace FinalTest
{
    //NO1//
    /*    internal class Nums1
        {
            public static int[] no1(int[] arr)
            {
                int[] array = arr;
                int first = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    array[i] = arr[(i + 1)];
                }
                array[arr.Length - 1] = first;
                return array;
            }
        }*/

    //NO2//
    public class Factorial
    {
        public int display(int n)
        {
            int num = 1;
            while (n != 1)
            {
                num = num * n;
                n = n - 1;
            }
            return num;
        }
        static void Main(string[] args)
        {
            int value = 5;
            int numbers;
            Factorial fact = new Factorial();
            numbers = fact.display(value);
            Console.WriteLine("Fib(n) : {0}", numbers);
            Console.ReadLine();
        }
    }

    //NO4//
    static void Main(string[] args)
    {

        int input, first = 0, second = 1, third = 0;
        Console.Write("Enter a number : ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("First {0} Fibonacci numbers {1} {2} ", input, first, second);

        for (int i = 3; i <= input; i++)
        {
            third = first + second;
            Console.Write("{0} ", third);
            first = second;
            second = third;
        }

    }


}