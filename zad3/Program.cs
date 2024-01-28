namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Statyczna s1 = new Statyczna(1);
            Console.WriteLine(Statyczna.Liczba);
            Statyczna.Zwieksz();
            Statyczna.Zwieksz();
            Statyczna.Zwieksz();
            Console.WriteLine(Statyczna.Liczba);
        }
    }
}
