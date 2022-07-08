namespace HomeWork

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

{
    class Dz_1_Polindrom
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Введите пятизначное число: ");
            string? N = Console.ReadLine();

            static void PolindromN(string N)
            {
                if (N[0] == N[4] && N[1] == N[3])
                {
                    Console.Write(N + " - Введенное число полиндром");
                }

                else Console.Write(N + " - Введенное число НЕ полиндром");
            }

            if (N!.Length == 5)
            {
                PolindromN(N);
            }

            else Console.WriteLine(N + " - Введено число не по заданию");

        }

    }

}