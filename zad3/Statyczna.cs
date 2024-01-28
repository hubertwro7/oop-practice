namespace zad3
{
    internal class Statyczna
    {
        int I;
        public static int Liczba;
        public static void Zwieksz()
        {
            Liczba++;
        }
        public Statyczna(int I)
        {
            this.I = I;
            Zwieksz();
        }
    }
}
