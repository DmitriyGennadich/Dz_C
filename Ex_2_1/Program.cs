namespace seminar3

{
    class Program

    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());     //Читаем число с консоли
           
            for (int i = 1; i <= a; i++)         // перебор массива с помощью цикла
            {
                PrintSquare(i);
            }
        }


        public static void PrintSquare(int n)  // Объявление функции
        {
            Console.WriteLine(n * n);
        }
    }
}