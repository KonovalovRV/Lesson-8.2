// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void Fillcoll(int[,] mat, int minValue, int maxValue)
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

void PrintMatr(int[,] col)
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

void PrintArray(int[] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        System.Console.Write($"{coll[i]}   ");
    }
    System.Console.WriteLine();
}

int[] SumElementsLine(int[,] coll)
{
    int[] col = new int[coll.GetLength(0)];
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            sum += coll[i, j];
            col[i] = sum;
        }
    }
    return col;
}

void FindMinSumLine(int[] coll)
{
    int min = coll[0];
    int i = 0;
    int curentindex = i;
    for (i = 0; i < coll.Length; i++)
    {
        if (coll[i] < min)
        {
            min = coll[i];
            curentindex = i;
        }
    }
    Console.WriteLine(
        $"Наименьшая сумма элементов в двумерном массиве равна -->({min}) и находится в -->({curentindex + 1}) строке"
    );
}

int line = Prompt("Введите количество строк матрицы   ");
int column = Prompt("Введите количество столбцов матрицы   ");
System.Console.WriteLine();

int[,] matr = new int[line, column];

Fillcoll(matr, 1, 10);
System.Console.WriteLine("Двумерный массив");
PrintMatr(matr);
System.Console.WriteLine();

int[] array = SumElementsLine(matr);
System.Console.WriteLine("Суммы элементов по строкам двумерного массива");
PrintArray(array);
System.Console.WriteLine();
FindMinSumLine(array);
