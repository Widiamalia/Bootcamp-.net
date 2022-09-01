namespace Day02
{
    class QuizDay2_Array
    {
        // No.1

        public static int[] InitArrayInt(int[] arr)
        {
            int[] array = arr;
            return array;
        }
        public static int[] UbahPosisi(int[] arr)
        {
            int[] value = arr;
            Random rand = new Random();
            int n = arr.Length - 1;

            while (n > 0)
            {
                int temp = value[n];
                int random = rand.Next(0, n);
                value[n] = value[random];
                value[random] = temp;
                n--;
            }
            return arr;
        }

        //No.2//
        public static int[] ShiftArray(int[] arr)
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

        //No.3//
        public static int[] RotateArray(int[] arr)
        {
            int[] num = new int[arr.Length];
            for (int j = 1; j < 4; j++)
            {
                // { 15, 2, 30, 12, 10, 5 }
                Console.WriteLine();
                Console.WriteLine($"Rotating {j}");
                int first = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    num[i] = arr[(i + 1)];
                }
                num[arr.Length - 1] = first;
                DisplayArray(num);
                arr = num;
            }
            return num;
        }


        //No.4//
        public static int[] No4(int[] arr)
        {
            int[] num = arr;
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine($"\nRotating ke {j + 1} : ");
                int last = arr[arr.Length - 1];
                for (int i = arr.Length -1; i > 0; i--)
                {
                    num[i] = arr[(i - 1)];
                }
                num[0] = last;
                DisplayArray(num);
                arr = num;
            }
            return num;
        }

        //No.5//
        public static int[] No5(int[] arr)
        {
            int[] num = arr;
            Array.Sort(num);
            int hitung = 0;
            for (int i = 0; i < num.Length; i++)
            {
                hitung = 0;
                for (int j = 0; j <= num.Length - 1; j++)
                {
                    if (num[i] == num[j])
                    {
                        hitung++;
                    }
                }
                if (i < num.Length - 1 && num[i] != num[i + 1] )
                {
                    Console.Write($"{num[i]} muncul {hitung} kali\n");
                }
                else if (i == num.Length - 1)
                {
                    Console.Write($"{num[i]} muncul {hitung} kali\n");
                }
            }
            return num;
        }

        //No.6//
        public static int[] No6(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                int x = arr[i];
                if (i < arr.Length - 1 && x == arr[i + 1])
                {
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (j == arr.Length - 1)
                        {
                            arr[j] = -1;
                        }
                        else
                        {
                            arr[j] = arr[j + 1];
                        }
                    }
                }
            }
            return arr;
        }



        //No.7//
        public static int[] No7(int[] arr)
        {
            int[] widi = arr;
            Array.Sort(widi);
            var widii = widi.Distinct().ToArray();
            /*        for (int i = 0; i < arr.Length; i++)
                    {
                        int x = arr[i];
                        if (i < arr.Length - 1 && x == arr[i + 1])
                        {
                            continue;
                        }
                    }
                    return arr;*/
            return widii;
        }


        //No.8//
        public static char[] No8(int arr)
        {
            char[] num = new char[arr];
            var huruf = "abcdefghijklmnopqrstuvwxyz";
            Random r = new Random();
            int hitung = 0;
            for (int i = 0; i < num.Length; i++)
            {

                num[i] = huruf[r.Next(0, 26)];
            }
            DisplayArrayChar(num);
            Console.WriteLine("\n==========RESULT=============\n");
            Console.WriteLine();
            Array.Sort(num);

            for (int i = 0; i < num.Length; i++)
            {
                hitung = 0;
                for (int j = 0; j <= num.Length - 1; j++)
                {
                    if (num[i] == num[j])
                    {
                        hitung++;
                    }
                }
                if (i < num.Length - 1 && num[i] != num[i + 1])
                {
                    Console.Write($"{hitung} {num[i]} ");

                }
                else if (i == num.Length - 1)
                {
                    Console.Write($"{hitung} {num[i]} ");
                }
            }
            return num;
        }


        public static void DisplayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");

            }
        }

        public static void DisplayArrayChar(char[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");

            }
        }
    }
}