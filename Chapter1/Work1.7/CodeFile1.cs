using System;

interface INum
{
    int Num { get; set; }

    void Show();
}

interface IText
{
    string Text { get; set; }

    void Show();
}

class Alpha : INum, IText
{
    private int num;

    private string txt;

    public int Num
    {
        get => num;
        set => num = value;
    }

    public string Text
    {
        get => txt;
        set => txt = value;
    }

    public void Show()
    {
        Console.WriteLine("Значение свойства из интерфейса INum: " + Num);
        Console.WriteLine("Значение свойства из интерфейса IText: " + Text);
    }
}

class InterfaceDemo
{
    static void Main()
    {
        Alpha A = new Alpha();

        A.Num = 10;

        A.Text = "ABC";

        A.Show();

        INum inum;

        IText itext;

        inum = A;

        itext = A;

        inum.Show();

        itext.Show();

        Console.ReadKey();
    }
}