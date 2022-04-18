namespace CalcButBetter
{
    public partial class Calculator : Form
    {
        float StoredNumber; //last num input to result when operator pressed
        float NumUsed; //last num input
        float DisplayNum; //result
        float ResultNum;
        string StoredOperator; //+, -, *, /
        bool OperatorPressed = false;
        bool ErrorResult = false;
        List<int> TwoToNine = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9 };
        List<char> OperatorSymbols = new List<char>() { '+', '-', '/', '*' };


        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OperatorPressed)
            {
                OperatorPressed = false;
                display.Text = "";
            }
            display.Text += button1.Text;
            NumUsed = float.Parse(display.Text);
            DisplayNum = NumUsed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OperatorPressed)
            {
                OperatorPressed = false;
                display.Text = "";
            }
            display.Text += button2.Text;
            NumUsed = float.Parse(display.Text);
            DisplayNum = NumUsed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OperatorPressed)
            {
                OperatorPressed = false;
                display.Text = "";
            }
            display.Text += button3.Text;
            NumUsed = float.Parse(display.Text);
            DisplayNum = NumUsed;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OperatorPressed)
            {
                OperatorPressed = false;
                display.Text = "";
            }
            display.Text += button4.Text;
            NumUsed = float.Parse(display.Text);
            DisplayNum = NumUsed;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (OperatorPressed)
            {
                OperatorPressed = false;
                display.Text = "";
            }
            display.Text += button5.Text;
            NumUsed = float.Parse(display.Text);
            DisplayNum = NumUsed;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (OperatorPressed)
            {
                OperatorPressed = false;
                display.Text = "";
            }
            display.Text += button6.Text;
            NumUsed = float.Parse(display.Text);
            DisplayNum = NumUsed;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (OperatorPressed)
            {
                OperatorPressed = false;
                display.Text = "";
            }
            display.Text += button7.Text;
            NumUsed = float.Parse(display.Text);
            DisplayNum = NumUsed;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (OperatorPressed)
            {
                OperatorPressed = false;
                display.Text = "";
            }
            display.Text += button8.Text;
            NumUsed = float.Parse(display.Text);
            DisplayNum = NumUsed;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (OperatorPressed)
            {
                OperatorPressed = false;
                display.Text = "";
            }
            display.Text += button9.Text;
            NumUsed = float.Parse(display.Text);
            DisplayNum = NumUsed;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (OperatorPressed)
            {
                OperatorPressed = false;
                display.Text = "";
            }
            display.Text += button0.Text;
            NumUsed = float.Parse(display.Text);
            DisplayNum = NumUsed;
        }

        private void buttonEQL_Click(object sender, EventArgs e)
        {
            switch (StoredOperator)
            {
                case "+":
                    ResultNum = StoredNumber + NumUsed;
                    StoredNumber = ResultNum;
                    break;
                case "-":
                    ResultNum = StoredNumber - NumUsed;
                    StoredNumber = ResultNum;
                    break;
                case "*":
                    ResultNum = StoredNumber * NumUsed;
                    StoredNumber = ResultNum;
                    break;
                case "/":
                    ResultNum = StoredNumber / NumUsed;
                    StoredNumber = ResultNum;
                    break;
                default:
                    ResultNum = NumUsed;
                    StoredNumber = ResultNum;
                    break;
            }

            DisplayNum = ResultNum;
            display.Text = DisplayNum.ToString();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            OperatorPressed = true;
            StoredOperator = buttonADD.Text;
            operatorDisplay.Text = StoredOperator;
            StoredNumber = NumUsed;
        }

        private void buttonSUB_Click(object sender, EventArgs e)
        {
            OperatorPressed = true;
            StoredOperator = buttonSUB.Text;
            operatorDisplay.Text = StoredOperator;
            StoredNumber = NumUsed;
        }

        private void buttonMUL_Click(object sender, EventArgs e)
        {
            OperatorPressed = true;
            StoredOperator = buttonMUL.Text;
            operatorDisplay.Text = StoredOperator;
            StoredNumber = NumUsed;
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {
            OperatorPressed = true;
            StoredOperator = buttonDIV.Text;
            operatorDisplay.Text = StoredOperator;
            StoredNumber = NumUsed;
        }

        private void buttonCLR_Click(object sender, EventArgs e)
        {
            StoredNumber = 0;
            NumUsed = 0;
            DisplayNum = 0;
            display.Text = "";
            OperatorPressed = false;
            StoredOperator = "";
            operatorDisplay.Text = "";
            ResultNum = 0;
            ErrorResult = false;
        }

        private void buttonDEC_Click(object sender, EventArgs e)
        {
            OperatorPressed = true;
            display.Text = "";

            foreach (int n in TwoToNine)
            {
                if (DisplayNum.ToString().Contains(n.ToString()))
                {
                    ErrorResult = true;
                }
            }

            if (!ErrorResult)
            {
                string binNum = DisplayNum.ToString();
                int num = Convert.ToInt32(binNum, 2);
                DisplayNum = num;
                display.Text = DisplayNum.ToString();
            }
            else
            {  
                display.Text = DisplayNum.ToString();
            }
        }

        private void buttonBIN_Click(object sender, EventArgs e)
        {
            OperatorPressed = true;
            display.Text = "";
            string binNum = "";
            int numToConvert = (int)DisplayNum;
            int remainder;

            while (numToConvert > 0)
            {
                remainder = numToConvert % 2;
                numToConvert /= 2;
                binNum = remainder.ToString() + binNum;
            }
            DisplayNum = float.Parse(binNum);
            display.Text = DisplayNum.ToString();
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                    button0_Click(sender, e);
                    break;
                case Keys.D1:
                    button1_Click(sender, e);
                    break;
                case Keys.D2:
                    button2_Click(sender, e);
                    break;
                case Keys.D3:
                    button3_Click(sender, e);
                    break;
                case Keys.D4:
                    button4_Click(sender, e);
                    break;
                case Keys.D5:
                    button5_Click(sender, e);
                    break;
                case Keys.D6:
                    button6_Click(sender, e);
                    break;
                case Keys.D7:
                    button7_Click(sender, e);
                    break;
                case Keys.D8:
                    button8_Click(sender, e);
                    break;
                case Keys.D9:
                    button9_Click(sender, e);
                    break;
                case Keys.Oemplus:
                    buttonADD_Click(sender, e);
                    break;
                case Keys.OemMinus:
                    buttonSUB_Click(sender, e);
                    break;
                case Keys.Multiply:
                    buttonMUL_Click(sender, e);
                    break;
                case Keys.Divide:
                    buttonDIV_Click(sender, e);
                    break;
                case Keys.Enter:
                    buttonEQL_Click(sender, e);
                    break;
                case Keys.Back:
                    buttonCLR_Click(sender, e);
                    break;
            }
        }
    }
}