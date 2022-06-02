// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int GetNumber (string msg)
{
    Console.WriteLine(msg);
    string ValueFromConsole = Console.ReadLine();
    if (int.TryParse(ValueFromConsole, out int num))
    {
        return num;
    }
    else 
    {
        Console.WriteLine("Вы ввели не число, попробуйте еще раз!");
    }
    return num;
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10); // [1;10)
        }
    }
}

void PrintArray(int [,] matrix)
{
    for (int a = 0; a < matrix.GetLength(0); a++)
    {
        for (int b = 0; b < matrix.GetLength(1); b++)
        {
            Console.Write($"{matrix[a,b]} ");
        }
        Console.WriteLine();
    }
}

int DiagonalSumm(int [,] matrix)
{
    int summ = 0;
    for (int c = 0; c < matrix.GetLength(0); c++)
    {
        for (int d = 0; d < matrix.GetLength(1); d++)
        {
            if(c==d)
            {
                summ += matrix[c,d];
            }
        }
    }
    return summ;
}

string message1 = "Введите количество строк: ";
string message2 = "Введите количество рядов: ";
int m = GetNumber(message1);
int n = GetNumber(message2);

int [,] matrix = new int [m,n];
FillArray(matrix);
PrintArray(matrix);
int result = DiagonalSumm(matrix);
Console.WriteLine(result);

