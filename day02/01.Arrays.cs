namespace day02
{
    class Arrays
    {
        //Initial array

        public static void InitArrays()
        {
            int[] arr = new int[2];

            //fill element
            arr[0] = 1;
            arr[1] = 2;

            int[] arr2 = new int[] { 2, 3, 5, 7, };

            int[] arr3 = { 10, 20, 30, 40 };

            double[] arr4 = new double[2];
            arr4[0] = 34.5;

            string[] arr5 = { "fathur", "nova", "corry", "jeremy" };

            DisplayArrayInt(arr2);
            Console.WriteLine();
            DisplayArrayString(arr5);
            Console.WriteLine();

            var sum = SumAllElement(arr3);
            Console.WriteLine($"Total Array : {sum}");


            //findLargest 
            var arr6 = new int[] { 1, 54, 78, 90, 3, 56, 76 };
            var max = FindingMaxElement(arr6);
            Console.WriteLine($"Total Max : {max}");
        }

        //finding largest element
        public static int FindingMaxElement(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                // cek mana paling max
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        //finding smallest element

        //copy array
      

        //fill element array with random int
        public static void FillRandomArray()
        {
            Random random = new Random();
            //fill integer
            var listInt = new int[100];
            for (int i = 0; i < listInt.Length; i++)
            {
                listInt[i] = random.Next(0, 100);
            }

            //DisplayArrayInt(listInt);

            //fill random with char 'a' -'z'
            char[] charArray = new char[100];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = (char)random.Next('a', 'z');
            }

            DisplayArrayChar(charArray);

        }
        public static void CopyingArray()

        {
            int[] sourceArray = { 2, 3, 5, 7, 11, 9, 15, 65};
            int[] targetArray = new int[sourceArray.Length];

            //case : target array refer ke memory yg sama di sourearray
            targetArray = sourceArray;

            //cara 1 : copy array by looping
           /* for (int i = 0; i < sourceArray.Length; i++)
            {
                targetArray[i] = sourceArray[i];
            }*/

            //cara 2: gunakan method

            Array.Copy(sourceArray, targetArray, sourceArray.Length);

            DisplayArrayInt(targetArray);

            //sorting
            Array.Sort(targetArray);

        }

        //sum all element array
        public static Double SumAllElement(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i]; 
            }
            return sum; 
        }

        public static void DisplayArrayInt(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        public static void DisplayArrayString(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        public static void DisplayArrayChar(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

    }
}