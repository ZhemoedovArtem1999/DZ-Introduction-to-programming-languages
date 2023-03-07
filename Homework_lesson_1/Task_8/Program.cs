namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число - ");
            bool flag = int.TryParse(Console.ReadLine(), out int N);

            if (!flag)
            {
                Console.WriteLine("Введено не число!!!");
            }
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
    }
}