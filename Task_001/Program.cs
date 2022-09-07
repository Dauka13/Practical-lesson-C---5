// Показать двумерный массив размером m×n заполненный вещественными числами

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] FillMatrix(int rows, int columns, int minNum, int maxNum)
{
    double[,] matrix = new double[rows, columns];
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(minNum, maxNum + 1) + random.NextDouble();
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int linesMatrix = InputNumber("Enter number of lines: ");
int columnsMatrix = InputNumber("Enter number of columns: ");

int minNumber = InputNumber("Minimum number: ");
int maxNumber = InputNumber("Maximum number: ");

double[,] realMatrix = FillMatrix(linesMatrix,columnsMatrix, minNumber, maxNumber);

Console.WriteLine("Array: ");
PrintMatrix(realMatrix);