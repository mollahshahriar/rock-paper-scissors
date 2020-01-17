using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assingment
{
    public partial class comr : Form
    {
        public comr()
        {
         
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int userinput = 1;
            int computerinput = 1;

            Random myRndNumber = new Random();
            computerinput = myRndNumber.Next(1, 4);
            if (userinput == 1 && computerinput == 1)
            {
                txtResult.Text = "game draw try again";
                computerR.Visible = true;
                computerS.Visible = false;
                computerP.Visible = false;

            }
            else if (userinput == 1 && computerinput == 2)
            {
                txtResult.Text = "You lose";
                computerR.Visible = false;
                computerS.Visible = false;
                computerP.Visible = true;
            }

            else if (userinput == 1 && computerinput == 3)
            {
                txtResult.Text = "You Won";
                computerR.Visible = false;
                computerS.Visible = true;
                computerP.Visible = false;
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int userinput = 2;
            int computerinput = 2;
            Random myRndNumber = new Random();
            computerinput = myRndNumber.Next(1, 4);
            Console.WriteLine(computerinput);


            if (userinput == 2 && computerinput == 1)
            {
                txtResult.Text = "You Won";
                computerR.Visible = true;
                computerS.Visible = false;
                computerP.Visible = false;
            }

            else if (userinput == 2 && computerinput == 2)

            {
                txtResult.Text = "Game draw try again";
                computerR.Visible = false;
                computerS.Visible = false;
                computerP.Visible = true;
            }

            else if (userinput == 2 && computerinput == 3)
            {
                txtResult.Text = "You Lose";
                computerR.Visible = false;
                computerS.Visible = true;
                computerP.Visible = false;
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int userinput = 3;
            int computerinput = 3;
            Random myRndNumber = new Random();
            computerinput = myRndNumber.Next(1, 4);
            Console.WriteLine(computerinput);


            if (userinput == 3 && computerinput == 1)
            {
                txtResult.Text = "you lose";
                computerR.Visible = true;
                computerS.Visible = false;
                computerP.Visible = false;
            }

            else if (userinput == 3 && computerinput == 2)
            {
                txtResult.Text = "You won";
                computerR.Visible = false;
                computerS.Visible = false;
                computerP.Visible = true;
            }

            else if (userinput == 3 && computerinput == 3)
            {
                txtResult.Text = "game draw";
                computerR.Visible = false;
                computerS.Visible = true;
                computerP.Visible = false;
            }


        }

        private void ComputerR_Click(object sender, EventArgs e)
        {

        }
    }
}
