using System;

class Alpha<T>:IComparable
{
    public int CompareTo(object obj)
    {
        
    }
}

class GenericDemo
{
    static T GetMaxMin<T>(T[] arr) where T: IComparable
    {

    }
    
    static void Main()
    {
        


        Console.ReadKey();
    }
}