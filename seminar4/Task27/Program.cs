/*
№27: Напишите метод, который принимает на
вход число и выдаёт сумму цифр в числе.

Пример работы программы:
452 -> 11
82 -> 10
9012 -> 12

Автор: Трофимов П.А.
*/

//Методы:

int GetSum(int number)
{
    string temp = number.ToString();
    int result = 0;
    for (int i = 0; i < temp.Length; i++)
    {
        result += int.Parse(temp[i].ToString);
    }
    return result;
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


//Программа:
int N = IntNumber("Введите число: ");
Console.WriteLine($"Сумма цифр в числе: {GetSum(N)}");