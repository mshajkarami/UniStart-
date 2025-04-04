using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            [,] int matrix1 = [[2, 5], [3, 1], [5, 2]];
            [,] int matrix2 = [[2, 5, 1], [3, 1, 2]];
            [,] int matrixResult = newint[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        matrixResult[i,k] += matrix1[i,j] * matrix2[j,k]
                    }
                }
            }

    }
}
