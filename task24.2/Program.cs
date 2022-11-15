// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки
// двумерного массива.


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

void PrintArray(int[,] col)
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

int[,] DecreasingOrder(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int index = 0; index < coll.GetLength(1); index++)
        {
            int max = coll[i, index];
            for (int j = index; j < coll.GetLength(1); j++)
            {
                if (coll[i, j] > coll[i, index])
                {
                    int temp = coll[i, index];
                    coll[i, index] = coll[i, j];
                    coll[i, j] = temp;
                }
            }
        }
    }
    return coll;
}

int line = Prompt("Введите количество строк матрицы   ");
int column = Prompt("Введите количество столбцов матрицы   ");
System.Console.WriteLine();

int[,] matr = new int[line, column];
Fillcoll(matr, 1, 10);
System.Console.WriteLine("Матрица");
PrintArray(matr);
System.Console.WriteLine();
System.Console.WriteLine("Сортированная по убыванию матрица");
int[,] arrrr = DecreasingOrder(matr);
PrintArray(arrrr);
