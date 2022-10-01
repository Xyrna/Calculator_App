using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        string operation = "";
        double firstNum, secondNum;
        double f, d;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (txtDisplay.Text == "0") txtDisplay.Text = "";

            txtDisplay.Text += b.Text;
        }

        

        private void buttonCE_Click(object sender, EventArgs e)
        {

            txtDisplay.Text = "0";

            string f, s;

            f = Convert.ToString(firstNum);
            s = Convert.ToString(secondNum);

            f = "";
            s = "";
        }

        private void Operational_Func(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstNum = Double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            else if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            }

            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }
        private void Pow2(object sender, EventArgs e)
        {
            
            firstNum = Double.Parse(txtDisplay.Text);
            operation = "pow";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            secondNum = Double.Parse(txtDisplay.Text);

            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(firstNum + secondNum);
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(firstNum - secondNum);
                    break;
                case "*":
                    txtDisplay.Text = Convert.ToString(firstNum * secondNum);
                    break;
                case "pow":
                    txtDisplay.Text = Convert.ToString(Math.Pow(firstNum, 2));
                    break;
                case "pow3":
                    txtDisplay.Text = Convert.ToString(Math.Pow(firstNum, 3));
                    break;
                case "sqrt":
                    txtDisplay.Text = Convert.ToString(Math.Sqrt(firstNum));
                    break;
                case "/":
                    if (secondNum == 0)
                    {
                        MessageBox.Show("You can not divide by zero!");
                    }
                    else
                    { txtDisplay.Text = Convert.ToString(firstNum / secondNum); }
                    break;
                
                default:
                    break;
            }
        }

        private void sqrt(object sender, EventArgs e)
        {
            firstNum = Double.Parse(txtDisplay.Text);
            operation = "sqrt";
        }

        private void pow3(object sender, EventArgs e)
        {
            firstNum = Double.Parse(txtDisplay.Text);
            operation = "pow3";
        }

        private void DotValue(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains(",") && txtDisplay.Text != "") txtDisplay.Text += ",";
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
