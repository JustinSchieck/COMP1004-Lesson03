using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace COMP1004_Lesson03
{
    public partial class CalculatorForm : Form
    {
        ///PRIVATE INSTANCE VARIABLES

        string _operand1;
        string _operand2;
        bool _isCalculatorClear;
             
        ///CONSTRUCTORS+++++++++++++++++++++++++++++++++++++++++++++++++++++
        public CalculatorForm()
        {
            InitializeComponent();

            this._clearCalculator();
        }

        /// <summary>
        /// This method clears the calculator and resets the variables
        /// </summary>
        private void _clearCalculator()
        {
            this._operand1 = "";
            this._operand1 = "";
            this._isCalculatorClear = true;
            ResultTextBox.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button CalculatorButton = sender as Button;

            switch (CalculatorButton.Tag.ToString())
            {
                case "Operand":
                    if (this._isCalculatorClear)
                    {
                        ResultTextBox.Text = CalculatorButton.Text;
                        this._isCalculatorClear = false;
                    }
                    else
                    {
                        ResultTextBox.Text += CalculatorButton.Text;
                    }
                    break;
                case "Operator":

                    break;
                case "Other":
                    break;
            }
        }
    }
}
