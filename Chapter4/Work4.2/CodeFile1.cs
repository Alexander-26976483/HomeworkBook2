using System;

class PointersDemo
{
    unsafe static void Main()
    {
        double n;

        int m = sizeof(double) / sizeof(byte);

        byte* p = (byte*)&n;

        for (int k = 0; k < m; k++)
        {
            if (k == 0)
            {
                p[k] = 1;
            }
            if (k == 1 || k == 2)
            {
                p[k] = 65;
            }
            if (k == 3 || k == 4 || k == 5 || k == 6)
            {
                p[k] = 2;
            }
            if (k == 7)
            {
                p[k] = 3;
            }
        }

        for (int k = 0; k < m; k++)
        {
            if (k == 1 || k == 2)
            {
                Console.Write("|{0}", (char)p[k]);
            }
            else
            {
                Console.Write("|{0}", p[k]);
            }
        }
        Console.Write("|");

        Console.ReadKey();
    }
}