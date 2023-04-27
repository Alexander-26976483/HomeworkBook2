using System;
using System.Threading;

class ThreadDemo
{
    static void Main()
    {
        Console.WriteLine("Контрольное значение: {0}", 3 * Math.Pow(Math.E, 2) - 1);

        double sum = 0;

        Thread calc = new Thread(() =>
        {
            int n = 1;

            double addition = 4;

            do
            {
                sum += addition;

                n++;

                addition = Math.Pow(2, n) * (n + 1);

                for (int k = 1; k <= n; k++)
                {
                    addition /= k;
                }

                Thread.Sleep(10);
            }
            while (true);
        });

        calc.Start();

        Thread.Sleep(1000);

        calc.Abort();

        Console.WriteLine("Вычесленное значение: {0}", sum);

        Console.ReadKey();
    }
}