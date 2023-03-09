using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Perceptron_LogicGate
{
    public partial class Form1 : Form
    {
        Perceptron perceptron;
        public int input1 = 0;
        public int input2 = 0;
        public Form1()
        {
            InitializeComponent();
            result.BackColor = Color.White;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            perceptron = new Perceptron();
            one.Enabled = false;
            two.Enabled = false;
            result.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            perceptron.Train(1, 0, 1, Convert.ToInt32(textBox1.Text));
            perceptron.Train(0, 1, 1, Convert.ToInt32(textBox1.Text));
            perceptron.Train(1, 1, 1, Convert.ToInt32(textBox1.Text));
            perceptron.Train(0, 0, 0, Convert.ToInt32(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e) //GO button
        {
            one.Enabled = true;
            two.Enabled = true;
            result.Enabled = true;

            if (one.BackColor == Color.Green)
            {
                input1 = 1;
            }
            else
            {
                input1 = 0;
            }

            if (two.BackColor == Color.Green)
            {
                input2 = 1;
            }
            else
            {
                input2 = 0;
            }

            int output = perceptron.Activate(input1, input2);

            if (output > 0)
            {
                result.BackColor = Color.Green;
            }
            else
            {
                result.BackColor = Color.White;
            }

            inputOne.Text = input1.ToString();
            inputTwo.Text = input2.ToString();
            awtput.Text = output.ToString();

        }

        private void one_Click(object sender, EventArgs e)
        {
            if (one.BackColor == Color.White)
            {
                one.BackColor = Color.Green;
            }
            else
            {
                one.BackColor = Color.White;
            }
            
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (two.BackColor == Color.White)
            {
                two.BackColor = Color.Green;
            }
            else
            {
                two.BackColor = Color.White;
            }
        }
    }
}
