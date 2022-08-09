using System.Collections;

namespace Day6_assign
{
    class Coupon_number
    {
        public void CouponNumber()
        {
            Console.WriteLine("Enter a number to which coupon to be generated");
            int n1=Convert.ToInt32(Console.ReadLine());
            Random r=new Random();
            //var Array1 = new ArrayList();
            int[] coupons=new int[n1];
            int i = 0;
            int generate = 0;
            while (i <n1)
            {
                int randomnumber = r.Next(n1 + 1);
                generate++;
                if (coupons.Contains(randomnumber))
                {
                    continue;
                }
                else
                {
                    coupons[i]=randomnumber;
                    
                }
                
            }
            for (int j=0; j < n1; j++)
            {
                Console.Write(coupons[i]+" ");
            }
        }
    }
}