namespace zad5
{
    internal class Liczba
    {
        private readonly char number;
        private int[] decimalPart = Array.Empty<int>();
        public Liczba(string wholeNumber)
        {
            if (wholeNumber.Contains('.'))
            {
                var substring = wholeNumber.Substring(wholeNumber.IndexOf('.')+1);
                decimalPart = new int[substring.Length];
                for(int i = 0; i < decimalPart.Length; i++)
                {
                    decimalPart[i] = Int32.Parse(substring[i].ToString());
                }
            }

            this.number = wholeNumber[0];
        }
        public string WholeNumber()
        {
            string decimalPartTemp = "";
            foreach (int value in decimalPart)
            {
                decimalPartTemp += value.ToString();
            }
            if (decimalPart.Length != 0)
            {
                
                return $"{number}.{decimalPartTemp}";
            }
            return $"{number}";
        }
        public void Display()
        {
            Console.WriteLine(WholeNumber());
        }

        public int Factorial(int value)
        {
            var factorial = 1;  
            for(int i = 1; i <= value; i++)
            {
                factorial *= i;
            }
            return factorial;   
        }
    }
}
 