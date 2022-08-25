namespace day01
{
    class Intro 
    {
        public static void ShowConsole()
        {
            Console.WriteLine("Hello, World!");

            //1. Output show normal text
            Console.WriteLine("CodeId Bootcamp");

            //2.Concat
            Console.WriteLine("Code Academy" + "Bootcamp .NET");

            //3
            Console.WriteLine("Code Academy \nCool .NET");

            //4
            Console.WriteLine("I Love Programming \"C#\"");

            //5
            Console.WriteLine("Geek alphabet for B : \u03B2");

            //6
            Console.WriteLine("C:\\Users\\E5470\\Documents\\Visual Studio 2022\\Exercise\\1-Fundamental\\");

            //7 verbatin
            Console.WriteLine(@"Bootcamp .NET with CodeID Academy
Location Sentul City
Bogor
");


            //8

            Console.WriteLine(
                @"Which best programming language
===========================
");
            Console.WriteLine("a) Java");
            Console.WriteLine("b) C#");
            Console.WriteLine("c) Golang");

            //9 Formated Number
            Console.WriteLine("Temperatur on {0:D} is {1}C", DateTime.Today, 36.5);
        }
    }
}