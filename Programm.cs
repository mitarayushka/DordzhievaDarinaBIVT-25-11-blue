namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            if (a != 0 && b != 0)
            {
                if ((a > 0 && b > 0) || (a < 0 && b > 0))
                    ans = true;
            }


            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            double frac = Math.Abs(d - Math.Truncate(d));
            if (frac > 0.0001)
                ans = true;

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            bool ans = false;
            if (b != 0 && a % b == 0)
                ans = true;
            return ans;

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            double absD = Math.Abs(d);
            double absF = Math.Abs(f);
            double absG = Math.Abs(g);

            if (absD >= absF && absD >= absG)
            {
                answer = d;
            }
            else if (absF >= absD && absF >= absG)
            {
                answer = f;
            }
            else
            {
                answer = g;
            }

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            if (x <= -1)
            {
                ans = 0;
            }
            else if (x > -1 && x <= 0)
            {
                ans = x + 1;
            }
            else if (x > 0)
            {
                ans = 1;
            }

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            
            double r = Math.Sqrt(circleS / 3.14); 
            double a = Math.Sqrt(squareS);       
            double d = 2 * r;         

            if (d <= a)
            {
                ans = true; 
            }
            else
            {
                ans = false; 
            }

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

          double absD = d < 0 ? -d : d;
            double absF = f < 0 ? -f : f;


            if (absD < absF)
            {

                if (d > 0)
                    ans = -1;
            }
            else
            {
                if (f > 0)
                    ans = 1;
            }

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

              int first = a / 2;
            int second = b / 2;
            int third = c / 2;
            
            for (int gold = 1; gold <= 10000; gold++) 
            {
                if (first >= gold && second >= gold && (third >= gold || third + 1 == gold))
                {
                    answer = true;
                    break;
                }
            }

            return answer;
        }
    }
}
