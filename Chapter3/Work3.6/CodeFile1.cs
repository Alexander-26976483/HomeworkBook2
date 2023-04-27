using System;

struct AlphaStruct
{
    public int num1;

    public int num2;

    public AlphaStruct(int n, int m)
    {
        num1 = n;

        num2 = m;
    }

    public static AlphaStruct operator +(AlphaStruct A, AlphaStruct B)
    {
        return new AlphaStruct() { num1 = A.num1 + B.num1, num2 = A.num2 + B.num2 };
    }

    public static AlphaStruct operator -(AlphaStruct A, AlphaStruct B)
    {
        return new AlphaStruct() { num1 = A.num1 - B.num1, num2 = A.num2 - B.num2 };
    }

    public static AlphaStruct operator *(AlphaStruct A, AlphaStruct B)
    {
        return new AlphaStruct() { num1 = A.num1 * B.num1, num2 = A.num2 * B.num2 };
    }

    // Возвращает наибольшее из значений полей экземпляра структуры:
    public static int operator !(AlphaStruct A)
    {
        if (A.num1 > A.num2)
        {
            return A.num1;
        }
        else
        {
            return A.num2;
        }
    }

    // Возвращает наименьшее из значений полей экземпляра структуры:
    public static int operator ~(AlphaStruct A)
    {
        if (A.num1 < A.num2)
        {
            return A.num1;
        }
        else
        {
            return A.num2;
        }
    }
}

class StructDemo
{
    static void Main()
    {
        AlphaStruct A = new AlphaStruct(13, 75);
        
        AlphaStruct B = new AlphaStruct(97, 12);

        AlphaStruct C = A + B;

        Console.WriteLine("A + B: поле num1 = {0}, поле num2 = {1}", C.num1, C.num2);

        C = A - B;

        Console.WriteLine("A - B: поле num1 = {0}, поле num2 = {1}", C.num1, C.num2);

        C = A * B;
        
        Console.WriteLine("A * B: поле num1 = {0}, поле num2 = {1}", C.num1, C.num2);

        Console.WriteLine("!A: {0}", !A);
        Console.WriteLine("!B: {0}", !B);

        Console.WriteLine("~A: {0}", ~A);
        Console.WriteLine("~B: {0}", ~B);

        Console.ReadKey();
    }
}