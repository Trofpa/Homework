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

Автор: Трофимов П.А.
*/


//Методы

//Создание списка посещения
string[] GenList()
{
    //Вводим количество строк
    Console.WriteLine("Создаем лист посещения."
                    + "\nВведите количество строк в списке: ");
    int size = int.Parse(Console.ReadLine());

    //Генерируем строковый массив с периодами времени.
    //Если значение начала посещения выпало 23, 
    //то уход записывается как 0, так как учитываем сутки 
    string[] VisitorsList = new string[size];
    int LeaveTime;
    int ArrTime;
    for (int i = 0; i < VisitorsList.Length; i++)
    {
        ArrTime = new Random().Next(0, 24);

        if (ArrTime == 23) LeaveTime = 0;
        else LeaveTime = new Random().Next(ArrTime + 1, 24);

        VisitorsList[i] = $"{ArrTime}-{LeaveTime}";
    }
    Console.WriteLine(" Сформированный список:\n{0}", String.Join("; ", VisitorsList));
    return VisitorsList;
}

//Преобразование входного строкового массива в двумерный массив значений,
//в котором 1 измерение - № события посещения, 2 измерение времена посещения[0] и ухода[1]
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

//Расчет наиболее посещаемого периода времени
string[,] MostPeopleTime(string[] str)
{
    //разбиваем строковый массив на двумерный c помощью StrToMass
    string[,] strlist = StrToMass(str);

    //Вводим массив счетчика часов посещения (индекс = час) и сканируем по
    //нашему двумерному массиву.Если час попадает в диапазон 
    //`посещение[0] - уход[1]`, прибавляем +1 к значению элемента
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

    //Определяем самый ранний период максимального посещения и запоминаем его начало
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

    //Формируем правильный формат ответа, начиная от самого раннего периода посещения
    string answer = String.Empty;
    for (int i = IndexMax; i < visitors.Length; i++)
    {
        if ((i == visitors.Length - 1) && (visitors[i] == max)) answer += $"23-0; ";
        else
        {
            if ((visitors[i] != max) && (visitors[i - 1] == max)) answer += $"{i}; ";
            else
            {
                if ((visitors[i - 1] != max) && (visitors[i] == max)) answer += $"{i}-";
                else continue;
            }
        }
    }
    Console.WriteLine($"Периоды с наибольшим посещением:  " + answer);
    Console.WriteLine("\n" + String.Join(" ", visitors) + "\n");

    //возвращения ответа в виде двумерного массива с помощью StrToMass
    string[,] result = StrToMass(answer.Split());
    return result;
}

//Программа
string[] example = GenList();

string[,] numbers = MostPeopleTime(example);
