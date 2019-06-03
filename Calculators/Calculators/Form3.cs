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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            //Form3 fr3 = new Form3();
            //fr3.Close();
        }

        private void BtnDistance_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            //Form3 fr3 = new Form3();
            //fr3.Close();
        }

        private void BtnWeight_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            //Form3 fr3 = new Form3();
            //fr3.Close();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }
    }
}
