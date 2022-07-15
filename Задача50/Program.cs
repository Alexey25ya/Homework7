// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] getArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(1, 11);
        }
    }
    return result;
}

void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void findArrayElement(int[,] array1)
{
    Console.WriteLine("Введите номер строки:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца:");
    int y = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (i == x-1 && j == y-1)
            {
                Console.WriteLine($"Элемент с такими индексами равен {array1[i, j]} ");
            }
        }
    }
    if (x >array1.GetLength(0) || y > array1.GetLength(1))
    {
        Console.Write("Элемента с такими индексами в массиве нет");
    }
}
int m = 5;
int n = 6;
int[,] array = getArray(m, n);
printArray(array);
findArrayElement(array);