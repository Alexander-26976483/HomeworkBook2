using System;

interface INum
{
    int GetNum(char s);
}

interface ISymb
{
    char GetSymb(int n);
}

class Alpha : ISymb, INum
{
    private char[] symb;

    public Alpha(int n, char s)
    {
        symb = new char[n];

        for (int k = 0; k < symb.Length; k++)
        {
            symb[k] = (char)(s + k);
        }
    }

    public int GetNum(char s)
    {
        for (int k = 0; k < symb.Length; k++)
        {
            if (symb[k] == s)
            {
                return k;
            }
        }
        return -1;
    }

    public char GetSymb(int n)
    {
        return symb[n % symb.Length];
    }
}

class InterfaceDemo
{
    static void Main()
    {
        int size = 10;

        ISymb R1;

        INum R2;

        Alpha A = new Alpha(size, 'A');

        R1 = A;

        R2 = A;

        for (int k = 0; k<size; k++)
        {
            Console.Write("|" + A.GetSymb(k));
        }
        Console.WriteLine("|");

        Console.WriteLine(R2.GetNum('B'));

        Console.WriteLine(R1.GetSymb(99));

        Console.ReadKey();
    }
}