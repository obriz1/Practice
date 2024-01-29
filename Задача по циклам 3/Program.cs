// See https://aka.ms/new-console-template for more information

while (true)
{

    Console.WriteLine("Введите число 1:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число 2:");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if ((num1 < 0 || num1 > 10) || (num2 < 0 || num2 > 10)){
        Console.WriteLine("Введенные числа недопустимы");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine($"Произведение: {num1 * num2}");
        break;
    }

}