﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using static System.Math;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DiceCalculator
{
    public partial class Cal_Form : Form
    {
        public Cal_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Num1_Click(object sender, EventArgs e)
        {
            Output.Text += "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            Output.Text += "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            Output.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            Output.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            Output.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            Output.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            Output.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            Output.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            Output.Text += "9";
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            Output.Text += "0";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            string a = Output.Text.ToString();
            int len = a.Length;
            if (Output.Text[--len] != '.')
            {
                Output.Text += ".";
            }
        
        }

        private void Cbut_Click(object sender, EventArgs e)
        {
            Output.Text = "";
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            Output.Text += "*";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            Output.Text += "/";
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            Output.Text += "+";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Output.Text += "-";
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Sqrt(double.Parse(Output.Text));
                Output.Text = ans.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void Pow_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Pow(double.Parse(Output.Text), 2);
                Output.Text = ans.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Calc = new DataTable();
                var ans = Calc.Compute(Output.Text,"");
                Output.Text = ans.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
