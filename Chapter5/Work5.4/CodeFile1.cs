using System;

class UsingTryCatchDemo
{
    static void SolveQuadraticEquation(double A, double B, double C, out double x1, out double x2)
    {
        string msg = "";

        if (A != 0)
        {
            double discriminant = B * B - 4 * A * C;

            if (discriminant > 0)
            {
                x1 = ((-B) + Math.Sqrt(discriminant)) / (2 * A);

                x2 = ((-B) - Math.Sqrt(discriminant)) / (2 * A);
            }
            else if (discriminant == 0)
            {
                x1 = (-B) / (2 * A);

                x2 = x1;
            }
            else
            {
                msg = "Дискриминант меньше нуля. Корней нет!";

                throw new ArithmeticException(msg);
            }
        }
        else
        {
            msg = "\"A\" не должно быть равно нулю!";

            throw new ArithmeticException(msg);
        }
    }

    static void Main()
    {
        double A, B, C;

        Console.WriteLine("Решение уравнения A*x^2 + B*x + C = 0");

        try
        {
            Console.Write("A = ");

            A = Double.Parse(Console.ReadLine());

            Console.Write("B = ");

            B = Double.Parse(Console.ReadLine());

            Console.Write("C = ");

            C = Double.Parse(Console.ReadLine());

            SolveQuadraticEquation(A, B, C, out double x1, out double x2);

            Console.WriteLine("x1 = {0};\nx2 = {1}", x1, x2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }
}