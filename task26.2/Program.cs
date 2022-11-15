// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void FillMatrix(int[,] mat, int minValue, int maxValue)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Random rnd = new Random();
            mat[i, j] = rnd.Next(minValue, maxValue);
        }
    }
}

void PrintMatrix(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            System.Console.Write($"{col[i, j]}   ");
        }
        System.Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] collect, int[,] matrix)
{
    int[,] collection = new int[collect.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < collect.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                {
                    collection[i, j] += collect[i, k] * matrix[k, j];
                }
            }
        }
    }
    return collection;
}

int line = Prompt("Введите количество строк матрицы   ");
int column = Prompt("Введите количество столбцов матрицы   ");

int[,] matr = new int[line, column]; // в данном варианте ввода количества строк и колонок валидация не требуется,
int[,] matrr = new int[column, line]; // правило - количество строк первой матрицы должно быть равно количеству

// столбцов 2 матрицы будет соблюдаться всегда.

FillMatrix(matr, 1, 10);
FillMatrix(matrr, 1, 10);
System.Console.WriteLine("Первая матрица");
PrintMatrix(matr);
System.Console.WriteLine();
System.Console.WriteLine("Вторая матрица");
PrintMatrix(matrr);
System.Console.WriteLine();
System.Console.WriteLine("Произведение первой и второй матриц");
int[,] arr = MultiplyMatrix(matr, matrr);
PrintMatrix(arr);
