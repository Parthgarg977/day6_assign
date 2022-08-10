namespace Day6_assign
{
    class Hello
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1 for fibbonacci series program \nEnter 2 for Perfect Number\nEnter 3 for Prime Number\nEnter 4 for Reverse Number\nEnter 5 for Coupon generation\nEnter 6 for stopwatch program");
            byte user_input = (byte)Convert.ToInt32(Console.ReadLine());
            switch (user_input)
            {
                case 1:
                    Fibbo_series f1 = new Fibbo_series();
                    f1.series();
                    break;
                case 2:
                    Perfect_number pn = new Perfect_number();
                    pn.Pn1();
                    break;
                case 3:
                    Prime_number pm = new Prime_number();
                    pm.pm();
                    break;
                case 4:
                    Reverse_number rn = new Reverse_number();
                    rn.Rn();
                    break;
                case 5:
                    Coupon_number cn = new Coupon_number();
                    cn.CouponNumber();
                    break;
                case 6:
                    StopWatch sw = new StopWatch();
                    sw.stopw();
                    break;
                    
                default:
                    Console.WriteLine("Please enter correct number");
                    break;

            }
        }
    }
}
