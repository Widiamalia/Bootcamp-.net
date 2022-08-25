namespace QuizLogic
{
    class Quiz09
    {
        public static void Palindrome()
        {
            Console.Write("Enter string : ");
            string kalimat = Console.ReadLine();
            kalimat.ToLower();
            string kata = "";

            for (int i = 0; i < kalimat.Length; i++)
            {
                kata += kalimat[i].ToString();
            }
            if (kata == kalimat)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("It's Not Palindrome");
            }
        }
    }
}