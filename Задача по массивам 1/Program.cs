// See https://aka.ms/new-console-template for more information

int[] nums = new int[10] { 1, 2, 3, 4, 5 ,6 ,7 ,8 ,9 ,10};
Console.Write("Исходный массив: ");
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"{nums[i]} ");

}
Console.WriteLine();
Console.Write("Массив нечетных чисел: ");
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 != 0)
    {
        Console.Write($"{nums[i]} ");
    }
}