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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Convertion(object sender, EventArgs e)
        {


            if (rdPoundsKls.Checked == true)
            {

                double i = 0;
                double.TryParse(txtinput.Text, out i);
                i.ToString();
                if (i.ToString() == "0")
                {
                    MessageBox.Show("Please insert a value!");

                }
                else
                {

                    double result = (i * 0.4535924);
                    txtConverted.Text = result.ToString();
                    txtConverted.Show();
                }

            }

            if (rdKilosPound.Checked == true)

            {

                double i = 0;
                double.TryParse(txtinput.Text, out i);
                i.ToString();

                if (i.ToString() == "0")
                {
                    MessageBox.Show("Please insert a value!");

                }

                else
                {
                    double result = (i * 2.20462);
                    txtConverted.Text = result.ToString();
                    txtConverted.Show();
                }

            }



        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Close();
            System.Environment.Exit(1);
        }
    }
}
