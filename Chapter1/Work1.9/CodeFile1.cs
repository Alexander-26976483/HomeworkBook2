using System;

interface IMyInterface
{
    void Method(string t);

    char this[int k] { get; set; }
}

abstract class Alpha
{
    protected char[] symb;

    public Alpha(string t)
    {
        symb = t.ToCharArray();
    }

    public char GetSymbol(int k)
    {
        return symb[k];
    }

    public abstract void Method(int n, char s);
}

class Bravo : Alpha, IMyInterface
{
    public Bravo(string t) : base(t)
    {

    }

    public override void Method(int n, char s)
    {
        symb[n] = s;
    }

    public void Method(string t)
    {
        symb = t.ToCharArray();
    }

    public char this[int k]
    {
        get => symb[k];
        set => symb[k] = value;
    }

    public void Show()
    {
        for (int k = 0; k < symb.Length; k++)
        {
            Console.Write(this[k]);
        }
        Console.WriteLine();
    }
}

class InterfaceDemo
{
    static void Main()
    {
        string txt = "Определенность цели - отправная точка всех достижений.";

        Bravo obj = new Bravo(txt);

        Alpha A = obj;

        IMyInterface R = obj;

        obj.Show();

        Console.WriteLine(obj.GetSymbol(3));

        A.Method(5, 'W');

        obj.Show();

        R[7] = 'G';

        obj.Show();

        txt = "Мы становимся тем, о чем мы думаем.";

        obj.Method(txt);

        obj.Show();

        Console.ReadKey();
    }
}