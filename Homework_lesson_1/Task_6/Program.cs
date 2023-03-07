namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число - ");
            bool flag = int.TryParse(Console.ReadLine(), out int a);

            if (!flag)
            {
                Console.WriteLine("Введено не число!!!");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
    }
}