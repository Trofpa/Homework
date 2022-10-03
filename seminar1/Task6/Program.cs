/*
Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка)

Автор: Трофимов П.А.
https://github.com/Trofpa/Homework/tree/main/seminar1/Task6_IsEven
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
//Проверка четности
void IsEven(int number)
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"{number} - четное число!");
    }
    else
    {
        Console.WriteLine($"{number} - нечетное число!");
    }
}


//Программа
Console.Clear();
int UsersNumber = InputNumbers("Введите целое число: ");
IsEven(UsersNumber);




