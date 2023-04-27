using System;

delegate void Message(string t);

class AlphaEvent
{
    private string txt;

    public AlphaEvent(string t)
    {
        txt = t;
    }

    public event Message MyEvent;

    public void RaiseMyEvent()
    {
        MyEvent(txt);
    }
}

class Bravo
{
    public void ShowArg(string t)
    {
        Console.WriteLine(t);
    }
}

class EventDemo
{
    static void Main()
    {
        AlphaEvent A1 = new AlphaEvent("Объект \"A1\" класса AlphaEvent");
        
        AlphaEvent A2 = new AlphaEvent("Объект \"A2\" класса AlphaEvent");

        Bravo B = new Bravo();

        A1.MyEvent += B.ShowArg;

        A2.MyEvent += B.ShowArg;

        A1.RaiseMyEvent();
        
        A2.RaiseMyEvent();

        Console.ReadKey();
    }
}