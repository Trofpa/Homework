/*
Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

Автор: Трофимов П.А.
https://github.com/Trofpa/Homework/tree/main/seminar1/Task8_WriteEvenNumbers
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
//Выводим все четные числа
void EvenString(int number)
{
    Console.Write("Четные числа: ");
    for (int count = 2; count <= number; count = count + 2)
    {
        Console.Write($"{count} ");
    }
}

//Программа
Console.Clear();
int N = InputNumbers("Введите число: ");
EvenString(N);

