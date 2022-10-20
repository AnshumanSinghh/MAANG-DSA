using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_9_CSharp
{
    class MatrixMultiplication
    {
        /*
         * Time Complexity:
         * We are doing 8 times multiplication (see Line 64 to 67) of Matrix having size n/2. So, recurrence
         * relation will be 8*T(n/2).
         * Also, we are adding matrices which will take O(N^2) time.
         * So, Over all reccurrence relation T(N) = 8 * T(N/2) + N
         * On solving using master's theorem we will get Worst Time complexity = O(N^3). Which is similar to Naive approach
         * (using 2 for loops to multiply the matrix).
         * 
         * Intuition:
         * We will divide the Square Matrix in two equal halves.
         * Ex:- {       |
                { 1, 1, | 1, 1 },
                { 2, 2, | 2, 2 },
           _ _ _ _ _ _ _ _ _ _ _ _  _
                { 3, 3, | 3, 3 },
                { 2, 2, | 2, 2 }
                        |
               };
         * Matrix-A and Matrix-B wil be divided in sane way. Now treat every sub-matrix (2x2 matrix) as one element now
         * Let A00 = {1, 1}
         *           {2, 2}
         * After dividing Matrix-A and Matrix-B we will have:
         * A = {                                    B = { 
         *       {A00, A01},                              {B00, B01},
         *       {A10, A11}                               {B10, B11}
         *     }                                        }
         *     
         * result_matrix = {
         *                  {C00, C01}, 
         *                  {C10, C11}
         *                 }
         *                 
         * Now, we can say that 
         * C00 = A00 * B00 + A01 * B10
         * C01 = A00 * B00 + A01 * B10
         * C10 = A00 * B00 + A01 * B10
         * C11 = A00 * B00 + A01 * B10
         * 
         * Here + (plus sign) indicates Matrix Addition not simple addition.
         * We know that smallest subproblem of multiplying can be if we have two matrix of size 1. Then,
         * we can directly return A00 * B00. We will use these things only to apply divide and
         * conquer to multiply two matrices.
         */
        public int[,] Multiply(int[,] arrayA, int[,] arrayB, int n)
        {
            int[,] finalMatrix = new int[n, n];
            if (n == 1)
            {
               finalMatrix[0, 0] = arrayA[0, 0] * arrayB[0, 0];
            }
            else
            {
                var split_idx = n / 2;
                var temp = new int[split_idx];

                // Result Matrix
                int[,] C00 = new int[split_idx, split_idx];            
                int[,] C01 = new int[split_idx, split_idx];            
                int[,] C10 = new int[split_idx, split_idx];            
                int[,] C11 = new int[split_idx, split_idx];

                // Splitted Matrix / Sub-Matrix
                // Of Matrix A
                int[,] A00 = new int[split_idx, split_idx];
                int[,] A01 = new int[split_idx, split_idx];
                int[,] A10 = new int[split_idx, split_idx];
                int[,] A11= new int[split_idx, split_idx];

                // Of Matrix B
                int[,] B00 = new int[split_idx, split_idx];
                int[,] B01 = new int[split_idx, split_idx];
                int[,] B10 = new int[split_idx, split_idx];
                int[,] B11 = new int[split_idx, split_idx];


                // Filling values to Matrix A and Matrix B
                for (int i = 0; i < split_idx; i++)
                {
                    for (int j = 0; j < split_idx; j++)
                    {
                        A00[i, j] = arrayA[i, j];
                        A01[i, j] = arrayA[i, j + split_idx];
                        A10[i, j] = arrayA[split_idx + i, j];
                        A11[i, j] = arrayA[i + split_idx, j + split_idx];
                        B00[i, j] = arrayB[i, j];
                        B01[i, j] = arrayB[i, j + split_idx];
                        B10[i, j] = arrayB[split_idx + i, j];
                        B11[i, j] = arrayB[i + split_idx, j + split_idx];
                    }
                }

                // Adding Matrices to get the final result
                AddMatrix(Multiply(A00, B00, split_idx), Multiply(A01, B10, split_idx), C00, split_idx);
                AddMatrix(Multiply(A00, B01, split_idx), Multiply(A01, B11, split_idx), C01, split_idx);
                AddMatrix(Multiply(A10, B00, split_idx), Multiply(A11, B10, split_idx), C10, split_idx);
                AddMatrix(Multiply(A10, B01, split_idx), Multiply(A11, B11, split_idx), C11, split_idx);

                // Filing finalMatrix from Result Matrices (C00, C01, C10. C11)
                for (int i = 0; i < split_idx; i++)
                {
                    for (int j = 0; j < split_idx; j++)
                    {
                        finalMatrix[i, j] = C00[i, j];
                        finalMatrix[i, j + split_idx] = C01[i, j];
                        finalMatrix[split_idx + i, j] = C10[i, j];
                        finalMatrix[i + split_idx, j + split_idx] = C11[i, j];
                    }
                }
            }
            return finalMatrix;
        }

        private void AddMatrix(int[,] matrix_A, int[,] matrix_B, int[,] matrix_C, int split_index)
        {
            for (int i = 0; i < split_index; i++)
            {
                for (int j = 0; j < split_index; j++)
                {
                    matrix_C[i, j] = matrix_A[i, j] + matrix_B[i, j];
                }
            }
        }
    }
}
