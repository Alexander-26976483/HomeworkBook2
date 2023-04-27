using System;

class UsingTryCatchDemo
{
    static int CheckPresenceElement(int[] arr, int valElement)
    {
        for (int k = 0; k < arr.Length; k++)
        {
            if (arr[k] == valElement)
            {
                return k;
            }
        }

        throw new Exception("Значения \"" + valElement + "\" в массиве нет!");
    }

    static void Main()
    {
        int[] array = new int[] { 1, 2, 9, 4, 5, 6, 7, 8, 9, 10 };

        Console.Write("Массив: ");

        for (int k = 0; k < array.Length; k++)
        {
            Console.Write("|" + array[k]);
        }
        Console.WriteLine("|");

        try
        {
            Console.Write("Введите целое число: ");

            int valElement = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Проверка наличия значения \"{0}\" в массиве", valElement);

            Console.WriteLine("Индекс элемента: {0}", CheckPresenceElement(array, valElement));

            Console.WriteLine("\nПроверка методом IndexOf:");

            Console.WriteLine("Индекс элемента: {0}", Array.IndexOf(array, valElement));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }
}