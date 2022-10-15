/*Условие задачи:
2_Extra. Задайте массив. Напишите программу,
которая определяет, присутствует ли заданное число в массиве.

`4; массив [6, 7, 19, 345, 3] -> нет`   
`-3; массив [6, 7, 19, 345, 3] -> да`

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

bool Search(int[] array, int number)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number) result = true;
    }
    return result;
}

//Программа
int size = InputNumber("Создаем массив..."
                        + "\nВведите размер массива: ");
int range = InputNumber("Введите диапазон значений массива: ");

int[] array = GenArray(size, max: range);

int N = InputNumber("Введите число для поиска: ");

string text = $"\n{N}; массив [{String.Join(", ", array)}] -> ";

if(Search(array, N)) text += "да \n";
else text += "нет \n";

Console.WriteLine(text);
