using System;

struct AlphaStruct
{
    private int num1;

    private int num2;

    private int num3;

    public AlphaStruct(int n)
    {
        num1 = n;

        num2 = 100;

        num3 = 200;
    }

    public AlphaStruct(int n, int m)
    {
        num1 = n;

        num2 = m;

        num3 = 300;
    }

    public AlphaStruct(int n, int m, int p)
    {
        num1 = n;

        num2 = m;

        num3 = p;
    }

    public int MaxValue
    {
        get
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    return num1;
                }
                else
                {
                    return num3;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    return num2;
                }
                else
                {
                    return num3;
                }
            }
        }
        set
        {
            num1 = value;
        }
    }

    public int MinValue
    {
        get
        {
            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    return num1;
                }
                else
                {
                    return num3;
                }
            }
            else
            {
                if (num2 < num3)
                {
                    return num2;
                }
                else
                {
                    return num3;
                }
            }
        }
    }
}

class StructDemo
{
    static void Main()
    {
        AlphaStruct alphaStruct1 = new AlphaStruct(10);

        AlphaStruct alphaStruct2 = new AlphaStruct(5, 7);

        AlphaStruct alphaStruct3 = new AlphaStruct(10, 30, 9);

        Console.WriteLine(alphaStruct1.MaxValue);
        Console.WriteLine(alphaStruct1.MinValue);
        
        Console.WriteLine(alphaStruct2.MaxValue);
        Console.WriteLine(alphaStruct2.MinValue);

        Console.WriteLine(alphaStruct3.MaxValue);
        Console.WriteLine(alphaStruct3.MinValue);

        alphaStruct3.MaxValue = 999;
        Console.WriteLine(alphaStruct3.MaxValue);

        Console.ReadKey();
    }
}