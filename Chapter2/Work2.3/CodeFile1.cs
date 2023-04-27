using System;

delegate char MyDelegate();

class Bravo
{
    private string text;

    private MyDelegate meth;

    public MyDelegate GetMeth => meth;

    public Bravo(string t, bool check)
    {
        text = t;

        if (check)
        {
            meth = delegate ()
            {
                return text[0];
            };
        }
        else
        {
            meth = () => text[text.Length - 1];
        }
    }
}

class DelegateDemo
{
    static void Main()
    {
        string txt = "Я этого хочу. Значит, это будет.";

        Bravo obj1 = new Bravo(txt, true);

        Bravo obj2 = new Bravo(txt, false);

        Console.WriteLine(obj1.GetMeth());

        Console.WriteLine(obj2.GetMeth());

        Console.ReadKey();
    }
}