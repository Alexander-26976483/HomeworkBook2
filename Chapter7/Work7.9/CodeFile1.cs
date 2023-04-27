using System;

class Alpha<T>
{
    public T[] arr;

    public Alpha(T[] array)
    {
        arr = array;
    }

    public static Alpha<T> operator +(Alpha<T> obj1, Alpha<T> obj2)
    {
        T[] result = new T[obj1.arr.Length + obj2.arr.Length];

        for (int k = 0; k < obj1.arr.Length; k++)
        {
            result[k] = obj1.arr[k];
        }

        for(int k = obj1.arr.Length, j = 0 ; k < result.Length | j < obj2.arr.Length; k++, j++)
        {
            result[k] = obj2.arr[j];
        }

        return new Alpha<T>(result);
    }

    public static void Show(Alpha<T> obj)
    {
        for (int k = 0; k < obj.arr.Length; k++)
        {
            Console.Write("|" + obj.arr[k]);
        }
        Console.WriteLine("|");
    }
}

class GenericDemo
{
    static void Main()
    {
        int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int[] arr2 = new int[] { 11, 12, 13, 14, 15 };

        Alpha<int> alpha1 = new Alpha<int>(arr1);

        Alpha<int> alpha2 = new Alpha<int>(arr2);

        Alpha<int>.Show(alpha1 + alpha2);

        char[] arr3 = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

        char[] arr4 = new char[] { 'K', 'L', 'M', 'N', 'O' };

        Alpha<char> alpha3 = new Alpha<char>(arr3);

        Alpha<char> alpha4 = new Alpha<char>(arr4);

        Alpha<char>.Show(alpha3 + alpha4);

        Console.ReadKey();
    }
}