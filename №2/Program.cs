
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, columns];
Random random = new Random();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = random.Next(10); 
    }
}

Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);

int[] temp = new int[columns];
for (int j = 0; j < columns; j++)
{
    temp[j] = matrix[0, j];
    matrix[0, j] = matrix[rows - 1, j];
    matrix[rows - 1, j] = temp[j];
}

Console.WriteLine("Измененный массив:");
PrintMatrix(matrix);
Console.ReadLine();

static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}