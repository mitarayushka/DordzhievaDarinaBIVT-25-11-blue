namespace Lab1
{
    public class Blue
    {
        public bool Task1(int x, int y)
        {
            bool result = false;

            // code here

            result = x > 0 && y > 0 || x < 0 && y < 0;
            
            // end

            return result;
        }
        public bool Task2(double num)
        {
            bool result = false;

            // code here

            result = (int)num != num;
            // end

            return result;
        }
        public bool Task3(int x, int y)
        {
            bool result = false;

            // code here

            result = y != 0 ? x % y == 0: false;
            // end

            return result;
        }
        public double Task4(double a, double b, double c)
        {
            double result = 0;

            // code here

            if ((a < 0 ? -a : a) > (b < 0 ? -b : b) && (a < 0 ? -a : a) > (c < 0 ? -c : c))
            {
                result = a;
            }
            else if ((b < 0 ? -b : b) > (a < 0 ? -a : a) && (b < 0 ? -b : b) > (c < 0 ? -c : c))
            {
                result = b;
            }
            else
            {
                result = c;
            }
            // end

            return result;
        }
        public double Task5(double x)
        {
            double result = 0;

            // code here

            if (x <= -1)
            {
                result = 0.0;
            }
            else if (-1 < x && x <= 0)
            {
                result = x + 1;
            }
            else
            {
                result = 1;
            }
            // end

            return result;
        }
        public bool Task6(double s1, double s2)
        {
            bool result = false;

            // code here

            result = (s1/3.141592653589793238) <= s2 / 4;
            // end

            return result;
        }
        public double Task7(double x, double y)
        {
            int result = 0;

            // code here

            if ((x > 0 ? x : -x) < (y > 0 ? y : -y))
            {
                if (x > 0)
                {
                    result = -1;
                }
            }
            else
            {
                if (y > 0)
                {
                    result = 1;
                }
            }
            // end

            return result;
        }
        public bool Task8(int x, int y, int z)
        {
            bool result = false;

            // code here

            int h1 = x / 2;
            int h2 = y / 2;
            int h3 = z / 2;
            int sum = h1 + h2 + h3;
            bool c1 = (sum % 3) == 0 && (sum / 3) >= 1 && (sum / 3) <= z && (sum / 3) <= x && (sum / 3) <= y;
            bool c2 = (sum + 1) % 3 == 0 && (sum + 1) / 3 >= 1 && ((sum+1) / 3) <= z && (sum+1) / 3 <= x && (sum+1) / 3 <= y;
            result = c1 || c2;
            // end

            return result;
        }
    }
}
