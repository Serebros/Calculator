///////////////////////////////////////////////////////////////////////////////
// Name: Calculator
// Author: Serebros
// Created: 21.02.2015
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            if (!editing)
            {
                textBox.Text = "";
                editing = true;
            }
            textBox.Text = textBox.Text + ((Button)sender).Text;
        }

        private void bBackspace_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
        }
        
        String argument1;   // текст первого аргумента
        int operation = 0;  // переменная кода операции: 1 - сложение, 2 - вычитание, 3 - умножение, 4 - деление
        bool editing = false;   // истина, когда мы вводим число

        private void bEqually_Click(object sender, EventArgs e)  // равно
        {
            if (operation == 0)
            {
                editing = false;
                return; 
            }
            if (editing == true)
            {
                String argument2;
                argument2 = argument1;
                argument1 = textBox.Text;
                textBox.Text = argument2;
                editing = false;
            }
            Decimal arg1, arg2;
            arg1 = Convert.ToDecimal(argument1);
            arg2 = Convert.ToDecimal(textBox.Text);
            if (operation == 1)
            {
                arg2 = arg1 + arg2;
            }
            if (operation == 2)
            {
                 arg2 = arg2 - arg1;}
             if (operation == 3)
             {
                 arg2 = arg1 * arg2;
             }
                if (operation == 4)
             {
                 arg2 = arg2 / arg1;
                
            }

                textBox.Text = Convert.ToString (arg2);
            
        }

        private void Operations_Click(object sender, EventArgs e)
        {
            if (sender == bPlus)
            {
                operation = 1;  // сложение
            }
            if (sender == bMinus)
            {
                operation = 2;  // вычитание
            }
            if (sender == bMull)
            {
                operation = 3;  // умножение
            }
            if (sender == bDivision)
            {
                operation = 4;  // деление
            }
            argument1 = textBox.Text;
            editing = false;
        }

        private void bC_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            editing = false;
            operation = 0;
        }
        private void bCE_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            editing = false;
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressed = e.KeyChar;
            if (!(Char.IsNumber(pressed) || pressed == '\b'))
            {
                e.Handled = true;   //запрет ввода
                if (pressed == '+') Operations_Click(bPlus, null);
                if (pressed == '-') Operations_Click(bMinus, null);
                if (pressed == '*') Operations_Click(bMull, null);
                if (pressed == '/') Operations_Click(bDivision, null);
            }
            else
            { 
                if (!editing)
                {
                    textBox.Text = "";
                    editing = true;
                }
            }
        }

        private void bPlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0" && textBox.Text != "")
            {
                if (textBox.Text[0] == '-')
                {
                    textBox.Text = textBox.Text.Replace("-", "");
                }
                else 
                {
                    textBox.Text = "-" + textBox.Text;
                }

            }   
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            Double arg1;
            arg1 = Convert.ToDouble(textBox.Text);
            if (arg1 >= 0)
            {
                arg1 = Math.Sqrt (arg1);
                textBox.Text = Convert.ToString(arg1);
            }
        }
    }
}
