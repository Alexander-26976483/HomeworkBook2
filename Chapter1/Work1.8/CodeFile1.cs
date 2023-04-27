using System;

interface IText1
{
    string Text { get; }
}

interface IText2
{
    string Text { get; }
}

class MyClass : IText1, IText2
{
    private string txt = "Успех — это способность идти от поражения к поражению, не теряя оптимизма";

    public string Text
    {
        get
        {
            return txt;
        }
    }

    string IText1.Text
    {
        get
        {
            txt = "Янвая реализация свойства из интерфейса IText1";

            return txt;
        }
    }

    string IText2.Text
    {
        get
        {
            txt = "Янвая реализация свойства из интерфейса IText2";

            return txt;
        }
    }
}

class InterfaceDemo
{
    static void Main()
    {
        MyClass obj = new MyClass();

        Console.WriteLine(obj.Text);

        IText1 itext1;

        IText2 itext2;

        itext1 = obj;

        itext2 = obj;

        Console.WriteLine(itext1.Text);

        Console.WriteLine(itext2.Text);

        Console.ReadKey();
    }
}