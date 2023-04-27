using System;

delegate int DFib();

class DelegateDemo
{
    static DFib Calculate(int n)
    {
        int count = 0;

        int a = 1, b = 1, c = 0;

        return () =>
        {
            count += n;

            if (count == 1 || count == 2)
            {
                return 1;
            }
            else
            {
                c = a + b;
                a = b;
                b = c;
                return c;
            }
        };
    }

    static void Main()
    {
        DFib next = Calculate(1);

        for(int i = 1; i <= 15; i++)
        {
            Console.Write(next() + " ");
        }
        
        Console.WriteLine();

        Console.ReadKey();
    }
}