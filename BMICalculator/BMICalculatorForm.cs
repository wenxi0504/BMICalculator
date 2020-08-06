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
            //Step 1 Using if statement to check if the user input reasonable data
            if (_myHeight<=0 || _myWeight<=0)
            {
                BMIScaleTextBox.Text = "My Height and My Weight must be greater than 0";
            }
            else
            {   // Step 2 using if else statement to distinguish different formula between 
                // imperial radio button and metric radio button
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
                //Using if statement to display different outputs based on different BMI result
                if (bmiResult < 18.5)
                {  BMIScaleTextBox.BackColor=Color.HotPink;
                    BMIScaleTextBox.Text = "Sorry, you are underweight !";
                    
                }
                else if (bmiResult >= 18.5 && bmiResult < 25)
                {
                    BMIScaleTextBox.Text = "Congrats ,your weight is normal.";
                }
                else if (bmiResult >= 25 && bmiResult < 30)
                {
                    BMIScaleTextBox.BackColor = Color.Plum;
                    BMIScaleTextBox.Text = "Sorry,you are overweight! ";
                }
                else
                {
                    BMIScaleTextBox.BackColor = Color.DarkRed;
                    BMIScaleTextBox.Text = "Sorry,you are obese!";
                }
            }

        }
        
    // reset button click method to clear all data 
    private void ResetButton_Click(object sender, EventArgs e)
    {
        inputMyHeightTextBox.Text = "";
        inputMyWeightTextBox.Text = "";
        BMIResultTextBox.Text = "";
        BMIScaleTextBox.Text = "";
    }
    

    }

}

