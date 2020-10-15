using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Subtraction : Form
    {
        Double Sum = 0;     //Used for decimal places
        String Math = "";       //To represent what mathmatical operation was selected
        bool sub = false;     //This is so that the operation that was selected does not interfere with the numbers

        public Subtraction()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if ((AnswerBox.Text == "0") || (sub))
                AnswerBox.Clear();      //Clears the 0 that is displayed when a number is clicked for the first time

            sub = false;

            Button btn = (Button)sender;        //Button variable
            AnswerBox.Text = AnswerBox.Text + btn.Text;     //The button that was pressed will be added to the text box
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            AnswerBox.Text = "0";       //Changes the text box back to 0
            Sum = 0;        //Resets the sum value back to 0, so the whole sum is cleared
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            AnswerBox.Text = "0";       //Changes the text box back to 0, so only the current field is cleared
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Math = btn.Text;        //Stores the operation
            Sum = Double.Parse(AnswerBox.Text);
            sub = true;
        }

        private void buttonEql_Click(object sender, EventArgs e)
        {
            switch (Math)       //In this loop contains the operation that when the equals button is pressed the sum ia calculated
            {
                case "-":
                    AnswerBox.Text = (Sum - Double.Parse(AnswerBox.Text)).ToString();       //Changes to a string
                    break;
            }
            sub = false;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            HelpPanel.Visible = true;       //Makes the help panel visible
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            HelpPanel.Visible = false;      //Makes the help panel invisible
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();     //The funtion will hide the login form once the calculator has opened
            MathOp nw = new MathOp();   //This creates a new calculator window
            nw.Show();      //This shows the new window
        }
    }
}
