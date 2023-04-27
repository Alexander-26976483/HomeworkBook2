using System;

class UsingTryCatchDemo
{
    static void CheckEvenOdd(int number)
    {
        if (number % 2 == 0)
        {
            throw new ArithmeticException("Число четное!");
        }

        throw new OverflowException("Число нечетное!");
    }

    static void Main()
    {
        int number;

        try
        {
            do
            {
                Console.Write("Введите целое число: ");

                number = Int32.Parse(Console.ReadLine());

                try
                {
                    CheckEvenOdd(number);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }
}