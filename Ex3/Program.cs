namespace Homework4Ex4
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Введите крайнее значение диапазона: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //
            int[] matrix = new int[n];
            Random rand = new Random();
            int x = rand.Next(n + 1);
            int i = 1;

            Console.WriteLine($"В диапазоне от 0 до {n} загадано случайное число, попробуйте отгадать ;)");
            Console.WriteLine("Введите число: ");
            var m = Console.ReadLine();
            while (Convert.ToInt32(m) != x)
            {
                i++;
                if (Convert.ToInt32(m) > x)
                {
                    Console.WriteLine($"Попробуйте еще раз, число {m} больше загаданного");
                    m = Console.ReadLine();
                }
                else if(Convert.ToInt32(m) < x)
                {
                    Console.WriteLine($"Попробуйте еще раз, число {m} меньше загаданного");
                    m = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Ура, Вы угадали! {m} = {x}");
            Console.WriteLine($"Попыток: {i}");
            Console.ReadKey();
        }
    }
}