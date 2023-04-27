using System;

//enum Weekday {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

//class EnumDemo
//{
//    static Weekday DefineWeekday(int n)
//    {

//    }

//    static void Main()
//    {


//        Console.ReadKey();
//    }
//}

class Program
{
    static int Recursion(int[] arr)
    {
        if(arr.Length == 1)
        {
            return arr[0];
        }
        else
        {
            return arr[0] + Recursion(arr);
        }
    }


    static void Main()
    {
        int[] arr = { 1, 2, 3, 4 };

        int result = 0;

        for (int k = 0; k < arr.Length; k++)
        {
            result += arr[k];
        }

        Recursion(arr);

        Console.ReadKey();
    }
}