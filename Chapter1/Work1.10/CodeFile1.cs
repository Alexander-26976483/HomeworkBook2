using System;

interface IAlpha
{
    int Property { get; set; }

    int this[int k] { get; set; }

    void Method();
}

interface IBravo
{
    int Property { get; set; }

    int this[int k] { get; set; }

    void Method();
}

abstract class Charlie
{
    public abstract int Property { get; set; }

    public abstract int this[int k] { get; set; }

    public abstract void Method();

}

class Gamma : Charlie, IAlpha, IBravo
{
    private int[] nums;

    public Gamma(int size)
    {
        nums = new int[size];

        for (int k = 0; k < size; k++)
        {
            nums[k] = k + 1;
        }
    }

    public override int this[int k] { get => nums[k]; set => nums[k] = value; }

    public override int Property { get => nums.Length; set => nums[0] = value; }

    public override void Method()
    {
        for (int k = 0; k < Property; k++)
        {
            Console.Write("|" + this[k]);
        }
        Console.WriteLine("|");
    }

    int IAlpha.this[int k] { get => nums[nums.Length - 1 - k]; set => nums[k] = 2 * value; }

    int IAlpha.Property { get => nums.Length; set => nums[nums.Length - 1] = value; }

    void IAlpha.Method()
    {
        for (int k = 0; k < Property; k++)
        {
            Console.Write("*" + this[k]);
        }
        Console.WriteLine("*");
    }

    int IBravo.this[int k] { get => nums[k] + 1; set => nums[k] = 2 * value - 1; }

    int IBravo.Property { get => nums.Length; set => nums[nums.Length / 2] = 2 * value - 1; }

    void IBravo.Method()
    {
        for (int k = 0; k < Property; k++)
        {
            Console.Write("#" + this[k]);
        }
        Console.WriteLine("#");
    }
}

class InterfaceDemo
{
    static void Main()
    {
        IAlpha ialpha;

        IBravo ibravo;

        Charlie charlie;

        Gamma obj = new Gamma(10);

        ialpha = obj;

        ibravo = obj;

        charlie = obj;

        ialpha.Method();

        ibravo.Method();

        charlie.Method();

        Console.WriteLine();

        for(int k = 0; k< ialpha.Property; k++)
        {
            ialpha[k] = k + 1;
        }
        ialpha.Property = 99;
        ialpha.Method();

        for (int k = 0; k < ibravo.Property; k++)
        {
            ibravo[k] = k + 1;
        }
        ibravo.Property = 100;
        ibravo.Method();

        for (int k = 0; k < ibravo.Property; k++)
        {
            Console.Write(ibravo[k] + " ");
        }
        Console.WriteLine();

        for (int k = 0; k < ialpha.Property; k++)
        {
            Console.Write(ialpha[k] + " ");
        }
        Console.WriteLine();

        Console.ReadKey();
    }
}