using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCloneCalculator
{
    public partial class WinCloneCalculator : Form
    {
        Double value = 0;
        Double prevValue = 0;
        String operation = "";
        Boolean operation_btn_pressed = false;
        public WinCloneCalculator()
        {
            InitializeComponent();
        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            tb_result.Text = "0";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            lbl_prevOperation.Text = "";
          
            switch (operation)
            {
                case "+":
                    tb_result.Text = (value + Double.Parse(tb_result.Text)).ToString();
                    break;
                case "-":
                    tb_result.Text = (value - Double.Parse(tb_result.Text)).ToString();
                    break;
                case "*":
                    tb_result.Text = (value * Double.Parse(tb_result.Text)).ToString();
                    break;
                case "/":
                    tb_result.Text = (value / Double.Parse(tb_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            

        }

        private void btn_Click(object sender, EventArgs e)
        {
           
            if ((tb_result.Text == "0") || operation_btn_pressed)
            {
                tb_result.Clear();
            }
            operation_btn_pressed = false;
            Button button = (Button)sender;
            tb_result.Text = tb_result.Text + button.Text;
            prevValue = Double.Parse(tb_result.Text);
        }
        private void handleInputFromNumpad(int sender)
        {
            if ((tb_result.Text == "0") || operation_btn_pressed)
            {
                tb_result.Clear();
            }
            operation_btn_pressed = false;
            tb_result.Text = tb_result.Text + sender;
            prevValue = Double.Parse(tb_result.Text);
        }
        private void handleAritmeticInput(object sender, KeyPressEventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Convert.ToDouble(tb_result.Text);
            operation_btn_pressed = true;
            if (tb_result.Text == "0")
            {
                value = prevValue;
            }
            lbl_prevOperation.Text = value + " " + operation;
            tb_result.Text = "0";
        }
        private void aritmeticOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Convert.ToDouble(tb_result.Text);
            operation_btn_pressed = true;
            if (tb_result.Text == "0")
            {
                value = prevValue;
            }
            lbl_prevOperation.Text = value + " " + operation;
            tb_result.Text = "0";

        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            value = 0;
            tb_result.Clear();
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                Button button = (Button)sender;
                int btn = (int)e.KeyChar - 48;
                button.Text = Convert.ToString(btn);
                btn_Click(sender, e);

            }
            else
            {
                Button button = (Button)sender;
                string sign;
                switch (e.KeyChar)
                {
                    case (char)47:
                        sign = "/";
                        button.Text = sign;
                        handleAritmeticInput(sender, e);
                        break;
                    case (char)42:
                        sign = "*";
                        button.Text = sign;
                        handleAritmeticInput(sender, e);
                        break;
                    case (char)43:
                        sign = "+";
                        button.Text = sign;
                        handleAritmeticInput(sender, e);
                        break;
                    case (char)45:
                        sign = "-";
                        button.Text = sign;
                         handleAritmeticInput(sender, e);
                        break;
                    case (char)61:
                        btn_equal_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
