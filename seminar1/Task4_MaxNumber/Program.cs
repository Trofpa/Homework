/*
Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.

Автор: Трофимов П.А.

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

//Определение максимального числа
int MaxNumber(int a, int b, int c)
{
    int[] numbers = {a, b, c};
    int count = 1;
    int max = numbers[0];
    while (count < 3)
    {
        if (numbers[count] > max)
        {
            max = numbers[count];
        }
    count++;
    }
    return max;
}


//Программа
Console.Clear();
int First = InputNumbers("Введите число: ");
int Second = InputNumbers("Введите число: ");
int Third = InputNumbers("И еще раз: ");

int max = MaxNumber(First, Second, Third);

Console.WriteLine($"Максимальное число - {max}");