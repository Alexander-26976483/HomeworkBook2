using System;

class Alpha
{
    private byte[] arr;

    public Alpha(int size)
    {
        arr = new byte[size];
    }

    public int this[int k]
    {
        get
        {
            return arr[k];
        }
        set
        {
            try
            {
                checked
                {
                    arr[k] = (byte)value;
                }
            }
            catch
            {
                arr[k] = 255;
            }
        }
    }
}

class UsingTryCatchDemo
{
    static void Main()
    {
        int size = 20;

        Alpha alpha = new Alpha(size);

        int start = 245;

        for (int k = 0; k < size; k++)
        {
            alpha[k] = start + k;
        }

        for (int k = 0; k < size; k++)
        {
            Console.Write("|{0}", alpha[k]);
        }
        Console.Write("|");

        Console.ReadKey();
    }
}