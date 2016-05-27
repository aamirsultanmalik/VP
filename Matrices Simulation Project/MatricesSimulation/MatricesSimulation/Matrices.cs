using System;
using System.IO;
using System.Windows.Forms;

namespace MatricesSimulation
{
    class Matrices 
    {
        
       public int rows=0, columns=0;
        public void convertToInt(string str)
        {
            try
            {
                bool xFound = false;
                char[] arr = str.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 'x')
                    {
                        xFound = true;
                        continue;
                    }
                    else if (xFound == true)
                    {
                        columns = int.Parse(columns.ToString() + arr[i].ToString());
                    }
                    else if (xFound == false)
                    {
                        rows = int.Parse(rows.ToString() + arr[i].ToString());
                    }
                }
            }
            catch (Exception io)
            {
                MessageBox.Show(io.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public int getRows()
        {
            return rows;
        }
        public int getColumns()
        {
            return columns;
        }
        public int checkNullMatrix(int[,] _matrices, int _rows, int _columns)
        {
            int result = 0;
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (_matrices[i, j] == 0)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
        public bool checkIdentityMatrix(int[,] _matrices, int _rows, int _columns)
        {
            bool result = false, result1 = false, result2 = false;
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (i == j)
                    {
                        if (_matrices[i, j] == 1)
                        {
                            result = true;
                            continue;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                    else if (_matrices[i, j] == 0)
                    {
                        result1 = true;
                    }
                    else
                    {
                        result1 = false;
                    }
                }
            }
            if (result==true&& result1==true)
            {
                result2 = true;
            }
            return result2;
        }
        public bool checkScalarMatrix(int[,] _matrices, int _rows, int _columns)
        {
            bool result = false, result1 = false, result2 = false;
            int diagonalValue = _matrices[0, 0];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (i == j)
                    {
                        if (_matrices[i, j] == diagonalValue)
                        {
                            result = true;
                            continue;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                    else if (_matrices[i, j] == 0)
                    {
                        result1 = true;
                    }
                    else
                    {
                        result1 = false;
                    }
                }
            }
            if (result==true&&result1==true)
            {
                result2 = true;
            }
            return result2;
        }
        public bool checkDiagonalMatrix(int[,] _matrices, int _rows, int _columns)
        {
            bool result = false, result1 = false, result2 = false;
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (i == j)
                    {
                        if (_matrices[i, j] !=0 )
                        {
                            result = true;
                            continue;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                    else if (_matrices[i, j] == 0)
                    {
                        result1 = true;
                    }
                    else
                    {
                        result1 = false;
                    }
                }
            }
            if (result == true && result1 == true)
            {
                result2 = true;
            }
            return result2;
        }
        public bool checkSymmetricMatrix(int[,] _matrices, int _rows, int _columns)
        {
            bool result = false;
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (_matrices[i, j] == _matrices[j,i])
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            return result;
        }
        public bool checkSkewSymmetricMatrix(int[,] _matrices, int _rows, int _columns)
        {
            bool result = false;
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (_matrices[i, j] ==-( _matrices[j, i]))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            return result;
        }
        public bool checkUperTriangleMatrix(int[,] _matrices, int _rows, int _columns)
        {
            bool result = false,result1 = false, result2 = false;
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (i > j)
                    {
                        if (_matrices[i,j]==0)
                        {
                            result = true;
                            continue;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                    else if (i<j)
                    {
                        if (_matrices[i, j] != 0)
                        {
                            result1 = true;
                            continue;
                        }
                        else
                        {
                            result1 = false;
                        }
                    }
                }
            }
            if (result==true&& result1==true)
            {
                result2 = true;
            }
            return result2;
        }
        public bool checkLowerTriangleMatrix(int[,] _matrices, int _rows, int _columns)
        {
            bool result = false, result1 = false, result2 = false;
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (i < j)
                    {
                        if (_matrices[i, j] == 0)
                        {
                            result = true;
                            continue;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                    else if (i>j)
                    {
                        if (_matrices[i,j]!=0)
                        {
                            result1 = true;
                            continue;
                        }
                        else
                        {
                            result1 = false;
                        }
                    }
                }
            }
            if (result==true&&result1==true)
            {
                result2 = true;
            }
            return result2;
        }
        public int[,] addMatrices(int[,] _matrixA,int [,] _matrixB,int _rows,int _columns)
        {
            int[,] result = new int[_rows, _columns];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    result[i, j] = _matrixA[i, j] + _matrixB[i, j];
                }
            }
            return result; 
        }
        public int[,] subMatrices(int[,] _matrixA, int[,] _matrixB, int _rows, int _columns)
        {
            int[,] result = new int[_rows, _columns];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    result[i, j] = _matrixA[i, j] - _matrixB[i, j];
                }
            }
            return result;
        }
        public int[,] multiplyMatrices(int[,] _matrixA, int[,] _matrixB, int _rows, int _columns)
        {
            int[,] result = new int[_rows, _columns];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    result[i, j] = _matrixA[i, j] * _matrixB[i, j];
                }
            }
            return result;
        }
        public double[,] divideMatrices(int[,] _matrixA, int[,] _matrixB, int _rows, int _columns)
        {
            double[,] result = new double[_rows, _columns];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    result[i, j] = Convert.ToDouble(_matrixA[i, j]) /Convert.ToDouble(_matrixB[i, j]);
                }
            }
            return result;
        }
        public int[,] transpose(int[,] _martix,int _rows,int _columns)
        {
            int[,] transpose = new int[_rows, _columns];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    transpose[i, j] = _martix[j, i];
                }
            }
            return transpose;
        }
        public int calculateMode(int _matrix,int _rows,int _columns)
        {
            int result = 0;
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {

                }
            }
            return result;
        }
        public int[,] CalculateCremer(int[,] _matrix,int _mode, int _rows,int _columns)
        {
            int[,] result = new int[_rows, _columns];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    _matrix[i, j] = _matrix[i, j] / _mode;
                }
            }
            return result;
        }

        //----------------------------------
        private static double[,] MatrixDecompose(double[,] matrix, out int[] perm, out int toggle)
        {
            // Doolittle LUP decomposition with partial pivoting.
            // rerturns: result is L (with 1s on diagonal) and U; perm holds row permutations; toggle is +1 or -1 (even or odd)
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            //Check if matrix is square
            if (rows != cols)
                throw new Exception("Attempt to MatrixDecompose a non-square mattrix");

            double[,] result = MatrixDuplicate(matrix); // make a copy of the input matrix

            perm = new int[rows]; // set up row permutation result
            for (int i = 0; i < rows; ++i) { perm[i] = i; } // i are rows counter

            toggle = 1; // toggle tracks row swaps. +1 -> even, -1 -> odd. used by MatrixDeterminant

            for (int j = 0; j < rows - 1; ++j) // each column, j is counter for coulmns
            {
                double colMax = Math.Abs(result[j, j]); // find largest value in col j
                int pRow = j;
                for (int i = j + 1; i < rows; ++i)
                {
                    if (result[i, j] > colMax)
                    {
                        colMax = result[i, j];
                        pRow = i;
                    }
                }

                if (pRow != j) // if largest value not on pivot, swap rows
                {
                    double[] rowPtr = new double[result.GetLength(1)];

                    //in order to preserve value of j new variable k for counter is declared
                    //rowPtr[] is a 1D array that contains all the elements on a single row of the matrix
                    //there has to be a loop over the columns to transfer the values
                    //from the 2D array to the 1D rowPtr array.
                    //----tranfer 2D array to 1D array BEGIN

                    for (int k = 0; k < result.GetLength(1); k++)
                    {
                        rowPtr[k] = result[pRow, k];
                    }

                    for (int k = 0; k < result.GetLength(1); k++)
                    {
                        result[pRow, k] = result[j, k];
                    }

                    for (int k = 0; k < result.GetLength(1); k++)
                    {
                        result[j, k] = rowPtr[k];
                    }

                    //----tranfer 2D array to 1D array END

                    int tmp = perm[pRow]; // and swap perm info
                    perm[pRow] = perm[j];
                    perm[j] = tmp;

                    toggle = -toggle; // adjust the row-swap toggle
                }

                if (Math.Abs(result[j, j]) < 1.0E-20) // if diagonal after swap is zero . . .
                    return null; // consider a throw

                for (int i = j + 1; i < rows; ++i)
                {
                    result[i, j] /= result[j, j];
                    for (int k = j + 1; k < rows; ++k)
                    {
                        result[i, k] -= result[i, j] * result[j, k];
                    }
                }
            } // main j column loop

            return result;
        }
        //-----------------------------------------
        private static double[,] MatrixDuplicate(double[,] matrix)
        {
            // allocates/creates a duplicate of a matrix. assumes matrix is not null.
            double[,] result = MatrixCreate(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < matrix.GetLength(0); ++i) // copy the values
                for (int j = 0; j < matrix.GetLength(1); ++j)
                    result[i, j] = matrix[i, j];
            return result;
        }
        //---------
        private static double[,] MatrixCreate(int rows, int cols)
        {
            // allocates/creates a matrix initialized to all 0.0. assume rows and cols > 0
            // do error checking here
            double[,] result = new double[rows, cols];
            return result;
        }
    }
}
