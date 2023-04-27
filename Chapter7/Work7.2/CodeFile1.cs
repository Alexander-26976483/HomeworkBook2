using System;

class GenericDemo
{
    static void Rearrange<T>(ref T[] arr)
    {
        T[] tempArr = new T[arr.Length];

        tempArr[0] = arr[arr.Length - 1];

        for (int k = 1; k < arr.Length; k++)
        {
            tempArr[k] = arr[k - 1];
        }

        arr = tempArr;
    }

    static void Show<T>(T[] arr)
    {
        for (int k = 0; k < arr.Length; k++)
        {
            Console.Write(arr[k] + "\t");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        char[] B = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

        string[] C = new string[] { "текст1", "текст2", "текст3", "текст4", "текст5" };

        Show(A);
        Show(B);
        Show(C);

        // СДЕЛАТЬ БЕЗ ref!!!
        Rearrange(ref A);
        Rearrange(ref B);
        Rearrange(ref C);

        Show(A);
        Show(B);
        Show(C);

        Console.ReadKey();
    }
}