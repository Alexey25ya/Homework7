//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами. m = 3, n = 4.

double[,] gatArray(int mLocal, int nLocal, int min, int max)
{
    double[,] result = new double[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = Convert.ToDouble(new Random().Next(min, max + 1)/10.0);
        }
    }
    return result;
}

void printArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} |");
        }
        Console.WriteLine();
    }
}

int m = 3;
int n = 4;
int min=-100;
int max=100;
double [,] array = gatArray(m, n, min, max);
printArray(array);