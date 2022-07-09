namespace HomeWork4Ex1
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Добрый день! Введите количество строк в будущей матрице: ");
            int lin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в будущей матрице: ");
            int col = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[,] matrix = new int[lin,col];
            int sum = 0;
            for (int i = 0; i < lin; i++)//щелкаем строчки
            {
                for(int j = 0; j < col; j++)//щелкаем столбцы
                {
                    matrix[i,j] = rand.Next(10);
                    Console.Write($"{matrix[i,j]} ");
                    sum += matrix[i, j];//подсчет суммы элементов
                }
                Console.WriteLine(); //новая строка
            }
            Console.WriteLine($"сумма = {sum}");
            Console.ReadKey();




        }
    }
}