namespace ClimbingStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int result = climbStairs(n);
            Console.WriteLine(result);
        }

        static int climbStairs(int n)
        {
            if (n < 3)
                return n;

            int n_2 = 2;
            int n_1 = 1;
            int res = 0;

            int i = 3;
            while(i++ <= n)
            {
                res = n_2 + n_1;
                n_1 = n_2;
                n_2 = res;
            }

            return res;
        }
    }
}