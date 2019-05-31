using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void Btn_Click(object sender, EventArgs e)
        {
            if ((textInput.Text == "0")|| (operation_pressed))  // clear  value and operator
                textInput.Clear();
            operation_pressed = false;
            Button b = (Button)sender; // read all number and ,
            textInput.Text = textInput.Text + b.Text;
                        
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textInput.Text = "0";
            equation.Text = "";
            value = 0;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button o = (Button)sender;
            operation = o.Text;
            value = Double.Parse(textInput.Text);
            operation_pressed = true;
            equation.Text = value + operation;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
          
            equation.Text = "";
            switch (operation)

            {
                case "+":
                    textInput.Text = (value + Double.Parse(textInput.Text)).ToString();
                    break;

                case "*":
                    textInput.Text = (value * Double.Parse(textInput.Text)).ToString();
                    break;
                case "/":
                    textInput.Text = (value / Double.Parse(textInput.Text)).ToString();
                    break;
                case "-":
                    textInput.Text = (value - Double.Parse(textInput.Text)).ToString();
                    break;
                                                        
            }// end switch
            

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Close();
            System.Environment.Exit(1);
        }
    }
}
