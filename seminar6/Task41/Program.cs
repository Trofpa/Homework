/* Условие задачи
41.  Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

`0, 7, 8, -2, -2 -> 2`
`1, -7, 567, 89, 223-> 3`

Автор: Трофимов П.А.

*/

//Методы

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

int[] FillString(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = InputNumber($"Введите {i + 1}-е число: ");
    }
    return result;
}

int CountPos(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}


//Программа:
int N = InputNumber("Сколько чисел вы хотите ввести: ");

int[] array = FillString(N);

Console.WriteLine("Счет положительных чисел..."
                + $"\n{String.Join(", ", array)} -> {CountPos(array)}");