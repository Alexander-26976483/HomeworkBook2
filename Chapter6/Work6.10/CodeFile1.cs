using System;
using System.Threading;

class ThreadDemo
{
    static void Main()
    {
        Console.WriteLine("Контрольное значение: {0}", (double)2/3);

        double product = 1;

        Thread calc = new Thread(() =>
        {
            int n = 2;

            double multiplier = (double)7 / 9;

            do
            {
                product *= multiplier;

                n++;

                multiplier = (Math.Pow(n, 3) - 1) / (Math.Pow(n, 3) + 1);

                Thread.Sleep(1);
            }
            while (true);

        });

        calc.Start();

        Thread.Sleep(1000);

        calc.Abort();

        Console.WriteLine("Вычесленное значение: {0}", product);

        Console.ReadKey();
    }
}