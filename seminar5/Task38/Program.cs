/*Условие задачи:
№38. Задайте массив вещественных чисел. Найдите разницу между
максимальным и минимальным элементов массива.

`[3 7 22 2 78] -> 76`

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
            Console.WriteLine("Введенный символ не является целым числом!");
        }
    }
    return number;
}

//Создание массива вещественных чисел произвольной длины и диапазона модуля чисел
double[] GenArray(int Nelements, int AbsRange = 10)
{
    double[] array = new double[Nelements];
    for (int i = 0; i < array.Length; i++)
    {
        int multiplicant = AbsRange * Random.Shared.Next(-1, 2);
        while (multiplicant == 0)
        {
            multiplicant = AbsRange * Random.Shared.Next(-1, 2);
        }
        array[i] = Math.Round(Random.Shared.NextDouble() * multiplicant, 3);
    }
    Console.WriteLine($"\nСозданный массив: [{String.Join(", ", array)}]\n");
    return array;
}

//Метод для расчета разности максимального и минимального значения
double GetDiff(double[] array)
{
    return array.Max() - array.Min();
}

int size = InputNumber("Генерируем массив вещественных чисел..."
                    + "\nВведите размер массива: ");
int N = InputNumber("Введите абсолютный диапазон значений N -> [-N, +N]: ");
double[] array = GenArray(size, N);

Console.WriteLine($"[{String.Join(", ", array)}] -> {Math.Round(GetDiff(array), 3)}\n");

