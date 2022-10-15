/*Условие задачи:
3_Extra. Напишите программу замена элементов массива: положительные
элементы замените на соответствующие отрицательные, и наоборот.

`[-4, -8, 8, 2] -> [4, 8, -8, -2] `

Автор: Трофимов П.А.
*/

//Методы
//Создание целочисленного массива произвольной длины и диапазона целых чисел
int[] GenArray(int Nelements, int min = 0, int max = 100)
{
    int[] array = new int[Nelements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    // Console.WriteLine($"\nСозданный массив: [{String.Join(", ", array)}]\n");
    return array;
}

//Меняем знак числа
int[] Reverse(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

int[] example = GenArray(10, -10, 10);
Console.WriteLine($"[{String.Join(", ", example)}] -> "
                + $"[{String.Join(", ", Reverse(example))}]");
