/* Условие задачи
58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица:
18 20
15 18

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
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

//Метод для произведения
int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] res = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Матрицы не перемножаются");
    }
    else
    {
        for (int i = 0; i < res.GetLength(0); i++)
        {
            for (int j = 0; j < res.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    res[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return res;
}


//Программа
Console.Clear();
int m1_a = 3; // - количество рядов матрицы 1
int m1_b = 3; // - количество столбцов матрицы 1
int m2_a = 3; // - количество рядов матрицы 2
int m2_b = 3; // - количество столбцов матрицы 2
int[,] matrix1 = new int[m1_a, m1_b];
int[,] matrix2 = new int[m2_a, m2_b];

matrix1 = FillArray(matrix1);
matrix2 = FillArray(matrix2);

PrintArray(matrix1, "матрица 1: ");
Console.WriteLine();
PrintArray(matrix2, "матрица 2: ");
Console.WriteLine();
PrintArray(MultiplyMatrix(matrix1, matrix2), "Произведение: ");