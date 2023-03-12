namespace Task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите день недели - ");
            int.TryParse(Console.ReadLine(), out int number);
            if (number <= 0 || number > 7)
            {
                Console.WriteLine("Не существует такого дня недели");
            }
            else if (number>0 && number < 6)
            {
                Console.WriteLine("Будний день");
            }
            else
            {
                Console.WriteLine("Выходной");
            }

        }
    }
}