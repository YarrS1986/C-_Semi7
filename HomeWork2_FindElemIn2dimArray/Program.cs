// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.Clear();

int m = Promt("Введи количество строк(m) = ");
int n = Promt("Введи количество столбцов(n) = ");

int[,] matrix = FillArray(m, n);
PrintArray(matrix);
Console.WriteLine();

FindElement(matrix, Promt("Введи номер строки = "), Promt("Введи номер столбца = "));


//--------------------------------------------
int FindElement(int[,] arr, int elementM, int elementN)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (elementM == i && elementN == j)
            {
                Console.Write($"{matrix[i, j]}");
                goto End;
            }
        }
    }
    Console.Write("Такого числа в массиве нет!");
End:
    return elementM;
}

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
            array[i, j] = rnd.Next(0, 10);
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