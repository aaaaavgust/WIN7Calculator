using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Win7Calculator
{

    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        public void Error()
        {
            while(label1.Text.Length !=0)
            {

            }
        }

        private void Btn_Click (object sender, EventArgs e)
        {
            label1.Text = label1.Text + (sender as Button).Text;
        }
       
        private void Point_Click(object sender, EventArgs e)
        {
            if (label1.Text != "" && label1.Text != "-")
            {
                if (label1.Text.IndexOf(',') == -1)
                {
                    label1.Text += ",";
                }
            }
        }
        private void Percent_Click(object sender, EventArgs e)
        {
            string origin, label_without_event = "";
            origin = label2.Text;
            for (int i = 0; i < label2.Text.Length - 1; i++)
                label_without_event += origin[i];
            label1.Text = (double.Parse(label_without_event) / 100 * double.Parse(label1.Text)).ToString();
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (label1.Text != "" && label1.Text != "+" && label1.Text != "-")
            {
                main_temp = double.Parse(label1.Text);
                label2.Text = $"√{main_temp}";
                if (main_temp < 0)
                {
                    label1.Text = "Не правильный ввод";
                }
                else
                {
                    label1.Text = Math.Sqrt(main_temp).ToString();
                }
                sign = true;
                //квадратный корень применяется сразу, символ взят из аскии а не как в оригинале sqrt
            }
        }

        private void ChangeSign_Click(object sender, EventArgs e)
        {
            if (label1.Text != "" && label1.Text != "+" && label1.Text != "-")
            {
                if (sign == true)
                {
                    label1.Text = "-" + label1.Text;
                    sign = false;
                }
                else if (sign == false)
                {
                    label1.Text = label1.Text.Replace("-", "");
                    sign = true;
                }
            }
            else if (label1.Text == "")
            {
                label1.Text = "-";
                sign = false;
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            int lenght = label1.Text.Length - 1;
            string text = label1.Text;
            label1.Text = "";
            for (int i = 0; i < lenght; i++)
            {
                label1.Text = label1.Text + text[i];
            }
        }

        private void MC_Click(object sender, EventArgs e)
        {
            memory_save = 0;
        }

        private void MR_Click(object sender, EventArgs e)
        {
            label1.Text = memory_save.ToString();
        }

        private void MS_Click(object sender, EventArgs e)
        {
            main_temp = double.Parse(label1.Text);
            memory_save = main_temp;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calculate();
                label2.Text = "";
            }
        }

       
        private void MPlus_Click(object sender, EventArgs e)
        {
            main_temp = double.Parse(label1.Text);
            memory_save += main_temp;
        }

        private void MMinus_Click(object sender, EventArgs e)
        {
            main_temp = double.Parse(label1.Text);
            memory_save -= main_temp;
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            plus();
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            minus();

        }
        private void Multiply_Click(object sender, EventArgs e)
        {
            mult();
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            div();
        }
        private void DivideByX_Click(object sender, EventArgs e)
        {
            if (label1.Text != "" && label1.Text != "+" && label1.Text != "-")
            {
                main_temp = double.Parse(label1.Text);
                label1.Text = (1 / main_temp).ToString();
            }
        }
        private void MainForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    One.PerformClick();
                    break;
                case Keys.D2:
                    Two.PerformClick();
                    break;
                case Keys.D3:
                    Three.PerformClick();
                    break;
                case Keys.D4:
                    Four.PerformClick();
                    break;
                case Keys.D5:
                    Five.PerformClick();
                    break;
                case Keys.D6:
                    Six.PerformClick();
                    break;
                case Keys.D7:
                    Seven.PerformClick();
                    break;
                case Keys.D8:
                    Eight.PerformClick();
                    break;
                case Keys.D9:
                    Nine.PerformClick();
                    break;
                case Keys.D0:
                    Zero.PerformClick();
                    break;
                case Keys.Back:
                    Backspace.PerformClick();
                    break;
               


            }
        }
    }
}
