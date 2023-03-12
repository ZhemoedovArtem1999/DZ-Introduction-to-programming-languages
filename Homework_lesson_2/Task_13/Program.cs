namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число - ");
            int.TryParse(Console.ReadLine(), out int number);
            if (number <= 99)
            {
                Console.WriteLine("Третьей цифры нет!!!");
            }
            else
            {
                while (number > 999)
                {
                    number /= 10;
                }
                Console.WriteLine(number % 10);
            }
        }
    }
}