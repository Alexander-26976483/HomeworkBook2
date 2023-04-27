using System;

delegate int MyDelegate(char s, string t);

class DelegateDemo
{
    static void Main()
    {
        MyDelegate meth = new MyDelegate(NumberOfOccurrences);

        string text = "Определенность во всем – важная составляющая успеха.";

        char s = 'о';

        Console.WriteLine($"Количество вхождений символа '{s}' в тексте \"{text}\":\n{meth(s, text)}");

        meth = MyIndexOfAny;

        Console.WriteLine($"Индекс первого вхождения символа '{s}' в тексте \"{text}\":\n{meth(s, text)}");

        Console.ReadKey();
    }
    
    static int NumberOfOccurrences(char s, string t)
    {
        int counter = 0;

        for(int k = 0; k < t.Length; k++)
        {
            if(t[k] == s)
            {
                counter++;
            }
        }

        return counter;
    }

    static int MyIndexOfAny(char s, string t)
    {
        for (int k = 0; k < t.Length; k++)
        {
            if (t[k] == s)
            {
                return k;
            }
        }
        return -1;
    }
}