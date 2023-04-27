using System;

class Charlie<T>
{
    private T _data;
    private int count;
    public Charlie<T> next;    

    public Charlie(T data)
    {
        _data = data;
    }

    public void Add(T data)
    {

    }
}

class GenericDemo
{
    static void Main()
    {

        Charlie<string> node1 = new Charlie<string>("alpha");

        node1.next = new Charlie<string>("bravo").next = new Charlie<string>("charlie");





        Console.ReadKey();
    }
}