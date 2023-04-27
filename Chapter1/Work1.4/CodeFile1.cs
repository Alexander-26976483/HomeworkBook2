using System;

interface MyInterface
{
    int GetNum(int n);
}

abstract class Alpha
{
    protected int num1;

    protected int num2;

    public Alpha(int n1, int n2)
    {
        num1 = n1;

        num2 = n2;
    }

    public abstract int this[int k] { get; }
}

class Bravo : Alpha, MyInterface
{
    public Bravo(int n1, int n2) : base(n1, n2)
    {

    }

    public override int this[int k]
    {
        get
        {
            if (k % 2 == 0)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }

    public int GetNum(int n)
    {
        return (num1 + num2) * n;
    }
}

class AbstractInterfaceDemo
{
    static void Main()
    {
        MyInterface R;

        Alpha A;
        
        Bravo B = new Bravo(10, 20);

        R = B;

        A = B;

        Console.WriteLine("Проверка значения поля при четном индексе: " + B[4]);

        Console.WriteLine("Проверка значения поля при нечетном индексе: " + A[5]);

        Console.WriteLine("Результат метода: " + R.GetNum(5));

        Console.ReadKey();
    }
}