//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int m = Promt("Введи количество строк(m) = ");
int n = Promt("Введи количество столбцов(n) = ");

int[,] matrix = FillArray(m, n);
PrintArray(matrix);

Console.WriteLine();

//мой вариант решения (Преподаватель: Первый цикл надо делать по второму индексу,
//и непонятно, как вы вычисляете среднее по строкам, если делите на длину результирующего массива? 
//Также непонял, зачем вам три вложенных цикла.)
double[] averageSum = new double[m];
Console.WriteLine($"Сумма по каждой строке = ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int k = 0; k < 1; k++)
    {
        double Sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum = Sum + matrix[i, j];
        }
        averageSum[k] = Sum / averageSum.Length;
        Console.Write($"{averageSum[k]:0.00}\t ");
    }
}

//вариант решения преподавателя
double[] averageSum = new double[matrix.GetLength(1)];
Console.WriteLine($"Сумма по каждой колонке = ");
for (int i = 0; i < matrix.GetLength(1); i++)
{
    double Sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        Sum = Sum + matrix[j, i];
    }
    averageSum[i] = Sum / matrix.GetLength(0);
    Console.Write($"{averageSum[i]:0.00}\t ");
}




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