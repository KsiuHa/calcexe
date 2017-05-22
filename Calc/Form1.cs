using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalyzerClass;
using CalcClass;

namespace Calc
{
    public partial class Form1 : Form
    {
        public int number;
        private Stopwatch _timer = new Stopwatch();
        private string _checkExp;

        public Form1()
        {
            InitializeComponent();
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                Expression.Text = Environment.GetCommandLineArgs()[1];
                Analyzer.Expression = Expression.Text;
                Result.Text = Analyzer.Estimate();
            }
        }

        private void OpenBracket_Click(object sender, EventArgs e)
        {
            Expression.Text += "(";
        }

        private void CloseBracket_Click(object sender, EventArgs e)
        {
            Expression.Text += ")";
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (Expression.Text.Length > 0)
                Expression.Text = Expression.Text.Remove(Expression.Text.Length - 1, 1);
        }

        private void C_Click(object sender, EventArgs e)
        {
            Expression.Text = "";
            Result.Text = "";
            
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            var numButton = sender as Button;
            if (numButton != null)
                Expression.Text += numButton.Text;
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            var operatorButton = sender as Button;
            if (operatorButton != null)
                Expression.Text += operatorButton.Tag;
        }

        private void MPlus_Click(object sender, EventArgs e)
        {
            number += Convert.ToInt32(Result.Text);
        }

        private void MC_Click(object sender, EventArgs e)
        {
            number = 0;
        }

        private void MR_Click(object sender, EventArgs e)
        {
            Expression.Text += number.ToString();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                Analyzer.Expression = Expression.Text;
                Result.Text = Analyzer.Estimate();
                //Result.Text = Analyzer.RunEstimate();
            }
            catch (InvalidOperationException exception)
            {
                Result.Text = exception.Message;
                //  Result.Text = "Error ";
            }
            //catch (DivideByZeroException)
            //{
            //    Result.Text = "Error 09";
            //}
            catch (Exception exception)
            {
                Result.Text = "Error";
            }
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Calculate.PerformClick();
        }

        private void ChangeSign_Click(object sender, EventArgs e)
        {
            if (!_timer.IsRunning)
            {
                _timer = Stopwatch.StartNew();

            }
            else
            {
                _timer.Stop();
                if (_timer.Elapsed.Seconds > 3)
                {
                    _timer.Reset();
                    _timer = Stopwatch.StartNew();
                    return;
                }
            }
            if (Expression.Text[Expression.Text.Length - 1] == 'm')
            {
                Expression.Text = Expression.Text.Remove(Expression.Text.Length - 1, 1);
                Expression.Text += 'p';
            }
            else
            {
                if (Expression.Text[Expression.Text.Length - 1] == 'p')
                {
                    Expression.Text = Expression.Text.Remove(Expression.Text.Length - 1, 1);
                    Expression.Text += 'm';
                }
                else
                {
                    if (Expression.Text == "0")
                    {
                        Expression.Text = "m";
                    }
                    else
                    {
                        Expression.Text += "m";
                    }
                }
            }
            _checkExp = Expression.Text;
        }

        private void Expression_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '+') && (e.KeyChar != '-') && (e.KeyChar != ',') && (e.KeyChar != '(') && (e.KeyChar != ')') && (e.KeyChar != '/') && (e.KeyChar != '*'))
                {
                e.Handled = true;
               // Result.Text = "Error 03";
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))

            {
                e.Handled = true;
               // Result.Text = "Error 03";
            }
        }
    }
}
