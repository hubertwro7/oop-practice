namespace zad4
{
    internal class Data
    {
        private int year;
        private int month;
        private int day;
        private readonly static Dictionary<int, int> months = new Dictionary<int, int>
        {
            { 1, 31 },
            { 2, 29 },
            { 3, 31 },
            { 4, 30 },
            { 5, 31 },
            { 6, 30 },
            { 7, 31 },
            { 8, 31 },
            { 9, 30 },
            { 10, 31 },
            { 11, 30 },
            { 12, 31 },
        };

        public Data(int year, int month, int day)
        {
            if(year < 1)
            {
                throw new Exception("Podano zły rok");
            }
            if (month < 1 || month > 12)
            {
                throw new Exception("Podano zły miesiąc");
            }
            if (day < 1 || day > months[month])
            {
                throw new Exception("Podano zły dzień");
            }
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public void WypiszDate() 
        {
            Console.WriteLine($"{year}-{month.ToString("00")}-{day.ToString("00")}");
        }

        public void PrzesunDoPrzodu()
        {
            var newDay = day + 7;
            if(newDay > months[month])
            {
                if(month != 12)
                {
                    month++;
                    day = newDay - months[month];
                }
                else
                {
                    year++;
                    day = newDay - months[month];
                    month = 1;
                }
                return;
            }
            day = newDay;
        }
        public void PrzesunDoTylu()
        {
            var newDay = day - 7;
            if (newDay < 1)
            {
                if (month != 1)
                {
                    month--;
                    day = months[month] - Math.Abs(newDay);
                }
                else
                {
                    year--;
                    day = months[month] - Math.Abs(newDay);
                    month = 12;
                }
                return;
            }
            day = newDay;
        }
    }
}
