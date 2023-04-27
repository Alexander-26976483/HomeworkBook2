using System;

class UsingTryCatchDemo
{
    static void Main()
    {
        Console.Write("Введите целое неотрицательное число: ");

        try
        {
            int size = Int32.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int k = 0; k < size; k++)
            {
                arr[k] = k + 1;
            }

            Console.WriteLine();

            for (int k = 0; k < size; k++)
            {
                Console.Write("|{0}", arr[k]);
            }
            Console.WriteLine("|");
        }

        catch (OverflowException)
        {
            Console.WriteLine("Ошибка №1: Неверный размер массива");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка №2: Неверный формат числа");
        }

        Console.ReadKey();
    }
}