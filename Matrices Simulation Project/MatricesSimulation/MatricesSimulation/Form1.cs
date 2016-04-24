using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatricesSimulation
{
    public partial class Form1 : Form
    {
        string lengthA, lengthB;
        public static int rowsA=0, columnsA=0, rowsB = 0, columnsB = 0;
        public delegate void delegateForVoidMethod(string str);
        Matrices obj_matrices = new Matrices();
        TextBox[,] txtA,txtB,txtResult;
        int[,] matrixA, matrixB,result;
        bool fisrtClick = false;
        public Form1()
        {
            InitializeComponent();
            txt_MatrixBLength.Hide();
            txt_MatrixALength.Hide();
            label1.Hide();
            label3.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Operation.Text== "Matrix Type")
            {
                txt_MatrixALength.Visible = true;
                label1.Visible = true;
                txt_MatrixBLength.Hide();
                label3.Hide();
            }
            else if (combo_Operation.Text== "Matrix Addition")
            {
                txt_MatrixALength.Visible = true;
                label1.Visible = true;
                txt_MatrixBLength.Visible = true;
                label3.Visible = true;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            delegateForVoidMethod obj_callConvertMethod = new delegateForVoidMethod(obj_matrices.convertToInt);
            if (combo_Operation.Text== "Matrix Type")
            {
                obj_callConvertMethod(lengthA);
                rowsA = obj_matrices.getRows();
                columnsA = obj_matrices.getColumns();
                creatMatrixA(rowsA, columnsA);
            }
            else
            {
                obj_callConvertMethod(lengthA);
                rowsA = obj_matrices.getRows();
                columnsA = obj_matrices.getColumns();
                creatMatrixA(rowsA, columnsA);
                obj_matrices.rows = 0;
                obj_matrices.columns = 0;
                obj_callConvertMethod(lengthB);
                rowsB = obj_matrices.getRows();
                columnsB = obj_matrices.getColumns();
                creatMatrixB(rowsB, columnsB);
            }
        }

        private void txt_MatrixALength_TextChanged(object sender, EventArgs e)
        {
            lengthA = txt_MatrixALength.Text;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {  
            if (combo_Operation.Text== "Matrix Addition")
            {
                result = new int[rowsA, columnsA];
                matrixA = new int[rowsA, columnsA];
                matrixB = new int[rowsB, columnsB];
                getMatrixInputA(txtA, ref matrixA, rowsA, columnsA);
                getMatrixInputB(txtB, ref matrixB, rowsB, columnsB);
                result = obj_matrices.addMatrices(matrixA, matrixB, rowsA, columnsB);
                if (fisrtClick==false)
                {
                    fisrtClick = true;
                    creatResultMatrix(rowsA, columnsA);
                }
                fillResultMatrix(txtResult, result, rowsA, columnsA);
            }
            else if (combo_Operation.Text == "Matrix Subtraction")
            {
                result = new int[rowsA, columnsA];
                matrixA = new int[rowsA, columnsA];
                matrixB = new int[rowsB, columnsB];
                getMatrixInputA(txtA, ref matrixA, rowsA, columnsA);
                getMatrixInputB(txtB, ref matrixB, rowsB, columnsB);
                result = obj_matrices.subMatrices(matrixA, matrixB, rowsA, columnsB);
                if (fisrtClick == false)
                {
                    fisrtClick = true;
                    creatResultMatrix(rowsA, columnsA);
                }
                fillResultMatrix(txtResult, result, rowsA, columnsA);
            }
            else if (combo_Operation.Text == "Matrix Multiplication")
            {
                result = new int[rowsA, columnsA];
                matrixA = new int[rowsA, columnsA];
                matrixB = new int[rowsB, columnsB];
                getMatrixInputA(txtA, ref matrixA, rowsA, columnsA);
                getMatrixInputB(txtB, ref matrixB, rowsB, columnsB);
                result = obj_matrices.multiplyMatrices(matrixA, matrixB, rowsA, columnsB);
                if (fisrtClick == false)
                {
                    fisrtClick = true;
                    creatResultMatrix(rowsA, columnsA);
                }
                fillResultMatrix(txtResult, result, rowsA, columnsA);
            }
            else if (combo_Operation.Text == "Matrix Division")
            {
                //result = new int[rowsA, columnsA];
                matrixA = new int[rowsA, columnsA];
                matrixB = new int[rowsB, columnsB];
                getMatrixInputA(txtA, ref matrixA, rowsA, columnsA);
                getMatrixInputB(txtB, ref matrixB, rowsB, columnsB);
                double[,] result = new double[rowsA, columnsA];
                result =obj_matrices.divideMatrices(matrixA, matrixB, rowsA, columnsB);
                creatResultMatrix(rowsA, columnsA);
                //fillResultMatrix(txtResult, result, rowsA, columnsA);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matrixA = new int[rowsA, columnsA];
            getMatrixInputA(txtA, ref matrixA, rowsA,columnsA);
            if (rowsA==columnsA)
            {
                if (obj_matrices.checkNullMatrix(matrixA, rowsA, columnsA) == (rowsA * columnsA))
                {
                    MessageBox.Show("Null Matrix");
                }
                else if (obj_matrices.checkIdentityMatrix(matrixA, rowsA, columnsA) == true)
                {
                    MessageBox.Show("Identity Matrix");
                }
                else if (obj_matrices.checkUperTriangleMatrix(matrixA, rowsA, columnsA) == true)
                {
                    MessageBox.Show("Uper Triangle Matrix");
                }
                else if (obj_matrices.checkLowerTriangleMatrix(matrixA, rowsA, columnsA) == true)
                {
                    MessageBox.Show("Lower Triangle Matrix");
                }
                else if (obj_matrices.checkScalarMatrix(matrixA, rowsA, columnsA) == true)
                {
                    MessageBox.Show("Scalar Matrix");
                }
                else if (obj_matrices.checkDiagonalMatrix(matrixA, rowsA, columnsA) == true)
                {
                    MessageBox.Show("Diagonal Matrix");
                }
                else if (obj_matrices.checkSymmetricMatrix(matrixA, rowsA, columnsA) == true)
                {
                    MessageBox.Show("Symmetric Matrix");
                }
                else if (obj_matrices.checkSymmetricMatrix(matrixA, rowsA, columnsA) == true)
                {
                    MessageBox.Show("Skew Symmetric Matrix");
                }
                else
                {
                    MessageBox.Show("No Match Found!!! Ooops");
                }
            }
        }
        
        public void creatMatrixA(int _rows,int _columns)
        {
             txtA = new TextBox[_rows, _columns];
            Point labelPosition = this.label4.Location;
            int x = labelPosition.X , y = labelPosition.Y;
            for (int i = 0; i < _rows; i++)
            {
                if (i==0)
                {
                    x = labelPosition.X + 10;
                }
                else
                {
                    x = labelPosition.X + 10;
                    y = y + 30;
                }
                for (int j = 0; j < _columns; j++)
                {
                    string name = "A" + Convert.ToString(i);
                    txtA[i,j] = new TextBox();
                    txtA[i, j].Name = name;
                    x = x + 35;
                    txtA[i, j].Height = 25;
                    txtA[i, j].Width = 25;
                    txtA[i, j].Location = new Point(x, y + 30);
                    this.Controls.Add(txtA[i, j]);
                }
            }

        }

        private void txt_MatrixBLength_TextChanged(object sender, EventArgs e)
        {
            lengthB = txt_MatrixBLength.Text;
        }

        public void creatMatrixB(int _rows, int _columns)
        {
            txtB = new TextBox[_rows, _columns];
            Point labelPosition = this.label5.Location;
            int x = labelPosition.X + 80, y = labelPosition.Y;
            for (int i = 0; i < _rows; i++)
            {
                if (i == 0)
                {
                    x = labelPosition.X + 10;
                }
                else
                {
                    x = labelPosition.X + 10;
                    y = y + 30;
                }
                for (int j = 0; j < _columns; j++)
                {
                    string name = "B" + Convert.ToString(i);
                    txtB[i, j] = new TextBox();
                    txtB[i, j].Name = name;
                    x = x + 35;
                    txtB[i, j].Height = 25;
                    txtB[i, j].Width = 25;
                    txtB[i, j].Location = new Point(x, y + 30);
                    this.Controls.Add(txtB[i, j]);
                }
            }

        }
        public void creatResultMatrix(int _rows, int _columns)
        {
            txtResult = new TextBox[_rows, _columns];
            Point labelPosition = this.txtA[_rows-1, _columns-1].Location;
            labelPosition.X = labelPosition.X + 80;
            labelPosition.Y = labelPosition.Y;
            Label resultLable = new Label();
            resultLable.Location = labelPosition;
            resultLable.Text = "Result";
            this.Controls.Add(resultLable);
            labelPosition = resultLable.Location;
            int x = labelPosition.X + 80, y = labelPosition.Y;
            for (int i = 0; i < _rows; i++)
            {
                if (i == 0)
                {
                    x = labelPosition.X + 10;
                }
                else
                {
                    x = labelPosition.X + 10;
                    y = y + 30;
                }
                for (int j = 0; j < _columns; j++)
                {
                    string name = "B" + Convert.ToString(i);
                    txtResult[i, j] = new TextBox();
                    txtResult[i, j].Name = name;
                    x = x + 35;
                    txtResult[i, j].Height = 25;
                    txtResult[i, j].Width = 25;
                    txtResult[i, j].Location = new Point(x, y + 30);
                    this.Controls.Add(txtResult[i, j]);
                }
            }
        }
        public void fillResultMatrix(TextBox[,] _txt,int [,] _values,int _rows,int _columns)
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    _txt[i, j].Text = _values[i, j].ToString();
                }
            }
        }
        public void getMatrixInputA(TextBox[,] _txt, ref int[,] _matrices, int _rows, int _columns)
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    _matrices[i, j] = Convert.ToInt32(_txt[i, j].Text);
                }
            }
        }
        public void getMatrixInputB(TextBox[,] _txt, ref int[,] _matrices, int _rows, int _columns)
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    _matrices[i, j] = Convert.ToInt32(_txt[i, j].Text);
                }
            }
        }
    }
}
