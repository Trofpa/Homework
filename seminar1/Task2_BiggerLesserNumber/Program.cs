/*
Условие задачи:
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Автор: Трофимов П.А.
*/
Console.Clear();

int FirstNumber;
int SecondNumber;
Console.WriteLine("Введите первое число: "); // Вводим числа
bool Condition1 = int.TryParse(Console.ReadLine(), out FirstNumber);
Console.WriteLine("Введите второе число: ");
bool Condition2 = int.TryParse(Console.ReadLine(), out SecondNumber);

if (Condition1 && Condition2) // Проверка на то, что были введены числа
{
    if(FirstNumber > SecondNumber) // Сравниваем введенные числа
    {
        Console.WriteLine("Большее число: " + FirstNumber + "\nМеньшее число: " + SecondNumber);
    }
    else 
    {
        if (FirstNumber == SecondNumber)
        {
        Console.WriteLine("\nВведенные числа равны!"); // Проверка на равенство введенных чисел
        }
        else
        {
        Console.WriteLine("\nБольшее число: " + SecondNumber + "\nМеньшее число: " + FirstNumber);
        }
    }
}
else
{
    Console.WriteLine("Одно или оба введенных символа не являлись числом!");
}