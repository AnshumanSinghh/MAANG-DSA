using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_9_CSharp
{
    class StrassenMatrixMultiplication
    {
        /// <summary>
        /// Efficient Algorithm to multiply two Matrices. 
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         Time Complexity: 7 * T(N/2) + N  ~= O(N ^(2.78))
        ///         <para>
        ///             Space Complexity: O(N) [Stack size for reccursion]
        ///         </para>
        ///     </para>
        /// </remarks>
        /// <param name="x">2D Array</param>
        /// <param name="y">2D Array</param>
        /// <param name="n">Length of Square matrix</param>
        /// <returns></returns>
        public int[,] Strassen(int[,] x, int[,] y, int n)
        {
            int[,] finalMatrix = new int[n,n];
            if (n == 1)
            {
                finalMatrix[0,0] = x[0,0] * y[0,0];
                return finalMatrix;
            }
            else
            {
                var mid = n / 2;
                // Splitting Matrix-A
                var a = GetSplittedMatrix(x, 0, mid, 0, mid); // Row(0, mid) , Column(0, mid) - 1st part
                var b = GetSplittedMatrix(x, 0, mid, mid, n); // Row(0, mid) , Column(mid, n) - 2nd part
                var c = GetSplittedMatrix(x, mid, n, 0, mid); // Row(mid, n) , Column(0, mid) - 3rd part
                var d = GetSplittedMatrix(x, mid, n, mid, n); // Row(mid, n) , Column(mid, n) - 4th part

                // Splitting Matrix-B
                var e = GetSplittedMatrix(y, 0, mid, 0, mid);
                var f = GetSplittedMatrix(y, 0, mid, mid, n);
                var g = GetSplittedMatrix(y, mid, n, 0, mid);
                var h = GetSplittedMatrix(y, mid, n, mid, n);

                // Create following 10 matrices (will be used to calculate P1, P2,..P7)
                var S1 = SubtractMatrix(f, h, mid);
                var S2 = AddMatrix(a, b, mid);
                var S3 = AddMatrix(c, d, mid);
                var S4 = SubtractMatrix(g, e, mid);
                var S5 = AddMatrix(a, d, mid);
                var S6 = AddMatrix(e, h, mid);
                var S7 = SubtractMatrix(b, d, mid);
                var S8 = AddMatrix(g, h, mid);
                var S9 = SubtractMatrix(a, c, mid);
                var S10 = AddMatrix(e, f, mid);

                // Computing the 7 products, recursively (p1, p2,...p7)
                var p1 = Strassen(a, S1, mid);   // a, (f - h)
                var p2 = Strassen(S2, h, mid);   // (a + b), h
                var p3 = Strassen(S3, e, mid);   // (c + d), e
                var p4 = Strassen(d, S4, mid);   // d, (g - e)
                var p5 = Strassen(S5, S6, mid);  // (a + d), (e + h)
                var p6 = Strassen(S7, S8, mid);  // (b - d), (g + h)
                var p7 = Strassen(S9, S10, mid); // (a - c), (e + f)

                // Computing Result matrices
                // as C00 = p5 + p4 - p2 + p6 = p5 + p4 - (p2 - p6)
                var C00 = SubtractMatrix(AddMatrix(p5, p4, mid), SubtractMatrix(p2, p6, mid), mid); 

                var C01 = AddMatrix(p1, p2, mid);
                var C10 = AddMatrix(p3, p4, mid);

                // as C11 = p1 + p5 - p3 - p7 = p1 + p5 - (p3 + p7)
                var C11 = SubtractMatrix(AddMatrix(p1, p5, mid), AddMatrix(p3, p7, mid), mid);

                // Filing finalMatrix from Result Matrices (C00, C01, C10. C11)
                for (int i = 0; i < mid; i++)
                {
                    for (int j = 0; j < mid; j++)
                    {
                        finalMatrix[i, j] = C00[i, j];
                        finalMatrix[i, j + mid] = C01[i, j];
                        finalMatrix[mid + i, j] = C10[i, j];
                        finalMatrix[i + mid, j + mid] = C11[i, j];
                    }
                }
            }
            return finalMatrix;
        }

        private int[,] GetSplittedMatrix(int[,] matrix, int startRow, int endRow, int startCol, int endCol)
        {
            int[,] splittedMatrix = new int[endRow - startRow,endRow - startRow];

            for (int row = startRow; row < endRow; row++)
            {
                for (int col = startCol; col < endCol; col++)
                {
                    splittedMatrix[row-startRow,col-startCol] = matrix[row,col];
                }
            }
            return splittedMatrix;
        }

        private int[,] AddMatrix(int[,] matrix_A, int[,] matrix_B, int split_index)
        {
            var matrix_C = new int[split_index, split_index];
            for (int i = 0; i < split_index; i++)
            {
                for (int j = 0; j < split_index; j++)
                {
                    matrix_C[i, j] = matrix_A[i,j] + matrix_B[i,j];
                }
            }
            return matrix_C;
        }

        private int[,] SubtractMatrix(int[,] matrix_A, int[,] matrix_B, int split_index)
        {
            var matrix_C = new int[split_index, split_index];
            for (int i = 0; i < split_index; i++)
            {
                for (int j = 0; j < split_index; j++)
                {
                    matrix_C[i,j] = matrix_A[i, j] - matrix_B[i, j];
                }
            }
            return matrix_C;
        }
    }
}
