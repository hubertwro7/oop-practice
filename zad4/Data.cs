namespace zad4
{
    internal class Data
    {
        private int year;
        private int month;
        private int day;
        private static Dictionary<int, int> months = new Dictionary<int, int>
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
            if(year > 0)
            {
                this.year = year;
            }
            if(month > 0 && month <= 12)
            {
                this.month = month;

            }
            if(day > 0 && day <= 31)
            {
                this.day = day;
            }
        }
        public void WypiszDate() 
        {
            Console.WriteLine($"{year}-{month}-{day}");
        }

        public Data PrzesunDoPrzodu()
        {
            var newDay = day + 7;
            if(newDay > months[month])
            {
                if(month != 12)
                {
                    month++;
                    day = newDay - month;
                }
                else
                {
                    year++;
                    day = newDay - month;
                    month = 1;
                }
            }
            day = newDay;
            return new Data(year, month, day);
        }
        public Data PrzesunDoTylu()
        {
            var newDay = day - 7;
            if (newDay > months[month])
            {
                if (month != 1)
                {
                    month--;
                    day = newDay - month;
                }
                else
                {
                    year--;
                    day = newDay - month;
                    month = 12;
                }
            }
            day = newDay;
            return new Data(year, month, day);
        }
    }
}
