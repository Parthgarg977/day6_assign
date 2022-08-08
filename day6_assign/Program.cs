namespace Day6_assign
{
    class Hello
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            Fibbo_series f1 = new Fibbo_series();
            f1.series();
            Perfect_number pn = new Perfect_number();
            pn.Pn1();
            Prime_number pm = new Prime_number();
            pm.pm();

        }
    }
}
