/*
**№50:** Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.

_Например, задан массив:_  
`1 4 7 2`  
`5 9 2 3`  
`8 4 2 4`  

`17 -> такого числа в массиве нет`
*/

//Поиск значения на нужной позиции
string Find(int[,] array, string position)
{
    string result;
    string[] positions = position.Split(',', 2);
    int row = Convert.ToInt16(positions[0]);
    int col = Convert.ToInt16(positions[1]);
    if((row > array.GetLength(0) - 1) || (col > array.GetLength(1) - 1))
    {
        result = "такого числа в массиве нет";
    }
    else
    {
        result = array[row, col].ToString();
    }
    return result;
}

//Программа
int[,] matrix = 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

Console.WriteLine("Задан массив.\nВведите номер ряда и столбца элемента через запятую: ");
string message = Console.ReadLine();
Console.WriteLine($"Позиция {message} -> {Find(matrix, message)}");
