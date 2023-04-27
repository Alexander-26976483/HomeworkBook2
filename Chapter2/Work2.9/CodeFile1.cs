using System;

delegate double QuadraticTrinomial(double x);

class DelegateDemo
{
    static QuadraticTrinomial Method(double a, double b, double c)
    {
        return (double x) =>
        {
            double result = a * x * x + b * x + c; ;

            return result;
        };
    }

    static void Main()
    {
        double a = 2.2, b = 5.5, c = 3.1, x = 3;

        Console.WriteLine(Method(a, b, c)(x));

        Console.ReadKey();
    }
}