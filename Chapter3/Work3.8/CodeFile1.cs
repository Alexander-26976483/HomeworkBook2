using System;

struct Alpha
{
    public string txt;

    public Alpha(string t)
    {
        txt = t;
    }

    public Bravo GetBravo(int k)
    {
        return new Bravo() { symb = txt[k] };
    }
}

struct Bravo
{
    public char symb;
}

class StructDemo
{
    static void Main()
    {
        Alpha alpha = new Alpha("Сделай сегодня сколько сможешь, завтра сможешь еще больше!");

        Bravo bravo = alpha.GetBravo(7);

        Console.WriteLine("\'{0}\'", bravo.symb);

        Console.ReadKey();
    }
}