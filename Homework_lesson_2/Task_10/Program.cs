namespace Task_10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число - ");
            int.TryParse(Console.ReadLine(), out int number);
            if (number <= 99 || number >= 1000)
            {
                Console.WriteLine("Введено не трёхзначное число!!!");
            }
            else
            {
                Console.WriteLine((number / 10) % 10);
            }
        }


    }
}