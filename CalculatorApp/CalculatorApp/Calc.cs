using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calc : Form
    {
        bool clearTheEquation = true;
        bool clearTheDisplay = true;
        double operand1 = 0;
        string op = "";
        double operand2 = 0;

        public Calc()
        {
            InitializeComponent();
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            display.Focus();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            operand1 = 0;
            op = "";
            operand2 = 0;
            equation.Text = "";

            display.Text = "0";
            display.Focus();
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            display.Text = display.Text.Remove(display.Text.Length - 1);
            if (display.Text == "-" || display.Text.Contains("E") || display.Text == "") { display.Text = "0"; }

            if (clearTheEquation)
            {
                equation.Text = "";
                clearTheEquation = false;
            }
            display.Focus();
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            if (clearTheEquation)
            {
                equation.Text = "";
                clearTheEquation = false;
            }
            if (clearTheDisplay)
            {
                display.Text = "0";
                clearTheDisplay = false;
            }

            Button btn = (Button)sender;

            switch (btn.Text)
            {
                case "0":
                    if (display.Text != "0")
                    {
                        display.Text = display.Text + "0";
                    }
                    break;

                case ".":
                    if (!display.Text.Contains("."))
                    {
                        display.Text = display.Text + ".";
                    }
                    break;

                default:
                    if (display.Text == "0")
                    {
                        display.Text = btn.Text;
                    }
                    else
                    {
                        display.Text = display.Text + btn.Text;
                    }
                    break;
            }
            display.Focus();
        }

        private void UnaryOp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (clearTheEquation) {
                equation.Text = "";
                clearTheEquation = false;
            }

            switch (btn.Text)
            {
                case "+/-":
                    display.Text = (-Double.Parse(display.Text)).ToString();
                    break;

                case "x²":
                    display.Text = (Double.Parse(display.Text) * Double.Parse(display.Text)).ToString();
                    break;

                case "√x":
                    if (Double.Parse(display.Text) >= 0)
                    {
                        display.Text = (Math.Sqrt(Double.Parse(display.Text))).ToString();
                    }
                    else
                    {
                        equation.Text = "sqrt([negative number]) is Invalid";
                        ResetCalcutor();
                        return;
                    }
                    break;

                case "¹/x":
                    if (display.Text != "0")
                    {
                        display.Text = (1 / Double.Parse(display.Text)).ToString();
                    }
                    else
                    {
                        equation.Text = "(Cannot divide by zero)";
                        ResetCalcutor();
                        return;
                    }
                    break;

                case "%":
                    display.Text = (0.01 * Double.Parse(display.Text)).ToString();
                    break;
            }
            display.Focus();
        }

        private void BinaryOp_Click(object sender, EventArgs e)
        {
            if (op != "") // if (operator is set) { compute with the previous op and continue with the next op }
            {
                display.Text = Calculate(operand1, op, Double.Parse(display.Text));
            }
            operand1 = Double.Parse(display.Text);

            Button btn = (Button)sender;
            op = btn.Text;

            equation.Text = operand1 + " " + op;

            clearTheEquation = false;
            clearTheDisplay = true;
            display.Focus();
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            operand2 = Double.Parse(display.Text);

            if (op != "") // if (operator is set) { compute the operation }
            {
                equation.Text = operand1 + " " + op + " " + operand2 + " =";
                display.Text = Calculate(operand1, op, operand2);
            }

            ResetCalcutor();
            display.Focus();
        }

        private string Calculate(double a, string optr, double b)
        {
            switch (optr)
            {
                case "+":
                    return (a + b).ToString();

                case "-":
                    return (a - b).ToString();

                case "*":
                    return (a * b).ToString();

                case "/":
                    if (b != 0)
                    {
                        return (a / b).ToString();
                    }
                    else
                    {
                        equation.Text = "(Cannot divide by zero)";
                        ResetCalcutor();
                        return display.Text;
                    }

                default:
                    return display.Text;
            }
        }

        private void ResetCalcutor()
        {
            operand1 = 0;
            op = "";
            operand2 = 0;
            clearTheEquation = true;
            clearTheDisplay = true;
        }

        private void Calc_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());

            switch (e.KeyCode.ToString())
            {
                case "Escape":
                    clear.PerformClick();
                    break;

                case "Back":
                    backspace.PerformClick();
                    break;

                case "Return":
                    equal.PerformClick();
                    break;
            }
        }

        private void Calc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());

            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;

                case "1":
                    one.PerformClick();
                    break;

                case "2":
                    two.PerformClick();
                    break;

                case "3":
                    three.PerformClick();
                    break;

                case "4":
                    four.PerformClick();
                    break;

                case "5":
                    five.PerformClick();
                    break;

                case "6":
                    six.PerformClick();
                    break;

                case "7":
                    seven.PerformClick();
                    break;

                case "8":
                    eight.PerformClick();
                    break;

                case "9":
                    nine.PerformClick();
                    break;

                case ".":
                    dot.PerformClick();
                    break;

                case "+":
                    add.PerformClick();
                    break;

                case "-":
                    sub.PerformClick();
                    break;

                case "*":
                    mul.PerformClick();
                    break;

                case "/":
                    div.PerformClick();
                    break;

                case "%":
                    percent.PerformClick();
                    break;

                case "^":
                    square.PerformClick();
                    break;

                case "=":
                    equal.PerformClick();
                    break;

                default:
                    break;
            }
        }
    }
}
