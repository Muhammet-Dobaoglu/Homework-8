namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0;
            int i = 0, sayac = 0;
            while (i < 20)
            {
                Console.Write("{0}. sayıyı girin: ", i + 1);
                double sayi = Convert.ToDouble(Console.ReadLine());

                if (sayi % 3 == 0 && sayi % 5 == 0)
                {
                    toplam = toplam + sayi;
                    sayac++;
                }
                i++;
            }
            Console.WriteLine("3'e ve 5'e tam bölünenlerin toplamı={0}\n3'e ve 5'e tam bölünenlerin sayısı={1}", toplam, sayac);
            Console.ReadKey();
        }
    }
}