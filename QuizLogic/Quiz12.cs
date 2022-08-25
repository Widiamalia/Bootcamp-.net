namespace QuizLogic
{
    class Quiz12
    {
        public static void Vowel()
        {
            Console.Write("Enter string : ");
            string kalimat = Console.ReadLine();
            kalimat.ToLower();
            int jumlah = 0;
            string kata = "";
            string ubah = "";
            for (int i = 1; i < kalimat.Length-1; i++)
            {
                kata = kalimat[i].ToString();
                if (kata == " ")
                {
                    ubah += " ";
                } else if (kata != " ")
                {
                    ubah += "*";
                }

            }
            var replacement = kalimat.Replace(kalimat.Substring(1, kalimat.Length - 2), ubah);
            Console.WriteLine(replacement);
        }
    }
}