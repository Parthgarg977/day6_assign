using System;
namespace Day6_assign
{
    public class Fibbo_series

    {
        public void series()
        {
            int number1 = 0, number2 = 1, n3, number;
            Console.WriteLine("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 + " " + number2 + " "); //printing 0 and 1    
            for (int i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = number1 + number2;
                Console.WriteLine(n3 + " ");
                number1 = number2;
                number2 = n3;
            }
        }

}
}