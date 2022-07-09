namespace HomeWork4Ex2
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Добрый день! Введите длину Вашей последовательности: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] matrix = new int[N];
            int min = int.MaxValue;
            //
            for(int i = 0; i < matrix.Length; i++)
            {
              Console.WriteLine($"Введите число {i+1}: ");
              matrix[i] = Convert.ToInt32(Console.ReadLine());
                if (matrix[i] < min)
                {
                    min = matrix[i];
                }
            }
            Console.WriteLine("Ваш ряд: ");
            for(int i = 0; i < matrix.Length; i++)
            {
                Console.Write($"{matrix[i]}");
                Console.Write("   ");
            }
            Console.WriteLine();
            Console.WriteLine($"Минимальное число Вашей последовательности: {min}");
            Console.ReadKey();
        }
    }
}