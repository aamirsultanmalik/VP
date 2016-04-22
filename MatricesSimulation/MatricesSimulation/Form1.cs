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
        public static int rows=0, columns=0;
        public delegate void delegateForVoidMethod(string str);
        Matrices obj_matrices = new Matrices();
        TextBox[,] txt;
        int[,] matrices;
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
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            delegateForVoidMethod obj_callConvertMethod= new delegateForVoidMethod(obj_matrices.convertToInt(lengthA))
            obj_matrices.convertToInt(lengthA);
            rows = obj_matrices.getRows();
            columns = obj_matrices.getColumns();
            creatRows(rows,columns);
        }

        private void txt_MatrixALength_TextChanged(object sender, EventArgs e)
        {
            lengthA = txt_MatrixALength.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matrices = new int[rows, columns];
            getMatrixInput(txt, ref matrices,rows,columns);
            if (rows==columns)
            {
                if (obj_matrices.checkNullMatrix(matrices, rows, columns) == (rows * columns))
                {
                    MessageBox.Show("Null Matrix");
                }
                else if (obj_matrices.checkIdentityMatrix(matrices, rows, columns) == true)
                {
                    MessageBox.Show("Identity Matrix");
                }
                else if (obj_matrices.checkUperTriangleMatrix(matrices, rows, columns) == true)
                {
                    MessageBox.Show("Uper Triangle Matrix");
                }
                else if (obj_matrices.checkLowerTriangleMatrix(matrices, rows, columns) == true)
                {
                    MessageBox.Show("Lower Triangle Matrix");
                }
                else if (obj_matrices.checkScalarMatrix(matrices, rows, columns) == true)
                {
                    MessageBox.Show("Scalar Matrix");
                }
                else
                {
                    MessageBox.Show("No Match Found!!! Ooops");
                }
            }
        }
        
        public void creatRows(int _rows,int _columns)
        {
             txt = new TextBox[rows, columns];
            Point labelPosition = this.label4.Location;
            int x = labelPosition.X + 80, y = labelPosition.Y;
            for (int i = 0; i < _rows; i++)
            {
                x = labelPosition.X + 10;
                y = y + 30;
                for (int j = 0; j < _columns; j++)
                {
                    string name = "A" + Convert.ToString(i);
                    txt[i,j] = new TextBox();
                    txt[i, j].Name = name;
                    x = x + 35;
                    txt[i, j].Height = 25;
                    txt[i, j].Width = 25;
                    txt[i, j].Location = new Point(x, y + 30);
                    this.Controls.Add(txt[i, j]);
                }
            }

        }
        public void getMatrixInput(TextBox[,] _txt, ref int[,] _matrices, int _rows, int _columns)
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
