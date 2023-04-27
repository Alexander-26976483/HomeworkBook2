using System;
using System.Threading;

class ThreadDemo
{
    static void Main()
    {
        int[,] nums = new int[4, 10];

        Thread[] threads = new Thread[nums.GetLength(0)];

        for (int k = 0; k < threads.Length; k++)
        {
            int i = k;
            int baseNum = 2 + k;

            threads[k] = new Thread(() =>
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = (int)Math.Pow(baseNum, j);
                    Console.WriteLine($"Поток {i}. Добавление в строку {i}, столбец {j}: {baseNum}^{j} = {nums[i, j]}");
                    Thread.Sleep(100);
                }
            });

            threads[k].Start();
        }

        for (int k = 0; k < threads.Length; k++)
        {
            if (threads[k].IsAlive)
            {
                threads[k].Join();
            }
        }

        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                Console.Write("{0}\t", nums[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}