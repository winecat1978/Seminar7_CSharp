//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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
            matrix[i,j] = new Random().Next(1,10);
        }
    }
}

void RefillArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(((i+1)%2==0) && ((j+1)%2==0) && (i > 0) && (j > 0))
            {
                matrix[i,j] = matrix[i,j]*matrix[i,j];
            }
        }
    }
}

void PrintArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

string message1 = "Введите количество строк: ";
string message2 = "Введите количество рядов: ";
int m = GetNumber(message1);
int n = GetNumber(message2);

int [,] matrix = new int [m,n];

FillArray(matrix);
PrintArray(matrix);
RefillArray(matrix);
Console.WriteLine();
PrintArray(matrix);