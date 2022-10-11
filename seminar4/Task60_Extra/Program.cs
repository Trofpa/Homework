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

//Одномерный случай:
/*
int[] GenArray()
{
    Console.WriteLine("Создаем массив целых чисел."
    + "\nСколько хотите элементов в массиве?"
    + "\nВведите целое число: ");
    int length = int.Parse(Console.ReadLine());
    int [] array = new int[length];

    Console.WriteLine("\nДо какого диапазона значения?");
    int Numbs = int.Parse(Console.ReadLine());

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, Numbs + 1);
    }
    Console.WriteLine($"Сгенерированный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("  "+ $"{array[i]}");
    }
    return array;
}

int[] HowManyTimes(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    
    int[] AddArray = new int[max + 1];
    for (int i = 0; i < AddArray.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if(array[j] == i)
            {
                AddArray[i]++;
            }
        }
    }
    return AddArray;
}

void PrintResult(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
{
    if(array[i] != 0) Console.WriteLine($"Количество {i} - {array[i]} раза;");
}
}


int[] array1 = GenArray();

int[] array2 = HowManyTimes(array1);

PrintResult(array2);

*/

