
public class Program
{ 
    public static int Main()
    {
        double a, b, c, d, e, f;
        List<double> refund = new List<double>();

        Console.WriteLine("Введите 6 чисел через пробел");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());
        d = Convert.ToDouble(Console.ReadLine());
        e = Convert.ToDouble(Console.ReadLine());
        f = Convert.ToDouble(Console.ReadLine());
        MainLogic(a, b, c, d, e, f, refund);

        foreach (var item in refund)
        {
            Console.WriteLine(item + " ");
        }

        return 0;
    }
    public static List<double> MainLogic(double a, double b, double c, double d, double e, double f, List<double> refund)
    {
        if ((a == 0) && (b == 0) && (c == 0) && (d == 0) && (e == 0) && (f == 0))
        {
            refund.Add(5);

                return refund;
        }
        else if ((a * d - c * b != 0) && ((e * d - b * f != 0) || (a * f - c * e != 0)))
        {
            double y = (a * f - c * e) / (a * d - c * b);
            double x = (d * e - b * f) / (d * a - b * c);

            refund.Add(2);
            refund.Add(x);
            refund.Add(y);

            return refund; 
        }
        else if (((a * d - c * b == 0) && ((e * d - b * f != 0) || 
                (a * f - c * e != 0))) ||
                (a == 0 && c == 0 && e / b != f / d) ||
                (b == 0 && d == 0 && e / a != f / c) ||
                (a == 0 && b == 0 && c == 0 && d == 0 && (e / f > 0)))
        {
            if (((a == 0 && b == 0 && e == 0 && d != 0 && c == 0) ||
               (c == 0 && d == 0 && f == 0 && b != 0 && a == 0)))
            {
                double y = 0;
                if (b == 0)
                    y = f / d;
                else if (d == 0)
                    y = e / b;
                else if (e == 0 || f == 0)
                    y = 0;

                refund.Add(3);
                refund.Add(y);

                return refund;
            }
            else if (((a == 0 && b == 0 && e == 0 && c != 0 && d == 0) ||
                    (c == 0 && d == 0 && f == 0 && a != 0 && b == 0)))
            {
                double x = 0;
                if (a == 0)
                    x = f / c;
                else if (c == 0)
                    x = e / a;
                else if (e == 0 || f == 0)
                    x = 0;

                refund.Add(3);
                refund.Add(x);

                return refund;
            }
            else
            {
                Console.WriteLine(0);
                refund.Add(0);

                return refund;
            }
        }
        else if (a == 0 && c == 0)
        {
            double y = 0;
            if (e == 0)
                y = f / d;
            else if (f == 0)
                y = e / b;
            else
                y = e / b;

            refund.Add(4);
            refund.Add(y);

            return refund;
        }
        else if (b == 0 && d == 0)
        {
            double x;
            if (e == 0)
                x = f / c;
            else if (f == 0)
                x = e / a;
            else
                x = e / a;

            refund.Add(3);
            refund.Add(x);

            return refund; 
        }
        else if (b == 0 && e == 0)
        {
            double k, n;
            k = -c / d;
            n = f / d;

            refund.Add(3);
            refund.Add(k);
            refund.Add(n);

            return refund;
        }
        else if (d == 0 && f == 0)
        {
            double k, n;
            k = -a / b;
            n = e / b;

            refund.Add(1);
            refund.Add(k);
            refund.Add(n);

            return refund;
        }
        else if (a == 0 && e == 0)
        {
            double k, n;
            k = -d / c;
            n = f / c;

            refund.Add(1);
            refund.Add(k);
            refund.Add(n);

            return refund;
        }
        else if (c == 0 && f == 0)
        {
            double k, n;
            k = -b / a;
            n = e / a;

            refund.Add(1);
            refund.Add(k);
            refund.Add(n);

            return refund;
        }
        else if ((a / b == c / d))
        {
            double k, n;
            k = -c / d;
            n = f / d;

            refund.Add(1);
            refund.Add(k);
            refund.Add(n);

            return refund;
        }
        else
        {
            Console.WriteLine("Are you kidding me?");
            refund.Add(-999);

            return refund;
        }
    }
}