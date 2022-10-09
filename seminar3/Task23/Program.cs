/*Условие задачи:

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.  
_Пример работы программы:_  
`3 -> 1, 8, 27`  
`5 -> 1, 8, 27, 64, 125`  

Автор: Трофимов П.А.
*/

//Методы:
//Ввод числа:
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

//Возвращение таблицы кубов:
double[] TimesThree(int number)
{
    double[] array = new double[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = Math.Pow(i + 1, 3);
    }
    return array;
}


//Программа:
int N = InputNumber("Введите число: ");
double[] res = TimesThree(N);
string output = $"{N} -> ";

for (int i = 0; i < res.Length; i++)
{
    if (i == res.Length - 1) output += $"{res[i]}";
    else output += $"{res[i]}, ";
}
Console.WriteLine(output);




