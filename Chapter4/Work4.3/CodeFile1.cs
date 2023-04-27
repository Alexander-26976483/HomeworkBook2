using System;

class PointersDemo
{
    unsafe static void Main()
    {
        int random1;

        int random2;

        int combo;

        Random rnd = new Random();

        random1 = rnd.Next(0, 101);

        random2 = rnd.Next(0, 101);

        byte* p = (byte*)&random1;


        
        Console.ReadKey();
    }
}