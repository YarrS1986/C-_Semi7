// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.
// Пример, m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();

int m = Promt("Введи количество строк(m) = ");
int n = Promt("Введи количество столбцов(n) = ");

int[,] matrix = FillArray(m, n);
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