// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите сумму вклада:");
decimal sum = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите кол-во месяцев:");
int col = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= col; i++)
{
    sum = sum + (sum / 100) * 7;
}
Console.WriteLine($"Конечная сумма вклада:{sum}");