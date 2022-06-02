// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // function.GetLength(0/1) - узнаем длину массива 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine(); // заполнили строку и перешли на новую
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1;10)
        }
    }
}
int[,] matrix = new int[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);