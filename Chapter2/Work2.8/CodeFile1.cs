using System;

delegate int Operation(int n);

class DelegateDemo
{
    static Operation Method(Operation F, Operation H)
    {
        return (int n) =>
        {
            return F(H(n));
        };
    }

    static int Add(int n) => n + n;

    static int Square(int n) => n * n;

    static void Main()
    {
        Console.WriteLine(Method(Add, Square)(7));

        Console.ReadKey();
    }
}