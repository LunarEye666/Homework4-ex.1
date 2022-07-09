namespace Exercise3edited
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите крайнее значение диапазона: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //Conditions
            int[] matrix = new int[n];
            Random rand = new Random();
            int x = rand.Next(n + 1);
            Console.WriteLine($"В диапазоне от 0 до {n} загадано случайное число, попробуйте отгадать ;)");
            int i = 0;
            //Solution
            while (true)
            {
                i++;
                Console.WriteLine("Введите число: ");
               var m = Console.ReadLine();
                if (m == String.Empty)
                {
                    Console.WriteLine($"Увы, Вы сдались. Загаданное число = {x}");
                    break;
                }
                else if (Convert.ToInt32(m) > x)
                {
                    Console.WriteLine("Число больше загаданного, попробуйте еще");
                }
                else if (Convert.ToInt32(m) < x)
                {
                    Console.WriteLine("Число меньше загаданного, попробуйте еще");
                }
                else if (Convert.ToInt32(m) == x)
                {
                    Console.WriteLine($"Ура, Вы выиграли! Число {m} = загаданному {x}. Количество попыток = {i} ");
                    break;
                }  
            }
            Console.ReadKey();
        }
    }
}