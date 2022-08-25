namespace QuizLogic
{
    class Quiz11
    {
        public static void JumlahKata()
        {
            Console.Write("Enter string : ");
            string kalimat = Console.ReadLine();
            kalimat.ToLower();
            int jumlahKata = 0;
            string kata = " ";
            for (int i = 0; i < kalimat.Length; i++)
            {
                kata = kalimat[i].ToString();
                if (kata == " " || i == kalimat.Length - 1);
                {
                    jumlahKata++;
                }
            }
            Console.WriteLine($"Total words : {jumlahKata}");
        }

    }
}