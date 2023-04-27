using System;

struct AlphaStruct
{
    private char[] symb;

    public AlphaStruct(string t)
    {
        symb = t.ToCharArray();
    }

    public AlphaStruct(int size, char symbol)
    {
        symb = new char[size];

        for (int k = 0; k < size; k++)
        {
            symb[k] = symbol;
        }
    }

    public char this[int k]
    {
        get
        {
            return symb[k];
        }
        set
        {
            symb[k] = value;
        }
    }

    public void MyReverse()
    {
        char[] arr_temp = new char[symb.Length];

        for (int k = 0; k < arr_temp.Length; k++)
        {
            arr_temp[k] = symb[symb.Length - 1 - k];
        }

        symb = arr_temp;
    }

    public void Show()
    {
        for(int k= 0; k < symb.Length; k++)
        {
            Console.Write("|" + this[k]);
        }
        Console.WriteLine("|");
    }

    public override string ToString()
    {
        string result = "";

        for(int k = 0; k < symb.Length; k++)
        {
            result += symb[k] + "[" + (int)symb[k] + "]";
        }
        
        return result;
    }
}

class StructDemo
{
    static void Main()
    {
        AlphaStruct alphaStruct1 = new AlphaStruct("Строка для первого объекта.");

        char[] array = { 'С', 'т', 'р', 'о', 'к', 'а', ' ', '№', '2', '.' };
        
        AlphaStruct alphaStruct2 = new AlphaStruct(10, 'N');

        Console.WriteLine("Проверка массива первого объекта:");

        alphaStruct1.Show();

        Console.WriteLine("Проверка метода MyReverse:");

        alphaStruct1.MyReverse();
        alphaStruct1.Show();

        Console.WriteLine("Проверка массива второго объекта:");

        alphaStruct2.Show();

        Console.WriteLine("Проверка работы индексатора:");

        alphaStruct2[5] = 'G';
        alphaStruct2.Show();

        alphaStruct1.MyReverse();
        Console.WriteLine("Проверка переопределенного метода ToString:\n" + alphaStruct1+ "\n" + alphaStruct2);

        Console.ReadKey();
    }
}