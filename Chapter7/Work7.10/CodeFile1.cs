using System;

class Alpha<X, Y>
{
    private X[] arrayX;
    private Y[] arrayY;

    public Alpha(int size)
    {
        arrayX = new X[size];
        arrayY = new Y[arrayX.Length];
    }

    public X this[Y k]
    {
        get
        {
            return arrayX[Array.IndexOf(arrayY, k)];
        }
        set
        {
            arrayX[Array.IndexOf(arrayY, k)] = value;
        }
    }

    public void Add()
    {

    }
}

class GenericDemo
{
    static void Main()
    {


        Console.ReadKey();
    }
}