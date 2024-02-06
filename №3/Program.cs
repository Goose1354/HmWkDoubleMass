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
        matrix[i, j] = random.Next(1, 10);
    }
}

Console.WriteLine("Матрица:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

int minSum = int.MaxValue;
int minSumRowIndex = -1;
for (int i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum += matrix[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        minSumRowIndex = i;
    }
}

Console.WriteLine("Строка с наименьшей суммой элементов: ");
for (int j = 0; j < columns; j++)
{
    Console.Write(matrix[minSumRowIndex, j] + " ");
}