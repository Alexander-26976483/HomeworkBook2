using System;

delegate string DWeek();

class DelegateDemo
{
    static DWeek GetDayWeek(int n)
    {
        int count = 0;

        return () =>
        {
            count += n;

            switch (count > 7 ? count = 1 : count)
            {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 7:
                    return "Воскресенье";
                default:
                    return " ";
            }
        };
    }

    static void Main()
    {
        DWeek nextDay = GetDayWeek(1);

        for (int i = 1; i <= 15; i++)
        {
            Console.WriteLine(nextDay());
        }

        Console.ReadKey();
    }
}