/*Условия задачи:
54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:

`1 4 7 2`
`5 9 2 3`
`8 4 2 4`

В итоге получается вот такой массив:

`7 4 2 1`
`9 5 3 2`
`8 4 4 2`

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
//Метод сортировки строк
int[,] SortArray(int[,] array)
{
    bool condition = true;
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        do
        {
            condition = false;
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    condition = true;
                    temp = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = temp;
                }
            }
        } while (condition);
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
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Программа
Console.Clear();
int[,] matrixOld = new int[6, 5];
matrixOld = FillArray(matrixOld, max:9);
PrintArray(matrixOld, "Начальная матрица: ");
SortArray(matrixOld);
PrintArray(matrixOld, "Отсортированная матрица: ");

