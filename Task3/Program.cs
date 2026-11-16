namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] questions =
            {
                "Які кольори у прапору України?",
                "В якому місті знаходиться ДТЕУ?",
                "Яка столиця Франції?",
                "Скільки океанів на Землі?",
                "Який природний супутник має Земля?"
            };

            string[] options =
            {
                "1.Жовтий і блакитний\n2.Червоний і зелений\n3.Чорний і жовтий\n4.Зелений і фіолетовий",
                "1.Вінниця\n2.Київ\n3.Львів\n4.Одеса",
                "1.Лондон\n2.Берлін\n3.Париж\n4.Мадрид",
                "1.3\n2.5\n3.6\n4.4",
                "1.Марс\n2.Сонце\n3.Місяць\n4.Венера"
            };

            int[] correctAnswers = { 1, 2, 3, 2, 3 };
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Current User Score: {score}");
                Console.WriteLine($"Питання {i + 1}, {questions[i]}");
                Console.WriteLine(options[i]);

                Console.Write("\nВаша відповідь (введіть номер): ");

                if (int.TryParse(Console.ReadLine(), out int answer) && answer == correctAnswers[i])
                {
                    Console.WriteLine("Correct answer\n");
                    score += 100;
                }
                else
                {
                    Console.WriteLine("Wrong Answer");
                    Console.WriteLine("Кінець програми");
                    return;
                }
            }
            Console.WriteLine("Вітаємо! Ви пройшли всю гру та стали мільйонером!");
            Console.WriteLine($"Ваш фінальний рахунок: {score} балів.");
        }
    }
}