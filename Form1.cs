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

            txtDisplay.Text = "";

            string f, s;

            f = Convert.ToString(firstNum);
            s = Convert.ToString(secondNum);

            f = "";
            s = "";
        }

        private void Operational_Func(object sender, EventArgs e)
        {
            try
            {

                Button b = (Button)sender;
                firstNum = Double.Parse(txtDisplay.Text);
                operation = b.Text;
                txtDisplay.Text = "";

            }
            catch

            {
                
                    MessageBox.Show("Enter digits only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            else if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "";
            }
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
                
                case "/":
                    if (secondNum == 0)
                    {
                        MessageBox.Show("You can not divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    { txtDisplay.Text = Convert.ToString(firstNum / secondNum); }
                    break;
                
                default:
                    break;
            }
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
