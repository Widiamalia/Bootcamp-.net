using static System.Console;
using FinalTest;


namespace FinalTest
{
    static void Main(string[] args)
    {
        var result = Anagrams.anagrams1("Hello", "OlleH");
        Console.WriteLine(true);
        var result1 = Anagrams.anagrams1("Hello", "HeOlL");
        Console.WriteLine(true);
        var result2 = Anagrams.anagrams1("Hello", "OLEH");
        Console.WriteLine(false);
        ReadLine();
    }

}

