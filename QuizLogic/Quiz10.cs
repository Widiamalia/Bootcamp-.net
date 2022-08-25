namespace QuizLogic
{
    class Quiz10
    {
        public static void Vowel()
        {
            Console.Write("Enter string : ");
            string kalimat = Console.ReadLine();
            kalimat.ToLower();
            int vowelHitung = 0;
            int consonantHitung = 0;
            string kata = " ";
            for  (int i = 0; i < kalimat.Length; i++)
            {
                kata = kalimat[i].ToString();

                if (kata == "a" || kata == "i" || kata == "u" || kata == "e" || kata == "o")
                {
                    vowelHitung++;
                }
                else
                {
                    consonantHitung++;
                }
            }
            Console.WriteLine($"Vowel : {vowelHitung}, consonant : {consonantHitung}");
        }
    }
}