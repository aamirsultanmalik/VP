using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
namespace MatricesSimulation
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Font font = new Font("Aria", 14, FontStyle.Italic);
        string lengthA, lengthB;
        public static int rowsA=0, columnsA=0, rowsB = 0, columnsB = 0;
        public delegate void delegateForVoidMethod(string str);
        Matrices obj_matrices = new Matrices();
        public TextBox[,] txtA,txtB,txtResult;
        int[,] matrixA, matrixB,result;
        double[,] divResult;
        bool fisrtClick = false, typeMAtrix = false, firstDraw = false;
        Point[] previuosPointstorage = new Point[rowsA];
        int thisX = 0, thisY = 0, newX = 0, newY = 0, counter = 0, counter1 = 0;
        public Form1()
        {
            InitializeComponent();
            txt_MatrixBLength.Hide();
            txt_MatrixALength.Hide();
            label1.Hide();
            label3.Hide();
            button1.Hide();
            btnOk.Hide();
            button2.Hide();
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
                button2.Show();
                button1.Show();
            }
            else if (combo_Operation.Text== "Matrix Addition")
            {
                txt_MatrixALength.Visible = true;
                label1.Visible = true;
                txt_MatrixBLength.Visible = true;
                label3.Visible = true;
                button1.Show();
                btnOk.Show();
                label5.Show();
            }

            else if (combo_Operation.Text == "Matrix Subtraction")
            {
                txt_MatrixALength.Visible = true;
                label1.Visible = true;
                txt_MatrixBLength.Visible = true;
                label3.Visible = true;
                button1.Show();
                btnOk.Show();
                label5.Show();
            }

            else if (combo_Operation.Text == "Matrix Multiplication")
            {
                txt_MatrixALength.Visible = true;
                label1.Visible = true;
                txt_MatrixBLength.Visible = true;
                label3.Visible = true;
                button1.Show();
                btnOk.Show();
                label5.Show();
            }

            else if (combo_Operation.Text == "Matrix Division")
            {
                txt_MatrixALength.Visible = true;
                label1.Visible = true;
                txt_MatrixBLength.Visible = true;
                label3.Visible = true;
                button1.Show();
                btnOk.Show();
                label5.Show();
            }
            else if (combo_Operation.Text=="Matrix Transpose")
            {
                txt_MatrixBLength.Hide();
                label3.Hide();
                button1.Show();
                btnOk.Show();
                label5.Hide();
            }
        }
        private void comboBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (combo_Operation.Text == "Matrix Type")
            {
                txt_MatrixALength.Visible = true;
                label1.Visible = true;
                txt_MatrixBLength.Hide();
                label3.Hide();
                button2.Show();
                button1.Show();
            }
            else if (combo_Operation.Text == "Matrix Addition")
            {
                txt_MatrixALength.Visible = true;
                label1.Visible = true;
                txt_MatrixBLength.Visible = true;
                label3.Visible = true;
                button1.Show();
                btnOk.Show();
            }
            else if (combo_Operation.Text == "Matrix Transpose")
            {
                txt_MatrixBLength.Hide();
                label3.Hide();
                button1.Show();
                btnOk.Show();
                label5.Hide();
            }
        }
        private void comboBox1_IndexChanged(object sender, EventArgs e)
        {
            if (combo_Operation.Text == "Matrix Type")
            {
                txt_MatrixALength.Visible = true;
                label1.Visible = true;
                txt_MatrixBLength.Hide();
                label3.Hide();
                button2.Show();
                button1.Show();
            }
            else if (combo_Operation.Text == "Matrix Addition")
            {
                txt_MatrixALength.Visible = true;
                label1.Visible = true;
                txt_MatrixBLength.Visible = true;
                label3.Visible = true;
                button1.Show();
                btnOk.Show();
            }
            else if (combo_Operation.Text == "Matrix Transpose")
            {
                txt_MatrixBLength.Hide();
                label3.Hide();
                button1.Show();
                btnOk.Show();
                label5.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                delegateForVoidMethod obj_callConvertMethod = new delegateForVoidMethod(obj_matrices.convertToInt);
                if (combo_Operation.Text == "Matrix Type")
                {
                    if (firstDraw == false)
                    {
                        obj_callConvertMethod(lengthA);
                        rowsA = obj_matrices.getRows();
                        columnsA = obj_matrices.getColumns();
                        creatMatrixA(rowsA, columnsA);
                        firstDraw = true;
                    }
                    else
                    {
                        MessageBox.Show("Please Click Reset And Operate Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (combo_Operation.Text == "Matrix Addition" || combo_Operation.Text == "Matrix Subtraction" || combo_Operation.Text == "Matrix Multiplication" || combo_Operation.Text == "Matrix Division")
                {
                    if (firstDraw == false)
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
                        firstDraw = true;
                    }
                    else
                    {
                        MessageBox.Show("Please Click Reset And Operate Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (combo_Operation.Text == "Matrix Transpose")
                {
                    if (firstDraw == false)
                    {
                        obj_callConvertMethod(lengthA);
                        rowsA = obj_matrices.getRows();
                        columnsA = obj_matrices.getColumns();
                        creatMatrixA(rowsA, columnsA);
                        firstDraw = true;
                    }
                    else
                    {
                        MessageBox.Show("Please Click Reset And Operate Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (IOException io)
            {
                MessageBox.Show(io.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_MatrixALength_TextChanged(object sender, EventArgs e)
        {
            lengthA = txt_MatrixALength.Text;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (combo_Operation.Text == "Matrix Addition")
                {
                    result = new int[rowsA, columnsA];
                    matrixA = new int[rowsA, columnsA];
                    matrixB = new int[rowsB, columnsB];
                    getMatrixInputA(txtA, ref matrixA, rowsA, columnsA);
                    getMatrixInputB(txtB, ref matrixB, rowsB, columnsB);
                    result = obj_matrices.addMatrices(matrixA, matrixB, rowsA, columnsB);
                    timer_addition.Start();
                    if (fisrtClick == false)
                    {
                        fisrtClick = true;
                        creatResultMatrix(rowsA, columnsA);
                    }
                    fillResultMatrix(txtResult, result, rowsA, columnsA);
                    hideresultMatrix(rowsA, columnsA);
                }
                else if (combo_Operation.Text == "Matrix Subtraction")
                {
                    result = new int[rowsA, columnsA];
                    matrixA = new int[rowsA, columnsA];
                    matrixB = new int[rowsB, columnsB];
                    getMatrixInputA(txtA, ref matrixA, rowsA, columnsA);
                    getMatrixInputB(txtB, ref matrixB, rowsB, columnsB);
                    result = obj_matrices.subMatrices(matrixA, matrixB, rowsA, columnsB);
                    timer_addition.Start();
                    if (fisrtClick == false)
                    {
                        fisrtClick = true;
                        creatResultMatrix(rowsA, columnsA);
                    }
                    fillResultMatrix(txtResult, result, rowsA, columnsA);
                    hideresultMatrix(rowsA, columnsA);
                }
                else if (combo_Operation.Text == "Matrix Multiplication")
                {
                    result = new int[rowsA, columnsA];
                    matrixA = new int[rowsA, columnsA];
                    matrixB = new int[rowsB, columnsB];
                    getMatrixInputA(txtA, ref matrixA, rowsA, columnsA);
                    getMatrixInputB(txtB, ref matrixB, rowsB, columnsB);
                    result = obj_matrices.multiplyMatrices(matrixA, matrixB, rowsA, columnsB);
                    timer_addition.Start();
                    if (fisrtClick == false)
                    {
                        fisrtClick = true;
                        creatResultMatrix(rowsA, columnsA);
                    }
                    fillResultMatrix(txtResult, result, rowsA, columnsA);
                    hideresultMatrix(rowsA, columnsA);
                }
                else if (combo_Operation.Text == "Matrix Division")
                {
                    divResult = new double[rowsA, columnsA];
                    matrixA = new int[rowsA, columnsA];
                    matrixB = new int[rowsB, columnsB];
                    getMatrixInputA(txtA, ref matrixA, rowsA, columnsA);
                    getMatrixInputB(txtB, ref matrixB, rowsB, columnsB);
                    divResult = obj_matrices.divideMatrices(matrixA, matrixB, rowsA, columnsB);
                    timer_addition.Start();
                    if (fisrtClick == false)
                    {
                        fisrtClick = true;
                        creatResultMatrix(rowsA, columnsA);
                    }
                    fillResultMatrixDiv(txtResult, divResult, rowsA, columnsA);
                    hideresultMatrix(rowsA, columnsA);
                }

                else if (combo_Operation.Text == "Matrix Transpose")
                {
                    result = new int[rowsA, columnsA];
                    matrixA = new int[rowsA, columnsA];
                    //matrixB = new int[rowsB, columnsB];
                    getMatrixInputA(txtA, ref matrixA, rowsA, columnsA);
                    //getMatrixInputB(txtB, ref matrixB, rowsB, columnsB);
                    result = obj_matrices.transpose(matrixA, rowsA, columnsA);
                    if (fisrtClick == false)
                    {
                        fisrtClick = true;
                        creatResultMatrix(rowsA, columnsA);
                    }
                    fillResultMatrix(txtResult, result, rowsA, columnsA);
                    hideresultMatrix(rowsA, columnsA);
                    timer.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Click Reset And Operate Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                matrixA = new int[rowsA, columnsA];
                getMatrixInputA(txtA, ref matrixA, rowsA, columnsA);
                if (rowsA == columnsA)
                {
                    if (obj_matrices.checkNullMatrix(matrixA, rowsA, columnsA) == (rowsA * columnsA))
                    {
                        MessageBox.Show("Null Matrix", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        typeMAtrix = true;
                        changeTypeColor();
                        this.Refresh();

                    }
                    else if (obj_matrices.checkIdentityMatrix(matrixA, rowsA, columnsA) == true)
                    {
                        MessageBox.Show("Identity Matrix", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeIdentityColor();
                        this.Refresh();
                    }
                    else if (obj_matrices.checkUperTriangleMatrix(matrixA, rowsA, columnsA) == true)
                    {
                        MessageBox.Show("Uper Triangle Matrix", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeUperTriangleColor();
                        this.Refresh();
                    }
                    else if (obj_matrices.checkLowerTriangleMatrix(matrixA, rowsA, columnsA) == true)
                    {
                        MessageBox.Show("Lower Triangle Matrix", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeLowerTriagleColor();
                        this.Refresh();
                    }
                    else if (obj_matrices.checkScalarMatrix(matrixA, rowsA, columnsA) == true)
                    {
                        MessageBox.Show("Scalar Matrix", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeScalarColor();
                        this.Refresh();
                    }
                    else if (obj_matrices.checkDiagonalMatrix(matrixA, rowsA, columnsA) == true)
                    {
                        MessageBox.Show("Diagonal Matrix", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeDiagonalColor();
                        this.Refresh();
                    }
                    else if (obj_matrices.checkSymmetricMatrix(matrixA, rowsA, columnsA) == true)
                    {
                        MessageBox.Show("Symmetric Matrix", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeSymmenticColor();
                        this.Refresh();
                    }
                    else if (obj_matrices.checkSymmetricMatrix(matrixA, rowsA, columnsA) == true)
                    {
                        MessageBox.Show("Skew Symmetric Matrix", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No Match Found!!! Ooops", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Click Reset And Operate Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void changeIdentityColor()
        {
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    if (i==j)
                    {
                        txtA[i, j].BackColor = Color.Red;
                    }
                }
            }
        }
        public void changeUperTriangleColor()
        {
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    if (i > j)
                    {
                        txtA[i, j].BackColor = Color.Red;
                    }
                }
            }
        }
        public void changeLowerTriagleColor()
        {
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    if (i < j)
                    {
                        txtA[i, j].BackColor = Color.Red;
                    }
                }
            }
        }
        public void changeScalarColor()
        {
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    if (i == j)
                    {
                        txtA[i, j].BackColor = Color.Red;
                    }
                }
            }
        }
        public void changeDiagonalColor()
        {
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    if (i == j)
                    {
                        txtA[i, j].BackColor = Color.Red;
                    }
                }
            }
        }
        public void changeSymmenticColor()
        {
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (txtA[i, j].Text == txtA[j, i].Text)
                    {
                        txtA[i, j].BackColor = Color.Red;
                    }
                }
            }
        }
        public void changeSkewSymmenticColor()
        {
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (txtA[i, j].Text == "-"+(txtA[j, i].Text))
                    {
                        txtA[i, j].BackColor = Color.Red;
                    }
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            drawRectangle(graphics);
        }
        public void drawRectangle(Graphics _graphics)
        {
            _graphics.FillRectangle(Brushes.Black, 1000, 300, 40, 40);
            _graphics.DrawString("125", font, Brushes.White, 300, 305);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (typeMAtrix == true)
                {
                    int height = 25;
                    for (int i = 0; i < rowsA; i++)
                    {
                        for (int j = 0; j < columnsA; j++)
                        {
                            while (height != 65)
                            {
                                txtA[i, j].Size = new Size(25, height);
                                height++;
                                Thread.Sleep(5);
                            }

                        }
                    }
                    timer.Stop();
                }
                else
                {

                    int sourceX, sourceY, destX, destY, stopY;
                    for (int i = 0; i < rowsA; i++)
                    {
                        for (int j = 0; j < columnsA; j++)
                        {
                            sourceX = txtA[i, j].Location.X;
                            sourceY = txtA[i, j].Location.Y;
                            stopY = sourceY - 20;
                            destX = txtResult[i, j].Location.X;
                            destY = txtResult[i, j].Location.Y;
                            txtA[i, j].BackColor = Color.Red;
                            this.Refresh();
                            while (sourceY != stopY)
                            {
                                {
                                    txtA[i, j].Location = new Point(sourceX, sourceY);
                                    sourceY--;
                                }
                            }
                            while ((sourceX != destX))
                            {
                                {
                                    txtA[i, j].Location = new Point(sourceX, sourceY);
                                    sourceX++;
                                    Thread.Sleep(20);
                                }
                            }
                            while (sourceY != destY - 12)
                            {
                                {
                                    txtA[i, j].Location = new Point(sourceX, sourceY);
                                    sourceY++;
                                    Thread.Sleep(20);
                                }
                            }
                            txtA[i, j].Dispose();
                            txtResult[i, j].Show();
                            txtResult[i, j].Text = result[i, j].ToString();
                            this.Refresh();
                        }
                    }
                    timer.Stop();
                    creatMatrixA(rowsA, columnsA);
                    fillMatrixA();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void changeTypeColor()
        {
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    txtA[i, j].BackColor = Color.Red;
                }
            }
        }
        
        public void hideresultMatrix(int _rows,int _columns)
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    txtResult[i, j].Hide();
                }
            }
        }
        private void timer_addition_Tick(object sender, EventArgs e)
        {
            try
            {
                int sourceX, sourceY, destinationX, destinationY;
                Point resultLocation;
                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < columnsA; j++)
                    {
                        sourceX = txtA[i, j].Location.X;
                        sourceY = txtA[i, j].Location.Y;
                        destinationX = txtB[i, j].Location.X;
                        destinationY = txtB[i, j].Location.Y;
                        resultLocation = txtResult[i, j].Location;
                        while (sourceY != destinationY - 20)
                        {
                            //if (i == 0)
                            {
                                txtA[i, j].Location = new Point(sourceX, sourceY);
                                sourceY--;
                            }
                        }
                        while ((sourceX != label6.Location.X))
                        {
                            //if (i == 0)
                            {
                                txtA[i, j].Location = new Point(sourceX, sourceY);
                                sourceX++;
                                Thread.Sleep(20);
                            }
                        }
                        while (sourceY != destinationY)
                        {
                            //if (i == 0)
                            {
                                txtA[i, j].Location = new Point(sourceX, sourceY);
                                sourceY++;
                                Thread.Sleep(20);
                            }
                        }

                        while ((destinationX != label6.Location.X + txtA[i, j].Width))
                        {
                            //if (i == 0)
                            {
                                txtB[i, j].Location = new Point(destinationX, destinationY);
                                destinationX--;
                                Thread.Sleep(20);
                            }
                        }
                        txtA[i, j].Dispose();
                        txtB[i, j].Dispose();
                        //txtResult[i, j].Text = result[i, j].ToString();
                        destinationY = txtResult[i, j].Location.Y;

                        txtResult[i, j].Show();
                        if (combo_Operation.Text == "Matrix Division")
                        {
                            txtResult[i, j].Text = divResult[i, j].ToString();
                        }
                        else
                        {

                            txtResult[i, j].Text = result[i, j].ToString();
                        }
                        this.Refresh();
                        while (txtResult[i, j].Location.Y != resultLocation.Y)
                        {
                            txtResult[i, j].Location = new Point(txtResult[i, j].Location.X, destinationY);
                            destinationY++;
                            Thread.Sleep(50);
                        }
                    }
                }
                timer_addition.Stop();
                creatMatrixA(rowsA, columnsA);
                creatMatrixB(rowsB, columnsB);
                fillMatrixA();
                fillMatrixB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void fillMatrixA()
        {
            try
            {
                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < columnsA; j++)
                    {
                        txtA[i, j].Text = matrixA[i, j].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void fillMatrixB()
        {
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < columnsB; j++)
                {
                    txtB[i, j].Text = matrixB[i, j].ToString();
                }
            }
        }
        public void simulateAddition(int _rows,int _columns)
        {
            
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
                    txtA[i, j].Location = new Point(x, y + 40);
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
            try
            {
                txtB = new TextBox[_rows, _columns];
                Point labelPosition = this.label5.Location;
                int x = labelPosition.X + 100, y = labelPosition.Y;
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
                        txtB[i, j].Location = new Point(x, y + 40);
                        txtB[i, j].SendToBack();
                        this.Controls.Add(txtB[i, j]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void creatResultMatrix(int _rows, int _columns)
        {
            try
            {
                txtResult = new TextBox[_rows, _columns];
                Point labelPosition = this.txtA[_rows - 1, _columns - 1].Location;
                labelPosition.X = labelPosition.X + 80;
                labelPosition.Y = labelPosition.Y;
                Label resultLable = new Label();
                resultLable.Location = labelPosition;
                resultLable.Width = 80;
                resultLable.Text = "Result";
                //this.Controls.Add(resultLable);
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
                        txtResult[i, j].BringToFront();
                        txtResult[i, j].BackColor = Color.White;
                        txtResult[i, j].Location = new Point(x, y + 30);
                        this.Controls.Add(txtResult[i, j]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void fillResultMatrix(TextBox[,] _txt,int [,] _values,int _rows,int _columns)
        {
            try
            {
                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _columns; j++)
                    {
                        _txt[i, j].Text = _values[i, j].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void fillResultMatrixDiv(TextBox[,] _txt, double[,] _values, int _rows, int _columns)
        {
            try
            {
                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _columns; j++)
                    {
                        _txt[i, j].Text = _values[i, j].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void getMatrixInputA(TextBox[,] _txt, ref int[,] _matrices, int _rows, int _columns)
        {
            try
            {
                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _columns; j++)
                    {
                        _matrices[i, j] = Convert.ToInt32(_txt[i, j].Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void getMatrixInputB(TextBox[,] _txt, ref int[,] _matrices, int _rows, int _columns)
        {
            try
            {
                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _columns; j++)
                    {
                        _matrices[i, j] = Convert.ToInt32(_txt[i, j].Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
