namespace Task_4
{
    internal class Program
    {
        private static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }


        static void Main(string[] args)
        {
            int[] array = new int[3];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1} число - ");
                int.TryParse(Console.ReadLine(), out array[i]);
            }

            Console.WriteLine($"Максимальное в массиве - {GetMax(array)}");
        }
    }
}