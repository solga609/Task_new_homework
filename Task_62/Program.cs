﻿class Program
{
    public static void Main()
    {
        int rows = 5, cols = 5;
        int[,] array = new int[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                array[i, j] = i * cols + (i % 2 == 0 ? j : cols - j - 1);
        PrintArray(array);
    }
 
    static void PrintArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
                Console.Write(arr[i, j] + " ");
            Console.WriteLine();
        }
    }
}

