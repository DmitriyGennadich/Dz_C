﻿namespace HomeWork
{
    class Dz_3_Cube
    {
        public static void Main(string[] arg)
        {
            Console.Write("Введите число: ");
            int cube = Convert.ToInt32(Console.ReadLine());
            int[] arry = new int[cube + 1];
            Cube(arry);
            PrintArry(arry);

            void Cube(int[] cube)
            {
                int count = 0;
                int length = cube.Length;
                while (count < length)
                {
                    cube[count] = Convert.ToInt32(Math.Pow(count, 3));
                    count++;
                }
            }

            void PrintArry(int[] coll)
            {
                int count = coll.Length;
                int index = 0;
                while (index < count)
                {
                    Console.Write(coll[index] + " ");
                    index++;
                }
            }

            
        }

    }
}
