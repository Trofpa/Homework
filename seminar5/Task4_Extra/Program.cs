/*Условие задачи:
4_Extra. Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
   
`[5, 18, 123, 6, 2] -> 1`  
`[1, 2, 3, 6, 2] -> 0`  
`[10, 11, 12, 13, 14] -> 5`

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
//Метод для поиска кол-во чисел в диапазоне
int FindCount(int[] array, int MinLimit, int MaxLimit)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if((array[i] >= MinLimit) && (array[i] <= MaxLimit)) result++;
    }
    return result;
}


//Программа

int[] example = GenArray(123, max: 200);
Console.WriteLine($"[{String.Join(", ", example)}] -> {FindCount(example, 10, 99)}");