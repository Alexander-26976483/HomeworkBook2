using System;

class PointersDemo
{
    unsafe static void Main()
    {
        int n;

        int m = sizeof(int) / sizeof(byte);

        byte* p = (byte*)&n;

        for (int k = 0; k < m; k++)
        {
            switch (k)
            {
                case 0:
                    p[k] = 1;
                    break;
                case 1:
                    p[k] = 65;
                    break;
                case 2:
                    p[k] = 65;
                    break;
                case 3:
                    p[k] = 1;
                    break;
            }
        }

        Console.WriteLine("|{0}|'{1}'|'{2}'|{3}|", p[0], (char)p[1], (char)p[2], p[3]);

        Console.ReadKey();
    }
}