namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var liczba = new Liczba("3.14152");
            liczba.Display();
            Console.WriteLine(liczba.Factorial(3));
        }
    }
}
