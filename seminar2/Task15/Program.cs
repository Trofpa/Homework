/*
15. Напишите метод, который принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.




Автор: Трофимов П.А.

*/

//Методы:

//Ввод чисел
int InputWeekDay(string text)
{
    int number = 0;
    while (true)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number > 7)
            {
                if (number == 0)
                {
                    
                }
                else
                {
                    Console.WriteLine("В неделе семь дней, валенок (-_-)");
                }
                
            }
            else
            {
                if (number <= 0)
                {
                    if (number == 0)
                    {
                        Console.WriteLine("Ага, нулевой день недели, а как же (-_-)");
                    }
                    else
                    {
                        Console.WriteLine("Отрицательные дни недели? Мдаааа Попробуй еще раз (-_-)");
                    }
                }
                else
                {
                break;
                }
            }
        }
        else
        {
            Console.WriteLine("Введенный символ не является числом!");
        }
    }
return number;
}

//Определение выходного
void WeekDay(int number)
{
    if ((number % 6 == 0) || (number % 7 == 0))
    {
        Console.WriteLine("Ура! Выходной! =)");
    }
    else
    {
        Console.WriteLine("Опять работать Т_Т");
    }
}

//Программа
Console.Clear();
int day = InputWeekDay("Какой по счету день недели? Введите число: ");
WeekDay(day);