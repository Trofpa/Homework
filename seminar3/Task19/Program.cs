/*Условие задачи:

Напишите программу, которая принимает на вход пятизначное число
и проверяет,является ли оно палиндромом.  

_Пример работы программы:_  
`14212 -> нет`  
`12821 -> да`  
`23432 -> да`  


Автор: Трофимов П.А.
*/

//Программа:
Console.Clear();
int N = InputNumber("Ввведите число: ");
if (IsPalindrom(N)) Console.WriteLine($"Число {N} является полиндромом!");
else Console.WriteLine($"Число {N} не является полиндромом!");





//Методы:

int InputNumber(string text)
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

bool IsPalindrom(int number)
{
    int TempNumber = number / 10;
    int Reverse = number % 10;
    do
    {
        Reverse = Reverse * 10 + TempNumber % 10;
        TempNumber = TempNumber / 10;
    }
    while(TempNumber != TempNumber % 10);
    Reverse = Reverse * 10 + TempNumber % 10;
    return Reverse == number;
}