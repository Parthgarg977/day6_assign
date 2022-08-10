namespace Day6_assign
{
    internal class Reverse_number
    {
        public void Rn()
        {
            int req_num = 0;
            Console.WriteLine("Enter number to reverse");
            int n1=Convert.ToInt32(Console.ReadLine());
            while (n1 != 0)
            {
                int n0 = n1 % 10;
                req_num = req_num * 10 + n0;
                n1 = n1 / 10;

            }

            Console.WriteLine("New number: " + req_num);


        }
    }
}