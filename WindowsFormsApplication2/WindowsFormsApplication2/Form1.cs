using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public int[] array = new int[10];
        protected int top = -1;
        Class1 c1 = new Class1();
        public Form1()
        {
            InitializeComponent();
            label1.Hide();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_push_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            c1.push(ref array,ref top,x);
            listBox1.Items.Add(x);
            textBox1.Clear();
        }

        private void btn_pop_Click(object sender, EventArgs e)
        {
            if (top==-1)
            {
                MessageBox.Show("Sorry Stack is Empty");
            }
            else
            {
                int p = c1.pop(ref array, ref top);
                listBox1.Items.Remove(p);
                label1.Text = p.ToString();
                label1.Show();
            }
        }
    }
    
}