using System;
using System.Threading;

class Alpha
{
    public int[] arrayOfNumb;

    public char[] arrayOfSymb;

    public Alpha(int n, int s)
    {
        arrayOfNumb = new int[n];
        arrayOfSymb = new char[s];
    }
}

class ThreadDemo
{
    static void Main()
    {
        Alpha alpha = new Alpha(10, 15);

        Thread thread1 = new Thread(() =>
        {
            Random rnd = new Random();

            for (int k = 0; k < alpha.arrayOfNumb.Length; k++)
            {
                alpha.arrayOfNumb[k] = rnd.Next(0, 101);
                Console.WriteLine($"В элемент массива с индексом {k} добавлено значение {alpha.arrayOfNumb[k]}");
                Thread.Sleep(100);
            }
        });

        Thread thread2 = new Thread(() =>
        {
            Random rnd = new Random();

            for (int k = 0; k < alpha.arrayOfSymb.Length; k++)
            {
                alpha.arrayOfSymb[k] = (char)rnd.Next(60, 101);
                Console.WriteLine($"В элемент массива с индексом {k} добавлено значение \'{alpha.arrayOfSymb[k]}\'");
                Thread.Sleep(100);
            }
        });

        thread1.Start();
        thread2.Start();

        Console.ReadKey();
    }
}