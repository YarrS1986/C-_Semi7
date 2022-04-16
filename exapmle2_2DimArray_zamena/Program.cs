// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1   4  7  2
// 5  81  2  9
// 8   4  2  4

Console.Clear();

int m = Promt("Введи количество строк(m) = ");
int n = Promt("Введи количество столбцов(n) = ");

int[,] matrix = FillArray(m, n);
PrintArray(matrix);

Console.WriteLine();

for (int i = 1; i < matrix.GetLength(0); i++)
{
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] *= matrix[i, j];
        j++;
    }
    i++;
}
PrintArray(matrix);

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