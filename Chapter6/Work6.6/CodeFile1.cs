using System;
using System.Threading;

class ThreadDemo
{
    static void Main()
    {
        int[] arr = new int[10];

        Random rnd = new Random();

        Console.WriteLine("Массив: ");

        for (int k = 0; k < arr.Length; k++)
        {
            arr[k] = rnd.Next(0, 101);
            Console.Write("|" + arr[k]);
        }
        Console.Write("|\n");

        Thread threadMax = new Thread(() =>
        {
            int max = arr[0];

            for (int k = 1; k < arr.Length; k++)
            {
                if (max < arr[k])
                {
                    max = arr[k];
                }
                Console.WriteLine("Выполняется поиск элемента с наибольшим значением...");
                Thread.Sleep(500);
            }
            Console.WriteLine($"Наибольшее значение в массиве: {max}");
        });

        Thread threadMin = new Thread(() =>
        {
            int min = arr[0];

            for (int k = 1; k < arr.Length; k++)
            {
                if (min > arr[k])
                {
                    min = arr[k];
                }
                Console.WriteLine("Выполняется поиск элемента с наименьшим значением...");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Наименьшее значение в массиве: {min}");
        });

        threadMax.Start();
        threadMin.Start();

        Console.ReadKey();
    }
}