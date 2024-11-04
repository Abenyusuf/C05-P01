//Ahmed Benyusuf
//Class and Section (CS 313 01)
//Assignment (Program 01 Chapter 05)
//Description of the Program : this program will calculate and display the cost of tuition as it rises by 2% for 5 years.





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05_P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double Loops = 0; // loop counter
            double Cost = 6000; // initial cost of tuition
            OutputListBox.Items.Add("Cost for Year " + Loops + ":" + Cost.ToString("c"));
            // Outputs the cost for the first year
            Loops += 1; // increments the loop counter one time to start the for loop
            for (Loops = 1; Loops < 6; Loops++) // for loop to continue for 5 years
            {
                Cost = Cost + (Cost * 0.02);// Calculates cost increases by 2% each year
                OutputListBox.Items.Add("Cost for Year "+ Loops +":" + Cost.ToString("c"));
                // Outputs the cost for each year
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            // Closes the program
        }
    }
}

