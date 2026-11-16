namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть рік: ");

            if (int.TryParse(Console.ReadLine(), out int year) && year > 0)
            {

                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine($"Рік {year} - високосний.");
                }
                else
                {
                    Console.WriteLine($"Рік {year} - не високосний.");
                }
            }
            else
            {
                Console.WriteLine("Помилка: введіть коректне число(рік).");
            }
        }
    }
}