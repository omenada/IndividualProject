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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Convertion(object sender, EventArgs e)
        {

        }

        private void Txtinput_TextChanged(object sender, EventArgs e)
        {
            if(txtinput.Text == "")
            {

                Console.Write("Please Insert a Value.");
            }
            else
            {

                txtinput.Text = txtinput.Text;
            }
            
        }
    }
}
