using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calc : Form
    {
        Double Sum = 0;     //Used for decimal places
        String Math = "";       //To represent what mathmatical operation was selected
        bool Math_Selected = false;     //This is so that the operation that was selected does not interfere with the numbers

        public Calc()
        {
            InitializeComponent();
        }


        private void Number_Click(object sender, EventArgs e)
        {
            if ((AnswerBox.Text == "0")||(Math_Selected))
                AnswerBox.Clear();      //Clears the 0 that is displayed when a number is clicked for the first time
            
            Math_Selected = false;

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

        private void Math_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Math = btn.Text;        //Stores the operation
            Sum = Double.Parse(AnswerBox.Text);
            Math_Selected = true;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            switch (Math)       //In this loop contains the operation that when the equals button is pressed the sum ia calculated
            {
                case "+":
                    AnswerBox.Text = (Sum + Double.Parse(AnswerBox.Text)).ToString();
                    break;
                case "-":
                    AnswerBox.Text = (Sum - Double.Parse(AnswerBox.Text)).ToString();
                    break;
                case "x":
                    AnswerBox.Text = (Sum * Double.Parse(AnswerBox.Text)).ToString();
                    break;
                case "/":
                    AnswerBox.Text = (Sum / Double.Parse(AnswerBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            Math_Selected = false;
        }

        private void Calc_Load(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            HelpPanel.Visible = true;       //Makes the help panel visible
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            HelpPanel.Visible = false;      //Makes the help panel invisible
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

        }
    }
}
