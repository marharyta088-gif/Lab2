namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть висоту трикутника: ");

            if (int.TryParse(Console.ReadLine(), out int height) && height > 0)
            {
                for (int i = 1; i <= height; i++)
                {
                    for (int j = 0; j < height - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Помилка! Введіть коректне число.");
            }
        }
    }
}
