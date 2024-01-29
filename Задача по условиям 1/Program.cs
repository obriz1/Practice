// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число 1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}
else
{
    Console.WriteLine($"Число {num1} равно числу {num2}");
}
