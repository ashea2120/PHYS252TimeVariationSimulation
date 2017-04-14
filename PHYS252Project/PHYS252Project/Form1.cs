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
            //Equation we are working with
            
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
            //Take the values from textboxes and load them into the equation
            decimal massOrTime = massNumeric.Value;
            decimal velocity = velocityNumeric.Value;

            
            double result = (Convert.ToDouble(massOrTime)) / (Math.Sqrt(1 - (Convert.ToDouble((velocity * velocity)) / Convert.ToDouble((lightspeed * lightspeed)))));
            resultsTextBox.Text = "The initial value is: " + massOrTime + "\r\nThe velocity you entered is: " + velocity + "\r\nAnd the final value is: " + result;
        }
    } 
}
