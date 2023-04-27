using System;

class Bravo<T>
{
    private T[] arr;

    public Bravo(int size)
    {
        arr = new T[size];
    }

    public T this[int k]
    {
        get
        {
            return arr[k];
        }
        set
        {
            arr[k] = value;
        }
    }
}

class GenericDemo
{
    static void Show<T>(Bravo<T> bravo, int size)
    {
        for (int k = 0; k < size; k++)
        {
            Console.Write("|" + bravo[k]);
        }
        Console.WriteLine("|");
    }

    static void Main()
    {
        int startNum = 1;

        int size1 = 10, size2 = 26;

        char startSymb = 'A';

        Bravo<int> bravo1 = new Bravo<int>(size1);

        for (int k = 0; k < size1; k++)
        {
            bravo1[k] = startNum;
            startNum++;
        }

        Show(bravo1, size1);

        Bravo<char> bravo2 = new Bravo<char>(size2);

        for (int k = 0; k < size2; k++)
        {
            bravo2[k] = startSymb;
            startSymb++;
        }

        Show(bravo2, size2);

        Console.ReadKey();
    }
}