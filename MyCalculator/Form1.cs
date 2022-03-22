using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        ICalculate calculate;

        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();

        }

        bool ValidateInputs()
        {
            bool isValid = true;

            if (numeric1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("Please Enter first number");
            }
            else
            {
                if (numeric2.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("Please Enter second number");
                }
            }

            return isValid;
        }

        private void jam_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculate.Plus((int)numeric1.Value, (int)numeric2.Value);
                MessageBox.Show("Sum is : " + sum);
            }
        }

        private void menha_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int minus = calculate.Minus((int)numeric1.Value, (int)numeric2.Value);
                MessageBox.Show("minus is : " + minus);

            }
        }

        private void zarb_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int multiple = calculate.Multiple((int)numeric1.Value, (int)numeric2.Value);
                MessageBox.Show("multiple is : " + multiple);

            }
        }

        private void taghsim_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int divide = calculate.Divide((int)numeric1.Value, (int)numeric2.Value);
                MessageBox.Show("divide is : " + divide);

            }
        }
    }
}
