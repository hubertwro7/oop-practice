namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data1 = new Data(2023, 10, 12);
            var newData = data1.PrzesunDoPrzodu();
            var newData1 = data1.PrzesunDoTylu();
            newData.WypiszDate();
            newData1.WypiszDate();
        }
    }
}
