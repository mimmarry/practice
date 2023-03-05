namespace practice1
{
    class Program
    { 
    static void Main(string[] strings) 
        {
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше {num2} ");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Число {num1} меньше {num2} ");
            }
            else if(num1==num2) 
            {
                Console.WriteLine($"Число {num1} равно {num2}");
            }
            Console.ReadKey();
        }
    }
}