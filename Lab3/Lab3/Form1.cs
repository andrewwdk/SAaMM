using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        const int ticksCount = 100000;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (IsValidDouble(pi1TextBox.Text) && IsValidDouble(pi2TextBox.Text))
            {
                double pi1 = Convert.ToDouble(pi1TextBox.Text);
                double pi2 = Convert.ToDouble(pi2TextBox.Text);

                if (pi1 <= 1 || pi2 <= 1)
                {
                    int m = 61121;
                    int a = 211;
                    int R0 = 319;

                    if (m > a)
                    {
                        DoSimulation(m, a, R0, pi1, pi2);
                    }
                    else
                    {
                        MessageBox.Show("m should be greater than a!");
                    }
                }
                else
                {
                    MessageBox.Show("Pi1 and Pi2 should be less than 1!");
                }
            }
            else
            {
                MessageBox.Show("All the values should be positive integers!");
            }
        }

        private bool IsValidDouble(string text)
        {
            bool result = true;
            double number;

            if (double.TryParse(text, out number))
            {
                if (number < 0)
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

        private void DoSimulation(int m, int a, int R0, double pi1, double pi2)
        {
            Generator gen = new Generator(a, m, R0);
            int taskCount = 0, doneTaskCount = 0, deletedTaskCount = 0;
            int inputStatus = 2, queueStatus = 0, channel1Status = 0, channel2Status = 0;
            int queueLengthSum = 0;

            for(var i = 1; i <= ticksCount; i++)
            {
                if (channel2Status == 1) // if channel #2 has a task
                {                        // then check 
                    if (gen.GetNext() <= pi2) // if event will happen
                    {                         // if happens then
                        doneTaskCount++;      // increase done task counter
                        channel2Status = 0;   // and make channel free
                    }
                }

                if(channel1Status == 1) // if channel #2 has a task
                {                       // then check
                    if (gen.GetNext() <= pi1) // if event will happen
                    {                           // if happens then
                        channel1Status = 0;     // and make channel free
                        if (channel2Status == 0)  //check if channel #2 is free
                        {                         // if it's free
                            channel2Status = 1;   // put task in channel #2 and make it busy
                        }
                        else                     // if channel #2 is busy
                        {
                            deletedTaskCount++;  // then delete task and increase deleted task counter
                        }
                    }
                }

                if(queueStatus > 0)
                {
                    if(channel1Status == 0)
                    {
                        channel1Status = 1;
                        queueStatus--;
                    }
                }

                if(inputStatus == 1)
                {
                    taskCount++;
                    if (channel1Status == 0)
                    {
                        channel1Status = 1;
                    }
                    else
                    {
                        if (queueStatus < 2)
                        {
                            queueStatus++;
                        }
                        else
                        {
                            deletedTaskCount++;
                        }
                    }
                }

                queueLengthSum += queueStatus;

                if (inputStatus == 2)
                {
                    inputStatus = 1;
                }
                else
                {
                    inputStatus = 2;
                }
            }

            PLabel.Text = ((double)deletedTaskCount / (deletedTaskCount + doneTaskCount)).ToString();
            ALabel.Text = ((double)doneTaskCount / ticksCount).ToString();
            LLabel.Text = ((double)queueLengthSum / ticksCount).ToString();
        }
    }
}
