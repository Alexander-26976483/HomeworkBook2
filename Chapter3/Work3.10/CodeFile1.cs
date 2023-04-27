using System;

struct Alpha
{
    public int num;

    public Alpha(int n)
    {
        num = n;
    }

    public static Bravo operator +(Alpha alpha1, Alpha alpha2)
    {
        return new Bravo(alpha1.num, alpha2.num);
    }
}

struct Bravo
{
    public int num1;

    public int num2;

    public Bravo(int n1, int n2)
    {
        num1 = n1;

        num2 = n2;
    }

    public Alpha[] GetAlphas()
    {
        Alpha[] result = new Alpha[2];

        result[0] = new Alpha(num1);

        result[1] = new Alpha(num2);

        return result;
    }
}

class StructDemo
{
    static void Main()
    {
        Alpha alpha1 = new Alpha(10);

        Alpha alpha2 = new Alpha(40);

        Bravo bravo = new Bravo(20, 30);

        Alpha[] alphas = bravo.GetAlphas();

        for (int k = 0; k < alphas.Length; k++)
        {
            Console.WriteLine(alphas[k].num);
        }

        Bravo bravo2 = alpha1 + alpha2;

        Console.WriteLine("{0}, {1}", bravo2.num1, bravo2.num2);

        Console.ReadKey();
    }
}