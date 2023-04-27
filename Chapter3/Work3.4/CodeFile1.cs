using System;

struct AlphaStruct
{
    private int[] nums;

    public AlphaStruct(int size)
    {
        nums = new int[size];

        Random rnd = new Random();

        for (int k = 0; k < nums.Length; k++)
        {
            nums[k] = rnd.Next(0, 101);
        }
    }

    public int GetMaxValue()
    {
        int max = nums[0];
        
        for(int k = 1; k < nums.Length; k++)
        {
            if (nums[k] > max)
            {
                max = nums[k];
            }
        }
        return max;
    }

    public int GetMinValue()
    {
        int min = nums[0];

        for (int k = 1; k < nums.Length; k++)
        {
            if (min > nums[k])
            {
                min = nums[k];
            }
        }
        return min;
    }

    public int GetMiddleValue()
    {
        int middle = 0;

        for (int k = 0; k < nums.Length; k++)
        {
            middle += nums[k];
        }

        middle /= nums.Length;

        return middle;
    }

    public void Show()
    {
        for (int k = 0; k < nums.Length; k++)
        {
            Console.Write("|" + nums[k]);
        }
        Console.WriteLine("|");
    }
}

class StructDemo
{
    static void Main()
    {

        AlphaStruct alphaStruct = new AlphaStruct(20);

        alphaStruct.Show();

        Console.WriteLine("Метод GetMaxValue:\n" + alphaStruct.GetMaxValue());
        Console.WriteLine("Метод GetMinValue:\n" + alphaStruct.GetMinValue());
        Console.WriteLine("Метод GetMiddleValue:\n" + alphaStruct.GetMiddleValue());

        Console.ReadKey();
    }
}