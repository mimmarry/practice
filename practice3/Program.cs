namespace practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите суммy вклада: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            if (sum < 100)
            {
                sum += sum * 0.5;
            }
            else if (sum <= 200)
            {
                sum += sum * 0.7;
            }

            if (sum > 200)
            { 
                sum += sum * 0.1;
            }
            Console.WriteLine($"Ваш процент по вклдаку составляет {sum}");
        }
    }
}