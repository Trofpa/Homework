/*Условие задачи:
№34. Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

`[345, 897, 568, 234] -> 2`

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

//Считает количество четных чисел в массиве
int EvenNumbers(int[] array)
{
    int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) result++;
}
return result;
}

//Ввод целых чисел в консоль
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

int size = InputNumber("Генерируем массив трехзначных чисел..."
                        + "\nВведите размер массива: ");
int[] array = GenArray(size, 100, 1000);
Console.WriteLine($"[{String.Join(", ", array)} -> {EvenNumbers(array)}]\n");

