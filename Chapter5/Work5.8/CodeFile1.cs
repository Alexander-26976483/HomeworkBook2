using System;

class MyException : Exception
{
    private char[] symbArr;

    public MyException(int size) : base()
    {
        symbArr = new char[size];

        char startSymb = 'A';

        for (int k = 0; k < size; k++)
        {
            symbArr[k] = startSymb;
            startSymb++;
        }
    }

    public override string Message
    {
        get
        {
            string msg = string.Empty;

            for (int k = 0; k < symbArr.Length; k++)
            {
                msg += "\'" + symbArr[k] + "\' ";
            }

            return msg;
        }
    }
}

class UsingTryCatchDemo
{
    static void Main()
    {
        try
        {
            throw new MyException(26);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }
}