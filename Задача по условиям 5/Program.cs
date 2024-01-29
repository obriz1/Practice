// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число 1:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение:");
int Operation = Convert.ToInt32(Console.ReadLine());

switch (Operation)
{
    case 1:
        Console.WriteLine($"Результат {num1 + num2}");
        break;
    case 2:
        Console.WriteLine($"Результат {num1 - num2}");
        break;
    case 3:
        Console.WriteLine($"Результат {num1 * num2}");
        break;
    default:
        Console.WriteLine("Операция неопределена");
        break;
}
