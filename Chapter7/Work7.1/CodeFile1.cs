using System;

class GenericDemo
{
    static void Exchange<T>(T arg1, T arg2)
    {
        Console.WriteLine($"Аргумент 1: {arg1}; аргумент 2: {arg2}");
        
        T temp = arg1;

        arg1 = arg2;

        arg2 = temp;

        Console.WriteLine($"После обмена: аргумент 1: {arg1}; аргумент 2: {arg2}");
    }

    static void Main()
    {
        int variable1 = 10, variable2 = 20;

        string variable3 = "Текст 1", variable4 = "Текст 2";

        char variable5 = 'A', variable6 = 'B';

        Exchange(variable1, variable2);

        Exchange(variable3, variable4);

        Exchange(variable5, variable6);

        Console.ReadKey();
    }
}