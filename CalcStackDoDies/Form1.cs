using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcStackDoDies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(Input1.Text);
            double second = Convert.ToDouble(Input2.Text);
            double result = first - second;
            Result.Text = Convert.ToString(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(Input1.Text);
            double second = Convert.ToDouble(Input2.Text);
            double result = first * second;
            Result.Text = Convert.ToString(result);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(Input1.Text);
            double second = Convert.ToDouble(Input2.Text);
            double result = first + second;
            Result.Text = Convert.ToString(result);
        }

        private void Div_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(Input1.Text);
            double second = Convert.ToDouble(Input2.Text);
            double result = first / second;
            Result.Text = Convert.ToString(result);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(Input1.Text);
            double second = Convert.ToDouble(Input2.Text);
            double result;

            switch (((Button)sender).Name)
            {
                case "Plus":
                    result = first + second;
                    Result.Text = Convert.ToString(result);
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }

            Result.Text = Convert.ToString(result);
        }
    }
}
