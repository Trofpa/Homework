/*Условие задачи:
5_Extra. Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.

`[1 2 3 4 5] -> 5 8 3  
`[6 7 3 6] -> 36 21

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

int[] Sums(int[] array)
{
    int half = array.Length / 2;
    int[] result = new int[half];
    for (int i = 0; i < half; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if(array.Length % 2 == 1)
    {
        Array.Resize(ref result, result.Length + 1);
        result[result.Length - 1] = array[half];
    }

    return result;
}

int[] example = GenArray(5, max: 20);
int[] multiply = Sums(example);
Console.WriteLine($"\n[{String.Join(", ", example)}] -> {String.Join(" ", multiply)} \n");













