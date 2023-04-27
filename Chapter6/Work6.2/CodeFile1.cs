using System;
using System.Threading;

class ThreadDemo
{
    static void ShowRedColor(int num)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Главный поток. Число: {0}", num);
        Console.ResetColor();
    }
    
    static void Main()
    {
        int num = 0;

        ShowRedColor(num);

        Thread checkOdd = new Thread(() =>
        {
            while (true)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine("Дочерний поток 1: число \"{0}\" в главном потоке нечетное", num);
                    Thread.Sleep(900);
                }
            }
        });

        Thread checkDivisibilityThree = new Thread(() =>
        {
            while (true)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine("Дочерний поток 2: число \"{0}\" в главном потоке делится на 3", num);
                    Thread.Sleep(900);
                }
            }
        });

        checkOdd.Start();

        checkDivisibilityThree.Start();

        Random rnd = new Random();

        for (int k = 0; k < 100; k++)
        {
            num = rnd.Next(0, 101);
            ShowRedColor(num);
            Thread.Sleep(1000);
        }

        Console.ReadKey();
    }
}