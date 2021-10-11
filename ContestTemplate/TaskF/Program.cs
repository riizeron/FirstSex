using System;

public class Program
{
    private static SmallSquaredMatrix ReadMatrix()
    {
        int dimension = int.Parse(Console.ReadLine());
        int[][] matrix = new int[dimension][];
        for (int i = 0; i < dimension; ++i)
        {
            matrix[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        }

        return new SmallSquaredMatrix(matrix);
    }

    private static void PrintMatrix(SmallSquaredMatrix matrix)
    {
        for (int i = 0; i < matrix.Dimension; ++i)
        {
            for (int j = 0; j < matrix.Dimension; ++j)
            {
                Console.Write($"{matrix[i, j]} ");
            }

            Console.WriteLine();
        }
    }
    
    public static void Main(string[] args)
    {
        SmallSquaredMatrix first = ReadMatrix();
        SmallSquaredMatrix second = ReadMatrix();

        Console.WriteLine(first < second);
        Console.WriteLine(first > second);

        try
        {
            PrintMatrix(first - second);
        }
        catch (InvalidOperationException exception)
        {
            Console.WriteLine(exception.Message);
        }
        
        try
        {
            PrintMatrix(first + second);
        }
        catch (InvalidOperationException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}