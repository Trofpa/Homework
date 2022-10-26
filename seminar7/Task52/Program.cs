/*Условие задачи
№52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Автор: Трофимов П.А.
*/

//Метод для заполнения двумерного массива случайными целыми числами от 0 до range
int[,] FillArray(int[,] array, int range = 10)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, range + 1);
        }
    }
    return array;
}

//Метод отображения массива
void PrintArray(int[,] array, string text = "\nСгенерированный массив: \n")
{
    Console.WriteLine(text);
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Метод нахождения ср. арифм.
double[] SrArifm(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result[i] += matrix[j, i];
        }
        result[i] /= matrix.GetLength(0);
    }
    return result;
}

//Программа
int[,] matr = new int[5, 5];
matr = FillArray(matr);
PrintArray(matr);
Console.WriteLine();
Console.WriteLine($"Ответ -> [{String.Join(", ", SrArifm(matr))}]");
