/*
№29: Напишите метод, который задаёт 
массив из 8 элементов и выводит их на экран.

Пример работы программы:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

Автор: Трофимов П.А.
*/

//Метод:
int[] GenArray(int Nelements, int Arrange)
{
    int[] array = new int[Nelements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, Arrange + 1);
    }
    Console.WriteLine($"[{String.Join(", ", array)}]");
    return array;
}


//Программа для вызова массива из N элементов:

Console.WriteLine("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите диапазон значений: ");
int R = int.Parse(Console.ReadLine());

int [] ex = GenArray(Nelements: N, Arrange: R);