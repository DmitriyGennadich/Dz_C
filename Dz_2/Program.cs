﻿namespace seminar2
{
    class homework
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
           
            if (number > 99)
            {
                string str = Convert.ToString(number);
                Console.WriteLine($"{str[2]}");
            }
            else 
            {
                Console.WriteLine("Третьей цифры нет");
            }
        }
    }

}