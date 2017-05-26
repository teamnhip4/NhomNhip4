using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn chắc chắn muốn thoát ứng dụng vi diệu này ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operation_pressed))
                textBox1.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + b.Text;
                }
            }
            else
                textBox1.Text = textBox1.Text + b.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                bang.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                label2.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(textBox1.Text);
                operation_pressed = true;
                label2.Text = value + " " + operation;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            switch (operation)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                default :
                    break;
            }
            value =Double.Parse(textBox1.Text);
            operation = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
            label2.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    khong.PerformClick();
                    break;
                case "1":
                    mot.PerformClick();
                    break;
                case "2":
                    hai.PerformClick();
                    break;
                case "3":
                    ba.PerformClick();
                    break;
                case "4":
                    bon.PerformClick();
                    break;
                case "5":
                    nam.PerformClick();
                    break;
                case "6":
                    sau.PerformClick();
                    break;
                case "7":
                    bay.PerformClick();
                    break;
                case "8":
                    tam.PerformClick();
                    break;
                case "9":
                    chin.PerformClick();
                    break;
                case "+":
                    cong.PerformClick();
                    break;
                case "-":
                    tru.PerformClick();
                    break;
                case "*":
                    nhan.PerformClick();
                    break;
                case "/":
                    chia.PerformClick();
                    break;
                case "=":
                    bang.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label2.Text = "DEC";
           int  so = int.Parse(textBox1.Text);
            string Base = Convert.ToString(so, 10);
            textBox1.Text = Base;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label2.Text = "HEX";
            int so = int.Parse(textBox1.Text);
            string Base = Convert.ToString(so, 16);
            textBox1.Text = Base;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label2.Text = "BIN";
            int so = int.Parse(textBox1.Text);
            string Base = Convert.ToString(so, 2);
            textBox1.Text = Base;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label2.Text = "OCT";
            int so = int.Parse(textBox1.Text);
            string Base = Convert.ToString(so, 8);
            textBox1.Text = Base;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
