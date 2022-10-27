/*Условие задачи:
56. Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

`1 4 7 2`  
`5 9 2 3`  
`8 4 2 4`  
`5 2 6 7`  

`Ответ: 1 строка`

Автор: Трофимов П.А.

*/

//Метод для заполнения двумерного массива из целых чисел
int[,] FillArray(int[,] array, int min = 0, int max = 10)
{
    //Заполняем двумерный массив случайными значениями
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = Random.Shared.Next(min, max + 1);
        }
    }
    return array;
}

//Вывод матрицы в консоль
void PrintArray(int[,] array, string text = "\nСгенерированный массив: \n")
{
    Console.WriteLine(text);
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
    Console.Write("\t");
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Поиск строки с минимальной суммой
int MinRow(int[,] array)
{
    int result = 1;
    int minSum = 0;
    int cash = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            cash += array[i, j];
        }
        if(i == 0) minSum = cash;
        else
        {
            if(cash < minSum)
            {
                result = i + 1;
                minSum = cash;
            }
        }
        cash = 0;
    }
    return result;
}

//Программа
int[,] matrix = new int[3,2];
matrix = FillArray(matrix, 0, 9);
PrintArray(matrix);
Console.WriteLine($"Ответ: {MinRow(matrix)} строка.");