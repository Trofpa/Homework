/*
Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка)

Автор: Трофимов П.А.

*/

Console.Clear();

int Number;

Console.WriteLine("Введите число: "); // Вводим число
bool IsNumber = int.TryParse(Console.ReadLine(), out Number);


if (IsNumber) // Проверка на то, что были введены числа
{
    if (Number % 2 == 0)
    {
        Console.WriteLine(Number + " - четное число!");
    }
    else
    {
        Console.WriteLine(Number + " - нечетное число!");
    }
}
else
{
    Console.WriteLine("Введенный символ не является числом!");
}