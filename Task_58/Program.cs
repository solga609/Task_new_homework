﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
        
            int[,] m1 = new int[3, 3];
            int[,] m2 = new int[3, 3];
            int[,] m3 = new int[3, 3];
 
            m1[0,0] = 12;
            m1[0,1] = 1;
            m1[0,2] = 122;
 
            m1[1,0] = 45;
            m1[1,1] = 65;
            m1[1,2] = 67;
 
            m1[2,0] = 19;
            m1[2,1] = 34;
            m1[2,2] = 56;
 
 
            m2[0,0] = 12;
            m2[0,1] = 1;
            m2[0,2] = 122;
 
            m2[1,0] = 45;
            m2[1,1] = 65;
            m2[1,2] = 67;
 
            m2[2,0] = 19;
            m2[2,1] = 34;
            m2[2,2] = 56;
            int j;
            for (int i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    m1[i, j] = m1[i, j] * m2[i, j];
                    Console.Write(m1[i, j]);
                    Console.WriteLine("\n");
                }
                j = 0;
            }
            Console.ReadKey();
        
