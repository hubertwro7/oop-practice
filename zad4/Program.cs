namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data1 = new Data(2023, 12, 30);
            data1.WypiszDate();
            data1.PrzesunDoPrzodu();
            data1.WypiszDate();
            data1.PrzesunDoTylu();
            data1.PrzesunDoTylu();
            data1.WypiszDate();
        }
    }
}
