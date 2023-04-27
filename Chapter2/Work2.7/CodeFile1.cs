using System;

delegate int MyDelegate(int n);

class MyClass
{
    static int MethodArgument(int n)
    {
        return n;
    }

    static int[] Method(int[] arr, MyDelegate F)
    {
        int[] result = new int[arr.Length];

        for (int k = 0; k < arr.Length; k++)
        {
            result[k] = F(arr[k]);
        }

        return result;
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        for (int k = 0; k < array.Length; k++)
        {
            Console.Write(Method(array, MethodArgument)[k] + " ");
        }

        Console.ReadKey();
    }
}