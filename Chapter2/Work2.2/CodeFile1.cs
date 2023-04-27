using System;

delegate void MyDelegate(char s);

class Alpha
{
    private char symb;

    public void SetSymb(char s)
    {
        symb = s;
    }

    public char GetSymb => symb;
}

class DelegateDemo
{
    static void Main()
    {
        Alpha[] objarr = new Alpha[5];

        for (int k = 0; k < objarr.Length; k++)
        {
            objarr[k] = new Alpha();
        }

        MyDelegate meth = objarr[0].SetSymb;

        for (int k = 1; k < objarr.Length; k++)
        {
            meth += objarr[k].SetSymb;
        }

        meth('B');

        Console.WriteLine("Проверка результата вызова экземпляра делегата:");

        for (int k = 0; k < objarr.Length; k++)
        {
            Console.WriteLine($"'{objarr[k].GetSymb}'");
        }

        Console.ReadKey();
    }
}