/*Условие задачи:

Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
_Пример работы программы:_  
`A (3,6,8); B (2,1,-7), -> 15.84`
`A (7,-5, 0); B (1,-1,9) -> 11.53`


Автор: Трофимов П.А.
*/

//Вводим координаты точек A и B:
int[] Point1 = InputCoordinates("A");
int[] Point2 = InputCoordinates("B");

//Считаем расстояние и выводим ответ:
double distance = GetDistance(Point1, Point2);

Console.WriteLine($"А ({Point1[0]}, {Point1[1]}, {Point1[2]}); "
                + $"B ({Point2[0]}, {Point2[1]}, {Point2[2]})"
                + $"-> {distance:F2}");


//Методы:

int[] InputCoordinates(string text)
{
    bool Condition = true;
    int[] array = new int[3];
    for (int i = 0; i < array.Length; i++)
    {
        switch (i)
        {
            case 0:
                Condition = true;
                while (Condition)
                {
                    Console.WriteLine($"Введите координату X точки {text}: ");

                    if (int.TryParse(Console.ReadLine(), out array[i]))
                    {
                        Condition = false;
                    }
                    else
                    {
                        Console.WriteLine("Введенный символ не является числом!");
                    }
                }
                break;
            case 1:
                Condition = true;
                while (Condition)
                {
                    Console.WriteLine($"Введите координату Y точки {text}: ");

                    if (int.TryParse(Console.ReadLine(), out array[i]))
                    {
                        Condition = false;
                    }
                    else
                    {
                        Console.WriteLine("Введенный символ не является числом!");
                    }
                }
                break;
            case 2:
                Condition = true;
                while (Condition)
                {
                    Console.WriteLine($"Введите координату Z точки {text}: ");

                    if (int.TryParse(Console.ReadLine(), out array[i]))
                    {
                        Condition = false;
                    }
                    else
                    {
                        Console.WriteLine("Введенный символ не является числом!");
                    }
                }
                break;
        }

    }
    return array;
}


double GetDistance(int[] a, int[] b)
{
    double sum = 0;
    double result;
    for (int i = 0; i < a.Length; i++)
    {
        sum += Math.Pow(a[i] - b[i], 2);
    }
    result = Math.Sqrt(sum);
    return result;
}

