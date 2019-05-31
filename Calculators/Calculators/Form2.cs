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

        

        private void Txtinput_TextChanged(object sender, EventArgs e)
        {
           
            
        }
       
       
        private void Convertion(object sender, EventArgs e)
        {
                      

            if (rbKiltoMiles.Checked == true)
            {

                double i = 0;
                double.TryParse(txtinput.Text,out i);
                i.ToString();
                if (i.ToString() == "0")
                {
                    MessageBox.Show("Please insert a value!");

                }                    
                else
                {

                    double result = (i * 1.609344);
                    txtConverted.Text = result.ToString();
                    txtConverted.Show();
                }    
                
            }
             
            if (rbMilestoKil.Checked == true)

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
                    double result = (i * 0.621371192);
                    txtConverted.Text = result.ToString();
                    txtConverted.Show();
                }

            }

            
            
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Close();
            System.Environment.Exit(1);
        }
    }
}
