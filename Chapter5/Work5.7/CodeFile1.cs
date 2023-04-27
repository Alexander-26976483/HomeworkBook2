using System;

class Alpha
{
    private int[] arr;

    public Alpha(int s)
    {
        arr = new int[s];

        for (int k = 0; k < arr.Length; k++)
        {
            arr[k] = k + 1;
        }
    }

    public int this[int k] => arr[k];
}

class UsingTryCatchDemo
{
    public static int GetSizeArray(Alpha alpha)
    {
        int size = 0;

        try
        {
            do
            {
                if (alpha[size].GetType() == size.GetType())
                {
                    size++;
                }
            }
            while (true);
        }
        catch (IndexOutOfRangeException)
        {
            return size;
        }
    }

    static void Main()
    {
        Console.Write("Задать размер массива: ");

        try
        {
            int sizeManually = Int32.Parse(Console.ReadLine());

            Alpha alpha = new Alpha(sizeManually);

            Console.WriteLine("Размер закрытого массива: {0}", GetSizeArray(alpha));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }
}