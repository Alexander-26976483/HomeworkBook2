using System;

struct BravoStruct
{
    public char symb;

    public static BravoStruct[] CreateArrStructOfString(string t)
    {
        BravoStruct[] result = new BravoStruct[t.Length];

        for (int k = 0; k<t.Length; k++)
        {
            result[k].symb = t[k];
        }

        return result;
    }

    public static string CreateStringOfArrStruct(BravoStruct[] bravoStructs)
    {
        string text = "";

        for (int k = 0; k < bravoStructs.Length; k++)
        {
            text += bravoStructs[k].symb;
        }

        return text;
    }
}

class StructDemo
{
    static void Main()
    {
        string txt = "Сделай сегодня сколько сможешь, завтра сможешь еще больше!";

        BravoStruct[] bravos = BravoStruct.CreateArrStructOfString(txt);

        for (int k= 0; k<txt.Length; k++)
        {
            Console.Write(bravos[k].symb);
        }
        Console.WriteLine();

        Console.WriteLine(BravoStruct.CreateStringOfArrStruct(bravos));

        Console.ReadKey();
    }
}