using System;

class GenericDemo
{
    static void Show<T>(T arg)
    {
        if (arg is int)
        {
            Console.WriteLine("Аргументом является целочисленное значение.");
        }
        else if (arg is char)
        {
            Console.WriteLine("Аргументом является символьное значение.");
        }
        else
        {
            Console.WriteLine("Аргументом является не целочисленное и не символьное значение.");
        }
    }
    
    static void Main()
    {
        Show(56);

        Show('A');

        Show("Текст");

        Show(55.6);

        object o = null;

        Show(o);

        Console.ReadKey();
    }
}