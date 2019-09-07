using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab1
{
    public partial class Form1 : Form
    {
        const int N = 100000;
        const int k = 20; // count of intervals
        const double xMin = 0;
        const double delta = 1 / (double)k;
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
            int[] countInIntervals = new int[k];

            DoEstimationsCalculations(xList, out Mx, out Dx, out GAMMAx);
            PrintEstimations(Mx, Dx, GAMMAx);
            DoDiagramCalculations(xList, countInIntervals);
            DrawDiagram(countInIntervals);
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

        private void DoDiagramCalculations(List<double> xList, int[] countInIntervals)
        {
            int intervalNumber;

            foreach(double x in xList)
            {
                intervalNumber = (int)Math.Truncate(x / delta);
                countInIntervals[intervalNumber]++;
            }
        }

        private void DrawDiagram(int[] countInIntervals)
        {
            chart1.Series["Ci"].Points.Clear();

            chart1.ChartAreas[0].AxisY.Maximum = 0.1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 1;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            for (int i = 0; i < countInIntervals.Length; i++)
            {
                chart1.Series["Ci"].Points.AddXY(i*delta + delta / 2, countInIntervals[i] / (double)N);
            }

            StripLine stripline = new StripLine();
            stripline.StripWidth = 0.00001;
            stripline.BackColor = Color.Red;
            stripline.IntervalOffset = 1 / (double)k;

            chart1.ChartAreas[0].AxisY.StripLines.Add(stripline);
        }
    }
}
