namespace seminar2
{
    class homework
    //     Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
    // и проверяет, является ли этот день выходным.

    // 6 -> да
    // 7 -> да
    // 1 -> нет
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели: ");
            int number = (Convert.ToInt32(Console.ReadLine())) % 7;

            if (number < 5)
            {
                Console.WriteLine("Будни");
            }
            else
            {
                Console.WriteLine("Выходной");
            }

        }
    }
}