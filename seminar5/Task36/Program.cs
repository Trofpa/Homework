/*Условие задачи:
№36. Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

`[3, 7, 23, 12] -> 19`
`[-4, -6, 89, 6] -> 0`

Автор: Трофимов П.А.
*/

//Методы:

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
//Суммирование элементов массива с нечетным индексом
int OddSum(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

//Программа
int size = InputNumber("Генерируем массив целых чисел..."
                        + "\nВведите размер массива: ");
int[] array = GenArray(size);
Console.WriteLine($"[{String.Join(", ", array)} -> {OddSum(array)}]\n");



