using System;
using System.Threading;

class ThreadDemo
{
    static void Main()
    {
        char[] symbs = new char[50];

        Thread evenIndexes = new Thread(() =>
        {
            char smb = 'A';
            for(int k = 0; k < symbs.Length; k += 2)
            {
                symbs[k] = smb;
                smb++;
                Console.WriteLine("В элемент массива с индексом {0} добавлен символ \'{1}\'", k, smb);
                Thread.Sleep(100);
            }
        });

        Thread oddIndexes = new Thread(() =>
        {
            char smb = 'А';
            for (int k = 1; k < symbs.Length; k += 2)
            {
                symbs[k] = smb;
                smb++;
                Console.WriteLine("В элемент массива с индексом {0} добавлен символ \'{1}\'", k, smb);
                Thread.Sleep(100);
            }
        });

        evenIndexes.Start();
        oddIndexes.Start();

        if(evenIndexes.IsAlive & oddIndexes.IsAlive)
        {
            evenIndexes.Join();
            oddIndexes.Join();
        }

        Console.WriteLine("Заполненный массив: ");

        for(int k =0; k < symbs.Length; k++)
        {
            Console.Write("|\'{0}\'", symbs[k]);
        }
        Console.Write("|");

        Console.ReadKey();
    }
}