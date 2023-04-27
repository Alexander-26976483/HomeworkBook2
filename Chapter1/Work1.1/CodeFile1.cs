using System;

abstract class Alpha
{
    protected int[] arr;

    public Alpha(int size)
    {
        arr = new int[size];
    }

    public int ArrLength => arr.Length;

    public abstract void Show();

    public abstract int this[int k] { get; set; }
}

class Bravo : Alpha
{
    public Bravo(int n) : base(n)
    {

    }

    public override void Show()
    {
        for(int k = 0; k < ArrLength; k++)
        {
            Console.Write("|" + this[k]);
        }
        Console.WriteLine("|");
    }

    public override int this[int k]
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

class AbstractDemo
{
    static void Main()
    {
        Bravo B = new Bravo(10);

        for(int k = 0; k < B.ArrLength; k++)
        {
            B[k] = k + 1;
        }

        B.Show();

        Console.ReadKey();
    }
}