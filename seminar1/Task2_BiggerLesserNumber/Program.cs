/*
Условие задачи:
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Автор: Трофимов П.А.
https://github.com/Trofpa/Homework/tree/main/seminar1/Task2_BiggerLesserNumber
*/

//Методы:
//Ввод чисел
int InputNumbers(string text)
{
    bool Condition = true;
    int number = 0;
    while (Condition)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            Condition = false;
        }
        else
        {
            Console.WriteLine("Введенный символ не является числом!");
        }
    }
return number;
}

//Сравнение двух введенных чисел
void Comparing(int a, int b)
{
    if(a > b) // Сравниваем введенные числа
    {
        Console.WriteLine($"Большее число: {a}\nМеньшее число: {b}");
    }
    else 
    {
        if (a == b)
        {
            Console.WriteLine("Введенные числа равны!");
        }
        else
        {
            Console.Write($"Большее число: {b}\nМеньшее число: {a}");;
        }
    }
}
 

//Программа
Console.Clear();
int FirstNumber = InputNumbers("Введите первое число: ");
int SecondNumber = InputNumbers("Введите второе число: ");
Comparing(FirstNumber, SecondNumber);