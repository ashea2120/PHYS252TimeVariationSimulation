using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PHYS252Project
{
    public partial class mainForm : Form
    {
        decimal lightspeed = 299792458;
        decimal initial = 0;
        decimal result = 0;
        public mainForm()
        {
            InitializeComponent();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void velocityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Ensuring the right textboxes display depending on the mode that is selected
            if (massRadioButton.Checked == true)
            {
                massLabel.Text = "Mass";
            }
            else
            {
                massLabel.Text = "Time";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Note: The max the velocity can be is the speed of light: 299792458

            //Take the values from textboxes and load them into the equation
            decimal massOrTime = massNumeric.Value;
            decimal velocity = velocityNumeric.Value;

            //plugging in the numbers from the Numeric boxes and doing the calculation
            //This is the formula that was used: t = t0 / square root{ (1 - v2 / c2) }
            double result = (Convert.ToDouble(massOrTime)) / (Math.Sqrt(1 - (Convert.ToDouble((velocity * velocity)) / Convert.ToDouble((lightspeed * lightspeed)))));

            //Depending on which mode we are in, we want to print different things to the results textbox
            if (massRadioButton.Checked)
            {
                resultsTextBox.Text = "The mass entered: " + massOrTime + "\r\nThe velocity entered: " + velocity + "\r\nThe resultant time: " + result;
            }
            else
            {
                resultsTextBox.Text = "The time entered: " + massOrTime + "\r\nThe velocity entered: " + velocity + "\r\nThe resultant mass: " + result;
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            massNumeric.Value = 0;
            velocityNumeric.Value = 0;
            resultsTextBox.Clear();
        }
    } 
}
