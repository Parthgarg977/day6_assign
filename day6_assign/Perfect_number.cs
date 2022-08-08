using System.Collections;

namespace Day6_assign
{
    internal class Perfect_number
    {
        public void Pn1()
        {
            Console.WriteLine("Enter number");
            int n1=Convert.ToInt32(Console.ReadLine());
            int j = 0;
            for (int i =1; i < n1; i++)
            {
                if (n1 % i == 0)
                {
                    j = j + i;
                }
            }
            if (j == n1)
            {
                Console.WriteLine("perfect number");
            }
            else
            {
                Console.WriteLine("not a perfect number ");
            }
           
        }
    }
}