/*
№25: Опишите метод, который принимает на вход два числа
(A и B) и возводит число A в целую степень B.
без Math.Pow!

Пример работы программы:
3, 5 -> 243 (3⁵)
2, 4 -> 16

Автор: Трофимов П.А.
*/

//Методы:

double NumberPow(double a, int b)
{
    double temp = a;
    for (int i = 1; i < b; i++)
    {
        a *= temp;
    }
    return a;
}

int IntNumber(string text)
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

double DoubleNumber(string text)
{
    bool Condition = true;
    double number = 0;
    while (Condition)
    {
        Console.Write(text);
        if (double.TryParse(Console.ReadLine(), out number))
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

//Проверка метода:

double A = DoubleNumber("Введите число А: ");
int B = IntNumber("Введите степень числа А: ");
Console.WriteLine($"{A}, {B} -> {NumberPow(A, B)}");





