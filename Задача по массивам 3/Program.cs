// See https://aka.ms/new-console-template for more information

int[] nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
double sum = 0;
Console.Write("Исходный массив: ");
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"{nums[i]} ");

}
Console.WriteLine();
Console.Write("Cумма элементов массива: ");
for (int i = 0; i < nums.Length; i++)
{
    sum += nums[i];
}
double average = sum / nums.Length;
Console.WriteLine(sum);
Console.Write($"Среднее арифметическое: {average}");