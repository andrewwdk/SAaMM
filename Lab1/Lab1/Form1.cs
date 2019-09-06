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
        const int N = 100000;
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

                if(m > a)
                {
                    DoCalculations(m, a, R0);
                }
                else
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

        private void DoCalculations(double m, double a, double R0)
        {
            Generator gen = new Generator(a, m, R0);
            List<double> xList = new List<double>();

            foreach(double x in gen.GetNext().Take(N))
            {
                xList.Add(x);
            }

            double Mx, Dx, GAMMAx;

            DoEstimationsCalculations(xList, out Mx, out Dx, out GAMMAx);
            PrintEstimations(Mx, Dx, GAMMAx);
        }

        private void DoEstimationsCalculations(List<double> xList, out double Mx, out double Dx, out double GAMMAx)
        {
            double sum = 0, sumD = 0;

            foreach(double x in xList)
            {
                sum += x;
            }

            Mx = sum / N;

            foreach (double x in xList)
            {
                sumD += (x - Mx) * (x - Mx);
            }

            Dx = sumD / N;
            GAMMAx = Math.Sqrt(Dx);
        }

        private void PrintEstimations(double Mx, double Dx, double GAMMAx)
        {
            MxLabel.Text = Math.Round(Mx, 4).ToString();
            DxLabel.Text = Math.Round(Dx, 4).ToString();
            GAMMAxLabel.Text = Math.Round(GAMMAx, 4).ToString();
        }
    }
}
