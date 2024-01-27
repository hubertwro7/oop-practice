namespace zad1
{
    internal class Licz
    {
        private int wartosc;
        public Licz(int wartosc)
        {
            this.wartosc = wartosc;
        }
        public void Dodaj(int liczba)
        {
            wartosc += liczba;
        }
        public void Odejmij(int liczba)
        {
            wartosc -= liczba;
        }
        public void WypiszWartosc()
        {
            Console.WriteLine($"Wartosc: {wartosc}");
        }
    }
}
