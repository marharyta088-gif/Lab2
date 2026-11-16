using System.Data;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть математичний вираз (наприклад: 5 + 5 * 10 + 4 / 2 - 3):");
            string expression = Console.ReadLine();

            try
            {
                DataTable table = new DataTable();
                var result = table.Compute(expression, "");

                Console.WriteLine($"Відповідь програми: {result}");
            }
            catch (Exception)
            {
                Console.WriteLine("Помилка: не вдалося розпізнати або обчислити вираз. Перевірте правильність введення.");
            }
            Console.WriteLine();
        }
    }
}
