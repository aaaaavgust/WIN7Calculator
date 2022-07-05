using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win7Calculator
{
    internal class CALCULATOR
    {

    }
    partial class MainForm
    {
        double main_temp, second_temp, memory_save;
        int event_case = default;
        bool sign = true;
        
        private void calculate()
        {
            switch (event_case)
            {
                case 1:
                    second_temp = main_temp + double.Parse(label1.Text);
                    label1.Text = second_temp.ToString();
                    event_case = default;
                    break;
                case 2:
                    second_temp = main_temp - double.Parse(label1.Text);
                    label1.Text = second_temp.ToString();
                    event_case = default;
                    break;
                case 3:
                    second_temp = main_temp * double.Parse(label1.Text);
                    label1.Text = second_temp.ToString();
                    event_case = default;
                    break;
                case 4:
                    second_temp = main_temp / double.Parse(label1.Text);
                    label1.Text = second_temp.ToString();
                    event_case = default;
                    break;
            }
        }
        private void plus()
        {
                if (label1.Text != "" && label1.Text != "+" && label1.Text != "-")
                {
                    main_temp = double.Parse(label1.Text);
                    label1.Text = "";
                    event_case = 1;
                    label2.Text = main_temp.ToString() + "+";
                }
                else if (label1.Text == "-")
                {
                    sign = true;
                    label1.Text = label1.Text.Replace("-", "");
                }
        }
        private void minus()
        {
            if (label1.Text == "")
            {
                label1.Text = "-";
                sign = false;
            }
            else if (label1.Text != "" && label1.Text != "-")
            {
                main_temp = double.Parse(label1.Text);
                label1.Text = "";
                event_case = 2;
                label2.Text = main_temp.ToString() + "-";
                sign = true;
            }
        }
        private void mult()
        {
            if (label1.Text != "" && label1.Text != "+" && label1.Text != "-")
            {
                main_temp = double.Parse(label1.Text);
                label1.Text = "";
                event_case = 3;
                label2.Text = main_temp.ToString() + "*";
                sign = true;
            }
        }
        private void div()
        {
            if (label1.Text != "" && label1.Text != "+" && label1.Text != "-")
            {
                main_temp = double.Parse(label1.Text);
                label1.Text = "";
                event_case = 4;
                label2.Text = main_temp.ToString() + "/";
                sign = true;
            }
        }


    }
}
      

