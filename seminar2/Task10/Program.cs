/*
10. Напишите метод, который принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

Автор: Трофимов П.А.

*/

//Методы:

//Ввод чисел
int InputNumbers(string text)
{
    bool Condition = true;
    int number = 0;
    int anger = 0;
    while (Condition)
    {
        Console.Write(text);
        if (!(int.TryParse(Console.ReadLine(), out number)))
        {
            anger++;
            if (anger >= 3)
            {
                Console.WriteLine("Введенный символ не является числом!!! (＞ｍ＜)");
            }
            else
            {
                Console.WriteLine("Введенный символ не является числом! (-_-)");
            }
            
        }
        else
        {
            if (((number < 1000) && (number >= 100)))
            {
                Condition = false;
            }
            else
            {
                anger++;
                if (anger >= 3)
                {
                    Console.WriteLine("Это не трехзначное число !!! (＞ｍ＜)");
                }
                else
                {
                    Console.WriteLine("Это не трехзначное число (-_-)") ;
                }      
            }
        }
    }
return number;
}

//Показ второй цифры
void SecondDigit(int number)
{
    int result = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа - {result}!");
}


//Программа
int N = InputNumbers("Введите трехзначное число: ");
SecondDigit(N);