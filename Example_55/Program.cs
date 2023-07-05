// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//            В случае, если это невозможно, программа должна вывести сообщение для пользователя.


double[,] matrix = new double[new Random().Next(5, 7), new Random().Next(5, 7)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(" " + matrix[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
if(matrix.GetLength(0) != matrix.GetLength(1))
{
    Console.WriteLine("Строки и/или столбцы не совпадают по длине. Заменить не получится ");
    Environment.Exit(0);
}
double[,] newMatrix = new double[matrix.GetLength(0),matrix.GetLength(1)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1);j++)
    {
        newMatrix[j,i] = matrix[i,j];
    }
}
for (int l = 0; l < matrix.GetLength(0); l++)
{
    for (int m = 0; m < matrix.GetLength(1); m++)
    {
        Console.Write(" " + newMatrix[l, m]);
    }
    Console.WriteLine();
}