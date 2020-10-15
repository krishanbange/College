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
    public partial class MathOp : Form
    {
        public MathOp()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Hide();
            Addition aa = new Addition();
            aa.Show();
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            Hide();
            Subtraction ss = new Subtraction();
            ss.Show();
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            Hide();
            Multiplication mm = new Multiplication();
            mm.Show();
        }

        private void Div_Click(object sender, EventArgs e)
        {
            Hide();
            Division dd = new Division();
            dd.Show();
        }

        private void MathOp_Load(object sender, EventArgs e)
        {

        }
    }
}
