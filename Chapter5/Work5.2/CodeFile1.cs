using System;

class UsingTryCatchDemo
{
    static void Main()
    {
        Console.Write("Введите первое целое число: ");

        try
        {
            int number1 = Int32.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число: ");

            int number2 = Int32.Parse(Console.ReadLine());

            int result;

            if (number1 > number2)
            {
                result = number1 % number2;
            }
            else
            {
                result = number2 % number1;
            }

            Console.WriteLine(result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка №1: Неверный формат числа");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка №2: Попытка деления на нуль");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка №3: Переполнение");
        }

        Console.ReadKey();
    }
}