using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Global variables
        float input01;
        float input02;
        bool flagResult = false;
        bool flagInput01;
        bool flagInput02;
        bool flagClearInput;
        float total;
        char oper;
        string mode;
        int lblLocationX = 21;
        int lblLocationY = 4;
        int lblSizeWidth = 210;
        int lblLen = 0;

        //Don't allow typing for 16 digit
        public bool OnlySixteenDigit()
        {
            int lenInput = txtInput.TextLength;
            if (lenInput < 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Divide Method
        public void Divide(float input01, float input02)
        {
            //Controls flags
            flagResult = true; //change for true, because in the end of this method, it'll be a result
            flagClearInput = true; //change for true to allow new input at txtInput
            if (input02 == 0)
            {
                txtInput.Clear();
                txtInput.Text = "Cannot divide by zero!‬";
            }
            else
            {
                total = input01 / input02;
                txtInput.Text = total.ToString();
            }
        }
        //Multiply Method
        public void Multiply(float input01, float input02)
        {
            //Controls flags
            flagResult = true; //change for true, because in the end of this method, it'll be a result
            flagClearInput = true; //change for true to allow new input at txtInput
            total = input01 * input02;
            txtInput.Text = total.ToString();
        }
        //Sum Method
        public void Sum(float input01, float input02)
        {
            //Controls flags
            flagResult = true; //change for true, because in the end of this method, it'll be a result
            flagClearInput = true; //change for true to allow new input at txtInput
            total = input01 + input02;
            txtInput.Text = total.ToString();
        }
        //Minus Method
        public void Minus(float input01, float input02)
        {
            //Controls flags
            flagResult = true; //change for true, because in the end of this method, it'll be a result
            flagClearInput = true; //change for true to allow new input at txtInput
            total = input01 - input02;
            txtInput.Text = total.ToString();
        }
        //reset Method
        public void Reset()
        {
            input01 = 0;
            input02 = 0;
            flagResult = false;
            flagInput01 = false;
            flagInput02 = false;
            flagClearInput = false;
            total = 0;
            oper = 'x';
            txtInput.Clear();
            lblExpression.Text = "";
            txtInput02.Clear();
            txtInput01.Clear();
            lblLocationX = 21;
            lblLocationY = 4;
            lblSizeWidth = 210;
        }
        //BackSpace Method
        public string BackSpace(string text, int len)
        {
            int lenInput = text.Length;
            if (lenInput > 0)
            {
                string aux = text;
                return aux.Substring(0, lenInput - len);
            }
            else
            {
                return text;
            }

        }
        //Method shows which oper was the last
        public char IsDifferentOper(string text, char oper)
        {
            int lenInput = text.Length;
            string aux = text;
            if(text != "")
            {
                char lastChar = Convert.ToChar(aux.Substring(lenInput - 1, 1));
                if (lastChar != '+' && lastChar != '-' && lastChar != '/' && lastChar != '*')
                {
                    return 'n';//Number
                }
                else
                {
                    if (lastChar == oper)
                    {
                        return 'e';//Equal
                    }
                    else
                    {
                        return 'd';//Diferent
                    }
                }
            }
            else
            {
                return 'x';
            }
            
        }
        //miles to Kilometers Method
        public string MilesToKm(float miles)
        {
            double total;
            total = miles / 0.62137;
            return total.ToString("F4");
        }
        //Kilometers to Miles Method
        public string KmToMiles(float km)
        {
            double total;
            total = km * 0.62137;
            return total.ToString("F4");
        }
        //Pounds to Kilograms
        public string PoundsToKilograms(float pounds)
        {
            double total;
            total = pounds / 2.2046;
            return total.ToString("F4");
        }
        //Kilograms to Pounds
        public string KilogramsToPounds(float kilograms)
        {
            double total;
            total = kilograms * 2.2046;
            return total.ToString("F4");
        }
        //Method type of conversion
        public void TypeConversion(string type)
        {
            switch (type)
            {
                case "Miles":
                    txtInput02.Text = MilesToKm(float.Parse(txtInput01.Text)).ToString();
                    break;

                case "Kilometres":
                    txtInput02.Text = KmToMiles(float.Parse(txtInput01.Text)).ToString();
                    break;

                case "Pounds":
                    txtInput02.Text = PoundsToKilograms(float.Parse(txtInput01.Text)).ToString();
                    break;

                default:
                    txtInput02.Text = KilogramsToPounds(float.Parse(txtInput01.Text)).ToString();
                    break;
            }
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            char input = '9';
            if (mode == "conversor")
            {
                txtInput01.Text += input;
            }
            else
            {
                if (flagClearInput == true)
                {
                    txtInput.Clear();
                    flagClearInput = false;
                }
                if (OnlySixteenDigit())
                {
                    txtInput.Text += input;
                }
            }
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            char input = '8';
            if (mode == "conversor")
            {
                txtInput01.Text += input;
            }
            else
            {
                if (flagClearInput == true)
                {
                    txtInput.Clear();
                    flagClearInput = false;
                }
                if (OnlySixteenDigit())
                {
                    txtInput.Text += input;
                }
            }
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            char input = '7';
            if (mode == "conversor")
            {
                txtInput01.Text += input;
            }
            else
            {
                if (flagClearInput == true)
                {
                    txtInput.Clear();
                    flagClearInput = false;
                }
                if (OnlySixteenDigit())
                {
                    txtInput.Text += input;
                }
            }
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            char input = '6';
            if (mode == "conversor")
            {
                txtInput01.Text += input;
            }
            else
            {
                if (flagClearInput == true)
                {
                    txtInput.Clear();
                    flagClearInput = false;
                }
                if (OnlySixteenDigit())
                {
                    txtInput.Text += input;
                }
            }
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            char input = '5';
            if (mode == "conversor")
            {
                txtInput01.Text += input;
            }
            else
            {
                if (flagClearInput == true)
                {
                    txtInput.Clear();
                    flagClearInput = false;
                }
                if (OnlySixteenDigit())
                {
                    txtInput.Text += input;
                }
            }
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            char input = '4';
            if (mode == "conversor")
            {
                txtInput01.Text += input;
            }
            else
            {
                if (flagClearInput == true)
                {
                    txtInput.Clear();
                    flagClearInput = false;
                }
                if (OnlySixteenDigit())
                {
                    txtInput.Text += input;
                }
            }
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            char input = '3';
            if (mode == "conversor")
            {
                txtInput01.Text += input;
            }
            else
            {
                if (flagClearInput == true)
                {
                    txtInput.Clear();
                    flagClearInput = false;
                }
                if (OnlySixteenDigit())
                {
                    txtInput.Text += input;
                }
            }
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            char input = '2';
            if (mode == "conversor")
            {
                txtInput01.Text += input;
            }
            else
            {
                if (flagClearInput == true)
                {
                    txtInput.Clear();
                    flagClearInput = false;
                }
                if (OnlySixteenDigit())
                {
                    txtInput.Text += input;
                }
            }
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            char input = '1';
            if (mode == "conversor")
            {
                txtInput01.Text += input;
            }
            else
            {
                if (flagClearInput == true)
                {
                    txtInput.Clear();
                    flagClearInput = false;
                }
                if (OnlySixteenDigit())
                {
                    txtInput.Text += input;
                }
            }
        }

        private void BtnZero_Click_1(object sender, EventArgs e)
        {
            char input = '0';
            if (mode == "conversor")
            {
                txtInput01.Text += input;
            }
            else
            {
                if (flagClearInput == true)
                {
                    txtInput.Clear();
                    flagClearInput = false;
                }
                if (OnlySixteenDigit())
                {
                    txtInput.Text += input;
                }
            }
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            char input = '.';
            if (mode == "conversor")
            {
                if (txtInput01.TextLength == 0)
                {
                    txtInput01.Text = "0" + input;
                    return;
                }
                if (!txtInput01.Text.Contains('.'))
                {
                    txtInput01.Text += input;
                    return;
                }
            }
            else
            {
                if (txtInput.TextLength == 0)
                {
                    txtInput.Text = "0" + input;
                }
                if (!txtInput.Text.Contains('.'))
                {
                    txtInput.Text += input;
                    return;
                }
            }
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            //Set operator
            oper = '+';
            //IF dont have a result yet
            if (flagResult == false)
            {
                if (flagInput02 == false)
                {
                    //Test if the input is a real number
                    flagInput01 = float.TryParse(txtInput.Text, out input01);
                    if (flagInput01)
                    {
                        //show the expression
                        lblExpression.Text = txtInput.Text + " " + oper;
                        //clear txtInput
                        txtInput.Clear();
                        //flag Input = true
                        flagInput02 = true;
                        return;
                    }
                }
                //IF the last operator is not equal the current operator
                if (IsDifferentOper(lblExpression.Text, oper) == 'd')
                {
                    lblExpression.Text = BackSpace(lblExpression.Text, 1) + oper;
                    return;
                }
                else
                {
                    //Test if the input is a real number
                    flagInput02 = float.TryParse(txtInput.Text, out input02);
                    if (flagInput02)
                    {
                        Sum(input01, input02);
                        lblExpression.Text += " " + input02.ToString() + " = " + total.ToString();
                        return;
                    }
                }
            }
            //If has a result
            else
            {
                //if the last character is number, put oper
                if (IsDifferentOper(lblExpression.Text, oper) == 'n')
                {
                    lblExpression.Text += " " + oper;
                    return;
                }
                //IF is diferent operator, change
                else if (IsDifferentOper(lblExpression.Text, oper) == 'd')
                {
                    lblExpression.Text = BackSpace(lblExpression.Text, 1);
                    lblExpression.Text += oper;
                    return;
                }
                //else is equal do a calculation
                else
                {
                    flagInput02 = float.TryParse(txtInput.Text, out input02);
                    if (flagInput02)
                    {
                        Sum(total, input02);
                        lblExpression.Text += " " + input02.ToString() + " = " + total.ToString();
                        return;
                    }
                }
            }

        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            //Set operator
            oper = '-';

            //IF dont have a result yet
            if (flagResult == false)
            {
                if (flagInput02 == false)
                {
                    //Test if the input is a real number
                    flagInput01 = float.TryParse(txtInput.Text, out input01);
                    if (flagInput01)
                    {
                        //show the expression
                        lblExpression.Text = txtInput.Text + " " + oper;
                        //clear txtInput
                        txtInput.Clear();
                        //flag Input = true
                        flagInput02 = true;
                        return;
                    }
                }
                //IF the last operator is not equal the current operator
                if (IsDifferentOper(lblExpression.Text, oper) == 'd')
                {
                    lblExpression.Text = BackSpace(lblExpression.Text, 1) + oper;
                    return;
                }
                else
                {
                    //Test if the input is a real number
                    flagInput02 = float.TryParse(txtInput.Text, out input02);
                    if (flagInput02)
                    {
                        Minus(input01, input02);
                        lblExpression.Text += " " + input02.ToString() + " = " + total.ToString();
                        return;
                    }
                }
            }
            //If has a result
            else
            {
                //if the last character is number, put oper
                if (IsDifferentOper(lblExpression.Text, oper) == 'n')
                {
                    lblExpression.Text += " " + oper;
                    return;
                }
                //IF is diferent operator, change
                else if (IsDifferentOper(lblExpression.Text, oper) == 'd')
                {
                    lblExpression.Text = BackSpace(lblExpression.Text, 1);
                    lblExpression.Text += oper;
                    return;
                }
                //else is equal do a calculation
                else
                {
                    flagInput02 = float.TryParse(txtInput.Text, out input02);
                    if (flagInput02)
                    {
                        Minus(total, input02);
                        lblExpression.Text += " " + input02.ToString() + " = " + total.ToString();
                        return;
                    }
                }
            }
        }

        private void BtnMultiple_Click(object sender, EventArgs e)
        {
            //Set operator
            oper = '*';

            //IF dont have a result yet
            if (flagResult == false)
            {
                if (flagInput02 == false)
                {
                    //Test if the input is a real number
                    flagInput01 = float.TryParse(txtInput.Text, out input01);
                    if (flagInput01)
                    {
                        //show the expression
                        lblExpression.Text = txtInput.Text + " " + oper;
                        //clear txtInput
                        txtInput.Clear();
                        //flag Input = true
                        flagInput02 = true;
                        return;
                    }
                }
                //IF the last operator is not equal the current operator
                if (IsDifferentOper(lblExpression.Text, oper) == 'd')
                {
                    lblExpression.Text = BackSpace(lblExpression.Text, 1) + oper;
                    return;
                }
                else
                {
                    //Test if the input is a real number
                    flagInput02 = float.TryParse(txtInput.Text, out input02);
                    if (flagInput02)
                    {
                        Multiply(input01, input02);
                        lblExpression.Text += " " + input02.ToString() + " = " + total.ToString();
                        return;
                    }
                }
            }
            //If has a result
            else
            {
                //if the last character is number, put oper
                if (IsDifferentOper(lblExpression.Text, oper) == 'n')
                {
                    lblExpression.Text += " " + oper;
                    return;
                }
                //IF is diferent operator, change
                else if (IsDifferentOper(lblExpression.Text, oper) == 'd')
                {
                    lblExpression.Text = BackSpace(lblExpression.Text, 1);
                    lblExpression.Text += oper;
                    return;
                }
                //else is equal do a calculation
                else
                {
                    flagInput02 = float.TryParse(txtInput.Text, out input02);
                    if (flagInput02)
                    {
                        Multiply(total, input02);
                        lblExpression.Text += " " + input02.ToString() + " = " + total.ToString();
                        return;
                    }
                }
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            //Set operator
            oper = '/';

            //IF dont have a result yet
            if (flagResult == false)
            {
                if (flagInput02 == false)
                {
                    //Test if the input is a real number
                    flagInput01 = float.TryParse(txtInput.Text, out input01);
                    if (flagInput01)
                    {
                        //show the expression
                        lblExpression.Text = txtInput.Text + " " + oper;
                        //clear txtInput
                        txtInput.Clear();
                        //flag Input = true
                        flagInput02 = true;
                        return;
                    }
                }
                //IF the last operator is not equal the current operator
                if (IsDifferentOper(lblExpression.Text, oper) == 'd')
                {
                    lblExpression.Text = BackSpace(lblExpression.Text, 1) + oper;
                    return;
                }
                else
                {
                    //Test if the input is a real number
                    flagInput02 = float.TryParse(txtInput.Text, out input02);
                    if (flagInput02)
                    {
                        Divide(input01, input02);
                        lblExpression.Text += " " + input02.ToString() + " = " + total.ToString();
                        return;
                    }
                }
            }
            //If has a result
            else
            {
                //if the last character is number, put oper
                if (IsDifferentOper(lblExpression.Text, oper) == 'n')
                {
                    lblExpression.Text += " " + oper;
                    return;
                }
                //IF is diferent operator, change
                else if (IsDifferentOper(lblExpression.Text, oper) == 'd')
                {
                    lblExpression.Text = BackSpace(lblExpression.Text, 1);
                    lblExpression.Text += oper;
                    return;
                }
                //else is equal do a calculation
                else
                {
                    flagInput02 = float.TryParse(txtInput.Text, out input02);
                    if (flagInput02)
                    {
                        Divide(total, input02);
                        lblExpression.Text += " " + input02.ToString() + " = " + total.ToString();
                        return;
                    }
                }
            }
        }

        private void BrnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnChangeSign_Click(object sender, EventArgs e)
        {
            bool flag;
            float aux;
            flag = float.TryParse(txtInput.Text, out aux);
            if (flag)
            {
                aux *= -1;
                txtInput.Clear();
                txtInput.Text = aux.ToString();
            }
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (mode == "conversor")
            {
                txtInput01.Text = BackSpace(txtInput01.Text, 1);
                if (txtInput01.Text.Length == 0)
                {
                    txtInput02.Clear();
                }
                else
                {
                    string typeConversion = lblType01.Text;
                    TypeConversion(typeConversion);
                }
            }
            else
            {
                txtInput.Text = BackSpace(txtInput.Text, 1);
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            //IF it has a result
            if (flagResult == true)
            {
                int lenInput = lblExpression.Text.Length;
                string aux = lblExpression.Text;
                oper = Convert.ToChar(aux.Substring(lenInput - 1, 1));

                input02 = float.Parse(txtInput.Text);
                //Do the calculations
                switch (oper)
                {
                    case '+':
                        Sum(total, input02);
                        lblExpression.Text += " " + input02.ToString() + " = " + total.ToString();
                        flagInput01 = false;
                        flagInput02 = false;
                        break;

                    case '-':
                        Minus(total, input02);
                        lblExpression.Text += " " + input02.ToString() + " = " + total.ToString();
                        flagInput01 = false;
                        flagInput02 = false;
                        break;

                    case '*':
                        Multiply(total, input02);
                        lblExpression.Text += " " + input02.ToString() + " = " + total.ToString();
                        flagInput01 = false;
                        flagInput02 = false;
                        break;

                    case '/':
                        Divide(total, input02);
                        lblExpression.Text += " " + input02.ToString() + " = " + total.ToString();
                        flagInput01 = false;
                        flagInput02 = false;
                        break;

                    default:
                        break;
                }
            }
            else
            {
                flagInput02 = float.TryParse(txtInput.Text, out input02);
                if(flagInput02 == true)
                {
                    switch (oper)
                    {
                        case '+':
                            Sum(input01, input02);
                            lblExpression.Text += " " + input01.ToString() + " = " + total.ToString();
                            flagResult = true;
                            break;

                        case '-':
                            Minus(input01, input02);
                            lblExpression.Text += " " + input01.ToString() + " = " + total.ToString();
                            flagResult = true;
                            break;

                        case '/':
                            Divide(input01, input02);
                            lblExpression.Text += " " + input01.ToString() + " = " + total.ToString();
                            flagResult = true;
                            break;

                        case '*':
                            Multiply(input01, input02);
                            lblExpression.Text += " " + input01.ToString() + " = " + total.ToString();
                            flagResult = true;
                            break;
                    }
                }
                
            }
        }

        private void BtnConversion_Click(object sender, EventArgs e)
        {
            if(panelCalculate.Visible == true)
            {
                panelCalculate.Visible = false;
                panelConversion.Visible = true;
                btnSum.Enabled = false;
                btnMinus.Enabled = false;
                btnDivide.Enabled = false;
                btnMultiple.Enabled = false;
                btnEqual.Enabled = false;
                mode = "conversor";
                btnConversion.Text = "Calculate";
                lstType.SelectedIndex = 0;
                Reset();
            }
            else
            {
                panelCalculate.Visible = true;
                panelConversion.Visible = false;
                btnSum.Enabled = true;
                btnMinus.Enabled = true;
                btnDivide.Enabled = true;
                btnMultiple.Enabled = true;
                btnEqual.Enabled = true;
                mode = "calculator";
                btnConversion.Text = "Conversion";
                Reset();
            }
        }

        private void BtnReverte_Click(object sender, EventArgs e)
        {
            string auxReverte = "";
            if(lstType.SelectedIndex == 0)
            {
                auxReverte = lblType01.Text;
                lblType01.Text = lblType02.Text;
                lblType02.Text = auxReverte;
                auxReverte = txtInput01.Text;
                txtInput01.Text = txtInput02.Text;
                txtInput02.Text = auxReverte;
            }
            else
            {
                auxReverte = lblType01.Text;
                lblType01.Text = lblType02.Text;
                lblType02.Text = auxReverte;
                auxReverte = txtInput01.Text;
                txtInput01.Text = txtInput02.Text;
                txtInput02.Text = auxReverte;
            }
        }

        private void LstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstType.SelectedIndex == 0)
            {
                lblType01.Text = "Miles";
                lblType02.Text = "Kilometres";
                Reset();
            }
            else
            {
                lblType01.Text = "Pounds";
                lblType02.Text = "Kilograms";
                Reset();
            }
        }

        private void TxtInput01_TextChanged(object sender, EventArgs e)
        {
            if(txtInput01.Text != "")
            {
                string typeConversion = lblType01.Text;
                TypeConversion(typeConversion);
            }
            
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            if(txtInput.TextLength <= 6)
            {
                txtInput.Font = new Font("Microsoft Sans Serif", 48.0f); 
            }
            else if(txtInput.TextLength > 6 && txtInput.TextLength < 12)
            {
                txtInput.Font = new Font("Microsoft Sans Serif", 30.0f);
            }
            else
            {
                txtInput.Font = new Font("Microsoft Sans Serif", 20.0f);
            }
        }

        private void LblExpression_TextChanged(object sender, EventArgs e)
        {
            lblLocationX = lblExpression.Location.X;
            lblLocationY = lblExpression.Location.Y;
            lblSizeWidth = lblExpression.Width;
            lblLen = lblExpression.Text.Length;

            if (lblLen >= 43)
            {
                lblExpression.TextAlign = ContentAlignment.MiddleRight;
                lblExpression.Size = new Size(lblSizeWidth + 1 + lblLen, 23);
                lblExpression.Location = new Point(lblLocationX + 1 - lblLen, lblLocationY);
            }

        }

        private void BtnForwardLbl_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnBackwardLbl_Click(object sender, EventArgs e)
        {
            int lenLblLocationX = lblLocationX + 1 - lblLen;
            MessageBox.Show(lblLocationX.ToString());
            lblExpression.Location = new Point(lenLblLocationX + 1, lblLocationY);
            lblLocationX = lenLblLocationX + 1;
            MessageBox.Show(lblLocationX.ToString());
        }
    }
}
