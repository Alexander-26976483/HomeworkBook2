using System;

struct AlphaStruct
{
    public int num;

    public string text;

    public char symb;

    public AlphaStruct(int n, string t, char s)
    {
        num = n;

        text = t;

        symb = s;
    }

    public AlphaStruct(int n, string t)
    {
        num = n;

        text = t;

        symb = 'A';
    }

    public AlphaStruct(string t)
    {
        text = t;

        num = 99;

        symb = 'B';
    }

    public void Show()
    {
        Console.WriteLine($"Текстовое поле: \"{text}\"\nСимвольное поле: \'{symb}\'\nЦелочисленное поле:  {num}\n");
    }
}

class StructDemo
{
    static void Main()
    {
        AlphaStruct A;

        AlphaStruct B = new AlphaStruct(10, "Три аргумента", 'v');

        AlphaStruct C = new AlphaStruct(20, "Два аргумента");

        AlphaStruct D = new AlphaStruct("Один аргумент");

        A.num = 12;

        A.symb = 'w';

        A.text = "Без аргументов";

        A.Show();

        B.Show();

        C.Show();

        D.Show();

        Console.ReadKey();
    }
}