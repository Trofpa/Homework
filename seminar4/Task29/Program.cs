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


//Программа для вызова массива из  элементов:
int [] ex = GenArray(Nelements: 8, Arrange: 50);