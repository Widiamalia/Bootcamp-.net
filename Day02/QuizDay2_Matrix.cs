using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class QuizDay2_Matrix
    {
        //No.9//
        public static int[,] MatrixDiagonal1(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = 5;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = counter--;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 20;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 10;
                    }
                }
            }
            return matrix;
        }

        //No.10//
        public static int[,] MatrixDiagonal2(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            Random rand = new Random();
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = rand.Next(100);
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 20;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 10;
                    }
                }
            }
            Console.WriteLine($"Total Diagonal Matrix  : {sum}");
            return matrix;
        }

        //NO.11
        public static int[,] No11(int baris, int kolom)
        {
            int[,] matrix = new int[7, 7];
            int n = baris - 1;

            //fill matrix

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i + j;
                    if (i != 0 && j != 0)
                    {
                        if (i != n && j != n)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }

            }
            return matrix;
        }


        //NO.12
        public static int[,] IniNomorDuaBelas(int[,] matrix)
        {
            int k = matrix.GetLength(0) - 1;
            int sum = 0;
            int s = 0;
            int[,] baru = new int[matrix.GetLength(0), matrix.GetLength(1)];
            int[,] bar = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < k && j < k)
                    {
                        baru[i, j] = i + j;
                    }
                }

            }

            bar = baru;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i != k && j != k)
                    {
                        sum += baru[i, j];
                        bar[k, i] = bar[i, k] = sum;
                        if (i == j)
                        {
                            s += baru[i, j];
                            bar[k, k] = s;
                        }
                        if (j == k - 1)
                        {
                            sum = 0;
                        }

                    }
                    
                }

            }
            return bar;
        }

        //No.13//



        //NO.14//



        //No.15//

        public static int Students(char[,] student, char[] guru)
        {
            char[,] nilai = student;
            char[] kunci = guru;
            int hitung = 0;

            for (int i = 0; i < nilai.GetLength(0); i++)
            {
                hitung = 0;
                Console.Write($"jawaban student {i} : ");
                for (int j = 0; j < nilai.GetLength(1); j++)
                {
                    Console.Write($" {nilai[i, j]} ");
                    if (nilai[i, j] == kunci[j])
                    {
                        hitung++;
                    }
                }
                Console.WriteLine($"\njawaban student {i} yang benar : {hitung}");
            }
            return hitung;
        }
    }
}