using System;
using System.Windows.Forms;

namespace CalcStackDoDies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                    break;
                case "Minus":
                    result = first - second;
                    break;
                case "Mul":
                    result = first * second;
                    break;
                case "Div":
                    result = first / second;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }

            Result.Text = Convert.ToString(result);
        }
    }
}
