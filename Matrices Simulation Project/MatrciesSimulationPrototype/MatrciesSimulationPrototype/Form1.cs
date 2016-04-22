using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MatrciesSimulationPrototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox5.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Add")
            {
                groupBox2.Visible = false;
            }
            else
            {
                groupBox2.Visible = true;
                TextBox txt = new TextBox();


                txt.Name = "txt" + i;
                
                this.Controls.Add(txt);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text=="1x1")
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SimulationForm obj_simulation = new SimulationForm();
            this.Hide();
            obj_simulation.Show();
        }
    }
}
