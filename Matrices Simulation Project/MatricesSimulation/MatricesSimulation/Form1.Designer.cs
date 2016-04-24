namespace MatricesSimulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MatrixALength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_Operation = new System.Windows.Forms.ComboBox();
            this.txt_MatrixBLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrix A Lenght";
            // 
            // txt_MatrixALength
            // 
            this.txt_MatrixALength.Location = new System.Drawing.Point(530, 60);
            this.txt_MatrixALength.Name = "txt_MatrixALength";
            this.txt_MatrixALength.Size = new System.Drawing.Size(121, 20);
            this.txt_MatrixALength.TabIndex = 2;
            this.txt_MatrixALength.TextChanged += new System.EventHandler(this.txt_MatrixALength_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operation";
            // 
            // combo_Operation
            // 
            this.combo_Operation.FormattingEnabled = true;
            this.combo_Operation.Items.AddRange(new object[] {
            "Matrix Type",
            "Matrix Addition",
            "Matrix Subtraction",
            "Matrix Multiplication",
            "Matrix Division",
            "Matrix Transpose",
            "Cremer Rule",
            "Equation Solution"});
            this.combo_Operation.Location = new System.Drawing.Point(530, 20);
            this.combo_Operation.Name = "combo_Operation";
            this.combo_Operation.Size = new System.Drawing.Size(121, 21);
            this.combo_Operation.TabIndex = 1;
            this.combo_Operation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_MatrixBLength
            // 
            this.txt_MatrixBLength.Location = new System.Drawing.Point(530, 100);
            this.txt_MatrixBLength.Name = "txt_MatrixBLength";
            this.txt_MatrixBLength.Size = new System.Drawing.Size(121, 20);
            this.txt_MatrixBLength.TabIndex = 3;
            this.txt_MatrixBLength.TextChanged += new System.EventHandler(this.txt_MatrixBLength_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Matrix B Lenght";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Draw Matrices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Matrix A";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Perform Check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matrix B";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(576, 387);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 495);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MatrixBLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_Operation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MatrixALength);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Matrices Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MatrixALength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_Operation;
        private System.Windows.Forms.TextBox txt_MatrixBLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOk;
    }
}

