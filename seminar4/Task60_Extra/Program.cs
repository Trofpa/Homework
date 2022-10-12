/*
Доп. задание №60 Составить частотный
словарь элементов двумерного массива

Пример работы программы:
2D-массив:
1, 2, 3
4, 6, 1
2, 1, 6
На выходе:
1 встречается 3 раза. частота повторений (33.33%)
2 встречается 2 раз. частота повторений (22.22%)
3 встречается 1 раз. частота повторений (11.11%)
4 встречается 1 раз. частота повторений (11.11%)
6 встречается 2 раза. частота повторений (22.22%)

Автор: Трофимов П.А.
*/


//Методы:

//Метод для генерации двумерного массива из целых чисел
int[,] GenArray(int Nrows, int Mcolumns, int Erange)
{
    //Заполняем двумерный массив случайными значениями
    int[,] result = new int[Nrows, Mcolumns];
    for (int i = 0; i < Nrows; i++)
    {
        for (int j = 0; j < Mcolumns; j++)
        {
            result[i, j] = new Random().Next(0, Erange + 1);
        }
    }

    //Отображение сгенерированного двумерного массива
    Console.WriteLine("Сгенерированный массив: ");
    for (int i = 0; i < Nrows; i++)
    {
        for (int j = 0; j < Mcolumns; j++)
        {
            Console.Write($"{result[i, j]} \t");
        }
        Console.WriteLine();
    }
    return result;
}


//Метод для создания частотного словаря значений массива
void FrequencyTable(int[,] array)
{
    //Запоминаем общее кол-во элементов в массиве, чтобы получить процентное соотношение.
    double Nelements = array.GetLength(0) * array.GetLength(1);
    
    //Считаем диапазон значений для поиска
    int max = array[0, 0];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max) max = array[i, j];
        }
    }

    //Считаем количество одинаковых чисел внутри двумерного массива
    double[] count = new double[max + 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < count.Length; k++)
            {
                if (k == array[i, j])
                {
                    count[k]++;
                }
            }
        }
    }

    //Вывод на экран частотной таблицы с учетом склонения.
    Console.WriteLine();
    for (int i = 0; i < count.Length; i++)
    {
        bool condition1 = (count[i] % 10 == 2) || (count[i] % 10 == 3) || (count[i] % 10 == 4);
        bool condition2 = (count[i] % 100 != 12) || (count[i] % 100 != 13) || (count[i] % 100 != 14);
        if (count[i] != 0)
        {
            if (condition1 && condition2)
            {
                Console.WriteLine($"{i} встречается {count[i]} раза."
                                + $"\tЧастота повторений: ({count[i] / Nelements:P1}) ");
            }
            else
            {
                Console.WriteLine($"{i} встречается {count[i]} раз."
                                + $"\tЧастота повторений ({count[i] / Nelements:P1}) ");
            }
        }
    }
}


//Программа:
Console.Clear();

Console.WriteLine("Задаем двумерный массив."
                + "Сколько строк в массиве? ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("\nСколько столбцов в массиве? ");
int columns = int.Parse(Console.ReadLine());

Console.WriteLine("\nДо какого диапазона значения?");
int range = int.Parse(Console.ReadLine());

int[,] array = GenArray(rows, columns, range);

FrequencyTable(array);
