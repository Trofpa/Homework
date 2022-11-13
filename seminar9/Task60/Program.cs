/*
## Задача 60:  
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.  

Пример: Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0) 
34(1,0,0) 41(1,1,0)  
27(0,0,1) 90(0,1,1) 
26(1,0,1) 55(1,1,1) 


Автор: Трофимов П.А.

*/
//Метод для заполнения массива
int[,,] FillArray(int[,,] array, int min, int max)
{
    List<int> numbers = new List<int>();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = Random.Shared.Next(min, max + 1);
                while (numbers.Contains(array[i, j, k]))
                {
                    array[i, j, k] = Random.Shared.Next(min, max + 1);
                }
                numbers.Add(array[i, j, k]);
            }
        }
    }
    return array;
}


//Метод для отображения массива с добавлением индексов
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


//Программа
int[,,] matrix = new int[2, 2, 2];

matrix = FillArray(matrix, 10, 99);
PrintArray(matrix);
Console.WriteLine();