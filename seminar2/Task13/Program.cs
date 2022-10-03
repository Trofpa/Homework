/*
13. Напишите метод, который выводит третью цифру заданного
числа или сообщает, что третьей цифры нет.

Понимаю, что можно сделать и проще через строку, но решил в методе
пользоваться чистой арифметикой


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

//Вывод третьей цифры
void ThirdDigit(int number)
{
    if (number % 100 == number)
    {
        Console.WriteLine($"В числе {number} нет третьей цифры");
    }
    else
    {
        while (true)
        {
            int digit = number % 10;
            if (number % 1000 == number)
            {
                Console.WriteLine($"Третья цифра - {digit}");
                break;
            }
            else
            {
                number /= 10;
            }
        }
    }
}


//Программа

int N = InputNumbers("Введите число: ");
ThirdDigit(N);
