﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

{

    int a = 2;
    int b = 3;
    int c = 7;
    int max = a;
            
    if (a > max) max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    Console.Write("max = ");
    Console.WriteLine(max);
}
    {
        int a = 44;
        int b = 5;
        int c = 78;
        int max = a;

        if (a > max) max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        Console.Write("max = ");
        Console.WriteLine(max);
    }
        {
            int a = 22;
            int b = 3;
            int c = 9;
            int max = a;

            if (a > max) max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            Console.Write("max = ");
            Console.WriteLine(max);

        }