namespace zad2
{
    internal class Sumator
    {
        private int[] liczby;
        public Sumator(int[] liczby)
        {
            this.liczby = liczby;   
        }
        public int Suma()
        {
            int suma = 0;
            foreach(int i in liczby)
            {
                suma += i;
            }
            return suma;
        }
        public int SumaPodziel3()
        {
            int suma = 0;
            foreach(int i in liczby) 
            {
                if(i % 3 == 0)
                {
                    suma += i;
                }
            }
            return suma;
        }
        public int IleElementow()
        {
            int licznik = 0;
            foreach(int i in liczby)
            {
                licznik++;
            }
            return licznik;
        }
        public void WypiszLiczby()
        {
            Console.WriteLine("Liczby:");
            foreach (int i in liczby)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        public void WypiszWPrzedziale(int lowIndex, int highIndex) 
        {
            Console.WriteLine("Liczby w przedziale:");
            for(int i = lowIndex; i <= highIndex; i++)
            {
                if(i >= 0 && i < IleElementow())
                {
                    Console.Write(liczby[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
