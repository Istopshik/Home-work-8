// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
Console.Clear();
System.Console.Write("Введите количество строк которые будут в 2 матрицах: ");
int lines = SetNumber("lines");
System.Console.Write("Введите количество столбцов которые будут в 2 матрицах: ");
int columns = SetNumber("columns");
System.Console.Write("Введите максимальное число которое будет в 2 матрицах: ");
int maxNumbers = SetNumber("max");
System.Console.Write("Введите минимальное число которое будет в 2 матрицах: ");
int minNumbers = SetNumber("min");
var matrix1 = GetMatrix(lines, columns, maxNumbers, minNumbers);
PrintArray(matrix1);
System.Console.WriteLine();
var matrix2 = GetMatrix(lines, columns, maxNumbers, minNumbers);
PrintArray(matrix2);
System.Console.WriteLine();
ResultArray(matrix1, matrix2);


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
void ResultArray(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            System.Console.Write((resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j]) + " ");
        }
        System.Console.WriteLine();
    }
}
