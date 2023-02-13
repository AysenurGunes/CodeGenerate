namespace CodeGenerate
{
    internal class Program
    {
        private static readonly int[] counterPattern = { 18, 19, 11, 11, 22, 22, 14, 3 };
        private static readonly string[] codePattern = { "N", "2", "F", "K", "Z", "5", "D", "C", "3", "9", "T", "L", "G", "A", "7", "H", "P", "E", "X", "M", "Y", "4", "R" };
        static void Main(string[] args)
        {
            int[] lastCounter = new int[counterPattern.Length];
            string Answer = "";
            do
            {
                lastCounter = CodeCounter(lastCounter);
                string code = "";
                bool lastCounterControl = true;
                for (int i = 0; i < lastCounter.Length; i++)
                {
                    code = code + codePattern[lastCounter[i]];
                    if (lastCounter[i] != 0)
                    {
                        lastCounterControl = false;
                    }
                }
                Console.WriteLine(code);
              
                Console.WriteLine("Devam etmek istiyor musunuz?-E(Evet)-H(Hayır)");
                Answer = Console.ReadLine();
                if (lastCounterControl)
                {
                    break;
                }
            } while (Answer.ToUpper() == "E");
        }
        public static int[] CodeCounter(int[] lastCounter)
        {

            if (lastCounter[7] == counterPattern[7])
            {
                lastCounter[7] = 0;
            }
            else if (lastCounter[7] < counterPattern[7])
            {
                lastCounter[7] = lastCounter[7] + 1;
                return lastCounter;
            }
            else
            {
                return lastCounter;
            }

            for (int i = 6; i >= 0; i--)
            {
                if (lastCounter[i + 1] == 0)
                {
                    lastCounter[i] = lastCounter[i] + 1;
                }
                if (lastCounter[i] == counterPattern[i])
                {
                    lastCounter[i] = 0;
                }
                else
                {
                    return lastCounter;
                }
            }

            return lastCounter;
        }
        //karakter paternde var mı bakılır
        //varsa index degeri alınıp diziye atılır
        //yoksa false döndürülür
        //varsa yeni dizi değerleri counter patteernde kontrol edilir edilir
        //patterne uygunsa true döner patterndeki bir değerden bile buyukse false döner

      
    }
}