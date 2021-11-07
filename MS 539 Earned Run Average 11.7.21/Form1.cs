using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_539_Earned_Run_Average_11._7._21
//November 7 2021 Starttime: 10:53 am estimated 1-2hours//
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateEraButton_Click(object sender, EventArgs e)
        {
         double runs;
         double innings;
         double era;
            if (double.TryParse(runsTextBox.Text, out runs))
            {
                if (double.TryParse(inningsTextBox.Text, out innings))
                {
                    era = (runs / innings) * 6;
                    eraLabel.Text = era.ToString("n1");
                }
                else
                {
                    MessageBox.Show("Invalid Input for Innings Pitched");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input for Earned Runs");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            runsTextBox.Text = "";
            inningsTextBox.Text = "";
            eraLabel.Text = "";
        }
    }
}
