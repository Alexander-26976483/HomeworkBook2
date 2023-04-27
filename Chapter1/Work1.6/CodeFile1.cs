using System;

interface INum
{
    int this[char n] { get; }
}

interface ISymb
{
    char this[int n] { get; }
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

    public char this[int n] => symb[n % symb.Length];

    public int this[char s]
    {
        get
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

        for (int k = 0; k < size; k++)
        {
            Console.Write("|" + A[k]);
        }
        Console.WriteLine("|");

        Console.WriteLine(R2['B']);

        Console.WriteLine(R1[3]);

        Console.ReadKey();
    }
}