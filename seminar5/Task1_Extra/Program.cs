/*Условие задачи:
1_Extra. Задайте массив из 12 элементов, заполненный случайными числами из
промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

[3,9,-8,1,0,-7,2,-1,8,-3,-1,6] -> сумма положительных чисел равна 29,
сумма отрицательных равна -20.

Автор: Трофимов П.А.
*/

//Методы:
//Создание целочисленного массива произвольной длины и диапазона целых чисел
int[] GenArray(int Nelements, int min = 0, int max = 100)
{
    int[] array = new int[Nelements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine($"\nСозданный массив: [{String.Join(", ", array)}]\n");
    return array;
}

//Нахождение сумм
int[] GetSums(int[] array)
{
    int[] result = new int[2];
    for (int i = 0; i < result.Length; i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if(array[j] >= 0) result[i] += array[j];
            }
        }
        else
        {
            for (int j = 0; j < array.Length; j++)
            {
                if(array[j] < 0) result[i] += array[j];
            }
        }
    }
    return result;
}


int[] example = GenArray(12, -9, 9);
int[] answer = GetSums(example);
Console.WriteLine($"[{String.Join(", ", example)}] ->"
                + $"сумма положительных чисел равна {answer[0]}, "
                + $"сумма отрицательных равна {answer[1]},");
