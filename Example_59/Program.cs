/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
*/

// Создаем двумерный массив на 4-6 строк, столбцов и случайными значениями внутри от 0 до 9  
Console.Clear();
Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
Console.WriteLine(" ");
double[,] matrix = new double[new Random().Next(4, 7), new Random().Next(4, 7)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(" " + matrix[i, j]);
    }
    Console.WriteLine(" ");
}
// Ищем минимальные значения
double min = 10;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (min > matrix[i, j])
            min = matrix[i, j];
    }
}
// Ищем максимальный индекс строки и столбца минимального значения
int strToCut = 0;
int columToCut = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (min == matrix[i, j])
        {
            strToCut = i;
            columToCut = j;
        }
    }
}
Console.WriteLine(" ");
Console.WriteLine("После удаления строк и столбцов по самому дальнему минимальному значению в двумерном массиве:");
Console.WriteLine(" ");
Print2dArray(Trim2dArray(strToCut, columToCut, matrix));

void Print2dArray(double[,] array2d){
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(" " + array2d[i, j]);
        }
        Console.WriteLine(" ");
    }
}


double[,] Trim2dArray(int rowToRemove, int columnToRemove, double[,] original2dArray)
{
    double[,] result = new double[original2dArray.GetLength(0) - 1, original2dArray.GetLength(1) - 1];

    for (int i = 0, j = 0; i < original2dArray.GetLength(0); i++)
    {
        if (i == rowToRemove)
            continue;

        for (int k = 0, u = 0; k < original2dArray.GetLength(1); k++)
        {
            if (k == columnToRemove)
                continue;

            result[j, u] = original2dArray[i, k];
            u++;
        }
        j++;
    }

    return result;
}