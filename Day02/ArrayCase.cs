namespace Day02
{
    internal class ArrayCase
    {
        public static void IntroArray()
        {
            //declare array with date type
            int[] arr;
            int[] arrInt = new int[5];
            arrInt[0] = 12;
            arrInt[1] = 45;
            arrInt[3] = 50;
            arrInt[4] = 1_000_000;

            //init array with string data type
            string[] listOfGirl = new string[] { "Yuli", "Rini", "Widi" };

            //display array
            foreach (var item in listOfGirl)
            {
                Console.WriteLine($"{item}");
            }

            for (int i = 0; i < listOfGirl.Length; i++)
            {
                Console.WriteLine(listOfGirl[i]);
            }
        }

        //method return or function input array int, return array int

        public static int[] InitArrayInt(int[] arr)
        {
            int[] array = arr;
            return array;

        }

        //initial value with random
        public static int[] InitArrayRandom(int n)
        {
            int[] arr = new int[n];
            Random rand = new Random();

            for (int i = 0; 1 < arr.Length; i++)
            {
                arr[1] = rand.Next(50);
            }
            return arr;
        }

        //sum all array element
        public static double SumAllElement(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static int FindLargestElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }


        public static void DisplayArrayInt(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }



    }
}