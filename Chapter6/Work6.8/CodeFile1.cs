using System;
using System.Threading;

class ThreadDemo
{
    static void Main()
    {
        char[,] symbs = new char[4, 10];

        Random rnd = new Random();

        Thread[] threads = new Thread[symbs.GetLength(1)];

        for (int k = 0; k < threads.Length; k++)
        {
            int index = k + 1;
            int column = k;

            threads[k] = new Thread(() =>
            {
                for(int row = 0; row < symbs.GetLength(0); row++)
                {
                    symbs[row, column] = (char)rnd.Next(65, 91);
                    Console.WriteLine($"Поток {index}. Добавление в строку {row}, столбец {column} символа \'{symbs[row, column]}\'");
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

        for (int i = 0; i < symbs.GetLength(0); i++)
        {
            for (int j = 0; j < symbs.GetLength(1); j++)
            {
                Console.Write($"\'{symbs[i, j]}\'\t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}