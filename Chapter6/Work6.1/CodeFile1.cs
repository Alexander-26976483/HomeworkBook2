using System;
using System.Threading;

class Factorial
{
    private int num;
    private int time;

    public Factorial(int num, int time)
    {
        this.num = num;
        this.time = time;
    }

    public void CalculateFactorial()
    {
        Console.WriteLine("Вычисление факториала числа {0}", num);

        int result = 1;

        if (num != 0)
        {
            for (int k = 1; k <= num; k++)
            {
                result *= k;
                Console.WriteLine("Промежуточное вычисление факториала числа {0}: {1}", num, result);
                Thread.Sleep(time);
            }
        }

        Console.WriteLine("Завершение вычисления факториала числа {0}. Результат: {1}", num, result);
    }
}

class DoubleFactorial
{
    private int num;
    private int time;

    public DoubleFactorial(int num, int time)
    {
        this.num = num;
        this.time = time;
    }

    public void CalculateDoubleFactorial()
    {
        Console.WriteLine("Вычисление двойного факториала числа {0}", num);

        int result = 1;

        if (num != 0)
        {
            for (int k = num; num % 2 == 0 ? k >= 2 : k >= 1; k--)
            {
                result *= k;
                k--;
                Console.WriteLine("Промежуточное вычисление двойного факториала числа {0}: {1}", num, result);
                Thread.Sleep(time);
            }
        }

        Console.WriteLine("Завершение вычисления двойного факториала числа {0}. Результат: {1}", num, result);
    }
}

class Fibonacci
{
    private int num;
    private int time;

    public Fibonacci(int num, int time)
    {
        this.num = num;
        this.time = time;
    }

    public void CalculateFibonacci()
    {
        Console.WriteLine("Вычисление последовательности Фибоначчи для числа {0}", num);

        int number1 = 1, number2 = 1;

        int intermediateVariable;

        Console.WriteLine("Промежуточное вычисление последовательности Фибоначчи для числа {0}: {1}", num, number1);
        Thread.Sleep(time);

        if (num > 2)
        {


            for (int k = 2; k <= num; k++)
            {
                intermediateVariable = number1 + number2;
                number1 = number2;
                number2 = intermediateVariable;
                Console.WriteLine("Промежуточное вычисление последовательности Фибоначчи для числа {0}: {1}", num, number1);
                Thread.Sleep(time);
            }
        }
        else if (num == 2)
        {
            Console.WriteLine("Промежуточное вычисление последовательности Фибоначчи для числа {0}: {1}", num, number1);
            Thread.Sleep(time);
        }

        Console.WriteLine("Завершение вычисления последовательности Фибоначчи для числа {0}. Результат: {1}", num, number1);
    }
}

class ThreadDemo
{
    static void Main()
    {
        int num;

        do
        {
            Console.Write("Введите целое число: ");

            num = Int32.Parse(Console.ReadLine());

            if(num < 0)
            {
                Console.WriteLine("Нужно ввести неотрицательное число!");
            }
        }
        while (num < 0);

        Factorial factorial = new Factorial(num, 100);

        DoubleFactorial doubleFactorial = new DoubleFactorial(num, 100);

        Fibonacci fibonacci = new Fibonacci(num, 100);

        //Thread thread1 = new Thread(factorial.CalculateFactorial);

        //Thread thread2 = new Thread(doubleFactorial.CalculateDoubleFactorial);

        //Thread thread3 = new Thread(fibonacci.CalculateFibonacci);

        //thread1.Start();

        //thread2.Start();

        //thread3.Start();

        ThreadStart ts = factorial.CalculateFactorial;
        ts += doubleFactorial.CalculateDoubleFactorial;
        ts += fibonacci.CalculateFibonacci;

        Thread thread = new Thread(ts);

        thread.Start();

        Console.ReadKey();
    }
}