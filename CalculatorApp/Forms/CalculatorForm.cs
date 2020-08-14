using CalculatorApp.Classes;
using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            mainTextBox.Text = null;
        }

        AddOperator addOperator = new AddOperator();

        // Value Configurations
        private void zeroButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = AddValue.Value("0");
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = AddValue.Value("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = AddValue.Value("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = AddValue.Value("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = AddValue.Value("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = AddValue.Value("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = AddValue.Value("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = AddValue.Value("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = AddValue.Value("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = AddValue.Value("9");
        }

        private void periodButton_Click(object sender, EventArgs e)
        {
            if (!mainTextBox.Text.Contains("."))
            {
                mainTextBox.Text = AddValue.Value(".");
            }
        }

        //Operator Configurationssssss
        public void plusButton_Click(object sender, EventArgs e)
        {
            equationTextBox.Text = addOperator.Operator("+", mainTextBox.Text);
            mainTextBox.Text = String.Empty;
        }

        public void minusButton_Click(object sender, EventArgs e)
        {
            equationTextBox.Text = addOperator.Operator("-", mainTextBox.Text);
            mainTextBox.Text = String.Empty;
        }

        public void multiplyButton_Click(object sender, EventArgs e)
        {
            equationTextBox.Text = addOperator.Operator("X", mainTextBox.Text);
            mainTextBox.Text = String.Empty;
        }

        public void divideButton_Click(object sender, EventArgs e)
        {            
            equationTextBox.Text = addOperator.Operator("/", mainTextBox.Text);
            mainTextBox.Text = String.Empty;
        }

        private void powerOfButton_Click(object sender, EventArgs e)
        {            
            equationTextBox.Text = addOperator.Operator("^", mainTextBox.Text);
            mainTextBox.Text = String.Empty;
        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {
            equationTextBox.Text = "²√" + "(" + mainTextBox.Text + ")";
            SquareRootButton Square = new SquareRootButton();
            mainTextBox.Text = Square.SquareRoot(mainTextBox.Text);
        }

        //Other Configurations
        public void equalsButton_Click(object sender, EventArgs e)
        {            
            EqualsButton Equals = new EqualsButton();
            mainTextBox.Text = Convert.ToString(Equals.ComputeAnswer(addOperator.firstValue, mainTextBox.Text, addOperator.mathOperator));
            equationTextBox.Text = String.Empty;             
        }
        public void backSpace_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = String.Empty;
            equationTextBox.Text = String.Empty;
            
            AddValue.currentValue = null;
        }
        private void negateButton_Click(object sender, EventArgs e)
        {
            NegateButton Negate = new NegateButton();
            mainTextBox.Text = Negate.Negate(mainTextBox.Text);
        }
    }
}
