/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
убыванию элементы каждой строки двумерного массива.
*/
int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n]; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); 
        }

        Console.WriteLine(); 
    }
}


int rows = 4;

int columns = 4;

Console.WriteLine("Дан массив 4х4:");

int[,] result = GetMatrix(rows, columns, 1, 10); // Создали матрицу
PrintMatrix(result);

int[,] ChangeMatrix(int[,] matrix)
{
    for (int c = 0; c < matrix.GetLength(0); c++)
            {
                for (int j = 0; j < matrix.GetLength(1) ;j++ )
                {
                    for (int i = 0; i < matrix.GetLength(1)-1; i++)
                    {
                        if (c % 2 == 0)
                        {
                            if (matrix[c, i] < matrix[c, i + 1])//по-убыванию
                            {
                                int tmp = matrix[c, i];
                                matrix[c, i] = matrix[c, i + 1];
                                matrix[c, i + 1] = tmp;
                            }
                        }
                        
                    }
                }
            }
    return matrix;
}
System.Console.WriteLine();
PrintMatrix(ChangeMatrix(result));
*/

