// задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)

Console.WriteLine("Введите число");
string number = Console.ReadLine() ?? "";
int even = int.Parse(number);

if (even % 2 == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("не четное");
}