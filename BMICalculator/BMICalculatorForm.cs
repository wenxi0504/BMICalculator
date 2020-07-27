using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        // private variables
        private double _myHeight;
        private double _myWeight;
        private double height;
        private double weight;
        private double bmiResult=0;
        //public properties
        public double MyHeight 
        { 
            get{return _myHeight; }
            set { MyHeight = value; }
        }
        public double MyWeight
        {
            get { return _myWeight; }
            set { MyWeight = value; }
        }



        public BMICalculatorForm()
        {
           InitializeComponent();
        }

    

    private void calculatorBMIButton_Click(object sender, EventArgs e)
       {
        _myHeight = Convert.ToDouble(inputMyHeightTextBox.Text);
        _myWeight = Convert.ToDouble(inputMyWeightTextBox.Text);

            if (_myHeight<=0 || _myWeight<=0)
            {
                BMIScaleTextBox.Text = "My Height and My Weight must be greater than 0";
            }
            else
            {
                if (imperialRadioButton.Checked)
                {
                    bmiResult = 703 * _myWeight * 2.21 / (39.37 * _myHeight * 39.37 * _myHeight);
                    BMIResultTextBox.Text = $"{bmiResult:F2}";
                }
                else if (metircRadioButton.Checked)
                {
                    bmiResult = _myWeight / (_myHeight * _myHeight);
                    BMIResultTextBox.Text = $"{bmiResult:F2}";
                }

            }
            if (bmiResult < 18.5)
            {
                BMIScaleTextBox.Text = "Sorry, you are underweight ";
            }
            else if (bmiResult >= 18.5 && bmiResult < 25)
            {
                BMIScaleTextBox.Text = "Congrats ,your weight is normal ";
            }
            else if (bmiResult >= 25 && bmiResult < 30)
            {
                BMIScaleTextBox.Text = "Sorry,you are overweight ";
            }
            else
            {
                BMIScaleTextBox.Text = "Sorry,you are obese";
            }
        }
    private void ResetButton_Click(object sender, EventArgs e)
    {
        inputMyHeightTextBox.Text = "";
        inputMyWeightTextBox.Text = "";
        BMIResultTextBox.Text = "";
        BMIScaleTextBox.Text = "";
    }
    


        private void BMICalculatorForm_Load_1(object sender, EventArgs e)
        {
            
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void userBMIinfo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void myHeight_Click(object sender, EventArgs e)
        {

        }
        private void myHeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void BMIResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BMIScaleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
    }

}

