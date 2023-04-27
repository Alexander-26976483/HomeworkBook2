using System;

struct Alpha
{
    public int max;

    public int index;

    public static Alpha GetAlpha(int[] arr)
    {
        int _max = 0;

        int _index = 0;

        for (int k = 0; k < arr.Length; k++)
        {
            if (arr[k] > _max)
            {
                _max = arr[k];
                _index = k;
            }
        }

        return new Alpha() { max = _max, index = _index };
    }
}

class StructDemo
{
    static void Main()
    {
        Random rnd = new Random();

        int[] arr = new int[10];

        for (int k = 0; k < arr.Length; k++)
        {
            arr[k] = rnd.Next(0, 101);
        }

        Alpha alpha = Alpha.GetAlpha(arr);

        Console.WriteLine("Поля структуры: \nmax = {0} \nindex = {1}", alpha.max, alpha.index);

        Console.ReadKey();
    }
}