using System;

abstract class Alpha
{
    protected string txt;

    public Alpha(string t)
    {
        txt = t;
    }

    public abstract int GetTxtLenght { get; }

    public abstract int this[int k] { get; }

    public abstract void SetTxt(string t);

    public abstract void ShowTxt();
}

class Bravo : Alpha
{
    public Bravo(string t) : base(t)
    {

    }

    public override int GetTxtLenght
    {
        get
        {
            return txt.Length;
        }
    }

    public override int this[int k]
    {
        get
        {
            return txt[k];
        }
    }

    public override void SetTxt(string t)
    {
        txt = t;
    }

    public override void ShowTxt()
    {
        Console.WriteLine("Значение поля: " + txt);
    }
}

class AbstractDemo
{
    static void Main()
    {
        Bravo B = new Bravo("Начинать всегда стоит с того, что сеет сомнения.");

        B.ShowTxt();

        Console.WriteLine("Количество символов в текстовом поле: " + B.GetTxtLenght);

        int k = 5;

        Console.WriteLine($"Код {k + 1}-го символа в текстовом поле: " + B[k]);

        B.SetTxt("Ваше время ограничено, не тратьте его, живя чужой жизнью.");

        B.ShowTxt();

        Console.ReadKey();
    }
}