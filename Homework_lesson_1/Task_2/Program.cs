namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Введите первое число - ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Введите второе число - ");
            int.TryParse(Console.ReadLine(), out b);

            if (a == b)
            {
                Console.WriteLine("Числа равны");
            }
            else if (a > b)
            {
                Console.WriteLine($"max = {a}");
            }
            else
            {
                Console.WriteLine($"max = {b}");
            }
        }
    }
}