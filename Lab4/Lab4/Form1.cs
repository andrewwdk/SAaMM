using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        const int endTime = 100000;
        const double delta = 0.001;

        public Form1()
        {
            InitializeComponent();
        }

        private void SimulateButton_Click(object sender, EventArgs e)
        {
            if (IsValidDouble(mTextBox.Text) && IsValidDouble(lambdaTextBox.Text))
            {
                double m = Convert.ToDouble(mTextBox.Text);
                double lambda = Convert.ToDouble(lambdaTextBox.Text);

                DoSimulation(m, lambda);  
            }
            else
            {
                MessageBox.Show("All the values should be double!");
            }
        }

        private bool IsValidDouble(string text)
        {
            bool result = true;
            double number;

            if (double.TryParse(text, out number))
            {
                if (number <= 0)
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

        private void DoSimulation(double m, double lambda)
        {
            Generator gen = new Generator(211, 61121, 319);
            int doneTasks = 0;
            bool firstChannelStatus = true, secondChannelStatus = true, thirdChannelStatus = true; //true - free, false - busy
            double firstChannelTimeUntilEnd = 0, secondChannelTimeUntilEnd = 0, thirdChannelTimeUntilEnd = 0;
            double sumTime = 0, currentTime = 0, timeUntilNewTask = 0;
            bool newTask = false;

            while(endTime - currentTime >= delta)
            {
                if (!firstChannelStatus)
                {
                    if(firstChannelTimeUntilEnd >= delta)
                    {
                        firstChannelTimeUntilEnd -= delta;
                        sumTime += delta;
                    }
                    else
                    {
                        doneTasks++;
                        sumTime += firstChannelTimeUntilEnd;

                        if (newTask)
                        {
                            newTask = false;
                            firstChannelTimeUntilEnd = gen.GetNext(2 * m);
                        }
                        else
                        {
                            firstChannelStatus = true;
                        }
                    }
                }
                else
                {
                    if (newTask)
                    {
                        firstChannelStatus = false;
                        newTask = false;
                        firstChannelTimeUntilEnd = gen.GetNext(2 * m);
                    }
                }

                if (!secondChannelStatus)
                {
                    if (secondChannelTimeUntilEnd >= delta)
                    {
                        secondChannelTimeUntilEnd -= delta;
                        sumTime += delta;
                    }
                    else
                    {
                        doneTasks++;
                        sumTime += secondChannelTimeUntilEnd;

                        if (newTask)
                        {
                            newTask = false;
                            secondChannelTimeUntilEnd = gen.GetNext(m);
                        }
                        else
                        {
                            secondChannelStatus = true;
                        }
                    }
                }
                else
                {
                    if (newTask)
                    {
                        secondChannelStatus = false;
                        newTask = false;
                        secondChannelTimeUntilEnd = gen.GetNext(m);
                    }
                }

                if (!thirdChannelStatus)
                {
                    if (thirdChannelTimeUntilEnd >= delta)
                    {
                        thirdChannelTimeUntilEnd -= delta;
                        sumTime += delta;
                    }
                    else
                    {
                        doneTasks++;
                        sumTime += thirdChannelTimeUntilEnd;

                        if (newTask)
                        {
                            newTask = false;
                            thirdChannelTimeUntilEnd = gen.GetNext(m);
                        }
                        else
                        {
                            thirdChannelStatus = true;
                        }
                    }
                }
                else
                {
                    if (newTask)
                    {
                        thirdChannelStatus = false;
                        newTask = false;
                        thirdChannelTimeUntilEnd = gen.GetNext(m);
                    }
                }

                if (newTask)
                {
                    newTask = false;
                }

                if(timeUntilNewTask <= delta)
                {
                    newTask = true;
                    timeUntilNewTask = gen.GetNext(lambda);
                }

                currentTime += delta;
                timeUntilNewTask -= delta;
            }

            ALabel.Text = (doneTasks / (double)endTime).ToString();
            wcLabel.Text = (sumTime / doneTasks).ToString();
        }
    }
}
