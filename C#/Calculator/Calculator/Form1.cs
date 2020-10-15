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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String UserName = "User1";   //This is the correct username
            String PassWord = "Password123";    //This is the correct password

            if (UNbox.Text == UserName & PWbox.Text == PassWord)    //If the text in the boxes match the correct username and password then the login will work
            {
                MessageBox.Show("Your login credentials are correct!");     //This message pops up if the credentials are correct

                Hide();     //The funtion will hide the login form once the calculator has opened
                MathOp nw = new MathOp();   //This creates a new calculator window
                nw.Show();      //This shows the new window
            }
            else
            {
                MessageBox.Show("Your login credentials are incorrect!");   //This message pops up if the credentials are incorrect
                UNbox.Text = "";    //This resets the username field to blank if it is incorrect
                PWbox.Text = "";    //This resets the password field to blank if it is incorrect
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();    //This closes the window when you press the exit button
        }


        private void buttonHelp_Click(object sender, EventArgs e)
        {
            HelpPanel.Visible = true;       //This makes the panel visible
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            HelpPanel.Visible = false;      //This makes the panel invisible
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
