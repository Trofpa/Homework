/*Условие задачи
№43.  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

`b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)`

Автор: Трофимов П.А.

*/

//Методы
double InputNumber(string text)
{
    bool Condition = true;
    double number = 0;
    while (Condition)
    {
        Console.Write(text);
        if (double.TryParse(Console.ReadLine(), out number))
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

double[] InputLine(bool show = true)
{
    Console.WriteLine("Ввод прямой y = kx + b.\n");
    double[] result =
    {
    InputNumber("Введите коэффициент k: "),
    InputNumber("Введите коэффициент b: ")
    };
    if (show) Console.WriteLine($"\nВведена прямая {result[0]}x + {result[1]}"
                                +"\n-----------------------------------------");
    return result;
}

bool[] Intersection(double[] line1, double[] line2)
{
    bool[] result = new bool[2];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = line1[i] == line2[i];
    }
    return result;
}

double[] IntersPoint(double[] line1, double[] line2)
{
    double[] result = new double[2];
    result[0] = (line2[1] - line1[1]) / (line1[0] - line2[0]); // точка Х
    result[1] = (line1[0] * line2[1] - line1[1] * line2[0]) / (line1[0] - line2[0]); // точка Y
    return result;
}


//Программа

double[] line1 = InputLine();
double[] line2 = InputLine();

bool[] condition = Intersection(line1, line2);

if (condition[0])
{
    if (condition[1])
    {
        Console.WriteLine($"Прямые {line1[0]}x + {line1[1]} и "
                            + $"{line2[0]}x + {line2[1]} идентичны");
    }
    else
    {
        Console.WriteLine($"Прямые {line1[0]}x + {line1[1]} и "
                        + $"{line2[0]}x + {line2[1]} параллельны");
    }
}
else
{
    Console.WriteLine($"Пересечение {line1[0]}x + {line1[1]}"
                    + $" и {line2[0]}x + {line2[1]} -> "
                    + $"({String.Join("; ", IntersPoint(line1, line2)):N2)})");
}


