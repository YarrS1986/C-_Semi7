// Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2

// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();

int m = Promt("Введи количество строк(m) = ");
int n = Promt("Введи количество столбцов(n) = ");

int[,] matrix = FillArray(m, n);
PrintArray(matrix);

Console.WriteLine();

int sum = 0;
Console.Write($"Сумма элементов главной диагонали = ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == j)
        {
            sum = matrix[i, j] + sum;
            Console.Write($"{matrix[i, j]} + ");
        }
    }
}
Console.Write($" = {sum}");

//--------------------------------------------
int Promt(string message)
{
    Console.Write(message);
    string mess = Console.ReadLine();
    int answer = int.Parse(mess);
    return answer;
}

int[,] FillArray(int row, int collumns)
{
    int[,] array = new int[row, collumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}