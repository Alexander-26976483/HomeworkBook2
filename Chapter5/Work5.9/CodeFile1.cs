using System;

class IndexTooLargeMyExceptionAlpha : Exception
{
    public IndexTooLargeMyExceptionAlpha(string msg) : base(msg)
    {

    }
}
class NegativeIndexException : ApplicationException
{
    public NegativeIndexException(string msg) : base(msg)
    {

    }
}
class Charlie
{
    private char[] symbArr;

    public Charlie(int size)
    {
        symbArr = new char[size];

        char startSymb = 'A';

        for (int k = 0; k < size; k++)
        {
            symbArr[k] = startSymb;
            startSymb++;
        }
    }

    public char this[int k]
    {
        get
        {
            try
            {
                CheckIndex(k);

                return symbArr[k];
            }
            catch
            {
                throw;
            }
        }
        set
        {
            try
            {
                CheckIndex(k);
                symbArr[k] = value;
            }
            catch
            {
                throw;
            }            
        }
    }

    private void CheckIndex(int k)
    {
        if (k > symbArr.Length - 1)
        {
            throw new IndexTooLargeMyExceptionAlpha("Ошибка: индекс слишком большой (выходит за верхнюю границу массива)");
        }
        else if (k < 0)
        {
            throw new NegativeIndexException("Ошибка: отрицательный индекс");
        }
    }
}
class UsingTryCatchDemo
{
    static void Main()
    {
        Charlie charlie = new Charlie(10);

        Console.Write("Введите целое число: ");

        try
        {
            int index = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Проверка индекса: ");

            Console.WriteLine("Индекс {0}, значение \'{1}\'", index, charlie[index]);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        Console.Write("Проверка присвоения значения:\nВведите целое число: ");

        try
        {
            int index2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Присваиваем значение \'{0}\' элементу с индексом {1}", charlie[index2] = 'X', index2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }
}