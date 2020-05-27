namespace Code
{
    public class MathFunc
    {
        public static int Power(int a, int b)
        {
            int s = 1;
            for (int i = 0; i < b; i++)
                s *= a;
            return s;
        }

        public static int Gcd(int a, int b)
        {
            while (b > 0) 
            {
                a %= b;
                int t = a;
                a = b;
                b = t;
            }
            return a;
        }

        public static int Lcm(int a, int b)
        {
            return a / Gcd(a, b) * b;
        }
    }
}