using System;

delegate int MyDelegate(int n);

class Alpha
{
    public MyDelegate this[uint k]
    {
        get
        {
            return delegate (int n)
            {
                return (int)Math.Pow(n, k);
            };
        }
    }
}

class DelegateDemo
{
    static void Main()
    {
        Alpha obj = new Alpha();

        int value = 2;
        for (uint power = 0; power <= 10; power++)
        {
            Console.WriteLine($"{value}^{power} = {obj[power](value)}");
        }

        Console.ReadKey();
    }
}