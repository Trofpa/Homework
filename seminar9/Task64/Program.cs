/*
 Задача 64:
 Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии!

Пример:  
N = 5 -> 5, 4, 3, 2, 1  
N = 8 -> 8, 7, 6, 5, 4, 3, 2, 1  

Автор: Трофимов П.А.

*/

//Метод для ввода числа
int InputNumber(string text)
{
    bool Condition = true;
    int number = 0;
    while (Condition)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out number) && number != 0)
        {
            Condition = false;
        }
        else
        {
            Console.WriteLine("Ошибка!");
        }
    }
    return number;
}

//Метод для последовательности чисел
string ShowSequence(int N)
{
    if (N == 1) return $"{N}";
    else return ($"{N}, " + ShowSequence(N - 1));
}

int Number = InputNumber("Введите целое положительное число >= 1: ");
Console.WriteLine($"N = {Number} -> {ShowSequence(Number)}");