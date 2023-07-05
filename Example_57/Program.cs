/*
* Задача 57: 
* Составить частотный словарь элементов двумерного массива.
* Частотный словарь содержит информацию о том, сколько раз встречается 
* элемент входных данных.
*/

Console.Clear();
Console.WriteLine("Случайный массив содержит следущие значения:");
Console.WriteLine(" ");
double[,] matrix = new double[new Random().Next(8,17),new Random().Next(8,17)];
for(int i = 0; i < matrix.GetLength(0);i++)
{
    for(int j = 0; j < matrix.GetLength(1);j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(" " + matrix[i,j]);
    }
    Console.WriteLine(" ");
}
int Temporary;
do
{
Console.WriteLine(" ");

    Console.Write("Введите 11 для выхода): ");
    Temporary = Convert.ToInt32(Console.ReadLine());
    int count = 0;
for(int i = 0; i < matrix.GetLength(0);i++)
{
    for(int j = 0; j < matrix.GetLength(1);j++)
    {
        if(Temporary == matrix[i,j])
            count++;
    }
}
Console.WriteLine("Данное число встречается " + count + " раз");
}
while(Temporary != 11);

