using static System.Console;
using Day02;

/*ArrayCase.IntroArray();

//call function
int[] n = { 10, 20, 30, };
var myArray = ArrayCase.InitArrayInt(new int[] { 20, 30, 40, 50 });

ArrayCase.DisplayArrayInt(myArray);

var myRandom = ArrayCase.InitArrayInt(new int[] { 20, 30, 40, 50 });

//ArrayCase.DisplayArrayInt(ArrayCase.InitArayRandom (20));
WriteLine();
WriteLine($"Total Sum Random = {ArrayCase.SumAllElement(myRandom)}");

WriteLine($"Max Number = {ArrayCase.FindLargestElement(myRandom)}");

//copy array dari myRandom to new array
int[] newArray = new int[myRandom.Length];
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = myRandom[i];
}

WriteLine();

//sort array
Array.Sort(newArray);
ArrayCase.DisplayArrayInt(newArray);

//gunakan method
var randomArray = new int[myRandom.Length];
Array.Copy(randomArray, 0, newArray, 0, myRandom.Length);

//sort array;*/

/*WriteLine();
Array.Reverse(randomArray);
Array.Sort(randomArray);*/

/*int[] n = { 15, 10, 20, 30, 45, 24 };
WriteLine("Before Random Position");
Arrays.DisplayArrayInt(n);
WriteLine();
var randomArr = QuizSolution.RandomPosition(n);
WriteLine("After Random Position");
Arrays.DisplayArrayInt(randomArr);

/*WriteLine("Before Shift Array");
Array.DisplayArrayInt(n);
var ShiftArray = QuizSolution.ShiftArray(n);
writeLine();
WriteLine("After Shift Array");
Array.DisplayArrayInt(ShiftArray);
*/

/** Matrix */

/*Matrix.InitMatrix();
var myMatrix = Matrix.FillRandomMatrix(5, 5);
*//*Matrix.DisplayMatrix(myMatrix);*//*

WriteLine();
var matrixDiagonal = Matrix.MatrixDiagonal(5, 5);
Matrix.DisplayMatrix(matrixDiagonal);*/



//----------------Array----------------//
//No.1
/*int[] n = { 15, 2, 30, 12, 10, 5 };
var myArray = Day02.QuizDay2_Array.InitArrayInt(n);
Console.WriteLine("Before Random : ");
Day02.QuizDay2_Array.DisplayArray(myArray);
var widi = Day02.QuizDay2_Array.UbahPosisi(myArray);
Console.WriteLine("\nAfter random position element change : ");
Day02.QuizDay2_Array.DisplayArray(widi);*/

//No.2
/*int[] x = { 15, 2, 30, 12, 10, 5 };
var myArray = Day02.QuizDay2_Array.ShiftArray(x);
Console.WriteLine("Before shifting : ");
QuizDay2_Array.DisplayArray(myArray);
var shift = QuizDay2_Array.ShiftArray(myArray);
Console.WriteLine("\n After shifting : ");
Day02.QuizDay2_Array.DisplayArray(shift);*/

//No.3
/*int[] n = { 15, 2, 30, 12, 10, 5 };
var RotateArray = Day02.QuizDay2_Array.InitArrayInt(n);
Console.WriteLine("\nBefore Rotating");
Day02.QuizDay2_Array.DisplayArray(RotateArray);
var num = QuizDay2_Array.RotateArray(RotateArray);*/

//No.4
/*int[] n = { 15, 2, 30, 12, 10, 5 };
var kanan = Day02.QuizDay2_Array.No4(n);
Console.WriteLine("\nBefore Rotating");
Day02.QuizDay2_Array.DisplayArray(kanan);*/

//No.5
Console.WriteLine("\n==============Result============\n");
int[] no5 = { 5, 2, 30, 12, 101, 5, 2, 10, 5 };
var total = Day02.QuizDay2_Array.No4(no5);
WriteLine();
Day02.QuizDay2_Array.DisplayArray(total);


//No.6



//No.7



//No.8
Console.WriteLine("\n==========No8==========\n");
int arr = 100;
var num = Day02.QuizDay2_Array.No8(arr);
WriteLine();
Day02.QuizDay2_Array.DisplayArray(num);


//-----------------MATRIX-------------//

//No.9
/*WriteLine();
var matrixDiagonal = Matrix.MatrixDiagonal1(5, 5);
Matrix.DisplayMatrix(matrixDiagonal);
*/

/*//No.10
WriteLine();
var matrixDiagonal = Matrix.MatrixDiagonal2(5, 5);
Matrix.DisplayMatrix(matrixDiagonal);*/

//No.11
/*WriteLine();
var myDiagonal = QuizDay2_Matrix.No11(7, 7);
Matrix.DisplayMatrix(myDiagonal);*/


//No.12
/*int[,] satu = new int[8, 8];
Matrix.DisplayMatrix(satu);
Console.WriteLine();
QuizDay2_Matrix.IniNomorDuaBelas(satu);

Matrix.DisplayMatrix(QuizDay2_Matrix.IniNomorDuaBelas(satu));
*/

//No.15
/*
char[,] student = new char[,]{
    {'A','B','A','C','C','D','E','E','A','D'},
    {'D','B','A','B','C','A','E','E','A','D'},
    {'E','D','D','A','C','B','E','E','A','D'},
    {'C','B','A','E','D','C','E','E','A','D'},
    {'A','B','D','C','C','D','E','E','A','D'},
    {'B','B','E','C','C','D','E','E','A','D'},
    {'B','B','A','C','C','D','E','E','A','D'},
    {'E','B','E','C','C','D','E','E','A','D'},
};
char[] guru = new char[] { 'D', 'B', 'D', 'C', 'C', 'D', 'A', 'E', 'A', 'D' };
Console.WriteLine(student);
var siswa = Day02.Matrix.Students(student, guru);*/

ReadLine();