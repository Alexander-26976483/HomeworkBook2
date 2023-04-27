using System;
using System.Threading;

class ThreadDemo
{
    static void Main()
    {
        int[] array = new int[10];

        Thread powerTwo = new Thread(() =>
        {
            int val = 2;
            for (int k = 0; k < array.Length; k++)
            {
                array[k] = (int)Math.Pow(val, k);
                Console.WriteLine($"В элемент массива с индексом {k} добавлено значение {val}^{k} = {array[k]}");
                Thread.Sleep(100);
            }
        });

        Thread powerThree = new Thread(() =>
        {
            int val = 3;
            for (int k = array.Length - 1; k > 0; k--)
            {
                array[k] = (int)Math.Pow(val, k);
                Console.WriteLine($"В элемент массива с индексом {k} добавлено значение {val}^{k} = {array[k]}");
                Thread.Sleep(100);
            }
        });

        powerTwo.Start();
        powerThree.Start();

        if (powerTwo.IsAlive & powerThree.IsAlive)
        {
            powerTwo.Join();
            powerThree.Join();
        }

        Console.WriteLine("Итоговый массив: ");

        for (int k = 0; k < array.Length; k++)
        {
            Console.Write("|{0}", array[k]);
        }
        Console.Write("|");

        Console.ReadKey();
    }
}