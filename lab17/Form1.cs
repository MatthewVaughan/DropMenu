using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Lab 17
// Date: 03/02/2015 09:15:19 am
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace lab17
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display message box showing programmers name and class
            MessageBox.Show($"Matthew Vaughan\nCS 1400 Sec 003");
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close program when clicked
            this.Close();

        }

        /// <summary>
        /// Combo Box / Display Box Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Declare string variables
            string standard = "Standard";
            string express = "Express";
            string sameDay = "Same Day";

            //Write if statements that decide what program should display in text box
            if(comboShip.Text == standard )
            {
                txtDisplayShipping.Text = standard;
            }
            else if(comboShip.Text == express)
            {
                txtDisplayShipping.Text = express;
            }
            else if (comboShip.Text == sameDay)
            {
                txtDisplayShipping.Text = sameDay;
            }
            else
            {
                txtDisplayShipping.Text = "No Valid Entry";
            }
        }
    }
}
