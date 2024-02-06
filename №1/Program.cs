Console.Clear();
Console.WriteLine("Введите количество строк:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, columns];
Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(1, 100);
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

    Console.WriteLine("Введите позицию элемента (строка столбец):");
    string[] position = Console.ReadLine().Split(' ');
    int row = int.Parse(position[0]);
    int column = int.Parse(position[1]);
        if (row >= 0 && row < rows && column >= 0 && column < columns)
        {
            int element = matrix[row, column];
            Console.WriteLine("Значение элемента: " + element);
        }
        else
        {
            Console.WriteLine("Такого элемента нет в матрице.");
        }