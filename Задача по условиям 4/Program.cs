// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите сумму вклада:");
Double sum = Convert.ToDouble(Console.ReadLine());

if (sum < 100)
{
    sum = sum + (sum / 100) * 5;
}
else if (sum >= 100 && sum <= 200)
{
    sum = sum + (sum / 100) * 7;
}
else if (sum > 200)
{
    sum = sum + (sum / 100) * 10;
}
Console.WriteLine($"Cумма вклада с процентами: {sum}");
