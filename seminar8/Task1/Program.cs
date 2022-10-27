/* Условие задачи:
1. Есть число N. Скольно групп M, можно получить при разбиении всех
чисел на группы, так чтобы в одной группе все числа были взаимно просты.
Задача: найти M при заданном N и получить одно из разбиений на группы.

Например для N = 50, M -> 6
Одно из решений :
`6 групп`  
`Группа 1: 1`   
`Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 `  
`Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49`  
`Группа 4: 8 12 18 20 27 28 30 42 44 45 50 `  
`Группа 5: 7 16 24 36 40 `  
`Группа 6: 5 32 48`  

Ещё одно решение:
`6 групп`  
`Группа 1: 1 `  
`Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 `  
`Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 `  
`Группа 4: 8 12 18 20 27 28 30 42 44 45 50 `  
`Группа 5: 16 24 36 40 `  
`Группа 6: 32 48`  

Автор: Трофимов П.А.
*/

//Методы:
//Ввод чисел
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

//Изменение размера двумерного массива
int[,] ResizeArray2D(int[,] array, int rows, int cols)
{
    int[,] output = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            output[i, j] = array[i, j];
        }
    }
    return output;
}
//Проверка списка чисел на взаимную простоту каждого элемента
bool IsSimple(List<int> array, int number)
{
    bool res = false;
    for (int i = 0; i < array.Count; i++)
    {
        if (number % array[i] == 0) res = true;
    }
    return !res;
}
//Подсчет количества элементов, отличных от нуля, в массиве
int Numbers(int[,] array)
{
    int res = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0) res++;
        }
    }
    return res;
}
//Поиск чисел в массиве
bool Find(int[,] array, int number)
{
    bool res = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number) res = true;
        }
    }
    return res;
}
//Помещение строки в массив
int[,] AddRow(int[,] array, List<int> numbers)
{
    if (numbers.Count > array.GetLength(1))
    {
        array = ResizeArray2D(array, array.GetLength(0) + 1, numbers.Count);
    }
    else
    {
        array = ResizeArray2D(array, array.GetLength(0) + 1, array.GetLength(1));
    }
    int newRow = array.GetLength(0) - 1;
    for (int i = 0; i < numbers.Count; i++)
    {
        array[newRow, i] = numbers[i];
    }
    return array;
}
//Расчет групп простых чисел
int[,] SimpleNumbs(int number)
{
    int[,] groups = new int[1, 1];
    groups[0, 0] = 1;
    List<int> array = new List<int>();
    while (Numbers(groups) < number)
    {
        array.Clear();
        for (int i = 2; i < number + 1; i++)
        {
            if (!Find(groups, i) && (array.Count == 0))
            {
                array.Add(i);
            }
            else
            {
                if ((!Find(groups, i)) && (IsSimple(array, i))) array.Add(i);
            }

        }
        groups = AddRow(groups, array);
        //Console.Write("-");
    }
    return groups;
}

//Программа:

int N = InputNumber("Введите число: ");
int[,] matrix = SimpleNumbs(N);
Console.WriteLine($"{matrix.GetLength(0)} групп.");
string text;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    text = $"Группа {i + 1}: ";
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] != 0) text += $"{matrix[i, j]} ";
    }
    Console.WriteLine(text);
}
// int[,] matrix =
// {
//     {0, 1, 1, 0},
//     {0, 1, 1, 0},
//     {0, 1, 1, 0},
// };
