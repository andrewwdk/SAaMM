using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if(IsValid(mTextBox.Text) && IsValid(aTextBox.Text) && IsValid(R0TextBox.Text))
            {
                double m = Convert.ToDouble(mTextBox.Text);
                double a = Convert.ToDouble(aTextBox.Text);
                double R0 = Convert.ToDouble(R0TextBox.Text);

                if(m <= a)
                {
                    MessageBox.Show("m should be greater than a!");
                }
            }
            else
            {
                MessageBox.Show("All the values should be positive!");
            }
        }
        
        private bool IsValid(string text)
        {
            bool result = true;
            double number;

            if (double.TryParse(text, out number))
            {
                if(number <= 0)
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
