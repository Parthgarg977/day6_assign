namespace Day6_assign
{
    internal class Prime_number
    {
        public void pm()
        {
            int mark = 0;
            Console.WriteLine("Enter number");
            int n1= Convert.ToInt32(Console.ReadLine());
            if (n1 == 1)
                Console.WriteLine("not a prime number");
            else if (n1 > 1)
            {
                for (int i = 2; i < n1; i++)
                {
                    if (n1 % i == 0)
                    {
                        Console.WriteLine("Not a prime number");
                        mark++;
                        break;
                    }
                    
                }
            }
            if (mark == 0) {
                Console.WriteLine("It is a prime number");
            }
        }
    }
}