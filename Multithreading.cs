using System;
using System.Threading;

public class GFG
{
    public static void method1()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Method1 is : {0}", i);
            if (i == 5)
            {
                Thread.Sleep(6000);
            }
        }
    }

    public static void method2()
    {
        for (int j = 0; j <= 10; j++)
        {
            Console.WriteLine("Method2 is : {0}", j);
        }
    }

    public static void Main()
    {
        Console.WriteLine("211211101216/N. Manikanta /4th Year/D");

        Thread thr1 = new Thread(method1);
        Thread thr2 = new Thread(method2);

        thr1.Start();
        thr2.Start();
    }
}
