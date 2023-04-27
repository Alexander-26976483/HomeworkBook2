using System;

class Alpha<T>
{
    private T field;

    public T GetSetField
    {
        get
        {
            return field;
        }
        set
        {
            field = value;
        }
    }
}

class GenericDemo
{
    static void Main()
    {
        int a = 1215;

        char b = 'Ы';

        string c = "текст";

        Alpha<int> alpha1 = new Alpha<int>();
        alpha1.GetSetField = a;

        Alpha<char> alpha2 = new Alpha<char>();
        alpha2.GetSetField = b;

        Alpha<string> alpha3 = new Alpha<string>();
        alpha3.GetSetField = c;

        Console.WriteLine(alpha1.GetSetField);
        Console.WriteLine(alpha2.GetSetField);
        Console.WriteLine(alpha3.GetSetField);

        Console.ReadKey();
    }
}