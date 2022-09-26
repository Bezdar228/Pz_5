namespace PZ._5
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Первая задача");
            Console.WriteLine();
            for (int i = 20; i <= 70; i+=4)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine();
            Console.WriteLine("Вторая задача") ;
            Console.WriteLine();

            char simvol = 'и';
            for (int i = 1080; i < 1087; i++)
            {
                Console.WriteLine(simvol++);
            }
            Console.WriteLine();
            Console.WriteLine("Третья задача");
            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                    Console.Write('#');
                }
            }

            Console.WriteLine();
            Console.WriteLine("Четвёртая задача");
            Console.WriteLine();
            for (int i = 15; i <=100; i++)
            {
                if (i % 15 == 0) Console.WriteLine($"{i}");
            }
            Console.WriteLine();
            Console.WriteLine("Пятая задача");
            Console.WriteLine();
            for (int i = 0, j= 88; ; i++, j--)
            {
                Console.WriteLine($"{i}, {j}");
                if ((i - j) == 6) break;
            }

        }

    }
}