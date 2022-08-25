namespace day01
{
    class Iterator
    {
        //01
        public static void ShowOddEventNumber()
        {
            for (int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"{i} adalah bilangan genap"); 
                }
                else
                {
                    Console.WriteLine($"{i} adalah bilangan ganjil");
                }
            }
        }


        //2
        public static void Showbox()
        {
            //cetak baris bawah
            for (int i = 0; i < 5; i++)
            {
                //cetak kolom kanan
                for(int j = 0; j < 5; j++)
                {
                    Console.Write($"{i+j}\t");
                }
                Console.WriteLine();
            }
        }

        //2
        public static void ShowLeftTriangle()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write((i + j) + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void ShowRightTriangle()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - 1; j++)
                {
                    Console.Write("\t");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write((i + 1) + "\t");
                }
                Console.WriteLine();
               
            }
            
        } 
        public static void ShowContinueStmt()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public static void ShowWhileDo()
        {
            int i = 0;
            while (i <= 20)
            {
                Console.WriteLine("iteration : " + i);
                i++;
                if (i == 10)
                    break;
            }
        }

        public static void ShowDoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine($"{i}");
                i++;
            } while (i <= 10);
        }

    }
}