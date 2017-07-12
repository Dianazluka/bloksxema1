using System;
using System.Windows.Forms;
using CalcStackDoDies.OneArgument;
using CalcStackDoDies.TwoArgument;

namespace CalcStackDoDies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TwoArgumentButtonClick(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(Input1.Text);
            double second = Convert.ToDouble(Input2.Text);
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button) sender).Name);
            double result = calculator.Calculate(first, second);
            Result.Text = Convert.ToString(result);
        }

        private void OneArgumentButtonClick(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(Input1.Text);
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(first);
            Result.Text = Convert.ToString(result);
        }


    }
}
