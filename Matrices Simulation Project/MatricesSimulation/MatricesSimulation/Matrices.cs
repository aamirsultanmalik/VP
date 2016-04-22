using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesSimulation
{
    class Matrices
    {
        
        int rows=0, columns=0;
        public void convertToInt(string str)
        {
            bool xFound = false;
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]=='x')
                {
                    xFound = true;
                    continue;
                }
                else if (xFound==true)
                {
                    columns = int.Parse(columns.ToString() + arr[i].ToString());
                }
                else if (xFound==false)
                {
                    rows = int.Parse(rows.ToString() + arr[i].ToString());
                }
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
            bool result = false;
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
        public bool checkScalarMatrix(int[,] _matrices, int _rows, int _columns)
        {
            bool result = false;
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
            bool result = false;
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
                            result = true;
                            continue;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
            }
            return result;
        }
        public bool checkLowerTriangleMatrix(int[,] _matrices, int _rows, int _columns)
        {
            bool result = false;
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
                            result = true;
                            continue;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
            }
            return result;
        }
    }
}
