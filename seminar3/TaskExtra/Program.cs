/*Условие задачи:

Показать интервалы времени, когда было больше всего людей в магазине.  

    _Пример работы программы:_  
Журнал посещения (сделать генератором чисел 0-23):  
11-13;
10-14;
9-10;
11-22;
18-18;
0-23;
4-5;
4-5;
4-5

Ответ : 4-5, 11-13

1. Метод - проверяем каждый час, ведем счетчик людей,
на выходе получаем массив с кол-вом людей [0, 23] - индекс == час.

2. Метод - определяем максимальные значения в массиве. Если внутри 
есть несколько max подряд - как то отформатировать это в ответе.

Подсказка: используй методы .Split() и .Substring() чтобы работать с форматами!

Автор: Трофимов П.А.
*/

/*
int[] PeopleHour(string[] str)
{
    string [] strlist = new string[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        strlist[i] = str[i].Split("-");
    }
}

*/

string[] GenList()
{
    Console.WriteLine("Создаем лист посещения."
    + "\nВведите количество строк в списке: \n");
    int size = int.Parse(Console.ReadLine());
    string[] VisitorsList = new string[size];
    int LeaveTime;
    int ArrTime;
    for (int i = 0; i < VisitorsList.Length; i++)
    {

        ArrTime = new Random().Next(0, 24);
        if (ArrTime == 23)
        {
            LeaveTime = 0;
        }
        else
        {
            LeaveTime = new Random().Next(ArrTime + 1, 24);
        }
        VisitorsList[i] = $"{ArrTime}-{LeaveTime}";
    }
    Console.WriteLine(" Сформированный список:\n{0}", String.Join("; ", VisitorsList));
    return VisitorsList;
}

string[,] StrToMass(string[] str)
{
    string[] temp = new string[2];
    string[,] result = new string[str.Length, 2];
    for (int i = 0; i < str.Length; i++)
    {
        temp = str[i].Split("-");
        for (int j = 0; j < temp.Length; j++)
        {
            result[i, j] = temp[j];
        }
    }
    return result;
}

string[,] MostPeopleTime(string[] str)
{
    string[,] strlist = StrToMass(str);
    int[] visitors = new int[24];
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < visitors.Length; j++)
        {
            if ((j < int.Parse(strlist[i, 1]) || (int.Parse(strlist[i, 1]) == 0)) && ((j >= int.Parse(strlist[i, 0]))))
            {
                visitors[j]++;
            }
        }
    }

    int IndexMax = 0;
    int max = visitors[IndexMax];
    for (int i = 1; i < visitors.Length; i++)
    {
        if (visitors[i] > max)
        {
            max = visitors[i];
            IndexMax = i;
        }
    }
    string answer = String.Empty;
    for (int i = IndexMax; i < visitors.Length; i++)
    {
        if ((i == visitors.Length - 1) && (visitors[i] == max))
        {
            answer += $"0;";
        }
        else
        {
            if ((visitors[i] != max) && (visitors[i - 1] == max))
            {
                answer += $"{i};";
            }
            else
            {
                if ((visitors[i - 1] != max) && (visitors[i] == max))
                {
                    answer += $"{i}-";
                }
                else
                {
                    continue;
                }
            }
        }

    }
    Console.WriteLine("\n" + String.Join(" ", visitors) + "\n");
    Console.WriteLine($"Периоды с наибольшим посещением:  " + answer);
    string[,] result = StrToMass(answer.Split());
    return result;
}

string[] example = GenList();
string[,] numbers = MostPeopleTime(example);




//     int[] visitors = new int[24];
//     result[0, 0] = IndexMax;
//     for (int i = IndexMax + 1; i < visitors.Length; i++)
//     {
//         if ()
// }

//     return result
// }

