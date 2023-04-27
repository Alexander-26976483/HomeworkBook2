using System;

interface MyInterface
{
    int GetNum();
}

class Alpha : MyInterface
{
    private int num;

    public Alpha(int n)
    {
        num = n;
    }

    // Метод возвращает результатом сумму нечетных чисел:
    public int GetNum()
    {
        int sum = 0;

        for (int k = 0; k < num; k++)
        {
            sum += 2 * k + 1;
        }

        return sum;
    }
}

class Bravo : MyInterface
{
    private int num;

    public Bravo(int n)
    {
        num = n;
    }

    // Метод возвращает результатом сумму четных чисел:
    public int GetNum()
    {
        int sum = 0;

        for (int k = 0; k < num; k++)
        {
            sum += 2 * k;
        }

        return sum;
    }
}

class InterfaceDemo
{
    static void Main()
    {
        Alpha A = new Alpha(10);

        Bravo B = new Bravo(6);

        Console.WriteLine("Сумма нечетных чисел: " + A.GetNum());
       
        Console.WriteLine("Сумма четных чисел: " + B.GetNum());

        MyInterface Rb = new Bravo(5);

        Console.WriteLine("Сумма четных чисел: " + Rb.GetNum());
        
        MyInterface Ra = new Alpha(11);

        Console.WriteLine("Сумма четных чисел: " + Ra.GetNum());

        Console.ReadKey();
    }
}