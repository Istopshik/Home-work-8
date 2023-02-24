// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
System.Console.Write("Введите количество строк: ");
int lines = SetNumber("lines");
System.Console.Write("Введите количество столбцов: ");
int columns = SetNumber("columns");
System.Console.Write("Введите максимальное число: ");
int maxNumbers = SetNumber("max");
System.Console.Write("Введите минимальное число: ");
int minNumbers = SetNumber("min");
var matrix = GetMatrix(lines, columns, maxNumbers, minNumbers);
PrintArray(matrix);

arratSort(matrix);
System.Console.WriteLine();



int SetNumber(string numberName)
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[,] GetMatrix(int lines, int columns, int maxNumbers, int minNumbers)
{
    int[,] matrix = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Convert.ToInt32(new Random().Next(minNumbers, maxNumbers));
        }
    }
    return matrix;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
void arratSort(int[,] matrix)
{
    int empty = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                if (matrix[i, j] > matrix[i, y])
                {
                    empty = matrix[i, y];
                    matrix[i, y] = matrix[i, j];
                    matrix[i, j] = empty;

                }

            }


        }

    }
    System.Console.WriteLine();
    PrintArray(matrix);
}

