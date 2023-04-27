using System;

class UsingTryCatchDemo
{
    static int Solve(int A, int B)
    {
        string msg = "";

        if (A != 0)
        {
            if (B % A == 0)
            {
                return B / A;
            }
            else
            {
                msg = "На множестве целых чисел решений нет!";
            }
        }
        else if (B == 0)
        {
            msg = "Решение - любое число!";
        }
        else
        {
            msg = "Решений нет!";
        }

        throw new ArithmeticException(msg);
    }

    static void Main()
    {
        int A, B, x;

        Console.WriteLine("Решение уравнения A*x = B");

        try
        {
            Console.Write("A = ");

            A = Int32.Parse(Console.ReadLine());

            Console.Write("B = ");

            B = Int32.Parse(Console.ReadLine());

            x = Solve(A, B);

            Console.WriteLine("x = {0}", x);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }
}