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
        const double yMin = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if(IsValid(mTextBox.Text) && IsValid(aTextBox.Text) && IsValid(R0TextBox.Text))
            {
                int m = Convert.ToInt32(mTextBox.Text);
                int a = Convert.ToInt32(aTextBox.Text);
                int R0 = Convert.ToInt32(R0TextBox.Text);

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
                MessageBox.Show("All the values should be positive integers!");
            }
        }
        
        private bool IsValid(string text)
        {
            bool result = true;
            int number;

            if (int.TryParse(text, out number))
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


            if (uniformRadioButton.Checked)
            {

                double a1 = double.Parse(a1TextBox.Text);
                double b = double.Parse(bTextBox.Text);
                xList = Distributions.Uniform(gen.GetNext().Take(N), a1, b);
            }
            if (gaussRadioButton.Checked)
            {
                double m1 = double.Parse(m1TextBox.Text);
                double sigma = double.Parse(sigmaTextBox.Text);
                xList = Distributions.Gauss(gen.GetNext().Take(N), m1, sigma);
            }
            if (exponentialRadioButton.Checked)
            {
                double lambda = double.Parse(lambdaTextBox.Text);
                xList = Distributions.Exponential(gen.GetNext().Take(N), lambda);
            }
            if (gammaRadioButton.Checked)
            {
                int n = int.Parse(nTextBox.Text);
                double lambda = double.Parse(lambdaTextBox.Text);
                xList = Distributions.Gamma(gen.GetNext().Take(N), lambda, n);
            }
            if (triangleRadioButton.Checked)
            {
                double a1 = double.Parse(a1TextBox.Text);
                double b = double.Parse(bTextBox.Text);
                xList = Distributions.Triangle(gen.GetNext().Take(N), a1, b);
            }
            if (simphsonRadioButton.Checked)
            {
                double a1 = double.Parse(a1TextBox.Text);
                double b = double.Parse(bTextBox.Text);
                xList = Distributions.Simpson(gen.GetNext().Take(N), a1, b);
            }

            double Mx, Dx, GAMMAx;
            int[] countInIntervals = new int[k];
            double xMin, xMax, yMax;

            DoEstimationsCalculations(xList, out Mx, out Dx, out GAMMAx);
            DoDiagramCalculations(xList, countInIntervals, out xMin, out xMax, out yMax);
            DrawDiagram(countInIntervals, xMin, xMax, yMax);
            //CalculateIndirectSign(out indirectSignValue, xList);
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

        private void DoDiagramCalculations(List<double> xList, int[] countInIntervals, out double xMin, out double xMax, out double yMax)
        {
            int intervalNumber;

            FindXMaxMin(xList, out xMin, out xMax);

            if(xMax == xMin)
            {
                //countInIntervals[0] = N;
                yMax = 1;
                return;
            }

            foreach(double x in xList)
            {
                intervalNumber = (int)Math.Truncate((x - xMin - 0.000000001) / ((xMax - xMin) / k)); // (x - xMin - 0.000000001) because Ox starts with xMin
                countInIntervals[intervalNumber]++;
            }

            yMax = FindYMax(countInIntervals);
        }

        private void FindXMaxMin(List<double> xList, out double xMin, out double xMax)
        {
            xMin = double.MaxValue;
            xMax = double.MinValue;

            foreach(double x in xList)
            {
                if(x < xMin)
                {
                    xMin = x;
                }

                if(x > xMax)
                {
                    xMax = x;
                }
            }
        }

        private double FindYMax(int[] countInintervals)
        {
            int maxCount = int.MinValue;

            foreach(int count in countInintervals)
            {
                if(count > maxCount)
                {
                    maxCount = count;
                }
            }

            return Math.Round((double)maxCount / N, 2);
        }

        private void DrawDiagram(int[] countInIntervals, double xMin, double xMax, double yMax)
        {
            chart1.Series["Ci"].Points.Clear();

            chart1.ChartAreas[0].AxisY.Maximum = yMax + 0.1 * yMax; // increase Oy by 10%
            chart1.ChartAreas[0].AxisY.Minimum = yMin;

            if(xMax != xMin)
            {
                chart1.ChartAreas[0].AxisX.Maximum = xMax;
                chart1.ChartAreas[0].AxisX.Minimum = xMin;

                double delta = (xMax - xMin) / k;

                for (int i = 0; i < countInIntervals.Length; i++)
                {
                    chart1.Series["Ci"].Points.AddXY(xMin + i * delta + delta / 2, countInIntervals[i] / (double)N);
                }

                StripLine stripline = new StripLine();
                stripline.StripWidth = 0.00001;
                stripline.BackColor = Color.Red;
                stripline.IntervalOffset = 1 / (double)k;

                chart1.ChartAreas[0].AxisY.StripLines.Add(stripline);
            }
            else
            {
                //chart1.ChartAreas[0].AxisX.Maximum = xMin + 0.5 * xMin;
                //chart1.ChartAreas[0].AxisX.Minimum = xMin - 0.5 * xMin;
                MessageBox.Show("One value repeats.");
            }
        }

        private void CalculateIndirectSign(out double indirectSignValue, List<double> xList)
        {
            int k = 0;

            for(int i = 0; i < xList.Count; i += 2)
            {
                if(xList[i] * xList[i] + xList[i + 1] * xList[i + 1] < 1)
                {
                    k++;
                }
            }

            indirectSignValue = 2 * (double)k / N;
        }

        private void CalculatePeriodAndLa(List<double> xList, out int p, out int La)
        {
            double checkingValue = xList[N - 1];
            int foundIndex = 0;

            for(int i = N - 2; i >= 0; i--)
            {
                if(xList[i] == checkingValue)
                {
                    foundIndex = i + 1;
                    break;
                }
            }

            p = N - foundIndex;
            La = p;

            if (p != N)
            {
                bool repeated = false;

                for(int i=0; i < xList.Count; i++)
                {
                    for (int j = i + 1; j < xList.Count; j++)
                    {
                        if (xList[i] == xList[j])
                        {
                            repeated = true;
                            break;
                        } 
                    }

                    if (repeated)
                    {
                        break;
                    }

                    La++;
                }
            }
        }

        private void UniformRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            a1TextBox.Enabled = true;
            bTextBox.Enabled = true;
            m1TextBox.Enabled = false;
            sigmaTextBox.Enabled = false;
            nTextBox.Enabled = false;
            lambdaTextBox.Enabled = false;
        }

        private void GaussRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            a1TextBox.Enabled = false;
            bTextBox.Enabled = false;
            m1TextBox.Enabled = true;
            sigmaTextBox.Enabled = true;
            nTextBox.Enabled = false;
            lambdaTextBox.Enabled = false;
        }

        private void ExponentialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            a1TextBox.Enabled = false;
            bTextBox.Enabled = false;
            m1TextBox.Enabled = false;
            sigmaTextBox.Enabled = false;
            nTextBox.Enabled = false;
            lambdaTextBox.Enabled = true;
        }

        private void GammaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            a1TextBox.Enabled = false;
            bTextBox.Enabled = false;
            m1TextBox.Enabled = false;
            sigmaTextBox.Enabled = false;
            nTextBox.Enabled = true;
            lambdaTextBox.Enabled = true;
        }

        private void TriangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            a1TextBox.Enabled = true;
            bTextBox.Enabled = true;
            m1TextBox.Enabled = false;
            sigmaTextBox.Enabled = false;
            nTextBox.Enabled = false;
            lambdaTextBox.Enabled = false;
        }

        private void SimphsonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            a1TextBox.Enabled = true;
            bTextBox.Enabled = true;
            m1TextBox.Enabled = false;
            sigmaTextBox.Enabled = false;
            nTextBox.Enabled = false;
            lambdaTextBox.Enabled = false;
        }
    }
}
