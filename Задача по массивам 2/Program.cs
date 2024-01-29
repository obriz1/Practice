// See https://aka.ms/new-console-template for more information

string[] names = new string[3] {"Tom","Sam","Bob"};
Console.Write("Введите строку: ");
string str = Console.ReadLine();
for (int i = 0; i < names.Length; i++) { 
if (names[i] == str)
{
    Console.WriteLine("Строка найдена!");
        break;
}
    else
    {
        Console.WriteLine("Строка не найдена!");
        break;
    }
}