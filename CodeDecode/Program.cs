namespace CodeDecode
{
    internal class Program
    {
        /// <summary>
        /// Öncelikle code karakter sayımıza göre uygun mu ona bakılır.
        ///karakter paternde var mı bakılır
        ///varsa index degeri alınıp diziye atılır
        ///yoksa false döndürülür
        ///varsa yeni dizi değerleri counter patternde kontrol edilir 
        ///patterne uygunsa true döner patterndeki bir değerden bile buyukse false döner
        /// </summary>
        private static readonly int[] counterPattern = { 18, 19, 11, 11, 22, 22, 14, 3 };
        private static readonly string[] codePattern = { "N", "2", "F", "K", "Z", "5", "D", "C", "3", "9", "T", "L", "G", "A", "7", "H", "P", "E", "X", "M", "Y", "4", "R" };

        static void Main(string[] args)
        {
            string answer = "";
            while (answer.ToUpper() == "E")
            {
                try
                {

                    Console.WriteLine("kodun doğruluğunu test etmek için kodu girmek ister misiniz?-E(Evet)-H(Hayır)");
                    answer = Console.ReadLine();
                    if (answer.ToUpper() == "E")
                    {
                        Console.Write("Kodunuzu giriniz:");
                        string answer2 = "";
                        answer2 = Console.ReadLine();
                        if (CodeControl(answer2))
                        {
                            Console.WriteLine("Kodunuz doğrulanmıştır.");
                        }
                        else
                        {
                            Console.WriteLine("Kodunuz hatalıdır.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata oluştu tekrar deneyiniz.");
                    Console.WriteLine("kodun doğruluğunu test etmek için kodu girmek ister misiniz?-E(Evet)-H(Hayır)");
                    answer = Console.ReadLine();
                }
            }
        }

        public static bool CodeControl(string code)
        {
            bool firstControl = false;
            try
            {
                if (code.Length == 8)
                {
                    for (int i = 0; i < code.Length; i++)
                    {
                        firstControl = false;
                        for (int j = 0; j < codePattern.Length; j++)
                        {
                            if (codePattern[j] == code[i].ToString().ToUpper())
                            {
                                if (counterPattern[i] >= j)
                                {
                                    firstControl = true;
                                    break;
                                }

                            }

                        }

                    }
                }
                return firstControl;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}