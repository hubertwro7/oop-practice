namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczby1 = new int[] { 1, 2, 3, 4, 5, 6 };
            Sumator sumator1 = new Sumator(liczby1);
            sumator1.WypiszLiczby();
            sumator1.WypiszWPrzedziale(-1, 6);
            sumator1.WypiszWPrzedziale(2, 3);
            Console.WriteLine($"Ile elementow: {sumator1.IleElementow()}");
            Console.WriteLine($"Suma podzielnych przez 3: {sumator1.SumaPodziel3()}");
            Console.WriteLine($"Suma: {sumator1.Suma()}");
        }
    }
}
