using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input;
        double val1;
        double val2;
        double result;
        string val3= string.Empty;
        //double val4;
        string action;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button1.Text;
            input = textBox1.Text;
            if (input.Contains("+") || input.Contains("-")|| input.Contains("*")|| input.Contains("/"))
            {
                val3 += "1";
                val2 = double.Parse(val3.ToString());
            }
            else
            {
                val1 = double.Parse(input);
            }
             // input + button1.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button2.Text; 
            input = textBox1.Text;
            if (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/"))
            {
                val3 += "2";
                val2 = double.Parse(val3.ToString());
                
                
            }
            else
            {
                val1 = double.Parse(input);

            }//input += button1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button3.Text; 
            input = textBox1.Text;
            if (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/"))
            {
                val3 += "3";
                val2 = double.Parse(val3.ToString());
            }
            else
            {
                val1 = double.Parse(input);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button4.Text;
            input = textBox1.Text;
            if (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/"))
            {
                val3 += "4";
                val2 = double.Parse(val3.ToString());
            }
            else
            {
                val1 = double.Parse(input);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button5.Text; 
            input = textBox1.Text;
            if (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/"))
            {
                val3 += "5";
                val2 = double.Parse(val3.ToString());
            }
            else
            {
                val1 = double.Parse(input);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button6.Text;
            input = textBox1.Text;
            if (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/"))
            {
                val3 += "6";
                val2 = double.Parse(val3.ToString());
            }
            else
            {
                val1 = double.Parse(input);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button7.Text;
            input = textBox1.Text;
            if (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/"))
            {
                val3 += "7";
                val2 = double.Parse(val3.ToString());
            }
            else
            {
                val1 = double.Parse(input);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button8.Text;
            input = textBox1.Text;
            if (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/"))
            {
                val3 += "8";
                val2 = double.Parse(val3.ToString());
            }
            else
            {
                val1 = double.Parse(input);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button9.Text;
            input = textBox1.Text;
            if (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/"))
            {
                val3 += "9";
                val2 = double.Parse(val3.ToString());
            }
            else
            {
                val1 = double.Parse(input);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button10.Text;
            input = textBox1.Text;
            action = "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button11.Text;
            input = textBox1.Text;
            action = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button12.Text;
            input = textBox1.Text;
            action = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button13.Text;
            input = textBox1.Text;
            action = "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (action =="+")
            {
                result = val1 + val2;
                textBox1.Text = result.ToString();
                val1 = result;
               // MessageBox.Show(result);
            
            }
            else if (action == "-")
            {
                result = val1 - val2;
                textBox1.Text = result.ToString();
                val1 = result;
                // MessageBox.Show(result);

            }
            else if (action == "*")
            {
                result = val1 * val2;
                textBox1.Text = result.ToString();
                val1 = result;
                // MessageBox.Show(result);

            }
            else if (action == "/")
            {
                result = val1 / val2;
                textBox1.Text = result.ToString();
                val1 = result;
                // MessageBox.Show(result);

            }
            input = textBox1.Text;
            val2 = 0;
            val3 = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            input = input.Remove(input.Length-1,1);
            textBox1.Text = input;
            input = textBox1.Text;
            if (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/"))
            {
                val3 = val3.Remove(val3.Length - 1, 1); ;
                val2 = double.Parse(val3.ToString());
            }
            else
            {
                val1 = double.Parse(input);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = string.Empty;
            val1 = 0;
            val2 = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button18.Text;
            input = textBox1.Text;
            if (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/"))
            {
                val3 += "0";
                val2 = double.Parse(val3.ToString());
            }
            else
            {
                val1 = double.Parse(input);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result = val1 * val1;
            textBox1.Text = result.ToString();
            val1 = result;
            val1 = 0;
            input = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            result = val1 * val1*val1;
            textBox1.Text = result.ToString();
            val1 = result;
            val1 = 0;
            input = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = input + button20.Text;
            input = textBox1.Text;
            if (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/"))
            {
                val3 += ".";
                val2 = double.Parse(val3.ToString());


            }
            else
            {
                val1 = double.Parse(input);

            }


        }
    }
}
